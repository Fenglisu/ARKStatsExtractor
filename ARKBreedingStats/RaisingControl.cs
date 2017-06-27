﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARKBreedingStats
{
    public partial class RaisingControl : UserControl
    {
        public delegate void ExtractBabyEventHandler(Creature mother, Creature father);
        public event ExtractBabyEventHandler extractBaby;
        public event Form1.collectionChangedEventHandler onChange;
        public event Form1.setSpeciesIndexEventHandler setSpeciesIndex;
        private int speciesIndex;
        public bool updateListView;
        private TimeSpan babyTime, maturationTime;
        private CreatureCollection cc;
        public TimerControl timerControl;

        public RaisingControl()
        {
            InitializeComponent();
            listViewBabies.Groups.Add("孵化", "孵化/妊娠");
            listViewBabies.Groups.Add("婴儿", "婴儿");
            listViewBabies.Groups.Add("growing", "Juveniles / Adolescent");
            updateListView = false;
            ControlExtensions.DoubleBuffered(listViewBabies, true); // prevent flickering
        }

        public void updateRaisingData()
        {
            updateRaisingData(speciesIndex);
        }

        public void updateRaisingData(int speciesIndex)
        {
            if (this.speciesIndex != speciesIndex)
            {
                this.speciesIndex = speciesIndex;
                if (speciesIndex >= 0 && Values.V.species[speciesIndex].taming != null)
                {
                    this.SuspendLayout();
                    BreedingData bd = Values.V.species[speciesIndex].breeding;
                    string incubationMode;
                    TimeSpan incubationTime, nextMatingMin, nextMatingMax;

                    listViewRaisingTimes.Items.Clear();

                    if (Raising.getRaisingTimes(speciesIndex, out incubationMode, out incubationTime, out babyTime, out maturationTime, out nextMatingMin, out nextMatingMax))
                    {
                        string eggInfo = Raising.eggTemperature(speciesIndex);
                        if (eggInfo.Length > 0)
                            eggInfo = "\n\n" + eggInfo;

                        TimeSpan totalTime = incubationTime;
                        DateTime until = DateTime.Now.Add(totalTime);
                        string[] times = new string[] { incubationMode, incubationTime.ToString("d':'hh':'mm':'ss"), totalTime.ToString("d':'hh':'mm':'ss"), Utils.shortTimeDate(until) };
                        listViewRaisingTimes.Items.Add(new ListViewItem(times));

                        totalTime += babyTime;
                        until = DateTime.Now.Add(totalTime);
                        times = new string[] { "婴儿期", babyTime.ToString("d':'hh':'mm':'ss"), totalTime.ToString("d':'hh':'mm':'ss"), Utils.shortTimeDate(until) };
                        listViewRaisingTimes.Items.Add(new ListViewItem(times));

                        totalTime = incubationTime + maturationTime;
                        until = DateTime.Now.Add(totalTime);
                        times = new string[] { "成熟期", maturationTime.ToString("d':'hh':'mm':'ss"), totalTime.ToString("d':'hh':'mm':'ss"), Utils.shortTimeDate(until) };
                        listViewRaisingTimes.Items.Add(new ListViewItem(times));

                        // food amount needed
                        string foodadmount = "";
                        double babyfood, totalfood;
                        if (uiControls.Trough.foodAmount(speciesIndex, Values.V.babyFoodConsumptionSpeedMultiplier, out babyfood, out totalfood))
                        {
                            if (Values.V.species[speciesIndex].taming.eats.IndexOf("生肉") >= 0)
                            {
                                foodadmount = "\n\n婴儿期食物: ~" + Math.Ceiling(babyfood / 50) + " 生肉"
                                    + "\n成熟总食物: ~" + Math.Ceiling(totalfood / 50) + " 生肉";
                            }
                            else if (Values.V.species[speciesIndex].taming.eats.IndexOf("Mejoberry") >= 0)
                            {
                                foodadmount = "\n\n婴儿期食物: ~" + Math.Ceiling(babyfood / 30) + " Mejoberries"
                                    + "\n成熟总食物: ~" + Math.Ceiling(totalfood / 30) + " Mejoberries";
                            }
                            foodadmount += "\n - Loss by spoiling is only a rough estimate and may vary.";
                        }

                        labelRaisingInfos.Text = "Time between mating: " + nextMatingMin.ToString("d':'hh':'mm':'ss") + " to " + nextMatingMax.ToString("d':'hh':'mm':'ss")
                            + eggInfo
                            + foodadmount;

                        groupBox1.Enabled = true;
                    }
                    else
                    {
                        labelRaisingInfos.Text = "没有提供数据.";
                        groupBox1.Enabled = false;
                    }

                    ResumeLayout();
                }
            }
        }

        public CreatureCollection creatureCollection
        {
            set
            {
                if (value != null)
                    cc = value;
            }
        }

        private void nudCurrentWeight_ValueChanged(object sender, EventArgs e)
        {
            updateMaturationProgress();
        }

        private void nudTotalWeight_ValueChanged(object sender, EventArgs e)
        {
            updateMaturationProgress();
        }

        private void updateMaturationProgress()
        {
            double babyTimeReciproke = maturationTime.TotalSeconds / babyTime.TotalSeconds;
            double maturation = Math.Round((double)(nudCurrentWeight.Value / nudTotalWeight.Value), 3);
            labelMaturationProgress.Text = Math.Round(100 * maturation, 1).ToString() + " %";
            if (maturationTime.TotalSeconds * maturation < babyTime.TotalSeconds)
            {
                labelTimeLeftBaby.Text = Utils.durationUntil(babyTime.Subtract(new TimeSpan(0, 0, (int)(babyTime.TotalSeconds * babyTimeReciproke * maturation))));
                labelTimeLeftBaby.ForeColor = SystemColors.ControlText;
            }
            else
            {
                labelTimeLeftBaby.Text = "not a baby anymore";
                labelTimeLeftBaby.ForeColor = SystemColors.GrayText;
            }
            if (maturation < 1)
            {
                labelTimeLeftGrowing.Text = Utils.durationUntil(maturationTime.Subtract(new TimeSpan(0, 0, (int)(maturationTime.TotalSeconds * maturation))));
                labelTimeLeftGrowing.ForeColor = SystemColors.ControlText;
            }
            else
            {
                labelTimeLeftGrowing.Text = "mature";
                labelTimeLeftGrowing.ForeColor = SystemColors.GrayText;
            }

            double foodAmount = 0;
            string foodAmountBabyString = "", foodAmountAdultString = "";
            if (Values.V.species[speciesIndex].taming.eats.IndexOf("Raw Meat") >= 0)
            {
                if (uiControls.Trough.foodAmountFromUntil(speciesIndex, Values.V.babyFoodConsumptionSpeedMultiplier, maturation, 0.1, out foodAmount))
                    foodAmountBabyString = Math.Ceiling(foodAmount / 50) + " 生肉";
                if (uiControls.Trough.foodAmountFromUntil(speciesIndex, Values.V.babyFoodConsumptionSpeedMultiplier, maturation, 1, out foodAmount))
                    foodAmountAdultString = Math.Ceiling(foodAmount / 50) + " 生肉";
            }
            else if (Values.V.species[speciesIndex].taming.eats.IndexOf("Mejoberry") >= 0)
            {
                if (uiControls.Trough.foodAmountFromUntil(speciesIndex, Values.V.babyFoodConsumptionSpeedMultiplier, maturation, 0.1, out foodAmount))
                    foodAmountBabyString = Math.Ceiling(foodAmount / 30) + " Mejoberries";
                if (uiControls.Trough.foodAmountFromUntil(speciesIndex, Values.V.babyFoodConsumptionSpeedMultiplier, maturation, 1, out foodAmount))
                    foodAmountAdultString = Math.Ceiling(foodAmount / 30) + " Mejoberries";
            }
            labelAmountFoodBaby.Text = foodAmountBabyString;
            labelAmountFoodAdult.Text = foodAmountAdultString;
        }

        public void addIncubationTimer(Creature mother, Creature father, TimeSpan incubationDuration, bool incubationStarted)
        {
            cc.incubationListEntries.Add(new IncubationTimerEntry(mother, father, incubationDuration, incubationStarted));
            onChange?.Invoke();
            recreateList();
        }

        private void removeIncubationTimer(IncubationTimerEntry ite)
        {
            cc.incubationListEntries.Remove(ite);
        }

        public void recreateList()
        {
            if (cc != null)
            {
                updateListView = false;
                listViewBabies.BeginUpdate();
                listViewBabies.Items.Clear();

                ListViewGroup g = listViewBabies.Groups[0];
                // add eggs / pregnancies
                foreach (IncubationTimerEntry t in cc.incubationListEntries)
                {
                    int i = Values.V.speciesNames.IndexOf(t.mother.species);
                    if (i >= 0 && Values.V.species[i].breeding != null)
                    {
                        string kind;
                        if (Values.V.species[i].breeding.gestationTimeAdjusted > 0)
                            kind = "Gestation";
                        else kind = "Egg";
                        string[] cols = new string[] { kind,
                                t.mother.species,
                                Utils.timeLeft(t.incubationEnd),
                                Utils.duration((int)(Values.V.species[i].breeding.maturationTimeAdjusted / 10)),
                                Utils.duration((int)Values.V.species[i].breeding.maturationTimeAdjusted) };
                        ListViewItem lvi = new ListViewItem(cols, g);
                        lvi.Tag = t;
                        listViewBabies.Items.Add(lvi);
                    }
                }

                // add babies / growing
                DateTime now = DateTime.Now;
                foreach (Creature c in cc.creatures)
                {
                    if (c.growingUntil > now)
                    {
                        int i = Values.V.speciesNames.IndexOf(c.species);
                        if (i >= 0 && Values.V.species[i].breeding != null)
                        {
                            DateTime babyUntil = c.growingUntil.AddSeconds(-0.9 * Values.V.species[i].breeding.maturationTimeAdjusted);
                            string[] cols;
                            if (babyUntil > now)
                            {
                                g = listViewBabies.Groups[1];
                                cols = new string[] { c.name,
                                        c.species,
                                        "-",
                                        Utils.timeLeft(babyUntil),
                                        Utils.timeLeft(c.growingUntil) };
                            }
                            else
                            {
                                g = listViewBabies.Groups[2];
                                cols = new string[] { c.name,
                                        c.species,
                                        "-",
                                        "-",
                                        Utils.timeLeft(c.growingUntil) };
                            }
                            ListViewItem lvi = new ListViewItem(cols, g);
                            lvi.Tag = c;
                            listViewBabies.Items.Add(lvi);
                        }
                    }
                }
                listViewBabies.EndUpdate();
                updateListView = true;
            }
        }

        public void Tick()
        {
            DateTime now = DateTime.Now;
            DateTime alertTime = now.AddMinutes(1);
            if (updateListView)
            {
                listViewBabies.BeginUpdate();
                foreach (ListViewItem lvi in listViewBabies.Items)
                {
                    if ((lvi.Tag.GetType() == typeof(IncubationTimerEntry)))
                    {
                        var t = (IncubationTimerEntry)lvi.Tag;
                        int i = Values.V.speciesNames.IndexOf(t.mother.species);
                        if (i >= 0)
                        {
                            lvi.SubItems[2].Text = Utils.timeLeft(t.incubationEnd);
                            lvi.SubItems[3].Text = Utils.duration((int)(Values.V.species[i].breeding.maturationTimeAdjusted / 10));
                            lvi.SubItems[4].Text = Utils.duration((int)Values.V.species[i].breeding.maturationTimeAdjusted);
                            double diff = t.incubationEnd.Subtract(alertTime).TotalSeconds;
                            if (diff >= 0 && diff < 1)
                                timerControl.playSound("Birth", 1);
                        }
                    }
                    else if ((lvi.Tag.GetType() == typeof(Creature)))
                    {
                        var c = (Creature)lvi.Tag;
                        int i = Values.V.speciesNames.IndexOf(c.species);
                        if (i >= 0 && Values.V.species[i].breeding != null)
                        {
                            DateTime babyUntil = c.growingUntil.AddSeconds(-0.9 * Values.V.species[i].breeding.maturationTimeAdjusted);
                            lvi.SubItems[3].Text = Utils.timeLeft(babyUntil);
                            lvi.SubItems[4].Text = Utils.timeLeft(c.growingUntil);
                        }
                    }
                }
                listViewBabies.EndUpdate();
            }
            else
            {
                foreach (ListViewItem lvi in listViewBabies.Items)
                {
                    if ((lvi.Tag.GetType() == typeof(IncubationTimerEntry)))
                    {
                        var t = (IncubationTimerEntry)lvi.Tag;
                        int i = Values.V.speciesNames.IndexOf(t.mother.species);
                        double diff = t.incubationEnd.Subtract(alertTime).TotalSeconds;
                        if (diff >= 0 && diff < 1)
                            timerControl.playSound("Birth", 1);
                    }
                }
            }
        }

        private void extractValuesOfHatchedbornBabyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewBabies.SelectedIndices.Count > 0 && listViewBabies.SelectedItems[0].Tag.GetType() == typeof(IncubationTimerEntry))
            {
                var ite = (IncubationTimerEntry)listViewBabies.SelectedItems[0].Tag;
                extractBaby?.Invoke(ite.mother, ite.father);
            }
        }

        private void deleteTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewBabies.SelectedIndices.Count > 0
                && listViewBabies.SelectedItems[0].Tag.GetType() == typeof(IncubationTimerEntry))
            {
                IncubationTimerEntry ite = (IncubationTimerEntry)listViewBabies.SelectedItems[0].Tag;
                if (MessageBox.Show("Delete this timer?\n" + ite.mother.species + ", ending in " + Utils.timeLeft(ite.incubationEnd), "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    removeIncubationTimer(ite);
                    recreateList();
                    onChange?.Invoke();
                }
            }
        }

        public void deleteAllExpiredIncubationTimers()
        {
            if (MessageBox.Show("Delete all expired incubation timers?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (ListViewItem lvi in listViewBabies.Items)
                {
                    if ((lvi.Tag.GetType() == typeof(IncubationTimerEntry)))
                    {
                        IncubationTimerEntry ite = (IncubationTimerEntry)lvi.Tag;
                        if (ite.incubationStarted && ite.incubationEnd < DateTime.Now)
                            removeIncubationTimer(ite);
                    }
                }
                recreateList();
                onChange?.Invoke();
            }
        }

        private void listViewBabies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBabies.SelectedIndices.Count > 0)
            {
                if (listViewBabies.SelectedItems[0].Tag.GetType() == typeof(Creature))
                {
                    Creature c = (Creature)listViewBabies.SelectedItems[0].Tag;
                    int sI = Values.V.speciesNames.IndexOf(c.species);
                    setSpeciesIndex?.Invoke(sI);
                    if (sI >= 0 && Values.V.species[sI].breeding != null && c.growingUntil > DateTime.Now)
                    {
                        double maturing = Math.Round(1 - c.growingUntil.Subtract(DateTime.Now).TotalSeconds / Values.V.species[sI].breeding.maturationTimeAdjusted, 2);
                        if (maturing > 0 && maturing <= 1)
                        {
                            nudCurrentWeight.Value = (decimal)(maturing * c.valuesBreeding[4]);
                            nudTotalWeight.Value = (decimal)c.valuesBreeding[4];
                        }
                    }
                }
                else if (listViewBabies.SelectedItems[0].Tag.GetType() == typeof(IncubationTimerEntry))
                {
                    IncubationTimerEntry ite = (IncubationTimerEntry)listViewBabies.SelectedItems[0].Tag;
                    int sI = Values.V.speciesNames.IndexOf(ite.mother.species);
                    setSpeciesIndex?.Invoke(sI);
                }
            }
        }
    }
}

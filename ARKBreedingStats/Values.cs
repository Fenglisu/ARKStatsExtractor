using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace ARKBreedingStats
{
    [DataContract]
    public class Values
    {
        private static Values _V;
        [DataMember]
        private string ver = "0.0";
        public Version version = new Version(0, 0);
        public Version modVersion = new Version(0, 0);
        [DataMember]
        public List<Species> species = new List<Species>();
        public List<string> speciesNames = new List<string>();
        [DataMember]
        public double[][] statMultipliers = new double[8][]; // official server stats-multipliers
        [DataMember]
        public Dictionary<string, TamingFood> foodData = new Dictionary<string, TamingFood>();

        public double imprintingStatScaleMultiplier = 1;
        public double babyFoodConsumptionSpeedMultiplier = 1;
        public bool celsius;

        public Values()
        {
            celsius = true;
        }

        public static Values V
        {
            get
            {
                if (_V == null)
                    _V = new Values();
                return _V;
            }
        }

        public bool loadValues()
        {
            bool loadedSuccessful = true;

            string filename = "json/values.json";

            // check if file exists
            if (!File.Exists(filename))
            {
                if (MessageBox.Show("找不到 Values-文件 '" + filename + "'. 如果没有该文件, 本工具将无法正常使用.\n\n你可以访问工具官方主页重新下载?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    System.Diagnostics.Process.Start("https://github.com/cadon/ARKStatsExtractor/releases/latest");
                return false;
            }

            _V.version = new Version(0, 0);

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Values));
            System.IO.FileStream file = System.IO.File.OpenRead(filename);

            try
            {
                _V = (Values)ser.ReadObject(file);
            }
            catch (Exception e)
            {
                MessageBox.Show("无法打开或读取文件.\n错误信息:\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadedSuccessful = false;
            }
            file.Close();

            if (loadedSuccessful)
            {
                try
                {
                    _V.version = new Version(_V.ver);
                }
                catch
                {
                    _V.version = new Version(0, 0);
                }
                _V.speciesNames = new List<string>();
                foreach (Species sp in _V.species)
                {
                    sp.initialize();
                    _V.speciesNames.Add(sp.name);
                }
            }

            //saveJSON();
            return loadedSuccessful;
        }

        public bool loadAdditionalValues(string filename, bool showResults)
        {
            // load extra values-file that can add values or modify existing ones
            bool loadedSuccessful = true;

            // check if file exists
            if (!File.Exists(filename))
            {
                MessageBox.Show("找不到附加 Values-文件 '" + filename + "' .\n此集合的值似乎已修改或添加保存在单独文件中, 该文件在存放的位置没有找到. 您可以通过菜单 “文件” - “Load additional values...” 手动加载该文件", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Values));
            System.IO.FileStream file = System.IO.File.OpenRead(filename);

            Values modifiedValues = new Values();

            try
            {
                modifiedValues = (Values)ser.ReadObject(file);
            }
            catch (Exception e)
            {
                MessageBox.Show("无法打开或读取文件.\n错误信息:\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadedSuccessful = false;
            }
            file.Close();
            if (!loadedSuccessful) return false;

            int speciesUpdated = 0;
            int speciesAdded = 0;
            // update data if existing
            // version
            try
            {
                _V.modVersion = new Version(modifiedValues.ver);
            }
            catch
            {
                _V.modVersion = new Version(0, 0);
            }

            // species
            if (modifiedValues.species != null)
            {
                foreach (Species sp in modifiedValues.species)
                {
                    if (!_V.speciesNames.Contains(sp.name))
                    {
                        _V.species.Add(sp);
                        sp.initialize();
                        _V.speciesNames.Add(sp.name);
                        speciesAdded++;
                    }
                    else
                    {
                        int i = _V.speciesNames.IndexOf(sp.name);
                        bool updated = false;
                        if (sp.TamedBaseHealthMultiplier != null)
                        {
                            _V.species[i].TamedBaseHealthMultiplier = sp.TamedBaseHealthMultiplier;
                            updated = true;
                        }
                        if (sp.NoImprintingForSpeed != null)
                        {
                            _V.species[i].NoImprintingForSpeed = sp.NoImprintingForSpeed;
                            updated = true;
                        }
                        if (sp.statsRaw != null && sp.statsRaw.Length > 0)
                        {
                            for (int s = 0; s < 8 && s < sp.statsRaw.Length; s++)
                            {
                                if (sp.statsRaw[s] != null)
                                {
                                    for (int si = 0; si < 5 && si < sp.statsRaw[s].Length; si++)
                                    {
                                        if (sp.statsRaw[s][si] != null)
                                        {
                                            _V.species[i].statsRaw[s][si] = sp.statsRaw[s][si];
                                            updated = true;
                                        }
                                    }
                                }
                            }
                            if (updated) speciesUpdated++;
                        }
                    }
                }
            }
            // fooddata TODO
            // default-multiplier TODO

            if (showResults)
                MessageBox.Show("物种变化的统计: " + speciesUpdated + "\n添加物种: " + speciesAdded, "成功添加的附加值", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }

        // currently not used
        //public void saveJSON()
        //{
        //    // to create minified json of current values
        //    DataContractJsonSerializer writer = new DataContractJsonSerializer(typeof(Values));
        //    try
        //    {
        //        System.IO.FileStream file = System.IO.File.Create("values.json");
        //        writer.WriteObject(file, _V);
        //        file.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Error during serialization.\nErrormessage:\n\n" + e.Message, "Serialization-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        public void applyMultipliers(CreatureCollection cc, bool eventMultipliers = false, bool applyStatMultipliers = true)
        {
            imprintingStatScaleMultiplier = cc.imprintingMultiplier;
            babyFoodConsumptionSpeedMultiplier = eventMultipliers ? cc.BabyFoodConsumptionSpeedMultiplierEvent : cc.BabyFoodConsumptionSpeedMultiplier;

            double eggHatchSpeedMultiplier = eventMultipliers ? cc.EggHatchSpeedMultiplierEvent : cc.EggHatchSpeedMultiplier;
            double babyMatureSpeedMultiplier = eventMultipliers ? cc.BabyMatureSpeedMultiplierEvent : cc.BabyMatureSpeedMultiplier;
            double matingIntervalMultiplier = eventMultipliers ? cc.MatingIntervalMultiplierEvent : cc.MatingIntervalMultiplier;

            for (int sp = 0; sp < species.Count; sp++)
            {
                if (applyStatMultipliers)
                {
                    // stat-multiplier
                    for (int s = 0; s < 8; s++)
                    {
                        species[sp].stats[s].BaseValue = (double)species[sp].statsRaw[s][0];
                        // don't apply the multiplier if AddWhenTamed is negative (currently the only case is the Giganotosaurus, which does not get the subtraction multiplied)
                        species[sp].stats[s].AddWhenTamed = (double)species[sp].statsRaw[s][3] * (species[sp].statsRaw[s][3] > 0 ? cc.multipliers[s][0] : 1);
                        species[sp].stats[s].MultAffinity = (double)species[sp].statsRaw[s][4] * cc.multipliers[s][1];
                        species[sp].stats[s].IncPerTamedLevel = (double)species[sp].statsRaw[s][2] * cc.multipliers[s][2];
                        species[sp].stats[s].IncPerWildLevel = (double)species[sp].statsRaw[s][1] * cc.multipliers[s][3];
                    }
                }
                // breeding multiplier
                if (species[sp].breeding != null)
                {
                    if (eggHatchSpeedMultiplier > 0)
                    {
                        species[sp].breeding.gestationTimeAdjusted = species[sp].breeding.gestationTime / eggHatchSpeedMultiplier;
                        species[sp].breeding.incubationTimeAdjusted = species[sp].breeding.incubationTime / eggHatchSpeedMultiplier;
                    }
                    if (babyMatureSpeedMultiplier > 0)
                        species[sp].breeding.maturationTimeAdjusted = species[sp].breeding.maturationTime / babyMatureSpeedMultiplier;

                    species[sp].breeding.matingCooldownMinAdjusted = species[sp].breeding.matingCooldownMin * matingIntervalMultiplier;
                    species[sp].breeding.matingCooldownMaxAdjusted = species[sp].breeding.matingCooldownMax * matingIntervalMultiplier;
                }
            }
        }

        public double[][] getOfficialMultipliers()
        {
            double[][] officialMultipliers = new double[8][];
            for (int s = 0; s < 8; s++)
            {
                officialMultipliers[s] = new double[4];
                for (int sm = 0; sm < 4; sm++)
                    officialMultipliers[s][sm] = statMultipliers[s][sm];
            }
            return officialMultipliers;
        }
    }
}

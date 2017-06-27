﻿namespace ARKBreedingStats
{
    partial class RaisingControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelRaisingInfos = new System.Windows.Forms.Label();
            this.listViewRaisingTimes = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTotalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUntil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nudCurrentWeight = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAmountFoodAdult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelAmountFoodBaby = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTimeLeftGrowing = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTimeLeftBaby = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMaturationProgress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudTotalWeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewBabies = new System.Windows.Forms.ListView();
            this.columnHeaderBabyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSpecies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIncubation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBabyTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGrowingTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripBabyList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.extractValuesOfHatchedbornBabyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentWeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalWeight)).BeginInit();
            this.contextMenuStripBabyList.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRaisingInfos
            // 
            this.labelRaisingInfos.AutoSize = true;
            this.labelRaisingInfos.Location = new System.Drawing.Point(6, 15);
            this.labelRaisingInfos.Name = "labelRaisingInfos";
            this.labelRaisingInfos.Size = new System.Drawing.Size(35, 12);
            this.labelRaisingInfos.TabIndex = 2;
            this.labelRaisingInfos.Text = "Infos";
            // 
            // listViewRaisingTimes
            // 
            this.listViewRaisingTimes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderDuration,
            this.columnHeaderTotalTime,
            this.columnHeaderUntil});
            this.listViewRaisingTimes.Location = new System.Drawing.Point(6, 113);
            this.listViewRaisingTimes.Name = "listViewRaisingTimes";
            this.listViewRaisingTimes.Size = new System.Drawing.Size(317, 85);
            this.listViewRaisingTimes.TabIndex = 3;
            this.listViewRaisingTimes.UseCompatibleStateImageBehavior = false;
            this.listViewRaisingTimes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "";
            this.columnHeaderName.Width = 65;
            // 
            // columnHeaderDuration
            // 
            this.columnHeaderDuration.Text = "持续时间";
            this.columnHeaderDuration.Width = 72;
            // 
            // columnHeaderTotalTime
            // 
            this.columnHeaderTotalTime.Text = "总时间";
            this.columnHeaderTotalTime.Width = 72;
            // 
            // columnHeaderUntil
            // 
            this.columnHeaderUntil.Text = "至";
            this.columnHeaderUntil.Width = 107;
            // 
            // nudCurrentWeight
            // 
            this.nudCurrentWeight.DecimalPlaces = 2;
            this.nudCurrentWeight.Location = new System.Drawing.Point(90, 18);
            this.nudCurrentWeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCurrentWeight.Name = "nudCurrentWeight";
            this.nudCurrentWeight.Size = new System.Drawing.Size(73, 21);
            this.nudCurrentWeight.TabIndex = 4;
            this.nudCurrentWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudCurrentWeight.ValueChanged += new System.EventHandler(this.nudCurrentWeight_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAmountFoodAdult);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelAmountFoodBaby);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelTimeLeftGrowing);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelTimeLeftBaby);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelMaturationProgress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudTotalWeight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudCurrentWeight);
            this.groupBox1.Location = new System.Drawing.Point(6, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 141);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Progress";
            // 
            // labelAmountFoodAdult
            // 
            this.labelAmountFoodAdult.AutoSize = true;
            this.labelAmountFoodAdult.Location = new System.Drawing.Point(133, 116);
            this.labelAmountFoodAdult.Name = "labelAmountFoodAdult";
            this.labelAmountFoodAdult.Size = new System.Drawing.Size(11, 12);
            this.labelAmountFoodAdult.TabIndex = 14;
            this.labelAmountFoodAdult.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "Food for adult needed:";
            // 
            // labelAmountFoodBaby
            // 
            this.labelAmountFoodBaby.AutoSize = true;
            this.labelAmountFoodBaby.Location = new System.Drawing.Point(133, 100);
            this.labelAmountFoodBaby.Name = "labelAmountFoodBaby";
            this.labelAmountFoodBaby.Size = new System.Drawing.Size(11, 12);
            this.labelAmountFoodBaby.TabIndex = 6;
            this.labelAmountFoodBaby.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Food for baby needed:";
            // 
            // labelTimeLeftGrowing
            // 
            this.labelTimeLeftGrowing.AutoSize = true;
            this.labelTimeLeftGrowing.Location = new System.Drawing.Point(133, 83);
            this.labelTimeLeftGrowing.Name = "labelTimeLeftGrowing";
            this.labelTimeLeftGrowing.Size = new System.Drawing.Size(11, 12);
            this.labelTimeLeftGrowing.TabIndex = 12;
            this.labelTimeLeftGrowing.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Time left until grown:";
            // 
            // labelTimeLeftBaby
            // 
            this.labelTimeLeftBaby.AutoSize = true;
            this.labelTimeLeftBaby.Location = new System.Drawing.Point(133, 66);
            this.labelTimeLeftBaby.Name = "labelTimeLeftBaby";
            this.labelTimeLeftBaby.Size = new System.Drawing.Size(11, 12);
            this.labelTimeLeftBaby.TabIndex = 10;
            this.labelTimeLeftBaby.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time left as Baby:";
            // 
            // labelMaturationProgress
            // 
            this.labelMaturationProgress.AutoSize = true;
            this.labelMaturationProgress.Location = new System.Drawing.Point(133, 50);
            this.labelMaturationProgress.Name = "labelMaturationProgress";
            this.labelMaturationProgress.Size = new System.Drawing.Size(17, 12);
            this.labelMaturationProgress.TabIndex = 8;
            this.labelMaturationProgress.Text = "0%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Maturation-progress:";
            // 
            // nudTotalWeight
            // 
            this.nudTotalWeight.DecimalPlaces = 1;
            this.nudTotalWeight.Location = new System.Drawing.Point(187, 18);
            this.nudTotalWeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudTotalWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTotalWeight.Name = "nudTotalWeight";
            this.nudTotalWeight.Size = new System.Drawing.Size(73, 21);
            this.nudTotalWeight.TabIndex = 6;
            this.nudTotalWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTotalWeight.ValueChanged += new System.EventHandler(this.nudTotalWeight_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前负重";
            // 
            // listViewBabies
            // 
            this.listViewBabies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBabyName,
            this.columnHeaderSpecies,
            this.columnHeaderIncubation,
            this.columnHeaderBabyTime,
            this.columnHeaderGrowingTime});
            this.listViewBabies.ContextMenuStrip = this.contextMenuStripBabyList;
            this.listViewBabies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewBabies.FullRowSelect = true;
            this.listViewBabies.GridLines = true;
            this.listViewBabies.Location = new System.Drawing.Point(347, 3);
            this.listViewBabies.Name = "listViewBabies";
            this.listViewBabies.Size = new System.Drawing.Size(568, 389);
            this.listViewBabies.TabIndex = 6;
            this.listViewBabies.UseCompatibleStateImageBehavior = false;
            this.listViewBabies.View = System.Windows.Forms.View.Details;
            this.listViewBabies.SelectedIndexChanged += new System.EventHandler(this.listViewBabies_SelectedIndexChanged);
            // 
            // columnHeaderBabyName
            // 
            this.columnHeaderBabyName.Text = "名称";
            this.columnHeaderBabyName.Width = 74;
            // 
            // columnHeaderSpecies
            // 
            this.columnHeaderSpecies.Text = "种类";
            this.columnHeaderSpecies.Width = 89;
            // 
            // columnHeaderIncubation
            // 
            this.columnHeaderIncubation.Text = "孵化/妊娠";
            this.columnHeaderIncubation.Width = 109;
            // 
            // columnHeaderBabyTime
            // 
            this.columnHeaderBabyTime.Text = "婴儿期时间 left";
            this.columnHeaderBabyTime.Width = 99;
            // 
            // columnHeaderGrowingTime
            // 
            this.columnHeaderGrowingTime.Text = "Growing Time left";
            this.columnHeaderGrowingTime.Width = 108;
            // 
            // contextMenuStripBabyList
            // 
            this.contextMenuStripBabyList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractValuesOfHatchedbornBabyToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteTimerToolStripMenuItem});
            this.contextMenuStripBabyList.Name = "contextMenuStripBabyList";
            this.contextMenuStripBabyList.Size = new System.Drawing.Size(288, 54);
            // 
            // extractValuesOfHatchedbornBabyToolStripMenuItem
            // 
            this.extractValuesOfHatchedbornBabyToolStripMenuItem.Name = "extractValuesOfHatchedbornBabyToolStripMenuItem";
            this.extractValuesOfHatchedbornBabyToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.extractValuesOfHatchedbornBabyToolStripMenuItem.Text = "Extract values of hatched/born baby";
            this.extractValuesOfHatchedbornBabyToolStripMenuItem.Click += new System.EventHandler(this.extractValuesOfHatchedbornBabyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(284, 6);
            // 
            // deleteTimerToolStripMenuItem
            // 
            this.deleteTimerToolStripMenuItem.Name = "deleteTimerToolStripMenuItem";
            this.deleteTimerToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.deleteTimerToolStripMenuItem.Text = "Delete Timer...";
            this.deleteTimerToolStripMenuItem.Click += new System.EventHandler(this.deleteTimerToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 344F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listViewBabies, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(918, 395);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 389);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelRaisingInfos);
            this.groupBox2.Controls.Add(this.listViewRaisingTimes);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 203);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "常规信息";
            // 
            // RaisingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RaisingControl";
            this.Size = new System.Drawing.Size(918, 395);
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentWeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalWeight)).EndInit();
            this.contextMenuStripBabyList.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelRaisingInfos;
        private System.Windows.Forms.ListView listViewRaisingTimes;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderDuration;
        private System.Windows.Forms.ColumnHeader columnHeaderTotalTime;
        private System.Windows.Forms.ColumnHeader columnHeaderUntil;
        private System.Windows.Forms.NumericUpDown nudCurrentWeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMaturationProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudTotalWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTimeLeftGrowing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTimeLeftBaby;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAmountFoodBaby;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewBabies;
        private System.Windows.Forms.ColumnHeader columnHeaderBabyName;
        private System.Windows.Forms.ColumnHeader columnHeaderSpecies;
        private System.Windows.Forms.ColumnHeader columnHeaderBabyTime;
        private System.Windows.Forms.ColumnHeader columnHeaderGrowingTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnHeaderIncubation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripBabyList;
        private System.Windows.Forms.ToolStripMenuItem extractValuesOfHatchedbornBabyToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelAmountFoodAdult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteTimerToolStripMenuItem;
    }
}

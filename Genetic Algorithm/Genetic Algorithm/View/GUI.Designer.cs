namespace Genetic_Algorithm
{
    partial class GUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.btGo = new System.Windows.Forms.Button();
            this.numRangeMin = new System.Windows.Forms.NumericUpDown();
            this.numRangeMax = new System.Windows.Forms.NumericUpDown();
            this.numGranularity = new System.Windows.Forms.NumericUpDown();
            this.btStart = new System.Windows.Forms.Button();
            this.numPopSize = new System.Windows.Forms.NumericUpDown();
            this.numNOG = new System.Windows.Forms.NumericUpDown();
            this.numPC = new System.Windows.Forms.NumericUpDown();
            this.numPM = new System.Windows.Forms.NumericUpDown();
            this.rbRoulette = new System.Windows.Forms.RadioButton();
            this.rbTournament = new System.Windows.Forms.RadioButton();
            this.gbSelection = new System.Windows.Forms.GroupBox();
            this.gbElitism = new System.Windows.Forms.GroupBox();
            this.rbElitNo = new System.Windows.Forms.RadioButton();
            this.rbElitYes = new System.Windows.Forms.RadioButton();
            this.gbCrossoverType = new System.Windows.Forms.GroupBox();
            this.rbCO2P = new System.Windows.Forms.RadioButton();
            this.rbCOUn = new System.Windows.Forms.RadioButton();
            this.rbCO1P = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.zgcFunction = new ZedGraph.ZedGraphControl();
            this.zgcPerformance = new ZedGraph.ZedGraphControl();
            this.gaTimer = new System.Windows.Forms.Timer(this.components);
            this.graphTimer = new System.Windows.Forms.Timer(this.components);
            this.gbOptimization = new System.Windows.Forms.GroupBox();
            this.rbOpMax = new System.Windows.Forms.RadioButton();
            this.rbOpMin = new System.Windows.Forms.RadioButton();
            this.gbFunctions = new System.Windows.Forms.GroupBox();
            this.rbF2 = new System.Windows.Forms.RadioButton();
            this.rbF1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numRangeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGranularity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNOG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPM)).BeginInit();
            this.gbSelection.SuspendLayout();
            this.gbElitism.SuspendLayout();
            this.gbCrossoverType.SuspendLayout();
            this.gbParameters.SuspendLayout();
            this.gbOptimization.SuspendLayout();
            this.gbFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbInfo
            // 
            this.rtbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfo.Location = new System.Drawing.Point(880, 427);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(204, 196);
            this.rtbInfo.TabIndex = 0;
            this.rtbInfo.Text = "";
            // 
            // btGo
            // 
            this.btGo.Location = new System.Drawing.Point(1038, 392);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(46, 23);
            this.btGo.TabIndex = 1;
            this.btGo.Text = "Go";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // numRangeMin
            // 
            this.numRangeMin.Location = new System.Drawing.Point(129, 127);
            this.numRangeMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRangeMin.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numRangeMin.Name = "numRangeMin";
            this.numRangeMin.Size = new System.Drawing.Size(47, 20);
            this.numRangeMin.TabIndex = 2;
            // 
            // numRangeMax
            // 
            this.numRangeMax.Location = new System.Drawing.Point(129, 153);
            this.numRangeMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRangeMax.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numRangeMax.Name = "numRangeMax";
            this.numRangeMax.Size = new System.Drawing.Size(47, 20);
            this.numRangeMax.TabIndex = 3;
            this.numRangeMax.Value = new decimal(new int[] {
            511,
            0,
            0,
            0});
            // 
            // numGranularity
            // 
            this.numGranularity.Location = new System.Drawing.Point(129, 179);
            this.numGranularity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numGranularity.Name = "numGranularity";
            this.numGranularity.Size = new System.Drawing.Size(47, 20);
            this.numGranularity.TabIndex = 4;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(985, 392);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(46, 23);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // numPopSize
            // 
            this.numPopSize.Location = new System.Drawing.Point(129, 24);
            this.numPopSize.Name = "numPopSize";
            this.numPopSize.Size = new System.Drawing.Size(47, 20);
            this.numPopSize.TabIndex = 6;
            this.numPopSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numNOG
            // 
            this.numNOG.Location = new System.Drawing.Point(129, 49);
            this.numNOG.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNOG.Name = "numNOG";
            this.numNOG.Size = new System.Drawing.Size(47, 20);
            this.numNOG.TabIndex = 7;
            this.numNOG.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numPC
            // 
            this.numPC.Location = new System.Drawing.Point(129, 75);
            this.numPC.Name = "numPC";
            this.numPC.Size = new System.Drawing.Size(47, 20);
            this.numPC.TabIndex = 8;
            this.numPC.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // numPM
            // 
            this.numPM.Location = new System.Drawing.Point(129, 101);
            this.numPM.Name = "numPM";
            this.numPM.Size = new System.Drawing.Size(47, 20);
            this.numPM.TabIndex = 9;
            this.numPM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbRoulette
            // 
            this.rbRoulette.AutoSize = true;
            this.rbRoulette.Checked = true;
            this.rbRoulette.Location = new System.Drawing.Point(6, 19);
            this.rbRoulette.Name = "rbRoulette";
            this.rbRoulette.Size = new System.Drawing.Size(65, 17);
            this.rbRoulette.TabIndex = 10;
            this.rbRoulette.TabStop = true;
            this.rbRoulette.Text = "Roulette\r\n";
            this.rbRoulette.UseVisualStyleBackColor = true;
            // 
            // rbTournament
            // 
            this.rbTournament.AutoSize = true;
            this.rbTournament.Location = new System.Drawing.Point(6, 42);
            this.rbTournament.Name = "rbTournament";
            this.rbTournament.Size = new System.Drawing.Size(82, 17);
            this.rbTournament.TabIndex = 11;
            this.rbTournament.TabStop = true;
            this.rbTournament.Text = "Tournament";
            this.rbTournament.UseVisualStyleBackColor = true;
            // 
            // gbSelection
            // 
            this.gbSelection.Controls.Add(this.rbRoulette);
            this.gbSelection.Controls.Add(this.rbTournament);
            this.gbSelection.Location = new System.Drawing.Point(880, 291);
            this.gbSelection.Name = "gbSelection";
            this.gbSelection.Size = new System.Drawing.Size(99, 60);
            this.gbSelection.TabIndex = 12;
            this.gbSelection.TabStop = false;
            this.gbSelection.Text = "Selection Type";
            // 
            // gbElitism
            // 
            this.gbElitism.Controls.Add(this.rbElitNo);
            this.gbElitism.Controls.Add(this.rbElitYes);
            this.gbElitism.Location = new System.Drawing.Point(880, 356);
            this.gbElitism.Name = "gbElitism";
            this.gbElitism.Size = new System.Drawing.Size(99, 65);
            this.gbElitism.TabIndex = 13;
            this.gbElitism.TabStop = false;
            this.gbElitism.Text = "Elitism";
            // 
            // rbElitNo
            // 
            this.rbElitNo.AutoSize = true;
            this.rbElitNo.Checked = true;
            this.rbElitNo.Location = new System.Drawing.Point(6, 19);
            this.rbElitNo.Name = "rbElitNo";
            this.rbElitNo.Size = new System.Drawing.Size(39, 17);
            this.rbElitNo.TabIndex = 1;
            this.rbElitNo.TabStop = true;
            this.rbElitNo.Text = "No";
            this.rbElitNo.UseVisualStyleBackColor = true;
            // 
            // rbElitYes
            // 
            this.rbElitYes.AutoSize = true;
            this.rbElitYes.Location = new System.Drawing.Point(6, 42);
            this.rbElitYes.Name = "rbElitYes";
            this.rbElitYes.Size = new System.Drawing.Size(43, 17);
            this.rbElitYes.TabIndex = 0;
            this.rbElitYes.TabStop = true;
            this.rbElitYes.Text = "Yes";
            this.rbElitYes.UseVisualStyleBackColor = true;
            // 
            // gbCrossoverType
            // 
            this.gbCrossoverType.Controls.Add(this.rbCO2P);
            this.gbCrossoverType.Controls.Add(this.rbCOUn);
            this.gbCrossoverType.Controls.Add(this.rbCO1P);
            this.gbCrossoverType.Location = new System.Drawing.Point(985, 292);
            this.gbCrossoverType.Name = "gbCrossoverType";
            this.gbCrossoverType.Size = new System.Drawing.Size(99, 93);
            this.gbCrossoverType.TabIndex = 14;
            this.gbCrossoverType.TabStop = false;
            this.gbCrossoverType.Text = "Crossover Type";
            // 
            // rbCO2P
            // 
            this.rbCO2P.AutoSize = true;
            this.rbCO2P.Location = new System.Drawing.Point(6, 65);
            this.rbCO2P.Name = "rbCO2P";
            this.rbCO2P.Size = new System.Drawing.Size(63, 17);
            this.rbCO2P.TabIndex = 15;
            this.rbCO2P.TabStop = true;
            this.rbCO2P.Text = "2 Points";
            this.rbCO2P.UseVisualStyleBackColor = true;
            // 
            // rbCOUn
            // 
            this.rbCOUn.AutoSize = true;
            this.rbCOUn.Location = new System.Drawing.Point(6, 42);
            this.rbCOUn.Name = "rbCOUn";
            this.rbCOUn.Size = new System.Drawing.Size(61, 17);
            this.rbCOUn.TabIndex = 1;
            this.rbCOUn.TabStop = true;
            this.rbCOUn.Text = "Uniform";
            this.rbCOUn.UseVisualStyleBackColor = true;
            // 
            // rbCO1P
            // 
            this.rbCO1P.AutoSize = true;
            this.rbCO1P.Checked = true;
            this.rbCO1P.Location = new System.Drawing.Point(6, 19);
            this.rbCO1P.Name = "rbCO1P";
            this.rbCO1P.Size = new System.Drawing.Size(58, 17);
            this.rbCO1P.TabIndex = 0;
            this.rbCO1P.TabStop = true;
            this.rbCO1P.Text = "1 Point";
            this.rbCO1P.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Population size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Number of generations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Crossover probability";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mutation probability";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Granularity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Maximum range";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Minimum range";
            // 
            // gbParameters
            // 
            this.gbParameters.Controls.Add(this.numPopSize);
            this.gbParameters.Controls.Add(this.label6);
            this.gbParameters.Controls.Add(this.numRangeMin);
            this.gbParameters.Controls.Add(this.label7);
            this.gbParameters.Controls.Add(this.numRangeMax);
            this.gbParameters.Controls.Add(this.label8);
            this.gbParameters.Controls.Add(this.numGranularity);
            this.gbParameters.Controls.Add(this.label4);
            this.gbParameters.Controls.Add(this.numNOG);
            this.gbParameters.Controls.Add(this.label3);
            this.gbParameters.Controls.Add(this.numPC);
            this.gbParameters.Controls.Add(this.label2);
            this.gbParameters.Controls.Add(this.numPM);
            this.gbParameters.Controls.Add(this.label1);
            this.gbParameters.Location = new System.Drawing.Point(880, 12);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(204, 205);
            this.gbParameters.TabIndex = 22;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "GA Parameters";
            // 
            // zgcFunction
            // 
            this.zgcFunction.Location = new System.Drawing.Point(12, 4);
            this.zgcFunction.Name = "zgcFunction";
            this.zgcFunction.ScrollGrace = 0D;
            this.zgcFunction.ScrollMaxX = 0D;
            this.zgcFunction.ScrollMaxY = 0D;
            this.zgcFunction.ScrollMaxY2 = 0D;
            this.zgcFunction.ScrollMinX = 0D;
            this.zgcFunction.ScrollMinY = 0D;
            this.zgcFunction.ScrollMinY2 = 0D;
            this.zgcFunction.Size = new System.Drawing.Size(862, 304);
            this.zgcFunction.TabIndex = 23;
            // 
            // zgcPerformance
            // 
            this.zgcPerformance.Location = new System.Drawing.Point(12, 319);
            this.zgcPerformance.Name = "zgcPerformance";
            this.zgcPerformance.ScrollGrace = 0D;
            this.zgcPerformance.ScrollMaxX = 0D;
            this.zgcPerformance.ScrollMaxY = 0D;
            this.zgcPerformance.ScrollMaxY2 = 0D;
            this.zgcPerformance.ScrollMinX = 0D;
            this.zgcPerformance.ScrollMinY = 0D;
            this.zgcPerformance.ScrollMinY2 = 0D;
            this.zgcPerformance.Size = new System.Drawing.Size(862, 304);
            this.zgcPerformance.TabIndex = 24;
            // 
            // gaTimer
            // 
            this.gaTimer.Tick += new System.EventHandler(this.gaTimer_Tick);
            // 
            // graphTimer
            // 
            this.graphTimer.Tick += new System.EventHandler(this.graphTimer_Tick);
            // 
            // gbOptimization
            // 
            this.gbOptimization.Controls.Add(this.rbOpMax);
            this.gbOptimization.Controls.Add(this.rbOpMin);
            this.gbOptimization.Location = new System.Drawing.Point(1003, 218);
            this.gbOptimization.Name = "gbOptimization";
            this.gbOptimization.Size = new System.Drawing.Size(81, 68);
            this.gbOptimization.TabIndex = 25;
            this.gbOptimization.TabStop = false;
            this.gbOptimization.Text = "Optimization";
            // 
            // rbOpMax
            // 
            this.rbOpMax.AutoSize = true;
            this.rbOpMax.Location = new System.Drawing.Point(9, 42);
            this.rbOpMax.Name = "rbOpMax";
            this.rbOpMax.Size = new System.Drawing.Size(69, 17);
            this.rbOpMax.TabIndex = 1;
            this.rbOpMax.TabStop = true;
            this.rbOpMax.Text = "Maximum";
            this.rbOpMax.UseVisualStyleBackColor = true;
            // 
            // rbOpMin
            // 
            this.rbOpMin.AutoSize = true;
            this.rbOpMin.Checked = true;
            this.rbOpMin.Location = new System.Drawing.Point(9, 19);
            this.rbOpMin.Name = "rbOpMin";
            this.rbOpMin.Size = new System.Drawing.Size(66, 17);
            this.rbOpMin.TabIndex = 0;
            this.rbOpMin.TabStop = true;
            this.rbOpMin.Text = "Minimum";
            this.rbOpMin.UseVisualStyleBackColor = true;
            // 
            // gbFunctions
            // 
            this.gbFunctions.Controls.Add(this.rbF2);
            this.gbFunctions.Controls.Add(this.rbF1);
            this.gbFunctions.Location = new System.Drawing.Point(880, 218);
            this.gbFunctions.Name = "gbFunctions";
            this.gbFunctions.Size = new System.Drawing.Size(117, 67);
            this.gbFunctions.TabIndex = 26;
            this.gbFunctions.TabStop = false;
            this.gbFunctions.Text = "Functions";
            // 
            // rbF2
            // 
            this.rbF2.AutoSize = true;
            this.rbF2.Location = new System.Drawing.Point(9, 42);
            this.rbF2.Name = "rbF2";
            this.rbF2.Size = new System.Drawing.Size(72, 17);
            this.rbF2.TabIndex = 1;
            this.rbF2.Text = "x*Sin(x^2)";
            this.rbF2.UseVisualStyleBackColor = true;
            // 
            // rbF1
            // 
            this.rbF1.AutoSize = true;
            this.rbF1.BackColor = System.Drawing.SystemColors.Control;
            this.rbF1.Checked = true;
            this.rbF1.Location = new System.Drawing.Point(9, 19);
            this.rbF1.Name = "rbF1";
            this.rbF1.Size = new System.Drawing.Size(102, 17);
            this.rbF1.TabIndex = 0;
            this.rbF1.TabStop = true;
            this.rbF1.Text = "- | x*Sin(Sqrt |x|) |";
            this.rbF1.UseVisualStyleBackColor = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 632);
            this.Controls.Add(this.gbFunctions);
            this.Controls.Add(this.gbOptimization);
            this.Controls.Add(this.gbElitism);
            this.Controls.Add(this.zgcPerformance);
            this.Controls.Add(this.zgcFunction);
            this.Controls.Add(this.gbParameters);
            this.Controls.Add(this.gbCrossoverType);
            this.Controls.Add(this.gbSelection);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.rtbInfo);
            this.Name = "GUI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numRangeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGranularity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNOG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPM)).EndInit();
            this.gbSelection.ResumeLayout(false);
            this.gbSelection.PerformLayout();
            this.gbElitism.ResumeLayout(false);
            this.gbElitism.PerformLayout();
            this.gbCrossoverType.ResumeLayout(false);
            this.gbCrossoverType.PerformLayout();
            this.gbParameters.ResumeLayout(false);
            this.gbParameters.PerformLayout();
            this.gbOptimization.ResumeLayout(false);
            this.gbOptimization.PerformLayout();
            this.gbFunctions.ResumeLayout(false);
            this.gbFunctions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.NumericUpDown numRangeMin;
        private System.Windows.Forms.NumericUpDown numRangeMax;
        private System.Windows.Forms.NumericUpDown numGranularity;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown numPopSize;
        private System.Windows.Forms.NumericUpDown numNOG;
        private System.Windows.Forms.NumericUpDown numPC;
        private System.Windows.Forms.NumericUpDown numPM;
        private System.Windows.Forms.RadioButton rbRoulette;
        private System.Windows.Forms.RadioButton rbTournament;
        private System.Windows.Forms.GroupBox gbSelection;
        private System.Windows.Forms.GroupBox gbElitism;
        private System.Windows.Forms.RadioButton rbElitNo;
        private System.Windows.Forms.RadioButton rbElitYes;
        private System.Windows.Forms.GroupBox gbCrossoverType;
        private System.Windows.Forms.RadioButton rbCO2P;
        private System.Windows.Forms.RadioButton rbCOUn;
        private System.Windows.Forms.RadioButton rbCO1P;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbParameters;
        private ZedGraph.ZedGraphControl zgcFunction;
        private ZedGraph.ZedGraphControl zgcPerformance;
        private System.Windows.Forms.Timer gaTimer;
        private System.Windows.Forms.Timer graphTimer;
        private System.Windows.Forms.GroupBox gbOptimization;
        private System.Windows.Forms.RadioButton rbOpMax;
        private System.Windows.Forms.RadioButton rbOpMin;
        private System.Windows.Forms.GroupBox gbFunctions;
        private System.Windows.Forms.RadioButton rbF2;
        private System.Windows.Forms.RadioButton rbF1;
    }
}


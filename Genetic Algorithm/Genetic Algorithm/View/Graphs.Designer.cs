namespace Genetic_Algorithm
{
    partial class Graphs
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
            this.zgcFunction = new ZedGraph.ZedGraphControl();
            this.zgcPerformance = new ZedGraph.ZedGraphControl();
            this.gaTimer = new System.Windows.Forms.Timer(this.components);
            this.graphTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rtbInfo
            // 
            this.rtbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfo.Location = new System.Drawing.Point(708, 4);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(309, 390);
            this.rtbInfo.TabIndex = 0;
            this.rtbInfo.Text = "";
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
            this.zgcFunction.Size = new System.Drawing.Size(690, 192);
            this.zgcFunction.TabIndex = 23;
            // 
            // zgcPerformance
            // 
            this.zgcPerformance.Location = new System.Drawing.Point(12, 202);
            this.zgcPerformance.Name = "zgcPerformance";
            this.zgcPerformance.ScrollGrace = 0D;
            this.zgcPerformance.ScrollMaxX = 0D;
            this.zgcPerformance.ScrollMaxY = 0D;
            this.zgcPerformance.ScrollMaxY2 = 0D;
            this.zgcPerformance.ScrollMinX = 0D;
            this.zgcPerformance.ScrollMinY = 0D;
            this.zgcPerformance.ScrollMinY2 = 0D;
            this.zgcPerformance.Size = new System.Drawing.Size(690, 192);
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
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 404);
            this.Controls.Add(this.zgcPerformance);
            this.Controls.Add(this.zgcFunction);
            this.Controls.Add(this.rtbInfo);
            this.Name = "Graphs";
            this.Text = "Genetic Algorithm v2.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInfo;
        private ZedGraph.ZedGraphControl zgcFunction;
        private ZedGraph.ZedGraphControl zgcPerformance;
        private System.Windows.Forms.Timer gaTimer;
        private System.Windows.Forms.Timer graphTimer;
    }
}


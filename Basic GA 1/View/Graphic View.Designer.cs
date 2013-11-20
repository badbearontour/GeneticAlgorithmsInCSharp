namespace Basic_GA_1
{
    partial class Graphic_View
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
            this.zgcFunction = new ZedGraph.ZedGraphControl();
            this.zgcPerformance = new ZedGraph.ZedGraphControl();
            this.UpdateGraphTimer = new System.Windows.Forms.Timer(this.components);
            this.GenAlgTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // zgcFunction
            // 
            this.zgcFunction.Location = new System.Drawing.Point(12, 12);
            this.zgcFunction.Name = "zgcFunction";
            this.zgcFunction.ScrollGrace = 0D;
            this.zgcFunction.ScrollMaxX = 0D;
            this.zgcFunction.ScrollMaxY = 0D;
            this.zgcFunction.ScrollMaxY2 = 0D;
            this.zgcFunction.ScrollMinX = 0D;
            this.zgcFunction.ScrollMinY = 0D;
            this.zgcFunction.ScrollMinY2 = 0D;
            this.zgcFunction.Size = new System.Drawing.Size(1222, 389);
            this.zgcFunction.TabIndex = 1;
            // 
            // zgcPerformance
            // 
            this.zgcPerformance.Location = new System.Drawing.Point(12, 407);
            this.zgcPerformance.Name = "zgcPerformance";
            this.zgcPerformance.ScrollGrace = 0D;
            this.zgcPerformance.ScrollMaxX = 0D;
            this.zgcPerformance.ScrollMaxY = 0D;
            this.zgcPerformance.ScrollMaxY2 = 0D;
            this.zgcPerformance.ScrollMinX = 0D;
            this.zgcPerformance.ScrollMinY = 0D;
            this.zgcPerformance.ScrollMinY2 = 0D;
            this.zgcPerformance.Size = new System.Drawing.Size(1222, 389);
            this.zgcPerformance.TabIndex = 2;
            // 
            // UpdateGraphTimer
            // 
            this.UpdateGraphTimer.Tick += new System.EventHandler(this.UpdateGraphTimer_Tick);
            // 
            // GenAlgTimer
            // 
            this.GenAlgTimer.Tick += new System.EventHandler(this.GenAlgTimer_Tick);
            // 
            // Graphic_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 802);
            this.Controls.Add(this.zgcPerformance);
            this.Controls.Add(this.zgcFunction);
            this.Name = "Graphic_View";
            this.Text = "Graphic_View";
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zgcFunction;
        private ZedGraph.ZedGraphControl zgcPerformance;
        private System.Windows.Forms.Timer UpdateGraphTimer;
        private System.Windows.Forms.Timer GenAlgTimer;

    }
}
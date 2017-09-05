namespace Garden_Actuation_and_Control
{
    partial class frmMain
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
            this.tabManual = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnWaterValve = new System.Windows.Forms.Button();
            this.tabManual.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabManual
            // 
            this.tabManual.Controls.Add(this.tabPage1);
            this.tabManual.Controls.Add(this.tabPage2);
            this.tabManual.Location = new System.Drawing.Point(7, 6);
            this.tabManual.Name = "tabManual";
            this.tabManual.SelectedIndex = 0;
            this.tabManual.Size = new System.Drawing.Size(657, 505);
            this.tabManual.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(649, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnWaterValve);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(649, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manual Control";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnWaterValve
            // 
            this.btnWaterValve.Location = new System.Drawing.Point(316, 289);
            this.btnWaterValve.Name = "btnWaterValve";
            this.btnWaterValve.Size = new System.Drawing.Size(124, 46);
            this.btnWaterValve.TabIndex = 0;
            this.btnWaterValve.Text = "Water Valve";
            this.btnWaterValve.UseVisualStyleBackColor = true;
            this.btnWaterValve.Click += new System.EventHandler(this.btnWaterValve_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 512);
            this.Controls.Add(this.tabManual);
            this.Name = "frmMain";
            this.Text = "Garden Actualtion and Control";
            this.tabManual.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabManual;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnWaterValve;
    }
}


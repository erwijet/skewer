﻿namespace SKU_Maker
{
    partial class frm_exports
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
            this.pb_main = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.l_main = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // pb_main
            // 
            this.pb_main.Location = new System.Drawing.Point(12, 48);
            this.pb_main.Name = "pb_main";
            this.pb_main.Size = new System.Drawing.Size(894, 37);
            this.pb_main.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Genering Skus...";
            // 
            // l_main
            // 
            this.l_main.AutoSize = true;
            this.l_main.Location = new System.Drawing.Point(753, 13);
            this.l_main.Name = "l_main";
            this.l_main.Size = new System.Drawing.Size(97, 25);
            this.l_main.TabIndex = 2;
            this.l_main.Text = "waiting...";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // frm_exports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 107);
            this.Controls.Add(this.l_main);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_exports";
            this.Text = "Skewer | Export";
            this.Load += new System.EventHandler(this.frm_exports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_main;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}
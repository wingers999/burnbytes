﻿namespace Burnbytes.Forms
{
    partial class Cleaner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cleaner));
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCleanup = new System.Windows.Forms.Label();
            this.prgCleaning = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.LblCleaning = new System.Windows.Forms.Label();
            this.lblCurrentHandler = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblIntro
            // 
            this.lblDescription.Location = new System.Drawing.Point(48, 11);
            this.lblDescription.Name = "LblIntro";
            this.lblDescription.Size = new System.Drawing.Size(276, 41);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Burnbytes is cleaning up unnecessary files on your machine.";
            // 
            // LblClnUp
            // 
            this.lblCleanup.AutoSize = true;
            this.lblCleanup.Location = new System.Drawing.Point(8, 62);
            this.lblCleanup.Name = "LblClnUp";
            this.lblCleanup.Size = new System.Drawing.Size(92, 13);
            this.lblCleanup.TabIndex = 1;
            this.lblCleanup.Text = "Cleaning up drive ";
            // 
            // PrgClean
            // 
            this.prgCleaning.Location = new System.Drawing.Point(11, 78);
            this.prgCleaning.Name = "PrgClean";
            this.prgCleaning.Size = new System.Drawing.Size(227, 13);
            this.prgCleaning.TabIndex = 2;
            // 
            // BtnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(249, 70);
            this.btnCancel.Name = "BtnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblClean
            // 
            this.LblCleaning.AutoSize = true;
            this.LblCleaning.Location = new System.Drawing.Point(8, 96);
            this.LblCleaning.Name = "LblClean";
            this.LblCleaning.Size = new System.Drawing.Size(51, 13);
            this.LblCleaning.TabIndex = 4;
            this.LblCleaning.Text = "Cleaning:";
            // 
            // LblHandler
            // 
            this.lblCurrentHandler.AutoSize = true;
            this.lblCurrentHandler.Location = new System.Drawing.Point(63, 96);
            this.lblCurrentHandler.Name = "LblHandler";
            this.lblCurrentHandler.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentHandler.TabIndex = 5;
            // 
            // PtbLogo
            // 
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PtbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(11, 11);
            this.ptbLogo.Name = "PtbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(32, 32);
            this.ptbLogo.TabIndex = 6;
            this.ptbLogo.TabStop = false;
            // 
            // Cleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(335, 114);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.lblCurrentHandler);
            this.Controls.Add(this.LblCleaning);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.prgCleaning);
            this.Controls.Add(this.lblCleanup);
            this.Controls.Add(this.lblDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cleaner";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burnbytes";
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCleanup;
        private System.Windows.Forms.ProgressBar prgCleaning;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label LblCleaning;
        private System.Windows.Forms.Label lblCurrentHandler;
        private System.Windows.Forms.PictureBox ptbLogo;
    }
}
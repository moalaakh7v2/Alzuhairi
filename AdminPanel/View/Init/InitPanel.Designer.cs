﻿namespace AdminPanel.View.Init
{
    partial class InitPanel
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
            this.pnlChoise = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.btnFeatures = new System.Windows.Forms.PictureBox();
            this.btnSubjects = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFeatures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChoise
            // 
            this.pnlChoise.BackColor = System.Drawing.Color.White;
            this.pnlChoise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlChoise.Location = new System.Drawing.Point(150, 122);
            this.pnlChoise.Name = "pnlChoise";
            this.pnlChoise.Size = new System.Drawing.Size(11, 39);
            this.pnlChoise.TabIndex = 8;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Image = global::AdminPanel.Properties.Resources.btnSettings1;
            this.btnSettings.Location = new System.Drawing.Point(12, 121);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(135, 39);
            this.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSettings.TabIndex = 10;
            this.btnSettings.TabStop = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnFeatures
            // 
            this.btnFeatures.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFeatures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeatures.Image = global::AdminPanel.Properties.Resources.btnFeatures1;
            this.btnFeatures.Location = new System.Drawing.Point(12, 66);
            this.btnFeatures.Name = "btnFeatures";
            this.btnFeatures.Size = new System.Drawing.Size(135, 39);
            this.btnFeatures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFeatures.TabIndex = 9;
            this.btnFeatures.TabStop = false;
            this.btnFeatures.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjects.Image = global::AdminPanel.Properties.Resources.btnSubjects;
            this.btnSubjects.Location = new System.Drawing.Point(12, 12);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(135, 39);
            this.btnSubjects.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSubjects.TabIndex = 6;
            this.btnSubjects.TabStop = false;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // InitPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(159, 468);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnFeatures);
            this.Controls.Add(this.pnlChoise);
            this.Controls.Add(this.btnSubjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InitPanel";
            this.Text = "InitPanel";
            this.Load += new System.EventHandler(this.InitPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFeatures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChoise;
        private System.Windows.Forms.PictureBox btnSubjects;
        private System.Windows.Forms.PictureBox btnFeatures;
        private System.Windows.Forms.PictureBox btnSettings;
    }
}
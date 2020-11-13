namespace AdminPanel.View.Students
{
    partial class StudentPanel
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
            this.btnManageStudents = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnManageStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChoise
            // 
            this.pnlChoise.BackColor = System.Drawing.Color.White;
            this.pnlChoise.Location = new System.Drawing.Point(150, 12);
            this.pnlChoise.Name = "pnlChoise";
            this.pnlChoise.Size = new System.Drawing.Size(11, 39);
            this.pnlChoise.TabIndex = 4;
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageStudents.Image = global::AdminPanel.Properties.Resources.Untitled_5;
            this.btnManageStudents.Location = new System.Drawing.Point(12, 12);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(135, 39);
            this.btnManageStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnManageStudents.TabIndex = 1;
            this.btnManageStudents.TabStop = false;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(159, 468);
            this.Controls.Add(this.pnlChoise);
            this.Controls.Add(this.btnManageStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentPanel";
            this.Text = "StudentPanel";
            this.Load += new System.EventHandler(this.StudentPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnManageStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnManageStudents;
        private System.Windows.Forms.Panel pnlChoise;
    }
}
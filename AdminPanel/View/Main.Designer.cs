﻿namespace AdminPanel.View
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlConrols = new System.Windows.Forms.Panel();
            this.btnInit = new System.Windows.Forms.PictureBox();
            this.pnlChoise = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.PictureBox();
            this.btnPOS = new System.Windows.Forms.PictureBox();
            this.btnNoteBook = new System.Windows.Forms.PictureBox();
            this.btnStudents = new System.Windows.Forms.PictureBox();
            this.pnlView = new System.Windows.Forms.Panel();
            this.pnlControlManage = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlConrols.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNoteBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.pnlNav.Controls.Add(this.btnMin);
            this.pnlNav.Controls.Add(this.btnClose);
            this.pnlNav.Controls.Add(this.label1);
            this.pnlNav.Controls.Add(this.pictureBox1);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(972, 34);
            this.pnlNav.TabIndex = 0;
            this.pnlNav.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlNav_MouseMove);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMin.Location = new System.Drawing.Point(890, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(33, 23);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "ــ";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(929, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alzuhairi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::AdminPanel.Properties.Resources.شعار_صافي;
            this.pictureBox1.Location = new System.Drawing.Point(5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlConrols
            // 
            this.pnlConrols.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.pnlConrols.Controls.Add(this.btnLogout);
            this.pnlConrols.Controls.Add(this.btnInit);
            this.pnlConrols.Controls.Add(this.pnlChoise);
            this.pnlConrols.Controls.Add(this.btnAbout);
            this.pnlConrols.Controls.Add(this.btnPOS);
            this.pnlConrols.Controls.Add(this.btnNoteBook);
            this.pnlConrols.Controls.Add(this.btnStudents);
            this.pnlConrols.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlConrols.Location = new System.Drawing.Point(0, 34);
            this.pnlConrols.Name = "pnlConrols";
            this.pnlConrols.Size = new System.Drawing.Size(69, 468);
            this.pnlConrols.TabIndex = 1;
            this.pnlConrols.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlNav_MouseMove);
            // 
            // btnInit
            // 
            this.btnInit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInit.Image = global::AdminPanel.Properties.Resources.btnInit;
            this.btnInit.Location = new System.Drawing.Point(12, 180);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(45, 40);
            this.btnInit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInit.TabIndex = 7;
            this.btnInit.TabStop = false;
            this.btnInit.Visible = false;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // pnlChoise
            // 
            this.pnlChoise.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlChoise.Location = new System.Drawing.Point(63, 12);
            this.pnlChoise.Name = "pnlChoise";
            this.pnlChoise.Size = new System.Drawing.Size(5, 46);
            this.pnlChoise.TabIndex = 6;
            this.pnlChoise.Visible = false;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Image = global::AdminPanel.Properties.Resources.btnAbout;
            this.btnAbout.Location = new System.Drawing.Point(12, 234);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(45, 40);
            this.btnAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAbout.TabIndex = 3;
            this.btnAbout.TabStop = false;
            this.btnAbout.Visible = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPOS.Image = global::AdminPanel.Properties.Resources.btnPOS;
            this.btnPOS.Location = new System.Drawing.Point(12, 125);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(45, 40);
            this.btnPOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPOS.TabIndex = 2;
            this.btnPOS.TabStop = false;
            this.btnPOS.Visible = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnNoteBook
            // 
            this.btnNoteBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNoteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoteBook.Image = global::AdminPanel.Properties.Resources.btnNoteBook;
            this.btnNoteBook.Location = new System.Drawing.Point(12, 70);
            this.btnNoteBook.Name = "btnNoteBook";
            this.btnNoteBook.Size = new System.Drawing.Size(45, 40);
            this.btnNoteBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNoteBook.TabIndex = 1;
            this.btnNoteBook.TabStop = false;
            this.btnNoteBook.Visible = false;
            this.btnNoteBook.Click += new System.EventHandler(this.btnNoteBook_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.Image = global::AdminPanel.Properties.Resources.btnStudents;
            this.btnStudents.Location = new System.Drawing.Point(12, 15);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(45, 40);
            this.btnStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStudents.TabIndex = 0;
            this.btnStudents.TabStop = false;
            this.btnStudents.Visible = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // pnlView
            // 
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlView.Location = new System.Drawing.Point(228, 34);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(744, 468);
            this.pnlView.TabIndex = 2;
            this.pnlView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlNav_MouseMove);
            // 
            // pnlControlManage
            // 
            this.pnlControlManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControlManage.Location = new System.Drawing.Point(69, 34);
            this.pnlControlManage.Name = "pnlControlManage";
            this.pnlControlManage.Size = new System.Drawing.Size(159, 468);
            this.pnlControlManage.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Image = global::AdminPanel.Properties.Resources._1246273;
            this.btnLogout.Location = new System.Drawing.Point(12, 416);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(45, 40);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogout.TabIndex = 8;
            this.btnLogout.TabStop = false;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(972, 502);
            this.Controls.Add(this.pnlControlManage);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.pnlConrols);
            this.Controls.Add(this.pnlNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlConrols.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNoteBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pnlConrols;
        public System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Panel pnlControlManage;
        private System.Windows.Forms.PictureBox btnAbout;
        private System.Windows.Forms.PictureBox btnPOS;
        private System.Windows.Forms.PictureBox btnNoteBook;
        private System.Windows.Forms.PictureBox btnStudents;
        public System.Windows.Forms.Panel pnlChoise;
        private System.Windows.Forms.PictureBox btnInit;
        private System.Windows.Forms.PictureBox btnLogout;
    }
}
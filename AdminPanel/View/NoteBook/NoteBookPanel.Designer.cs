namespace AdminPanel.View.NoteBook
{
    partial class NoteBookPanel
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNoteBook = new System.Windows.Forms.PictureBox();
            this.pnlChoise = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNoteBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AdminPanel.Properties.Resources.Add_User;
            this.pictureBox1.Location = new System.Drawing.Point(12, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNoteBook
            // 
            this.btnAddNoteBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNoteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNoteBook.Image = global::AdminPanel.Properties.Resources.Add_User;
            this.btnAddNoteBook.Location = new System.Drawing.Point(12, 12);
            this.btnAddNoteBook.Name = "btnAddNoteBook";
            this.btnAddNoteBook.Size = new System.Drawing.Size(135, 39);
            this.btnAddNoteBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddNoteBook.TabIndex = 1;
            this.btnAddNoteBook.TabStop = false;
            this.btnAddNoteBook.Click += new System.EventHandler(this.btnAddNoteBook_Click);
            // 
            // pnlChoise
            // 
            this.pnlChoise.BackColor = System.Drawing.Color.White;
            this.pnlChoise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlChoise.Location = new System.Drawing.Point(150, 12);
            this.pnlChoise.Name = "pnlChoise";
            this.pnlChoise.Size = new System.Drawing.Size(11, 39);
            this.pnlChoise.TabIndex = 5;
            // 
            // NoteBookPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(159, 468);
            this.Controls.Add(this.pnlChoise);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddNoteBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoteBookPanel";
            this.Text = "NoteBookPanel";
            this.Load += new System.EventHandler(this.NoteBookPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNoteBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAddNoteBook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlChoise;
    }
}
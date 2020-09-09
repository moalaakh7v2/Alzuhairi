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
            this.pnlChoise = new System.Windows.Forms.Panel();
            this.btnReissuing = new System.Windows.Forms.PictureBox();
            this.btnManageNoteBook = new System.Windows.Forms.PictureBox();
            this.btnAddNoteBook = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnReissuing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnManageNoteBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNoteBook)).BeginInit();
            this.SuspendLayout();
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
            // btnReissuing
            // 
            this.btnReissuing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReissuing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReissuing.Image = global::AdminPanel.Properties.Resources.rrrrrr;
            this.btnReissuing.Location = new System.Drawing.Point(12, 121);
            this.btnReissuing.Name = "btnReissuing";
            this.btnReissuing.Size = new System.Drawing.Size(135, 39);
            this.btnReissuing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReissuing.TabIndex = 6;
            this.btnReissuing.TabStop = false;
            this.btnReissuing.Click += new System.EventHandler(this.btnReissuing_Click);
            // 
            // btnManageNoteBook
            // 
            this.btnManageNoteBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageNoteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageNoteBook.Image = global::AdminPanel.Properties.Resources.Untitled_3;
            this.btnManageNoteBook.Location = new System.Drawing.Point(12, 66);
            this.btnManageNoteBook.Name = "btnManageNoteBook";
            this.btnManageNoteBook.Size = new System.Drawing.Size(135, 39);
            this.btnManageNoteBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnManageNoteBook.TabIndex = 2;
            this.btnManageNoteBook.TabStop = false;
            this.btnManageNoteBook.Click += new System.EventHandler(this.btnManageNoteBook_Click);
            // 
            // btnAddNoteBook
            // 
            this.btnAddNoteBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNoteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNoteBook.Image = global::AdminPanel.Properties.Resources.Untitled_1;
            this.btnAddNoteBook.Location = new System.Drawing.Point(12, 12);
            this.btnAddNoteBook.Name = "btnAddNoteBook";
            this.btnAddNoteBook.Size = new System.Drawing.Size(135, 39);
            this.btnAddNoteBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddNoteBook.TabIndex = 1;
            this.btnAddNoteBook.TabStop = false;
            this.btnAddNoteBook.Click += new System.EventHandler(this.btnAddNoteBook_Click);
            // 
            // NoteBookPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(159, 468);
            this.Controls.Add(this.btnReissuing);
            this.Controls.Add(this.pnlChoise);
            this.Controls.Add(this.btnManageNoteBook);
            this.Controls.Add(this.btnAddNoteBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoteBookPanel";
            this.Text = "NoteBookPanel";
            this.Load += new System.EventHandler(this.NoteBookPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnReissuing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnManageNoteBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNoteBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAddNoteBook;
        private System.Windows.Forms.PictureBox btnManageNoteBook;
        private System.Windows.Forms.Panel pnlChoise;
        private System.Windows.Forms.PictureBox btnReissuing;
    }
}
namespace AdminPanel.View.NoteBook
{
    partial class Reissuing
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboNoteBook = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReissuing = new System.Windows.Forms.Button();
            this.btnQrDownload = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grdQRcode = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdQRcode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reissuing QRcode";
            // 
            // comboNoteBook
            // 
            this.comboNoteBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboNoteBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNoteBook.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNoteBook.FormattingEnabled = true;
            this.comboNoteBook.Location = new System.Drawing.Point(163, 111);
            this.comboNoteBook.Name = "comboNoteBook";
            this.comboNoteBook.Size = new System.Drawing.Size(207, 30);
            this.comboNoteBook.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "NoteBook Title";
            // 
            // txtCount
            // 
            this.txtCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(163, 188);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(207, 26);
            this.txtCount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Count";
            // 
            // btnReissuing
            // 
            this.btnReissuing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReissuing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnReissuing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReissuing.FlatAppearance.BorderSize = 0;
            this.btnReissuing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReissuing.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReissuing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReissuing.Location = new System.Drawing.Point(286, 258);
            this.btnReissuing.Name = "btnReissuing";
            this.btnReissuing.Size = new System.Drawing.Size(84, 32);
            this.btnReissuing.TabIndex = 11;
            this.btnReissuing.Text = "Reissuing";
            this.btnReissuing.UseVisualStyleBackColor = false;
            this.btnReissuing.Click += new System.EventHandler(this.btnReissuing_Click);
            // 
            // btnQrDownload
            // 
            this.btnQrDownload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQrDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnQrDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQrDownload.FlatAppearance.BorderSize = 0;
            this.btnQrDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQrDownload.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQrDownload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQrDownload.Location = new System.Drawing.Point(460, 296);
            this.btnQrDownload.Name = "btnQrDownload";
            this.btnQrDownload.Size = new System.Drawing.Size(240, 32);
            this.btnQrDownload.TabIndex = 15;
            this.btnQrDownload.Text = "Download QR Folder";
            this.btnQrDownload.UseVisualStyleBackColor = false;
            this.btnQrDownload.Click += new System.EventHandler(this.btnQrDownload_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(457, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "QRcode";
            // 
            // grdQRcode
            // 
            this.grdQRcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdQRcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQRcode.Location = new System.Drawing.Point(460, 115);
            this.grdQRcode.Name = "grdQRcode";
            this.grdQRcode.Size = new System.Drawing.Size(240, 175);
            this.grdQRcode.TabIndex = 13;
            // 
            // Reissuing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(744, 468);
            this.Controls.Add(this.btnQrDownload);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grdQRcode);
            this.Controls.Add(this.btnReissuing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboNoteBook);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reissuing";
            this.Text = "Reissuing";
            this.Load += new System.EventHandler(this.Reissuing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdQRcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboNoteBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReissuing;
        private System.Windows.Forms.Button btnQrDownload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdQRcode;
    }
}
namespace QRCodeAdded
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddQRPath = new System.Windows.Forms.Button();
            this.txtQRPath = new System.Windows.Forms.TextBox();
            this.txtFormPath = new System.Windows.Forms.TextBox();
            this.btnAddFormPath = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddQRPath
            // 
            this.btnAddQRPath.Location = new System.Drawing.Point(257, 56);
            this.btnAddQRPath.Name = "btnAddQRPath";
            this.btnAddQRPath.Size = new System.Drawing.Size(109, 23);
            this.btnAddQRPath.TabIndex = 0;
            this.btnAddQRPath.Text = "Add QR Path";
            this.btnAddQRPath.UseVisualStyleBackColor = true;
            this.btnAddQRPath.Click += new System.EventHandler(this.btnAddQRPath_Click);
            // 
            // txtQRPath
            // 
            this.txtQRPath.Location = new System.Drawing.Point(22, 57);
            this.txtQRPath.Name = "txtQRPath";
            this.txtQRPath.ReadOnly = true;
            this.txtQRPath.Size = new System.Drawing.Size(229, 23);
            this.txtQRPath.TabIndex = 1;
            // 
            // txtFormPath
            // 
            this.txtFormPath.Location = new System.Drawing.Point(19, 109);
            this.txtFormPath.Name = "txtFormPath";
            this.txtFormPath.ReadOnly = true;
            this.txtFormPath.Size = new System.Drawing.Size(229, 23);
            this.txtFormPath.TabIndex = 3;
            // 
            // btnAddFormPath
            // 
            this.btnAddFormPath.Location = new System.Drawing.Point(254, 108);
            this.btnAddFormPath.Name = "btnAddFormPath";
            this.btnAddFormPath.Size = new System.Drawing.Size(109, 23);
            this.btnAddFormPath.TabIndex = 2;
            this.btnAddFormPath.Text = "Add Form Path";
            this.btnAddFormPath.UseVisualStyleBackColor = true;
            this.btnAddFormPath.Click += new System.EventHandler(this.btnAddFormPath_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(67, 168);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(114, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(203, 168);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 241);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtFormPath);
            this.Controls.Add(this.btnAddFormPath);
            this.Controls.Add(this.txtQRPath);
            this.Controls.Add(this.btnAddQRPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddQRPath;
        private System.Windows.Forms.TextBox txtQRPath;
        private System.Windows.Forms.TextBox txtFormPath;
        private System.Windows.Forms.Button btnAddFormPath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
    }
}


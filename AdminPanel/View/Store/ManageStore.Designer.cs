namespace AdminPanel.View.Store
{
    partial class ManageStore
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
            this.grdStores = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGrant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdStores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Store";
            // 
            // grdStores
            // 
            this.grdStores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStores.Location = new System.Drawing.Point(18, 69);
            this.grdStores.Name = "grdStores";
            this.grdStores.Size = new System.Drawing.Size(714, 196);
            this.grdStores.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 284);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 26);
            this.comboBox1.TabIndex = 4;
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(281, 329);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(191, 23);
            this.txtCount.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Count";
            // 
            // btnGrant
            // 
            this.btnGrant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGrant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnGrant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrant.FlatAppearance.BorderSize = 0;
            this.btnGrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrant.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGrant.Location = new System.Drawing.Point(307, 386);
            this.btnGrant.Name = "btnGrant";
            this.btnGrant.Size = new System.Drawing.Size(84, 32);
            this.btnGrant.TabIndex = 10;
            this.btnGrant.Text = "Grant";
            this.btnGrant.UseVisualStyleBackColor = false;
            // 
            // ManageStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(744, 468);
            this.Controls.Add(this.btnGrant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.grdStores);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageStore";
            this.Text = "ManageStore";
            ((System.ComponentModel.ISupportInitialize)(this.grdStores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdStores;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGrant;
    }
}
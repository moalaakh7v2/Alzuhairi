namespace AdminPanel.View.Store
{
    partial class StorePanel
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
            this.btnManageStore = new System.Windows.Forms.PictureBox();
            this.btnAddStore = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnManageStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddStore)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChoise
            // 
            this.pnlChoise.BackColor = System.Drawing.Color.White;
            this.pnlChoise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlChoise.Location = new System.Drawing.Point(150, 12);
            this.pnlChoise.Name = "pnlChoise";
            this.pnlChoise.Size = new System.Drawing.Size(11, 39);
            this.pnlChoise.TabIndex = 8;
            // 
            // btnManageStore
            // 
            this.btnManageStore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageStore.Image = global::AdminPanel.Properties.Resources._321;
            this.btnManageStore.Location = new System.Drawing.Point(12, 66);
            this.btnManageStore.Name = "btnManageStore";
            this.btnManageStore.Size = new System.Drawing.Size(135, 39);
            this.btnManageStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnManageStore.TabIndex = 7;
            this.btnManageStore.TabStop = false;
            this.btnManageStore.Click += new System.EventHandler(this.btnManageStore_Click_1);
            // 
            // btnAddStore
            // 
            this.btnAddStore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStore.Image = global::AdminPanel.Properties.Resources._123;
            this.btnAddStore.Location = new System.Drawing.Point(12, 12);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Size = new System.Drawing.Size(135, 39);
            this.btnAddStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddStore.TabIndex = 6;
            this.btnAddStore.TabStop = false;
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // StorePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(159, 468);
            this.Controls.Add(this.pnlChoise);
            this.Controls.Add(this.btnManageStore);
            this.Controls.Add(this.btnAddStore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StorePanel";
            this.Text = "StorePanel";
            this.Load += new System.EventHandler(this.StorePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnManageStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChoise;
        private System.Windows.Forms.PictureBox btnManageStore;
        private System.Windows.Forms.PictureBox btnAddStore;
    }
}
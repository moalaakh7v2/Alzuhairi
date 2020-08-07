namespace AdminPanel.View.Subjects
{
    partial class SubjectsController
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnDepts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(85)))), ((int)(((byte)(111)))));
            this.btnDisplay.Location = new System.Drawing.Point(12, 17);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(141, 29);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Manage Subjects";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnDepts
            // 
            this.btnDepts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(85)))), ((int)(((byte)(111)))));
            this.btnDepts.Location = new System.Drawing.Point(159, 17);
            this.btnDepts.Name = "btnDepts";
            this.btnDepts.Size = new System.Drawing.Size(146, 29);
            this.btnDepts.TabIndex = 4;
            this.btnDepts.Text = "Manage Depts";
            this.btnDepts.UseVisualStyleBackColor = false;
            this.btnDepts.Click += new System.EventHandler(this.btnDepts_Click);
            // 
            // SubjectsController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(93)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(746, 65);
            this.Controls.Add(this.btnDepts);
            this.Controls.Add(this.btnDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubjectsController";
            this.Text = "SubjectsController";
            this.Load += new System.EventHandler(this.SubjectsController_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnDepts;
    }
}
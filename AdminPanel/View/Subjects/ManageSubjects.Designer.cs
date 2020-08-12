﻿namespace AdminPanel.View.Subjects
{
    partial class ManageSubjects
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
            this.grdDisplay = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.comboDeptEdit = new System.Windows.Forms.ComboBox();
            this.txtSubjectEdit = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboDeptAdd = new System.Windows.Forms.ComboBox();
            this.txtSubjectAdd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDisplay
            // 
            this.grdDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDisplay.Location = new System.Drawing.Point(30, 44);
            this.grdDisplay.Name = "grdDisplay";
            this.grdDisplay.Size = new System.Drawing.Size(193, 259);
            this.grdDisplay.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.comboDeptEdit);
            this.groupBox1.Controls.Add(this.txtSubjectEdit);
            this.groupBox1.Location = new System.Drawing.Point(229, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 259);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dept";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(97, 183);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // comboDeptEdit
            // 
            this.comboDeptEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDeptEdit.FormattingEnabled = true;
            this.comboDeptEdit.Location = new System.Drawing.Point(97, 110);
            this.comboDeptEdit.Name = "comboDeptEdit";
            this.comboDeptEdit.Size = new System.Drawing.Size(159, 21);
            this.comboDeptEdit.TabIndex = 1;
            // 
            // txtSubjectEdit
            // 
            this.txtSubjectEdit.Location = new System.Drawing.Point(97, 45);
            this.txtSubjectEdit.Name = "txtSubjectEdit";
            this.txtSubjectEdit.Size = new System.Drawing.Size(159, 20);
            this.txtSubjectEdit.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.comboDeptAdd);
            this.groupBox2.Controls.Add(this.txtSubjectAdd);
            this.groupBox2.Location = new System.Drawing.Point(520, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 259);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dept";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // comboDeptAdd
            // 
            this.comboDeptAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDeptAdd.FormattingEnabled = true;
            this.comboDeptAdd.Location = new System.Drawing.Point(26, 113);
            this.comboDeptAdd.Name = "comboDeptAdd";
            this.comboDeptAdd.Size = new System.Drawing.Size(159, 21);
            this.comboDeptAdd.TabIndex = 1;
            // 
            // txtSubjectAdd
            // 
            this.txtSubjectAdd.Location = new System.Drawing.Point(26, 45);
            this.txtSubjectAdd.Name = "txtSubjectAdd";
            this.txtSubjectAdd.Size = new System.Drawing.Size(159, 20);
            this.txtSubjectAdd.TabIndex = 0;
            // 
            // ManageSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(93)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(746, 325);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageSubjects";
            this.Text = "DisplaySubjects";
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox comboDeptEdit;
        private System.Windows.Forms.TextBox txtSubjectEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboDeptAdd;
        private System.Windows.Forms.TextBox txtSubjectAdd;
    }
}
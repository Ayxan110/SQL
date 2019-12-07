namespace SchoolDbProject
{
    partial class TeacherAddForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_Name = new System.Windows.Forms.TextBox();
            this.txbx_Surname = new System.Windows.Forms.TextBox();
            this.cmbx_Subject = new System.Windows.Forms.ComboBox();
            this.cmbx_Class = new System.Windows.Forms.ComboBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(91, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(91, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(91, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(90, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Subject";
            // 
            // txbx_Name
            // 
            this.txbx_Name.Location = new System.Drawing.Point(94, 74);
            this.txbx_Name.Name = "txbx_Name";
            this.txbx_Name.Size = new System.Drawing.Size(137, 20);
            this.txbx_Name.TabIndex = 2;
            // 
            // txbx_Surname
            // 
            this.txbx_Surname.Location = new System.Drawing.Point(94, 145);
            this.txbx_Surname.Name = "txbx_Surname";
            this.txbx_Surname.Size = new System.Drawing.Size(137, 20);
            this.txbx_Surname.TabIndex = 2;
            // 
            // cmbx_Subject
            // 
            this.cmbx_Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Subject.FormattingEnabled = true;
            this.cmbx_Subject.Location = new System.Drawing.Point(94, 215);
            this.cmbx_Subject.Name = "cmbx_Subject";
            this.cmbx_Subject.Size = new System.Drawing.Size(137, 21);
            this.cmbx_Subject.TabIndex = 3;
            // 
            // cmbx_Class
            // 
            this.cmbx_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Class.FormattingEnabled = true;
            this.cmbx_Class.Location = new System.Drawing.Point(94, 290);
            this.cmbx_Class.Name = "cmbx_Class";
            this.cmbx_Class.Size = new System.Drawing.Size(137, 21);
            this.cmbx_Class.TabIndex = 3;
            // 
            // btn_Next
            // 
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Next.Location = new System.Drawing.Point(171, 348);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(125, 35);
            this.btn_Next.TabIndex = 6;
            this.btn_Next.Text = "NEXT";
            this.btn_Next.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Add.Location = new System.Drawing.Point(44, 348);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(121, 35);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // TeacherAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cmbx_Class);
            this.Controls.Add(this.cmbx_Subject);
            this.Controls.Add(this.txbx_Surname);
            this.Controls.Add(this.txbx_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TeacherAddForm";
            this.Text = "TeacherAddForm";
            this.Load += new System.EventHandler(this.TeacherAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx_Name;
        private System.Windows.Forms.TextBox txbx_Surname;
        private System.Windows.Forms.ComboBox cmbx_Subject;
        private System.Windows.Forms.ComboBox cmbx_Class;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Add;
    }
}
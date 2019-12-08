namespace SchoolDbProject.Forms
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(24, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(24, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(192, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(192, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Class";
            // 
            // txbx_Name
            // 
            this.txbx_Name.Location = new System.Drawing.Point(29, 126);
            this.txbx_Name.Name = "txbx_Name";
            this.txbx_Name.Size = new System.Drawing.Size(121, 20);
            this.txbx_Name.TabIndex = 1;
            this.txbx_Name.Text = "Aykhan";
            // 
            // txbx_Surname
            // 
            this.txbx_Surname.Location = new System.Drawing.Point(29, 215);
            this.txbx_Surname.Name = "txbx_Surname";
            this.txbx_Surname.Size = new System.Drawing.Size(121, 20);
            this.txbx_Surname.TabIndex = 1;
            this.txbx_Surname.Text = "Dadashov";
            // 
            // cmbx_Subject
            // 
            this.cmbx_Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Subject.FormattingEnabled = true;
            this.cmbx_Subject.Location = new System.Drawing.Point(195, 125);
            this.cmbx_Subject.Name = "cmbx_Subject";
            this.cmbx_Subject.Size = new System.Drawing.Size(121, 21);
            this.cmbx_Subject.TabIndex = 2;
            this.cmbx_Subject.SelectionChangeCommitted += new System.EventHandler(this.cmbx_Subject_SelectionChangeCommitted);
            // 
            // cmbx_Class
            // 
            this.cmbx_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Class.FormattingEnabled = true;
            this.cmbx_Class.Location = new System.Drawing.Point(195, 215);
            this.cmbx_Class.Name = "cmbx_Class";
            this.cmbx_Class.Size = new System.Drawing.Size(121, 21);
            this.cmbx_Class.TabIndex = 2;
            this.cmbx_Class.SelectionChangeCommitted += new System.EventHandler(this.cmbx_Class_SelectionChangeCommitted);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Add.Location = new System.Drawing.Point(29, 344);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(121, 39);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Back.Location = new System.Drawing.Point(197, 344);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(121, 39);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "BACK";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // TeacherAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.btn_Back);
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
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Back;
    }
}
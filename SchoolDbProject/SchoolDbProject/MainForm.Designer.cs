namespace SchoolDbProject
{
    partial class MainForm
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
            this.btn_SubjectAdd = new System.Windows.Forms.Button();
            this.btn_TeacherAdd = new System.Windows.Forms.Button();
            this.btn_ClassAdd = new System.Windows.Forms.Button();
            this.btn_StudentAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(233, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select which to add";
            // 
            // btn_SubjectAdd
            // 
            this.btn_SubjectAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_SubjectAdd.Location = new System.Drawing.Point(210, 182);
            this.btn_SubjectAdd.Name = "btn_SubjectAdd";
            this.btn_SubjectAdd.Size = new System.Drawing.Size(171, 55);
            this.btn_SubjectAdd.TabIndex = 1;
            this.btn_SubjectAdd.Text = "Subject";
            this.btn_SubjectAdd.UseVisualStyleBackColor = true;
            this.btn_SubjectAdd.Click += new System.EventHandler(this.btn_SubjectAdd_Click);
            // 
            // btn_TeacherAdd
            // 
            this.btn_TeacherAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_TeacherAdd.Location = new System.Drawing.Point(210, 275);
            this.btn_TeacherAdd.Name = "btn_TeacherAdd";
            this.btn_TeacherAdd.Size = new System.Drawing.Size(171, 55);
            this.btn_TeacherAdd.TabIndex = 1;
            this.btn_TeacherAdd.Text = "Teacher";
            this.btn_TeacherAdd.UseVisualStyleBackColor = true;
            this.btn_TeacherAdd.Click += new System.EventHandler(this.btn_TeacherAdd_Click);
            // 
            // btn_ClassAdd
            // 
            this.btn_ClassAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_ClassAdd.Location = new System.Drawing.Point(387, 182);
            this.btn_ClassAdd.Name = "btn_ClassAdd";
            this.btn_ClassAdd.Size = new System.Drawing.Size(171, 55);
            this.btn_ClassAdd.TabIndex = 1;
            this.btn_ClassAdd.Text = "Class";
            this.btn_ClassAdd.UseVisualStyleBackColor = true;
            // 
            // btn_StudentAdd
            // 
            this.btn_StudentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_StudentAdd.Location = new System.Drawing.Point(387, 275);
            this.btn_StudentAdd.Name = "btn_StudentAdd";
            this.btn_StudentAdd.Size = new System.Drawing.Size(171, 55);
            this.btn_StudentAdd.TabIndex = 1;
            this.btn_StudentAdd.Text = "Student";
            this.btn_StudentAdd.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ClassAdd);
            this.Controls.Add(this.btn_TeacherAdd);
            this.Controls.Add(this.btn_StudentAdd);
            this.Controls.Add(this.btn_SubjectAdd);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SubjectAdd;
        private System.Windows.Forms.Button btn_TeacherAdd;
        private System.Windows.Forms.Button btn_ClassAdd;
        private System.Windows.Forms.Button btn_StudentAdd;
    }
}


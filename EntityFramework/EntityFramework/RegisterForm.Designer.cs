namespace EntityFramework
{
    partial class RegisterForm
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
            this.txbx_Name = new System.Windows.Forms.TextBox();
            this.txbx_Surname = new System.Windows.Forms.TextBox();
            this.txbx_Email = new System.Windows.Forms.TextBox();
            this.txbx_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(107, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txbx_Name
            // 
            this.txbx_Name.Location = new System.Drawing.Point(110, 69);
            this.txbx_Name.Name = "txbx_Name";
            this.txbx_Name.Size = new System.Drawing.Size(145, 20);
            this.txbx_Name.TabIndex = 1;
            // 
            // txbx_Surname
            // 
            this.txbx_Surname.Location = new System.Drawing.Point(110, 143);
            this.txbx_Surname.Name = "txbx_Surname";
            this.txbx_Surname.Size = new System.Drawing.Size(145, 20);
            this.txbx_Surname.TabIndex = 1;
            // 
            // txbx_Email
            // 
            this.txbx_Email.Location = new System.Drawing.Point(110, 218);
            this.txbx_Email.Name = "txbx_Email";
            this.txbx_Email.Size = new System.Drawing.Size(145, 20);
            this.txbx_Email.TabIndex = 1;
            // 
            // txbx_Password
            // 
            this.txbx_Password.Location = new System.Drawing.Point(110, 299);
            this.txbx_Password.Name = "txbx_Password";
            this.txbx_Password.Size = new System.Drawing.Size(145, 20);
            this.txbx_Password.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(107, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(107, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(107, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Register.Location = new System.Drawing.Point(110, 358);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(144, 44);
            this.btn_Register.TabIndex = 2;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txbx_Password);
            this.Controls.Add(this.txbx_Email);
            this.Controls.Add(this.txbx_Surname);
            this.Controls.Add(this.txbx_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_Name;
        private System.Windows.Forms.TextBox txbx_Surname;
        private System.Windows.Forms.TextBox txbx_Email;
        private System.Windows.Forms.TextBox txbx_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Register;
    }
}


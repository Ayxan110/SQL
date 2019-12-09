using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            using (SupportDbEntities db = new SupportDbEntities())
            {
                if (!(String.IsNullOrEmpty(txbx_Name.Text) || String.IsNullOrEmpty(txbx_Surname.Text) || String.IsNullOrEmpty(txbx_Email.Text) || String.IsNullOrEmpty(txbx_Password.Text)))
                {
                    db.Users.Add(new User
                    {
                        UserName = txbx_Name.Text,
                        UserSurname = txbx_Surname.Text,
                        UserEmail = txbx_Email.Text,
                        UserPassword = txbx_Password.Text,
                        RoleType = (int)RoleType.User
                    });
                    db.SaveChanges();
                    this.Close();
                }
                else
                    MessageBox.Show("Fill the gaps");
            }
        }
    }
}

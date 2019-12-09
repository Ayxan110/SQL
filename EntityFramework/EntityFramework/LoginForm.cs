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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            using (SupportDbEntities db = new SupportDbEntities())
            {
                if (!(String.IsNullOrEmpty(txbx_Email.Text) || String.IsNullOrEmpty(txbx_Password.Text)))
                {
                    User user = db.Users.Where(x => x.UserEmail == txbx_Email.Text && x.UserPassword == txbx_Password.Text).FirstOrDefault();
                    if (user == null)
                    {
                        MessageBox.Show("Email or Password is incorrect");
                    }
                    else if(user.RoleType == (int)RoleType.Admin)
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.ShowDialog();
                    }
                    else if (user.RoleType == (int)RoleType.User)
                    {
                        UserForm userForm = new UserForm();
                        userForm.ShowDialog();
                    }
                    else
                        MessageBox.Show("Success");
                }
                else
                    MessageBox.Show("Fill the gaps");
            }   
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            using (SupportDbEntities db = new SupportDbEntities())
            {
                User user = db.Users.Where(x => x.RoleType == (int)RoleType.Admin).FirstOrDefault();
                if(user == null)
                {
                    db.Users.Add(new User
                    {
                        UserName = "Admin",
                        UserSurname = "Adminov",
                        UserEmail = "admin@gmail.com",
                        UserPassword = "admin123",
                        RoleType = (int)RoleType.Admin
                    });
                    db.SaveChanges();
                }
            }
        }
    }
}

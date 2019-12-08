using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolDbProject.Forms;
using SchoolDbProject.Forms;

namespace SchoolDbProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_SubjectAdd_Click(object sender, EventArgs e)
        {
            SubjectAddForm subjectAddForm = new SubjectAddForm();
            subjectAddForm.ShowDialog();
        }

        private void btn_TeacherAdd_Click(object sender, EventArgs e)
        {
            TeacherAddForm teacherAddForm = new TeacherAddForm();
            teacherAddForm.ShowDialog();
        }
    }
}

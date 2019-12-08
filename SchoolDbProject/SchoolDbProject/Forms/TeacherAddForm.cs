using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDbProject.Forms
{
    public partial class TeacherAddForm : Form
    {
        public TeacherAddForm()
        {
            InitializeComponent();
        }

        string constr = @"Data Source = CAMR7\SQLSERVER2020; Initial Catalog = SchoolDb; Integrated Security = true";

        private void TeacherAddForm_Load(object sender, EventArgs e)
        {
            DataTable SubjectTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(constr))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Subjects", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(SubjectTable);
                    }
                }
            }
            cmbx_Subject.DataSource = SubjectTable;
            cmbx_Subject.DisplayMember = "SubjectName";
            cmbx_Subject.ValueMember = "SubjectID";
        }

        private void cmbx_Subject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable data = new DataTable();

            string SubjectId = ((ComboBox)sender).SelectedValue.ToString();

            using (SqlConnection sqlConnection = new SqlConnection(constr))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand($"SELECT DISTINCT c.classname,c.ClassId FROM Subjects as S INNER JOIN SubjectClass AS SC ON SC.SubjectID={SubjectId} " +
                    $"INNER JOIN Classes AS C ON SC.ClassId = C.ClassId", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(data);
                    }
                }
            }
            cmbx_Class.DataSource = data;
            cmbx_Class.DisplayMember = "ClassName";
            cmbx_Class.ValueMember = "ClassId";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constr))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Teachers(TeacherName,TeacherSurname,ClassID,SubjectID)" + $"VALUES('{txbx_Name.Text}','{txbx_Surname.Text}','{cmbx_Class.SelectedValue}','{cmbx_Subject.SelectedValue}')", sqlConnection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void cmbx_Class_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constr))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Classes", sqlConnection))
                {
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                }
            }
            cmbx_Class.ValueMember = "ClassID";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

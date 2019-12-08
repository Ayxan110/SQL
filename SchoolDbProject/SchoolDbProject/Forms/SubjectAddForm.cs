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
    public partial class SubjectAddForm : Form
    {
        public SubjectAddForm()
        {
            InitializeComponent();
        }

        string constr = @"Data Source = CAMR7\SQLSERVER2020; Initial Catalog = SchoolDb; Integrated Security = true";

        private void SubjectAddForm_Load(object sender, EventArgs e)
        {
            DataTable ClassTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(constr))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Classes", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(ClassTable);
                    }
                }
            }
            cmbx_Class.DataSource = ClassTable;
            cmbx_Class.DisplayMember = "ClassName";
            cmbx_Class.ValueMember = "ClassID";


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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constr))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO SubjectClass(SubjectID,ClassID)" + $"VALUES('{cmbx_Subject.SelectedValue}','{cmbx_Class.SelectedValue}')", sqlConnection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

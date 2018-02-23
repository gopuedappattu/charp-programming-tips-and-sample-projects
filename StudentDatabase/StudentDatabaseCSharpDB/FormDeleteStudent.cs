using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StudentDatabaseCSharpDB
{
    public partial class FormDeleteStudent : Form
    {
        private OleDbConnection StudentDBConnection;
        public FormDeleteStudent()
        {
            InitializeComponent();
        }

        private void FormDeleteStudent_Load(object sender, EventArgs e)
        {
            LoadstudentInfo();
        }

        //Copying the required code to set database connection
        public void SetDBConnection(ref OleDbConnection DBConnection)
        {
            StudentDBConnection = DBConnection;
        }

        //code to load student information
        private void LoadstudentInfo()
        {
            try
            {
                OleDbCommand DeleteCommand = new OleDbCommand();
                DeleteCommand.Connection = StudentDBConnection;
                string strAddQuery;
                strAddQuery = "SELECT * FROM STUDENT_TB";
                DeleteCommand.CommandText = strAddQuery;
                OleDbDataReader DeleteReader = DeleteCommand.ExecuteReader();
                listBoxStudents.Items.Clear();
                while (DeleteReader.Read())
                {
                    listBoxStudents.Items.Add(DeleteReader.GetValue(0));

                }
                DeleteReader.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Code to delete a student record
            try
            {
                OleDbCommand DeleteCommand = new OleDbCommand();
                DeleteCommand.Connection = StudentDBConnection;
                string strAddQuery;
                strAddQuery = "DELETE * FROM STUDENT_TB WHERE StudentID=" + listBoxStudents.SelectedItem + "";
                DeleteCommand.CommandText = strAddQuery;
                OleDbDataReader DeleteReader = DeleteCommand.ExecuteReader();
                DeleteReader.Close();
                LoadstudentInfo();
                MessageBox.Show("student information deleted...", "Student database");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Code for loading the listbox
            try
            {
                OleDbCommand FindCommand = new OleDbCommand();
                FindCommand.Connection = StudentDBConnection;
                string strAddQuery;
                strAddQuery = "SELECT * FROM STUDENT_TB WHERE StudentID=" + listBoxStudents.SelectedItem + "";
                FindCommand.CommandText = strAddQuery;
                OleDbDataReader DeleteReader = FindCommand.ExecuteReader();
                DeleteReader.Read();
                labelName.Text = DeleteReader.GetValue(1).ToString();
                DeleteReader.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

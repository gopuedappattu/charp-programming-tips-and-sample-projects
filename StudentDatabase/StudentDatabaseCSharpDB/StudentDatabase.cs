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
    public partial class StudentDatabase : Form
    {
        private DataTable GridStudentTableDisplay;
        private OleDbConnection StudentDBConnection;
        public StudentDatabase()
        {
            InitializeComponent();
        }

        private void addAStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddStudent AddStudent = new FormAddStudent();
            AddStudent.SetDBConnection(ref StudentDBConnection);
            AddStudent.ShowDialog();
        }

        private void deleteAStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeleteStudent DeleteStudent = new FormDeleteStudent();
            DeleteStudent.SetDBConnection(ref StudentDBConnection);
            DeleteStudent.ShowDialog();
        }

        private void showAllSudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //code to show all student details
            try
            {
                string mySelectQuery = "SELECT * FROM STUDENT_TB";
                OleDbCommand StudentCommand = new OleDbCommand(mySelectQuery, StudentDBConnection);
                OleDbDataAdapter StudentDataAdapter = new OleDbDataAdapter();
                StudentDataAdapter.SelectCommand = StudentCommand;
                DataSet StudentDataSet = new DataSet();
                StudentDataAdapter.Fill(StudentDataSet, "STUDENT_TB");
                dataGridViewStudentList.DataSource = StudentDataSet.Tables["STUDENT_TB"];
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void StudentDatabase_Load(object sender, EventArgs e)
        {
            GridStudentTableDisplay = new DataTable();
            GridStudentTableDisplay.Columns.Add("StudentID");
            GridStudentTableDisplay.Columns.Add("Student Name");
            GridStudentTableDisplay.Columns.Add("StudentAge");
            dataGridViewStudentList.DataSource = GridStudentTableDisplay;
            //Open the connection
            StudentDBConnection = new OleDbConnection();
            StudentDBConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=";// Connection string
            StudentDBConnection.ConnectionString += "F:\\Projects\\StudentDatabaseCSharpDB\\StudentDatabaseCSharpDB\\StudentDatabase.mdb";
            try
            {
                StudentDBConnection.Open();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
    }
}

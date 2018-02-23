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
    public partial class FormAddStudent : Form
    {
        private OleDbConnection StudentDBConnection;
        public FormAddStudent()
        {
            InitializeComponent();
        }

        //Copying the required code to set database connection
        public void SetDBConnection(ref OleDbConnection DBConnection)
        {
            StudentDBConnection = DBConnection;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //code to add a student
            try
            {
                OleDbCommand AddCommand = new OleDbCommand();
                AddCommand.Connection = StudentDBConnection;
                string strAddQuery;
                //Insert a student record
                strAddQuery = "insert into STUDENT_TB(StudentName,StudentAge) values('" + textBoxName.Text + "'," + textBoxAge.Text + ")";
                AddCommand.CommandText = strAddQuery;
                AddCommand.ExecuteNonQuery();
                MessageBox.Show("Student Added.. ");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}

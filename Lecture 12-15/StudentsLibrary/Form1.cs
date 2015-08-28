using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentsLibrary
{
    public partial class Form1 : Form
    {
        private string _connectionString;
        public Form1()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["db_connectionString"].ConnectionString;
        }

        private void clearControls()
        {
            txtName.Text = string.Empty;
            txtRollNumber.Text = string.Empty;
            cmbCourse.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearControls();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!VerifyParameters())
                return;
            try
            {
                using (MySqlConnection conn = new MySqlConnection())
                {
                    conn.ConnectionString = _connectionString;
                    conn.Open();

                    MySqlCommand insertCommand = new MySqlCommand("INSERT INTO users(`Name`,`RollNumber`,`ClassId`) VALUES (@1, @2, @3)", conn);

                    MySqlParameter paramName = new MySqlParameter("1", MySqlDbType.VarChar, 20);
                    paramName.Value = txtName.Text;

                    MySqlParameter paramRoll = new MySqlParameter("2", MySqlDbType.VarChar, 20);
                    paramRoll.Value = txtRollNumber.Text;

                    MySqlParameter paramCourse = new MySqlParameter("3", MySqlDbType.Int32, 11);
                    paramCourse.Value = cmbCourse.SelectedIndex;

                    insertCommand.Parameters.Add(paramName);
                    insertCommand.Parameters.Add(paramRoll);
                    insertCommand.Parameters.Add(paramCourse);

                    int rowId = insertCommand.ExecuteNonQuery();

                    if (rowId == 0)
                        lblError.Text = "User not saved.";
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }

            clearControls();
        }

        private bool VerifyParameters()
        {
            bool result = false;

            if (string.IsNullOrWhiteSpace(txtName.Text))
                lblError.Text = "Name is Empty.";
            else if (string.IsNullOrWhiteSpace(txtRollNumber.Text))
                lblError.Text = "Roll Number is Empty.";
            else if (cmbCourse.SelectedIndex == 0)
                lblError.Text = "Class is not selected";
            else
                result = true;

            return result;
        }

        private void btnShowall_Click(object sender, EventArgs e)
        {
            AllStudents frame = new AllStudents();
            frame.Show();
        }
    }
}

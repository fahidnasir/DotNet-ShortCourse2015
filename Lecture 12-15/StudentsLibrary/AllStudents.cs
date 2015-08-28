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
    public partial class AllStudents : Form
    {
        public AllStudents()
        {
            InitializeComponent();
            PopulateData();
        }

        private void PopulateData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection())
                {
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["db_connectionString"].ConnectionString;
                    conn.Open();


                    MySqlCommand command = new MySqlCommand("SELECT c.`Name` AS 'Course', u.`Name`, u.`RollNumber` FROM users u INNER JOIN classes c ON c.`Id` = u.`ClassId`", conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        dgStudents.AutoGenerateColumns = true;
                        dgStudents.DataSource = dt;
                        dgStudents.Refresh();
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}

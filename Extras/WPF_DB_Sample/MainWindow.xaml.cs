using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace WPF_DB_Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnShowFunc_Click(object sender, RoutedEventArgs e)
        {
            spShowHideArea.Visibility = System.Windows.Visibility.Visible;
        }

        private void btnHideFunc_Click(object sender, RoutedEventArgs e)
        {
            spShowHideArea.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void btnShowOtherScreen_Click(object sender, RoutedEventArgs e)
        {
            //Showing other screen.
            SecondScreen window = new SecondScreen();
            window.Show();
        }

        private void btnShowModelScreen_Click(object sender, RoutedEventArgs e)
        {
            SaveDataWithModel window = new SaveDataWithModel();
            window.Show();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //Removing all the values written in the Fields.
            this.txtName.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            lblResult.Content = string.Empty;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //Saving all the values written in the Fields.
            string name = this.txtName.Text;
            string email = this.txtEmail.Text;

            /**
             * See the App.Config of this project to see the connection string.
             * Make the Changes in the Connection string according to your database server.
             * 
             * Here are the Details:
             * 
             * server=localhost;
             * user id=root;
             * password=root;
             * database=wpf_db_demo"
             */

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["db_connectionString"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    //The table name is users in the above mentioned database.
                    string commandText = "Insert Into users(name, email) Values(@a, @b)";
                    using (MySqlCommand command = new MySqlCommand(commandText, conn))
                    {
                        //MySqlParameter(reserved Parameter name,   value);
                        MySqlParameter paramName = new MySqlParameter("a", name);
                        MySqlParameter paramEmail = new MySqlParameter("b", email);
                        command.Parameters.Add(paramName);
                        command.Parameters.Add(paramEmail);
                        int rowId = command.ExecuteNonQuery();

                        if (rowId > 0)
                        {
                            lblResult.Content = "Record Saved and Row id in Database is: " + command.LastInsertedId;
                        }
                        else
                        {
                            lblResult.Content = "Record not Saved.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblResult.Content = ex.Message;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

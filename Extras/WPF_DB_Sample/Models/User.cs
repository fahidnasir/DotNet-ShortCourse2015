using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WPF_DB_Sample.Models
{
    public class User : INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

        /// <summary>
        /// This method helps you to save the effort when want to save User in DB.
        /// 
        /// When ever you have to save User in Database you have a User's Object so why not make a method in that class to write it once.
        /// and whenever you have to save data. just call that method. and this method knows how to save a user in DB.
        /// </summary>
        /// <returns></returns>
        public int SaveUserInDatabase()
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
                    MySqlParameter paramName = new MySqlParameter("a", this.name);
                    MySqlParameter paramEmail = new MySqlParameter("b", this.email);
                    command.Parameters.Add(paramName);
                    command.Parameters.Add(paramEmail);
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                        return command.LastInsertedId;
                    return 0;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                    new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}

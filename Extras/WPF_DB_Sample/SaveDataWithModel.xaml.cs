using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using WPF_DB_Sample.Models;

namespace WPF_DB_Sample
{
    /// <summary>
    /// Interaction logic for SaveDataWithModel.xaml
    /// </summary>
    public partial class SaveDataWithModel : Window
    {
        public SaveDataWithModel()
        {
            InitializeComponent();
            this.rootElementForBinding.DataContext = new User();

            //You can try initialize binding with default Values.
            //this.rootElementForBinding.DataContext = new User() { Name = "Dummy Name", Email = "Dummy Email" };
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new User();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //  'as'   is also a way of Type Casting
            User modelValues = (this.rootElementForBinding.DataContext as User);
            try
            {
                int rowId = modelValues.SaveUserInDatabase();
                if (rowId > 0)
                    lblResult.Content = "Record is saved and Row ID is: " + rowId;
                else
                    lblResult.Content = "Record not Saved.";
            }
            catch (Exception ex)
            {
                lblResult.Content = ex.Message;
            }
            this.Close();
        }
    }
}

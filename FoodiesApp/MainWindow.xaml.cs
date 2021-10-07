using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Data.SqlClient;

namespace FoodiesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Hello World!!!!!
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }


        //private void buttonLogin_Click(object sender, RoutedEventArgs e)
        //{
        //    SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //    try
        //    {
        //        if (sqlCon.State == System.Data.ConnectionState.Closed)
        //            sqlCon.Open();
        //       // String query="SELECT COUNT(1) FROM tblUser"
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        sqlCon.Close();
        //    }
        //}

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }
}

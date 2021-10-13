using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
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
//using Microsoft.EntityFrameworkCore.Migrations;



namespace FoodiesApp.MVVM.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl 
    {
        public LoginView()
        {
            InitializeComponent();
        }
        private void loginBtn_Click(Object sender, RoutedEventArgs e)
        {
            DataSet1TableAdapters.UserLoginTableAdapter adp = new DataSet1TableAdapters.UserLoginTableAdapter();
            DataTable table = adp.GetData();

            string UserName = null;
            string Password = null;

            foreach (DataRow row in table.Rows)
            {
                UserName = row["UserName"].ToString();
                Password = row["Password"].ToString();
            }
            if(UserName.Contains(txtUsername.Text) && Password.Contains(txtPassword.Text))
            {
                LoginView loginView = new LoginView();
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.Show();
            
            }
        }
     
    
    }
}

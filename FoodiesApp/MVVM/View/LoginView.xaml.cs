using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
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
            if (UserName.Contains(txtUsername.Text) && Password.Contains(txtPassword.Text))
            {
                LoginView loginView = new LoginView();
                MainWindow mainWindow = new MainWindow();
                // this.Close();
                mainWindow.Show();

            }
        }


    }
}

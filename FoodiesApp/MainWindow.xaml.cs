using FoodiesApp.MVVM.ViewModel;
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
//using System.Data.SqlClient;
using Caliburn.Micro;

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
        public class MenuItems
        {
            public string MenuName { get; set; }
            public string MenuImage { get; set; }
        }
        public class HomeItems
        {
            public string HomeName { get; set; }
            public string HomeImage { get; set; }
        }
        public class FeaturedItems
        {
            public string FeaturedName { get; set; }
            public string FeaturedImage { get; set; }
        }
        public class RecipeItems
        {
            public string RecipeName { get; set; }
            public string RecipeImage { get; set; }

        }
        public class MyAccount
        {

        }
        public class About
        {

        }
        private LoginViewModel _loginVM;

    }
}
  
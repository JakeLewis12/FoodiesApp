using System.Windows;
using System.Windows.Input;
//using System.Data.SqlClient;

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
        //private LoginViewModel _loginVM;

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Close();

        }


    }
}



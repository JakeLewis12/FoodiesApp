using FoodiesApp.Core;
using FoodiesApp.MVVM.ViewModel;
using LinqToDB;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace FoodiesApp.MVVM.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    /// 

    public partial class HomeView : UserControl
    {

        public HomeView()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connString = @"Data Source=DESKTOP-RJRJT25\SQLEXPRESS;Initial Catalog=Foodies;Integrated Security=True";
            //try
            {
                //                DataSet2.PaellaRecipeDataTable db = new DataSet2.PaellaRecipeDataTable(connString);

                ///*                var st = new DataSet2.PaellaRecipeRow*/.
                //                //IQueryable<PaellaRecipe> ingredQuery =
                //                //     from ingredients in db.PaellaRecipe
                //                //     where ingredients != "NULL"
                //                //     select Ingredient;

                //                var ingredients =
                //                    from p in PaellaRecipe


                //                };
                //            }
                //            catch { }




            }

        }
        public class PaellaRecipe
        {
            public int id { get; set; }
            public string ingredient { get; set; }
            public string quantity { get; set; }

            public List<PaellaRecipe> ReadAll()
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["PaellaRecipe"].ConnectionString))
                {
                    return db.Query<PaellaRecipe>
                        ("Select* From PaellaRecipe").ToList();
                }
            }
        }




    }
}
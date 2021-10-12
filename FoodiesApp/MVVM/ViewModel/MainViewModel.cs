using FoodiesApp.Core;
using FoodiesApp.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiesApp.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand MyAccountViewCommand { get; set; }
        public RelayCommand LoginViewCommand { get; set; }
        public RelayCommand RecipeViewCommand { get; set; }
        public RelayCommand FeaturedViewCommand { get; set; }
        public RelayCommand AboutViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public AboutViewModel1 AboutVM { get; set; }
        public MyAccountViewModel1 MyAccountVM { get; set; }
        public LoginViewModel LoginVM { get; set; }
        public RecipesViewModel RecipeVM { get; set; }
        public FeaturedViewModel FeaturedVM { get; set; }
        private object _currentView;
        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            LoginVM = new LoginViewModel();
            RecipeVM = new RecipesViewModel();
            HomeVM = new HomeViewModel();
            FeaturedVM = new FeaturedViewModel();
            MyAccountVM = new MyAccountViewModel1();
            AboutVM = new AboutViewModel1();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
              {
                  CurrentView = HomeVM;
              });
            MyAccountViewCommand = new RelayCommand(o =>
              {
                  CurrentView = MyAccountVM;
              });
            LoginViewCommand = new RelayCommand(o =>
              {
                  CurrentView = LoginVM;
              });
            FeaturedViewCommand = new RelayCommand(o =>
              {
                  CurrentView = FeaturedVM;
              });
            RecipeViewCommand = new RelayCommand(o =>
              {
                  CurrentView = RecipeVM;
              });
            AboutViewCommand = new RelayCommand(o =>
              {
                  CurrentView = AboutVM;
              });
        }



    }

}


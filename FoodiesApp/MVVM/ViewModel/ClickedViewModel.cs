using FoodiesApp.Core;
using FoodiesApp.MVVM.ViewModel;


namespace FoodiesApp.MVVM.ViewModel
{
    internal class ClickedViewModel : ObservableObject
    {

        public RelayCommand FirstViewCommand { get; set; }
        public RelayCommand SecondViewCommand { get; set; }
        public RelayCommand ThirdViewCommand { get; set; }
        public RelayCommand FourthViewCommand { get; set; }
        public RelayCommand FifthViewCommand { get; set; }
        public RelayCommand SixthViewCommand { get; set; }
        public RelayCommand SeventhViewCommand { get; set; }


        public FirstViewModel FirstVM { get; set; }
        public SecondViewModel SecondVM { get; set; }
        public ThirdViewModel ThirdVM { get; set; }
        public FourthViewModel FourthVM { get; set; }
        public FifthViewModel FifthVM { get; set; }
        public SixthViewModel SixthVM { get; set; }
        public SeventhViewModel SeventhVM { get; set; }


        private object _selectedView1;
        private object _selectedView2;
        private object _selectedView3;
        private object _selectedView4;
        private object _selectedView5;
        private object _selectedView6;
        private object _selectedView7;

        public object SelectedView1
        {
            get => _selectedView1;
            set
            {
                _selectedView1 = value;
                OnPropertyChanged();
            }
        }
        public object SelectedView2
        {
            get => _selectedView2;
            set
            {
                _selectedView2 = value;
                OnPropertyChanged();
            }
        }

        public object SelectedView3
        {
            get => _selectedView3;
            set
            {
                _selectedView3 = value;
                OnPropertyChanged();
            }
        }

        public object SelectedView4
        {
            get => _selectedView4;
            set
            {
                _selectedView4 = value;
                OnPropertyChanged();
            }
        }

        public object SelectedView5
        {
            get => _selectedView5;
            set
            {
                _selectedView5 = value;
                OnPropertyChanged();
            }
        }

        public object SelectedView6
        {
            get => _selectedView6;
            set
            {
                _selectedView6 = value;
                OnPropertyChanged();
            }
        }

        public object SelectedView7
        {
            get => _selectedView7;
            set
            {
                _selectedView7 = value;
                OnPropertyChanged();
            }
        }


        public ClickedViewModel()
        {
            FirstVM = new FirstViewModel();
            SecondVM = new SecondViewModel();
            ThirdVM = new ThirdViewModel();
            FourthVM = new FourthViewModel();
            FifthVM = new FifthViewModel();
            SixthVM = new SixthViewModel();
            SeventhVM = new SeventhViewModel();
            

            {

                FirstViewCommand = new RelayCommand(o =>
                {
                    SelectedView1 = FirstVM;
                });
                SecondViewCommand = new RelayCommand(o =>
                {
                    SelectedView2 = SecondVM;
                });
                ThirdViewCommand = new RelayCommand(o =>
                {
                    SelectedView3 = ThirdVM;
                });
                FourthViewCommand = new RelayCommand(o =>
                {
                    SelectedView4 = FourthVM;
                });
                FifthViewCommand = new RelayCommand(o =>
                {
                    SelectedView5 = FifthVM;
                });
                SixthViewCommand = new RelayCommand(o =>
                {
                    SelectedView6 = SixthVM;
                });
                SeventhViewCommand = new RelayCommand(o =>
                {
                    SelectedView7 = SeventhVM;
                });

            }

        }

    }
}
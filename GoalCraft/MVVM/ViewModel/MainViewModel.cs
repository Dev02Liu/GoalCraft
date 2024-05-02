using GoalCraft.Commands;
using System.Windows.Input;

namespace GoalCraft.MVVM.ViewModel
{
    public class MainViewModel : BaseViewModel
    {

        public ICommand NavigateCommand { get; private set; }

        private BaseViewModel? _currentViewModel;
        public BaseViewModel? CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }

        private NavBarViewModel? _leftNavBarViewModel;
        public NavBarViewModel? LeftNavBarViewModel // Adjusted type to NavBarViewModel
        {
            get => _leftNavBarViewModel;
            set => SetProperty(ref _leftNavBarViewModel, value);
        }

        public MainViewModel()
        {

            NavigateCommand = new RelayCommand(Navigate);

            CurrentViewModel = new HomeViewModel();
            LeftNavBarViewModel = new NavBarViewModel(); // Pass navigationService

            SetupNavigation(); // Adjust setup method to correctly subscribe to events
        }

        private void Navigate(object? parameter)
        {
            if (parameter is string destination)
            {
                switch (destination)
                {
                    case "Home":
                        CurrentViewModel = new HomeViewModel();
                        break;
                    case "Create":
                        CurrentViewModel = new CreateViewModel();
                        break;
                    case "Manage":
                        CurrentViewModel = new ManageViewModel();
                        break;
                }
            }
        }

        private void SetupNavigation()
        {
            // Correctly subscribe to the OnNavigateRequested event
            if (LeftNavBarViewModel != null)
            {
                LeftNavBarViewModel.OnNavigateRequested += Navigate;
            }
        }
    }

}

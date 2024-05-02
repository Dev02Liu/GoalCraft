using GoalCraft.Commands;
using System.Windows.Input;

namespace GoalCraft.MVVM.ViewModel
{
    public class NavBarViewModel : BaseViewModel
    {
        public ICommand NavigateCommand { get; private set; }

        // Ensure the event name matches what you subscribe to in MainViewModel
        public event Action<string>? OnNavigateRequested;

        public NavBarViewModel()
        {
            NavigateCommand = new RelayCommand(parameter =>
            {
                if (parameter is string destination)
                {
                    OnNavigateRequested?.Invoke(destination);
                }
            });
        }
    }
}

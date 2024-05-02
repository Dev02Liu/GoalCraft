using GoalCraft.MVVM.ViewModel;
using System.Windows;

namespace GoalCraft
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Set up MainViewModel with the navigation service
            var mainViewModel = new MainViewModel();

            // Set the DataContext of the MainWindow
            this.DataContext = mainViewModel;
        }
    }
}
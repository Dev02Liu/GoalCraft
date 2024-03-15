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
            
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            tbTitle.Text = "New";
        }
    }
}
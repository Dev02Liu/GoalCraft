using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;

namespace GoalCraft.MVVM.View
{
    /// <summary>
    /// Interaktionslogik für CreateView.xaml
    /// </summary>
    public partial class CreateView : UserControl
    {
        public CreateView()
        {
            InitializeComponent();
        }
        private void TextChanged(Object sender, TextChangedEventArgs e)
        {
            titlePlaceholder.Visibility = string.IsNullOrEmpty(title.Text) ? Visibility.Visible : Visibility.Hidden;
            txtPlaceholder.Visibility = string.IsNullOrEmpty(txt.Text) ? Visibility.Visible : Visibility.Hidden;
        }

        private void BtnClear(object sender, RoutedEventArgs e) 
        {
            title.Text = "";
            txt.Text = "";
            cal_startdate.SelectedDate = DateTime.Now;
            cal_deadline.SelectedDate = DateTime.Now;  
        }

        private void BtnCreate(object sender, RoutedEventArgs e)
        {
            if (cal_startdate.SelectedDate.HasValue) { var startdate = cal_startdate.SelectedDate.Value; }
            if (cal_deadline.SelectedDate.HasValue) { var deadline = cal_deadline.SelectedDate.Value; }
            //title.Text, txt.Text
        }
    }
}

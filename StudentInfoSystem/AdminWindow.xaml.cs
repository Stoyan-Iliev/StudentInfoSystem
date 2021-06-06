using System.Windows;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void OnClick_ShowStudentInfo(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void OnClick_HighestGradeStudents(object sender, RoutedEventArgs e)
        {
            HighestGradeStudents window = new HighestGradeStudents();
            window.Show();
            this.Close();
        }
    }
}

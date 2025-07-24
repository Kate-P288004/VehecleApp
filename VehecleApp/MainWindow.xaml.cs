using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VehecleApp
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
      
        private void AddVehicleButton_Click(object sender, RoutedEventArgs e)
        {
            string brand = BrandTextBox.Text;
            string model = ModelTextBox.Text;
            string year = YearTextBox.Text;

            if (string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(year))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }




        }




    }
}
using System.Windows;
using VehecleApp;

namespace VehicleApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddVehicle_Click(object sender, RoutedEventArgs e)
        {
            string brand = BrandInput.Text;
            string model = ModelInput.Text;
            string year = YearInput.Text;

            if (string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(year))
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

            Vehicle newVehicle = new Vehicle
            {
                Brand = brand,
                Model = model,
                Year = year
            };

            VehicleListBox.Items.Add(newVehicle);

            // Clear input fields
            BrandInput.Clear();
            ModelInput.Clear();
            YearInput.Clear();
        }
    }
}

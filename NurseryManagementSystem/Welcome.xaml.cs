using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NurseryManagementSystem
{
    /// <summary>
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {
        public Welcome()
        {
            InitializeComponent();

        }

        private void exitbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dres;
            dres = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (dres == MessageBoxResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void plant_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Plant_Section ps = new Plant_Section();
            ps.Show();
            this.Close();


        }

        private void employee_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            EmployeeSection ps = new EmployeeSection();
            ps.ShowDialog();
            this.Close();

        }
    }
}

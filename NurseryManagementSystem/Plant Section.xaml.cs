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
    /// Interaction logic for Plant_Section.xaml
    /// </summary>
    public partial class Plant_Section : Window
    {
        public Plant_Section()
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

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Add_Plant addpt = new Add_Plant();
            addpt.ShowDialog();
            this.Close();

        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Update_Plant addpt = new Update_Plant();
            addpt.ShowDialog();
            this.Close();

        }

        private void deletebtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Delete_plant addpt = new Delete_plant();
            addpt.ShowDialog();
            this.Close();
        }

        private void searchbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Search_Plant addpt = new Search_Plant();
            addpt.ShowDialog();
            this.Close();

        }

        private void exitbtn2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            EmployeeSection addpt = new EmployeeSection();
            addpt.ShowDialog();
            this.Close();
        }
    }
}

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
using System.Data.SqlClient;
using System.Data;
namespace NurseryManagementSystem
{
    /// <summary>
    /// Interaction logic for Add_Plant.xaml
    /// </summary>
    public partial class Add_Plant : Window
    {
        public Add_Plant()
        {
            InitializeComponent();
        }
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void add_Click(object sender, RoutedEventArgs e)
        {
            String pname, ptype, pprice;
            pname = name.Text;
            ptype = type.Text;
            pprice = price.Text;
            if (pname != "" && ptype != "" && pprice != "")
            {

                try
                {
                String query = "insert into plants(name,type,price) values('"+pname+"','"+ptype+"','"+pprice+"')";
                sqlconn.Open();
               SqlCommand cmd = new SqlCommand(
                    query, sqlconn);
                cmd.ExecuteNonQuery();
                MessageBoxResult dres;
                dres = MessageBox.Show("Added Successfully.Do you want to add more?", "Added", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (dres == MessageBoxResult.Yes)
                {
                    Add_Plant ps = new Add_Plant();
                    ps.Show();
                    this.Close();
                }
                else
                {
                    Plant_Section ps = new Plant_Section();
                    ps.Show();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                sqlconn.Close();

            }
            }
            else
            {
                MessageBox.Show("Enter all feilds");
            }

        }
        private void exit_Click(object sender, RoutedEventArgs e)
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

        private void cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dres;
            dres = MessageBox.Show("Do you want to exit and go back to plant section?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (dres == MessageBoxResult.Yes)
            {
                Plant_Section ps = new Plant_Section();
                ps.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }         
        }

      
    }
}

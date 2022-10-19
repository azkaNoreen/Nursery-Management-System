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
    /// Interaction logic for Update_Plant.xaml
    /// </summary>
    public partial class Update_Plant : Window
    {
        public Update_Plant()
        {
            InitializeComponent();
        }
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void update_Click(object sender, RoutedEventArgs e)
        {
            String name, updatedprice;
            name = upname.Text;
            updatedprice = upprice.Text;
            if (name != "" && updatedprice != "")
            {

                try
                {
                String query = "update plants set price='"+updatedprice+"'where name='" + name + "'";
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand(
                     query, sqlconn);
                int rowsEffected=cmd.ExecuteNonQuery();
                if (rowsEffected > 0)
                {
                    MessageBoxResult dres;
                    dres = MessageBox.Show("Updated Successfully.Do you want to Update more?", "Deleted", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (dres == MessageBoxResult.Yes)
                    {
                        Update_Plant ps = new Update_Plant();
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
                else
                {
                    MessageBoxResult dres;
                    dres = MessageBox.Show("Record not found, yes to try update one more time!", "Not found", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (dres == MessageBoxResult.Yes)
                    {
                        Update_Plant ps = new Update_Plant();
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

       
    }
}

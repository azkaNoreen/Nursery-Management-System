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
    /// Interaction logic for Search_Plant.xaml
    /// </summary>
    public partial class Search_Plant : Window
    {
        public Search_Plant()
        {
            InitializeComponent();
        }
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void search_Click(object sender, RoutedEventArgs e)
        {
            String searchPlant;
            searchPlant=searchname.Text;
            if (searchPlant != "")
            {

                try
                {
                String query = "Select * from plants where name='" + searchPlant + "'";

                sqlconn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    query, sqlconn);
                DataTable dtable = new DataTable();

                adapter.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    foreach (DataRow row in dtable.Rows)
                    {
                        string name = row["name"].ToString();
                        string type = row["type"].ToString();
                        string price = row["price"].ToString();

                        MessageBox.Show(name + type + price);

                    }
                }
                else
                {
                    MessageBox.Show("Plant does not exist", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    searchname.Clear();
                    searchname.Focus();
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

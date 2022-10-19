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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
namespace NurseryManagementSystem
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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
            Username.Clear();
            Password.Clear();
        }


        private void login_Click(object sender, RoutedEventArgs e)
        {
            String uname, pass;
            uname = Username.Text;
            pass = Password.Text;
            try
            {
                String query = "Select * from users where username='" + uname + "' and password='" + pass + "'";

                sqlconn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    query, sqlconn);
                DataTable dtable = new DataTable();

                adapter.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    uname = Username.Text;
                    pass = Password.Text;

                    this.Hide();
                    //page to go to welcome
                    Welcome wc = new Welcome();
             
                    wc.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Login credentials", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    Username.Clear();
                    Password.Clear();

                    Username.Focus();
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

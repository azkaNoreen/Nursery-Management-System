using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace NurseryManagementSystem
{
    public partial class Update_Employee : Form
    {
        public Update_Employee()
        {
            InitializeComponent();
        }
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        private void button1_Click(object sender, EventArgs e)
        {
            String name, phone;
            name = textBox1.Text;
            phone = textBox2.Text;
            if (name != "" && phone != "")
            {

                try
                {
                String query = "update employee set phone='" + phone + "'where name='" + name + "'";
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand(
                     query, sqlconn);
                int rowsEffected = cmd.ExecuteNonQuery();
                if (rowsEffected > 0)
                {
                  
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                    DialogResult result = MessageBox.Show("Updated Successfully.Do you want to Update more?", "Conformation", buttons);

                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        Update_Employee ps = new Update_Employee();
                        ps.ShowDialog();
                            this.Close();

                        }
                        else
                    {
                    }

                }
                else
                {
                    
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Record not found,  yes to try update one more time!", "Not Found", buttons);

                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        Update_Employee ps = new Update_Employee();
                        ps.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                        EmployeeSection ps = new EmployeeSection();
                        ps.ShowDialog();
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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show("Do you want to cancel and go back to Employee section?", "Exit", buttons);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                EmployeeSection ps = new EmployeeSection();
                ps.ShowDialog();
                this.Close();

            }
            else
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show("Do you want to exit?", "Exit", buttons);

            if (result == DialogResult.Yes)
            {
                this.Close();

            }
            else
            {
            }
        }
    }
}

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
    public partial class Delete_Employee : Form
    {
        public Delete_Employee()
        {
            InitializeComponent();
        }
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void button1_Click(object sender, EventArgs e)
        {
            String dname;
            dname = textBox1.Text;
            if (dname != "")
            {

                try
                {
                String query = "delete from employee where name='" + dname + "'";
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand(
                     query, sqlconn);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Deleted Successfully.Do you want to delete more?", "Deleted", buttons);

                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        Delete_Employee ps = new Delete_Employee();
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
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Record not found,  yes to try delete one more time!", "Not Found", buttons);

                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        Delete_Employee ps = new Delete_Employee();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

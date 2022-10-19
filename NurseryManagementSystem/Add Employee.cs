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


namespace NurseryManagementSystem
{
    public partial class Add_Employee : Form
    {
        public Add_Employee()
        {
            InitializeComponent();
        }
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void button2_Click(object sender, EventArgs e)
        {
          
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show("Do you want to Cancel and go back to Employee section?", "Exit", buttons);

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

        private void button1_Click(object sender, EventArgs e)
        {
            String ename, ephone, eaddresss;
            ename = textBox1.Text;
            ephone = textBox2.Text;
            eaddresss = textBox3.Text;
            if (ename != "" && ephone != "" && eaddresss != "")
            {

                try
                {
                    String query = "insert into employee(name,phone,address) values('" + ename + "','" + ephone + "','" + eaddresss + "')";
                    sqlconn.Open();
                    SqlCommand cmd = new SqlCommand(
                         query, sqlconn);
                    cmd.ExecuteNonQuery();
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Added Successfully.Do you want to add more?", "Confirmation", buttons);

                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        Add_Employee ps = new Add_Employee();
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
                MessageBox.Show("Enter all fields");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Phone_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Employee_Load(object sender, EventArgs e)
        {

        }
    }
}

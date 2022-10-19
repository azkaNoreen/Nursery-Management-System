using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NurseryManagementSystem
{
    public partial class EmployeeSection : Form
    {
        public EmployeeSection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Employee addpt = new Add_Employee();
            addpt.ShowDialog();
            this.Close();

        }

        private void EmployeeSection_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Employee addpt = new Delete_Employee();
            addpt.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Display_All addpt = new Display_All();
            addpt.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Employee addpt = new Update_Employee();
            addpt.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        int x;
        private void Main_Load(object sender, EventArgs e)
        {
            // Set Operations to ComboBox
            cmbOperations.Items.Add("+");
            cmbOperations.Items.Add("-");
            cmbOperations.Items.Add("/");
            cmbOperations.Items.Add("*");
            cmbOperations.Items.Add("%");
            x = lblResult.Location.X + lblResult.Size.Width;
        }

        private void btnGetResult_Click(object sender, EventArgs e)
        {
            if (cmbOperations.SelectedItem == null)
            {
                MessageBox.Show("Zehmet olmasa emeliyyati secin!", "Xeta", MessageBoxButtons.OK);
            }
            else
            {
                string operation = cmbOperations.SelectedItem.ToString();
                int number01 = Convert.ToInt32(nudNumber01.Value);
                int number02 = Convert.ToInt32(nudNumber02.Value);
                writeResult(number01, number02, operation);
               
            }
        }

        private void cmbOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            int locationX = nudNumber01.Location.X + nudNumber01.Size.Width / 2 - 10;
            int locationY = nudNumber01.Location.Y + nudNumber01.Size.Height + (nudNumber02.Location.Y - nudNumber01.Size.Height - nudNumber01.Location.Y) / 2 - lblOperation.Size.Height / 2;
            lblOperation.Location = new Point(locationX, locationY);
            lblOperation.Visible = true;
            lblOperation.Text = cmbOperations.SelectedItem.ToString();
            string operation;
            if (cmbOperations.SelectedItem != null)
            {
                operation = cmbOperations.SelectedItem.ToString();
            }
            else
            {
                operation = "";
            }
            int number01 = Convert.ToInt32(nudNumber01.Value);
            int number02 = Convert.ToInt32(nudNumber02.Value);
            writeResult(number01, number02, operation);
        }

        private void nudNumber01_ValueChanged(object sender, EventArgs e)
        {
            string operation;
            if (cmbOperations.SelectedItem != null)
            {
                operation = cmbOperations.SelectedItem.ToString();
            }
            else
            {
                operation = "";
            }
            int number01 = Convert.ToInt32(nudNumber01.Value);
            int number02 = Convert.ToInt32(nudNumber02.Value);
            writeResult(number01, number02, operation);
        }

        private void writeResult(int number01, int number02, string operation)
        {
            switch (operation)
            {
                case "+":
                    lblResult.Text = (number01 + number02).ToString();
                    break;
                case "-":
                    lblResult.Text = (number01 - number02).ToString();
                    break;
                case "*":
                    lblResult.Text = (number01 * number02).ToString();
                    break;
                case "%":
                    lblResult.Text = (number01 % number02).ToString();
                    break;
                case "/":
                    if (number02 == 0)
                    {
                        MessageBox.Show("0-a bolmek olmaz!", "Xeta", MessageBoxButtons.OK);
                        break;
                    }
                    else
                    {
                        lblResult.Text = ((double)number01 / number02).ToString();
                    }
                    break;
                default:
                    MessageBox.Show("Gozlenilmez xeta bas verdi!", "Xeta", MessageBoxButtons.OK);
                    break;
            }
            int locationX = x - lblResult.Size.Width;
            int locationY = lblResult.Location.Y;
            lblResult.Location = new Point(locationX, locationY);
        }

        private void nudNumber02_ValueChanged(object sender, EventArgs e)
        {
            string operation;
            if (cmbOperations.SelectedItem != null)
            {
                operation = cmbOperations.SelectedItem.ToString();
            }
            else
            {
                operation = "";
            }
            int number01 = Convert.ToInt32(nudNumber01.Value);
            int number02 = Convert.ToInt32(nudNumber02.Value);
            writeResult(number01, number02, operation);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task06
{
    public partial class Task06 : Form
    {
        public Task06()
        {
            InitializeComponent();
        }
        // Global Variables
        Color color;

        private void Task06_Load(object sender, EventArgs e)
        {
            resizeColumns();
            loadCarData();
            dtpYear.Enabled = false;
            btnColor.Enabled = false;
        }
        
        // Load Data
        private void loadCarData()
        {
            // brand
            cbBrand.Items.Add("Audi");
            cbBrand.Items.Add("Mercedes-benz");
            cbBrand.Items.Add("Mitsubishi");
            cbBrand.Items.Add("BMW");

            // model 
            cbModel.Items.Add("Model01");
            cbModel.Items.Add("Model02");
            cbModel.Items.Add("Model03");
            cbModel.Enabled = false;

            // fuel
            cbFuel.Items.Add("Benzin");
            cbFuel.Items.Add("Disel");
            cbFuel.Enabled = false;

            // body_style
            cbBodyStyle.Items.Add("Sedan");
            cbBodyStyle.Items.Add("Cip");
            cbBodyStyle.Items.Add("Pikap");
            cbBodyStyle.Enabled = false;

            // transmission
            cbTransmissionType.Items.Add("Avtomat");
            cbTransmissionType.Items.Add("Mexanika");
            cbTransmissionType.Enabled = false;

            // motor
            cbMotorType.Items.Add("2.0 L");
            cbMotorType.Items.Add("2.5 L");
            cbMotorType.Items.Add("3.0 L");
            cbMotorType.Enabled = false;

        }

        private void clearInputs()
        {
            cbBrand.SelectedIndex = -1;

            cbModel.SelectedIndex = -1;
            cbModel.Enabled = false;

            cbFuel.SelectedIndex = -1;
            cbFuel.Enabled = false;

            cbBodyStyle.SelectedIndex = -1;
            cbBodyStyle.Enabled = false;

            cbTransmissionType.SelectedIndex = -1;
            cbTransmissionType.Enabled = false;

            cbMotorType.SelectedIndex = -1;
            cbMotorType.Enabled = false;

            dtpYear.Enabled = false;
            btnColor.Enabled = false;
        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbModel.Enabled = true;
        }

        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFuel.Enabled = true;
        }

        private void cbFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBodyStyle.Enabled = true;
        }

        private void cbBodyStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTransmissionType.Enabled = true;
        }

        private void cbTransmissionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMotorType.Enabled = true;
        }

        private void cbMotorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpYear.Enabled = true;
            dtpYear.Format = DateTimePickerFormat.Custom;
            dtpYear.CustomFormat = "yyyy";
            dtpYear.ShowUpDown = true;
        }

        private void dtpYear_ValueChanged(object sender, EventArgs e)
        {
            btnColor.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string brand = cbBrand.SelectedItem.ToString();
            string model = cbModel.SelectedItem.ToString();
            string fuel = cbFuel.SelectedItem.ToString();
            string body_style = cbBodyStyle.SelectedItem.ToString();
            string transmission = cbTransmissionType.SelectedItem.ToString();
            string motor = cbMotorType.SelectedItem.ToString();
            string year = dtpYear.Value.ToString("yyyy");
            
            ListViewItem car = new ListViewItem(brand);
            car.SubItems.Add(model);
            car.SubItems.Add(fuel);
            car.SubItems.Add(body_style);
            car.SubItems.Add(transmission);
            car.SubItems.Add(motor);
            car.SubItems.Add(year);
            car.SubItems.Add("");
            car.UseItemStyleForSubItems = false;
            car.SubItems[car.SubItems.Count - 1].BackColor = color;

            lvCars.Items.Add(car);
            clearInputs();

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;
                color = colorDialog.Color;
            }
        }

        // Method for column sizing
        private void resizeColumns()
        {
            int columnWidth = (lvCars.Width - 5) / lvCars.Columns.Count;
            foreach (ColumnHeader column in lvCars.Columns)
            {
                column.Width = columnWidth;
            }
        }
    }
}

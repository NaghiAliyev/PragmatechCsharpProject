using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task01
{
    public partial class OnlineOrder : Form
    {
        public OnlineOrder()
        {
            InitializeComponent();
        }

        //Global Variables
        string[] categories;
        List<Product> products;

        private void OnlineOrder_Load(object sender, EventArgs e)
        {
            nudPrice.ReadOnly = true;
            nudPrice.Increment = 0;
            MakeFakeData();
            AddDataToCmb();
        }

        private void MakeFakeData()
        {
            // Categories
            categories = new string[] { "Kateqoriya01", "Kateqoriya02", "Kateqoriya03" };

            // Products
            products = new List<Product>();
            foreach (string category in categories)
            {
                Random random = new Random();
                int count = random.Next(1,5);
                for (int i = 0; i < count; i++)
                {
                    Product product = new Product
                    {
                        Category = category,
                        Name = $"Mehsul0{i + 1}",
                        Price = random.Next(1, 10)
                    };
                    products.Add(product);
                }
            }
        }

        private void AddDataToCmb()
        {
            // Categories
            foreach (string category in categories)
            {
                cmbCategories.Items.Add(category);
            }

            // Delivery Methods
            cmbDeliveryMethods.Items.Add("Poçt01");
            cmbDeliveryMethods.Items.Add("Poçt02");
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedIndex != -1)
            {
                cmbProductNames.Items.Clear();
                string selectedCategory = cmbCategories.SelectedItem.ToString();
                foreach (Product product in products)
                {
                    if (product.Category == selectedCategory)
                    {
                        cmbProductNames.Items.Add(product.Name);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckForNulls())
            {
                Order order = new Order
                {
                    OrderedProduct = FindProduct(),
                    Date = dtpDeliveryDate.Value,
                    DeliveryMethod = cmbDeliveryMethods.SelectedItem.ToString(),
                    Weight = Convert.ToInt32(nudWeight.Value)
                };
                order.CalculateOrderPrice();

                ListViewItem item = new ListViewItem(order.OrderedProduct.Name);
                item.SubItems.Add(order.Weight.ToString());
                item.SubItems.Add(order.OrderedProduct.Price.ToString());
                item.SubItems.Add(order.Price.ToString());
                item.SubItems.Add(order.DeliveryMethod);
                item.SubItems.Add(order.Date.ToString("dd/MM/yyyy"));

                lvOrders.Items.Add(item);

                ClearControls();
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun!", "Xəta", MessageBoxButtons.OK);
            }
        }
        
        private void ClearControls()
        {
            cmbCategories.SelectedIndex = -1;
            cmbProductNames.SelectedIndex = -1;
            cmbDeliveryMethods.SelectedIndex = -1;
            nudPrice.Value = 0;
            nudWeight.Value = 0;
        }

        private Product FindProduct()
        {
            Product selectedProduct;
            string selectedCategory = cmbCategories.SelectedItem.ToString();
            string selectedProductName = cmbProductNames.SelectedItem.ToString();
            foreach (Product product in products)
            {
                if (product.Category == selectedCategory && product.Name == selectedProductName)
                {
                    //selectedProduct = product;
                    return product;
                    break;
                }
            }
            //return selectedProduct; // I can not find the cause of the error 
            return new Product();
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            int count = lvOrders.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                lvOrders.Items.Remove(lvOrders.SelectedItems[0]);
            }
        }

        private void lvOrders_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnRemoveOrder_Click(sender, e);
            }
        }

        private bool CheckForNulls()
        {
            if (cmbCategories.SelectedIndex == -1 || cmbDeliveryMethods.SelectedIndex == -1 || cmbProductNames.SelectedIndex == -1 || nudWeight.Value == 0)
            {
                return false;
            }
            return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in lvOrders.Items)
            {
                if (item.Text == tbSearchText.Text.Trim())
                {
                    count++;
                }
            }
            if (count != 0)
            {
                MessageBox.Show($"Sifarişlərin içərisində {count} sayda {tbSearchText.Text.Trim()} məhsulu var");
            }
            else
            {
                MessageBox.Show($"Sifarişlərin içərisində {tbSearchText.Text.Trim()} məhsulu yoxdur");
            }
        }
    }
}

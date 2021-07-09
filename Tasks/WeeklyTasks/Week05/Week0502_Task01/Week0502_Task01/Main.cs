using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week0502_Task01
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim().ToUpper();
            lbNames.Items.Add(name);
            tbName.Clear();
            tbName.Focus();
        }

        private void btnShowCount_Click(object sender, EventArgs e)
        {
            int count = lbNames.Items.Count;
            MessageBox.Show($"ListBox-da {count} element var");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sName = tbSearch.Text.Trim().ToUpper();
            bool f = false;
            foreach (string item in lbNames.Items)
            {
                if (sName == item)
                {
                    MessageBox.Show($"ListBox-da {sName} adi var");
                    f = true;
                    break;
                }
            }
            if (!f)
            {
                MessageBox.Show($"ListBox-da {sName} adi yoxdur");
            }
            tbName.Clear();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            int count = lbNames.Items.Count;
            int[] randomIndexes = new int[count];
            for (int i = 0; i < randomIndexes.Length; i++)
            {
                randomIndexes[i] = -1;
            }
            Random random = new Random();
            for (int i = 0; i < randomIndexes.Length; i++)
            {
                int index = random.Next(count);
                while (Array.IndexOf(randomIndexes, index) != -1)
                {
                    index = random.Next(count);
                }
                randomIndexes[i] = index;
            }
            string[] names = new string[count];
            int j = 0;
            foreach(string item in lbNames.Items)
            {
                names[j++] = item;
            }
            lbNames.Items.Clear();
            for (int i = 0; i < count; i++)
            {
                lbNames.Items.Add(names[randomIndexes[i]]);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int count = lbNames.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                lbNames.Items.Remove(lbNames.SelectedItems[0]);
            }

        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void lbNames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnRemove_Click(sender, e);
            }
        }
    }
}

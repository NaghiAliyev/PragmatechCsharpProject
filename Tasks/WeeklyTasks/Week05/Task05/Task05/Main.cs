using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task05
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // Global Variables
        string name;
        string surname;
        string phoneNumber;
        string birthDate;

        private void Main_Load(object sender, EventArgs e)
        {
            resizeLVColumns();
        }

        // Method for column sizing
        private void resizeLVColumns()
        {
            int headerWidth = (lvMembers.Width-4) / lvMembers.Columns.Count;
            foreach (ColumnHeader column in lvMembers.Columns)
            {
                column.Width = headerWidth;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            name = tbName.Text.Trim();
            surname = tbSurname.Text.Trim();
            phoneNumber = mtbPhoneNumber.Text;
            birthDate = dtpBirthDate.Value.ToString("MM-dd-yyyy");

            ListViewItem member = new ListViewItem(name);
            member.SubItems.Add(surname);
            member.SubItems.Add(phoneNumber);
            member.SubItems.Add(birthDate);
            if (checkMember(member))
            {
                lvMembers.Items.Add(member);
            }
            else
            {
                MessageBox.Show("Daxil etdiyiniz melumatlara sahib bir istifadeci var!");
            }
        }

        // Method for member checking
        private bool checkMember(ListViewItem item)
        {
            foreach (ListViewItem member in lvMembers.Items)
            {
                bool f = true;
                for (int i = 0; i < member.SubItems.Count; i++)
                {
                    if (member.SubItems[i].ToString() != item.SubItems[i].ToString())
                    {
                        f = false;
                        break;
                    }
                }
                if (f)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

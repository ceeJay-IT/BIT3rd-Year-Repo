using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dataHelper;
using static dataHelper.DataHelper;

namespace LabAct3_Phonebook_Pellosis_BIT31
{
    public partial class Form1 : Form
    {
        private Phonebook phonebook = new Phonebook();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string phoneNumber = mtxtphNum.Text;
            string name = txtName.Text;

            if (phonebook.AddContact(phoneNumber, name))
            {
                RefreshDataGridView();
                MessageBox.Show("Contact added!");
            }
            else
            {
                MessageBox.Show("A contact of with the same number has been inputted.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string phoneNumber = mtxtphNum.Text.Trim();
            string name = txtName.Text.Trim();

            dataGridView1.Rows.Clear();

            Contact contact = null;

            if (!string.IsNullOrEmpty(phoneNumber) && !string.IsNullOrEmpty(name))
            {
                contact = phonebook.searchPhoneNum(phoneNumber);
                if (contact == null)
                {
                    contact = phonebook.searchName(name);
                }
            }
            else if (!string.IsNullOrEmpty(phoneNumber))
            {
                contact = phonebook.searchPhoneNum(phoneNumber);
            }
            else if (!string.IsNullOrEmpty(name))
            {
                contact = phonebook.searchName(name);
            }
            else
            {
                MessageBox.Show("Enter a Phone Number or Name to search!");
                return;
            }

            if (contact != null)
            {
                dataGridView1.Rows.Add(contact.PhoneNumber, contact.Name);
            }
            else
            {
                MessageBox.Show("Contact Not Found!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string phoneNumber = mtxtphNum.Text;
            string newName = txtName.Text;

            if (phonebook.EditContact(phoneNumber, newName))
            {
                RefreshDataGridView();
                MessageBox.Show("Contact Updated!");
            }
            else
            {
                MessageBox.Show("Contact not Found!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string phoneNumber = mtxtphNum.Text;

            if (phonebook.DeleteContact(phoneNumber))
            {
                RefreshDataGridView();
                MessageBox.Show("Contact Deleted!");
            }
            else
            {
                MessageBox.Show("Contact Not Found!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (Contact contact in phonebook.GetAllContacts())
            {
                dataGridView1.Rows.Add(contact.PhoneNumber, contact.Name);
            }
        }

        private bool IsPhoneNumber(string text)
        {
            string cleanedText = new string(text.Where(char.IsDigit).ToArray());
            return cleanedText.Length >= 10;
        }
    }
}

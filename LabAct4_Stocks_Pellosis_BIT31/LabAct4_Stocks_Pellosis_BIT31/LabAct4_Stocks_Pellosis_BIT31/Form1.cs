using dataHelp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static dataHelp.dataHelper;

namespace LabAct4_Stocks_Pellosis_BIT31
{
    public partial class Form1 : Form
    {
        public dataHelper _dataHelper;
        public ArrayList selectedProducts;
        public Calculation calculation;

        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            timer1.Start();
            Title();

            _dataHelper = new dataHelper();
            calculation = new Calculation(_dataHelper);
            PopulateGridView();
            PopulateComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Title();
        }

        private void Title()
        {
            this.Text = DateTime.Now.ToString();
        }

        public void PopulateGridView()
        {
            dataGridView1.Rows.Clear();
            ArrayList products = _dataHelper.getProducts();
            foreach (Product product in products )
            {
                dataGridView1.Rows.Add(product.prodID,  product.prodName, product.stocks);
            }
        }

        public void PopulateComboBox()
        {
            ArrayList products = _dataHelper.getProducts();
            comboBox1.Items.Clear();
            foreach (Product product in products )
            {
                comboBox1.Items.Add(product.prodID);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedID = comboBox1.SelectedItem.ToString();
            Product selectedProduct = null;

            foreach (Product product in _dataHelper.getProducts() )
            {
                if(product.prodID == selectedID)
                {
                    selectedProduct = product;
                    break;
                }
            }

            if (selectedProduct != null )
            {
                textBox1.Text = selectedProduct.prodName;
                textBox2.Text = selectedProduct.SRP.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }
            
            string selectedID = comboBox1.SelectedItem.ToString();
            Product selectedProduct = null;

            foreach (Product product in _dataHelper.getProducts())
            {
                if(product.prodID == selectedID)
                {
                    selectedProduct= product;
                    break;
                }
            }

            if (selectedProduct == null)
            {
                MessageBox.Show("Selected product not found.");
                return;
            }

            int quantity = (int)numericUpDown1.Value;

            if (selectedProduct.stocks <= 0)
            {
                MessageBox.Show("This product is out of stocks");
                return;
            }

            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a membership type.");
                return;
            }

            string membershipType = comboBox2.SelectedItem.ToString();

            var selectedProducts = new List<(Product product, int quantity)>
            {
                (selectedProduct, quantity)
            };

            decimal total = calculation.CalculateTotal(selectedProducts, membershipType);

            ListViewItem items = new ListViewItem(selectedProduct.prodID);
            items.SubItems.Add(selectedProduct.prodName);
            items.SubItems.Add(quantity.ToString());
            items.SubItems.Add(total.ToString("C"));

            listView1.Items.Add(items);

            selectedProduct.decreaseStock(quantity);
            PopulateGridView();
        }
    }
}

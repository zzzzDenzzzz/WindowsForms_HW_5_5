using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class AddingEditingForm : Form
    {
        List<Product> products;
        bool isEdit;
        int numberProduct;

        public AddingEditingForm()
        {
            InitializeComponent();
            products = new List<Product>();
            isEdit = false;
        }

        /// <summary>
        /// добаление товара в базу
        /// </summary>
        private void button_addDataBase_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].GetHashCode() == numberProduct)
                    {
                        products.RemoveAt(i);
                        break;
                    }
                }
                isEdit = false;
            }

            var product = new Product(textBox_name.Text, textBox_specification.Text,
                textBox_description.Text, decimal.Parse(textBox_price.Text));

            products.Add(product);
            comboBox_products.Items.Add(product.Name);
        }

        /// <summary>
        /// чтение товара из базы и добавление полей товара в соответствующие texBox
        /// </summary>
        private void button_edit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            foreach (Product item in products)
            {
                if (item.Name == comboBox_products.SelectedItem.ToString())
                {
                    textBox_name.Text = item.Name;
                    textBox_specification.Text = item.Specification;
                    textBox_description.Text = item.Description;
                    textBox_price.Text = item.Price.ToString();
                    numberProduct = item.GetHashCode();
                }
            }
            comboBox_products.Items.RemoveAt(comboBox_products.SelectedIndex);
        }
    }
}

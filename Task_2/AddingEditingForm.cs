using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Task_2
{
    public partial class AddingEditingForm : Form
    {
        // список товаров
        List<Product> products;
        // переменная, хранящая состояние кнопки Edit
        bool isEdit;
        // хэш-код товара
        int hashCodeProduct;
        // путь к базе данных
        string pathProduct;

        public AddingEditingForm()
        {
            InitializeComponent();
            pathProduct = "product.dat";
            products = new List<Product>();
            if (File.Exists(pathProduct))
            {
                ReadingFromFile();
            }
            isEdit = false;
        }

        /// <summary>
        /// добаление товара в базу
        /// </summary>
        private void button_addDataBase_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                RemovingProductList();
                isEdit = false;
            }

            var product = new Product(textBox_name.Text, textBox_specification.Text,
                textBox_description.Text, decimal.Parse(textBox_price.Text));

            products.Add(product);
            comboBox_products.Items.Add(product.Name);
            SaveFile();
            button_edit.Enabled = true;
        }

        /// <summary>
        /// чтение товара из базы и добавление полей товара в соответствующие texBox
        /// </summary>
        private void button_edit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            button_edit.Enabled = false;
            foreach (Product item in products)
            {
                if (item.Name == comboBox_products.SelectedItem.ToString())
                {
                    textBox_name.Text = item.Name;
                    textBox_specification.Text = item.Specification;
                    textBox_description.Text = item.Description;
                    textBox_price.Text = item.Price.ToString();
                    hashCodeProduct = item.GetHashCode();
                }
            }
            comboBox_products.Items.RemoveAt(comboBox_products.SelectedIndex);
        }

        /// <summary>
        /// сохранение базы в файл
        /// </summary>
        void SaveFile()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(pathProduct, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, products);
            }
        }

        /// <summary>
        /// чтение из файла
        /// </summary>
        void ReadingFromFile()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(pathProduct, FileMode.OpenOrCreate))
            {
                products = (List<Product>)formatter.Deserialize(fs);
                foreach (Product item in products)
                {
                    comboBox_products.Items.Add(item.Name);
                }
            }
        }

        /// <summary>
        /// удаление товара из List при редактировании
        /// </summary>
        void RemovingProductList()
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].GetHashCode() == hashCodeProduct)
                {
                    products.RemoveAt(i);
                    break;
                }
            }
        }
    }
}

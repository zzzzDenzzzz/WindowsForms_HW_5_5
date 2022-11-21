using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

/*Фирма продает составляющие компьютера. Первая форма отвечает за учет продаж,
 * вторая за добавление и редактирование составляющих.
 Первая форма:
    Список,  выпадающий  список,  текстовое  поле,  кнопка  вызова 
    второй формы. В выпадающем списке появляются наименования 
    всех товаров, которые в наличие в магазине. Пользователь выбира-
    ет товар, в текстовом окне, которое нельзя редактировать, появля-
    ется цена. Пользователь нажимает «добавить» и товар добавляется 
    в  список  продаж.  Также  должно  быть  окошко,  которое  выводит 
    общую стоимость.
Вторая форма:
    Информация о комплектующих (наименование, характеристика, 
    описание и цена) вводится в текстовые поля; в список добавляется 
    текстовая  строка,  содержащая  информацию  о  товаре,  кроме  цены, 
    цена в списке не видна, но содержится; также комплектующие можно 
    редактировать.*/

namespace Task_2
{
    public partial class Form1 : Form
    {
        List<Product> products;
        string pathProduct;
        // общая сумма
        decimal totalCost;

        public Form1()
        {
            pathProduct = "product.dat";
            products = new List<Product>();
            InitializeComponent();
            if (File.Exists(pathProduct))
            {
                FillingComboBox();
            }
        }

        /// <summary>
        /// вызов формы добаления и редактирования товаров
        /// </summary>
        private void button_addProduct_Click(object sender, EventArgs e)
        {
            AddingEditingForm form = new AddingEditingForm();
            form.ShowDialog();
        }

        /// <summary>
        /// заполнение comboBox
        /// </summary>
        void FillingComboBox()
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
        /// добавляет в список товары
        /// </summary>
        private void button_add_Click(object sender, EventArgs e)
        {
            listBox_salesList.Items.Add(comboBox_products.SelectedItem);
            FillingPriceTextBox();
        }

        /// <summary>
        /// заполняет textBox с ценой
        /// </summary>
        void FillingPriceTextBox()
        {
            foreach (Product item in products)
            {
                if (item.Name == comboBox_products.SelectedItem.ToString())
                {
                    textBox_price.Text = item.Price;
                }
            }
            TotalCost(textBox_price.Text);
        }

        /// <summary>
        /// подсчет общей стоимости
        /// </summary>
        void TotalCost(string price)
        {
            if (decimal.TryParse(price, out decimal cost))
            {
                totalCost += cost;
            }
            textBox_totalCost.Text = totalCost.ToString();
        }
    }
}

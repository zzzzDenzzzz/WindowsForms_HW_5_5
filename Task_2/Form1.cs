using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// вызов формы добаления и редактирования товаров
        /// </summary>
        private void button_addProduct_Click(object sender, EventArgs e)
        {
            AddingEditingForm form = new AddingEditingForm();
            form.ShowDialog();
        }
    }
}

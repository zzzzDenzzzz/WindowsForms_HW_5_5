using System;
using System.Windows.Forms;

/*Разработайте  программу,  которая  позволяет  пользователю  осу-
ществлять поиск файлов по заданному критерию. Приложение состо-
ит из двух форм – главное окно и окно поиска. Пользователь может 
открыть сколько угодно окон для поиска. Окно поиска запускается 
немодально. В окне поиска пользователь выбирает папку, в которой 
будет идти поиск и вводит маску поиска, например «*.doc». Найден-
ные файлы отображаются в списке.*/

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            button_close.Click += button_close_Click;
            button_search.Click += button_search_Click;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Show();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

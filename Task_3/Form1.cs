using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Разработайте приложение, которое состоит из двух форм. Первая 
форма содержит TextBox доступный только для чтения и две кнопки 
«загрузить файл» и «редактировать». Кнопка «редактировать» изна-
чально неактивна. При нажатии на первую кнопку, открывается диа-
лог и пользователю предлагают выбрать текстовый файл. Выбранный 
файл загружается в TextBox и кнопка «редактировать» становится ак-
тивной. При нажатии на вторую кнопку открывается вторая форма 
(не модально), которая содержит TextBox доступный для редактиро-
вания и две кнопки «Сохранить» и «Отменить». При нажатии на пер-
вую кнопку изменения отображаются в TextBox первой формы.*/

namespace Task_3
{
    public partial class Form1 : Form
    {
        public string MainText
        {
            get { return tfr_tb_fileText.Text; }
            set { tfr_tb_fileText.Text = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            tfr_b_openFile.Click += Tfr_b_openFile_Click;
            tfr_b_editText.Click += Tfr_b_editText_Click;
        }

        /// <summary>
        /// Обработка нажатия кнопки редактирования
        /// </summary>
        private void Tfr_b_editText_Click(object sender, EventArgs e)
        {
            EditForm ef = new EditForm(this);
            ef.Show();
        }

        /// <summary>
        /// Обработка нажатия кнопки открытия файла
        /// </summary>
        private void Tfr_b_openFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "text files (*.txt)|*.txt";      //задает фильтры для выбора файлов
            ofd.FilterIndex = 1;                        //задает выбраный фильтр по умолчанию
            ofd.RestoreDirectory = true;                //восстанавливает ранее выбранный каталог

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MainText = File.ReadAllText(ofd.FileName, Encoding.Default);

                ofd.Dispose();

                tfr_b_editText.Enabled = true;
            }
        }
    }
}

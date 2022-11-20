using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Task_1
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            button_openFolder.Click += button_openFolder_Click;
            textBox_masks.TextChanged += textBox_masks_TextChanged;
            button_startSearch.Click += button_startSearch_Click;
        }

        /// <summary>
        /// Запуск процедуры поиска файлов
        /// </summary>
        private void button_startSearch_Click(object sender, EventArgs e)
        {
            listBox_files.Items.Clear(); //очищаю список

            string[] masks = textBox_masks.Text.Split('.').ToArray(); //разбиваю введенную маску на массив для проверки

            if (masks.Count() != 2 || masks[1] == "")
            {
                MessageBox.Show("Вы ввели не правильную маску.\rМаска должна быть вида *.*", "Ошибка ввода маски!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox_files.Cursor = Cursors.WaitCursor;
                Cursor = Cursors.WaitCursor;

                foreach (var file in Directory.GetFiles(statusLabel_path.Text, textBox_masks.Text))
                {
                    listBox_files.Items.Add(file.ToString());
                }

                MessageBox.Show("Нашлось " + listBox_files.Items.Count.ToString() + " файлов", "Результат добавления",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Cursor = Cursors.Default;
                listBox_files.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Изменение текста в поле для ввода маски
        /// </summary>
        private void textBox_masks_TextChanged(object sender, EventArgs e)
        {
            if (textBox_masks.Text.Length > 0)
            {
                button_startSearch.Enabled = true;
            }
            else
            {
                button_startSearch.Enabled = false;
            }
        }

        /// <summary>
        /// При нажатии на кнопку открывется диалог выбора папки для поиска файла
        /// </summary>
        private void button_openFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dir = new FolderBrowserDialog();
            // Т.к. у нас предусмотрен только поиск, то пользователю не нужна возможность содавать папки
            dir.ShowNewFolderButton = false; 

            if (dir.ShowDialog() == DialogResult.OK)
            {
                statusLabel_path.Text = dir.SelectedPath;
                textBox_masks.Enabled = true;
                textBox_masks.Focus();
            }
            else
            {
                statusLabel_path.Text = "";
                textBox_masks.Text = "";
                if (textBox_masks.Enabled)
                {
                    textBox_masks.Enabled = false;
                }
            }
        }
    }
}

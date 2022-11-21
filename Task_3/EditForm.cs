using System;
using System.Windows.Forms;

namespace Task_3
{
    public partial class EditForm : Form
    {
        public Form1 MainForm;

        public EditForm(Form1 form1)
        {
            MainForm = form1;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            ef_b_save.Click += Ef_b_save_Click;
            ef_tb_edit.Text = MainForm.MainText;
            ef_b_cansel.Click += Ef_b_cansel_Click;
        }

        /// <summary>
        /// Обработка нажатия кнопки отмена
        /// </summary>
        private void Ef_b_cansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обработка нажатия кнопки схранить
        /// </summary>
        private void Ef_b_save_Click(object sender, EventArgs e)
        {
            MainForm.MainText = ef_tb_edit.Text;
            Close();
        }
    }
}

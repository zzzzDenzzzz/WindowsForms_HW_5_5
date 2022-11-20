namespace Task_2
{
    partial class AddingEditingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_name = new System.Windows.Forms.Label();
            this.label_specification = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_specification = new System.Windows.Forms.TextBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.button_addDataBase = new System.Windows.Forms.Button();
            this.label_products = new System.Windows.Forms.Label();
            this.comboBox_products = new System.Windows.Forms.ComboBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(12, 9);
            this.label_name.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(134, 20);
            this.label_name.TabIndex = 10;
            this.label_name.Text = "Наименование";
            // 
            // label_specification
            // 
            this.label_specification.AutoSize = true;
            this.label_specification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_specification.Location = new System.Drawing.Point(12, 44);
            this.label_specification.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label_specification.Name = "label_specification";
            this.label_specification.Size = new System.Drawing.Size(148, 20);
            this.label_specification.TabIndex = 11;
            this.label_specification.Text = "Характеристика";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_description.Location = new System.Drawing.Point(12, 79);
            this.label_description.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(91, 20);
            this.label_description.TabIndex = 12;
            this.label_description.Text = "Описание";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_price.Location = new System.Drawing.Point(12, 114);
            this.label_price.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(52, 20);
            this.label_price.TabIndex = 13;
            this.label_price.Text = "Цена";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(166, 9);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(622, 20);
            this.textBox_name.TabIndex = 14;
            // 
            // textBox_specification
            // 
            this.textBox_specification.Location = new System.Drawing.Point(166, 44);
            this.textBox_specification.Multiline = true;
            this.textBox_specification.Name = "textBox_specification";
            this.textBox_specification.Size = new System.Drawing.Size(622, 20);
            this.textBox_specification.TabIndex = 15;
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(166, 79);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(622, 20);
            this.textBox_description.TabIndex = 16;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(166, 114);
            this.textBox_price.Multiline = true;
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(622, 20);
            this.textBox_price.TabIndex = 17;
            // 
            // button_addDataBase
            // 
            this.button_addDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addDataBase.Location = new System.Drawing.Point(16, 152);
            this.button_addDataBase.Name = "button_addDataBase";
            this.button_addDataBase.Size = new System.Drawing.Size(367, 52);
            this.button_addDataBase.TabIndex = 18;
            this.button_addDataBase.Text = "Добавить в базу данных";
            this.button_addDataBase.UseVisualStyleBackColor = true;
            this.button_addDataBase.Click += new System.EventHandler(this.button_addDataBase_Click);
            // 
            // label_products
            // 
            this.label_products.AutoSize = true;
            this.label_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_products.Location = new System.Drawing.Point(12, 221);
            this.label_products.Name = "label_products";
            this.label_products.Size = new System.Drawing.Size(287, 20);
            this.label_products.TabIndex = 20;
            this.label_products.Text = "Товары, которые есть в наличие";
            // 
            // comboBox_products
            // 
            this.comboBox_products.FormattingEnabled = true;
            this.comboBox_products.Location = new System.Drawing.Point(16, 255);
            this.comboBox_products.Name = "comboBox_products";
            this.comboBox_products.Size = new System.Drawing.Size(367, 21);
            this.comboBox_products.Sorted = true;
            this.comboBox_products.TabIndex = 19;
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edit.Location = new System.Drawing.Point(16, 304);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(367, 52);
            this.button_edit.TabIndex = 21;
            this.button_edit.Text = "Редактировать";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Task_2.Properties.Resources.Computer_Hardware_Notebook_icon;
            this.pictureBox1.Location = new System.Drawing.Point(389, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // AddingEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.label_products);
            this.Controls.Add(this.comboBox_products);
            this.Controls.Add(this.button_addDataBase);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.textBox_specification);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_specification);
            this.Controls.Add(this.label_name);
            this.Name = "AddingEditingForm";
            this.Text = "Добавление и редактирование товаров";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_specification;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_specification;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Button button_addDataBase;
        private System.Windows.Forms.Label label_products;
        private System.Windows.Forms.ComboBox comboBox_products;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
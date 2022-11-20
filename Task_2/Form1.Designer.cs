namespace Task_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_salesList = new System.Windows.Forms.ListBox();
            this.label_price = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.comboBox_products = new System.Windows.Forms.ComboBox();
            this.label_totalCost = new System.Windows.Forms.Label();
            this.textBox_totalCost = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_editProduct = new System.Windows.Forms.Button();
            this.label_salesList = new System.Windows.Forms.Label();
            this.label_products = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_salesList
            // 
            this.listBox_salesList.FormattingEnabled = true;
            this.listBox_salesList.Location = new System.Drawing.Point(386, 37);
            this.listBox_salesList.MultiColumn = true;
            this.listBox_salesList.Name = "listBox_salesList";
            this.listBox_salesList.Size = new System.Drawing.Size(402, 264);
            this.listBox_salesList.Sorted = true;
            this.listBox_salesList.TabIndex = 0;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_price.Location = new System.Drawing.Point(12, 305);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(131, 20);
            this.label_price.TabIndex = 1;
            this.label_price.Text = "Цена за товар";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(154, 305);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.ReadOnly = true;
            this.textBox_price.Size = new System.Drawing.Size(226, 20);
            this.textBox_price.TabIndex = 2;
            // 
            // comboBox_products
            // 
            this.comboBox_products.FormattingEnabled = true;
            this.comboBox_products.Location = new System.Drawing.Point(16, 37);
            this.comboBox_products.Name = "comboBox_products";
            this.comboBox_products.Size = new System.Drawing.Size(367, 21);
            this.comboBox_products.TabIndex = 3;
            // 
            // label_totalCost
            // 
            this.label_totalCost.AutoSize = true;
            this.label_totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_totalCost.Location = new System.Drawing.Point(382, 305);
            this.label_totalCost.Name = "label_totalCost";
            this.label_totalCost.Size = new System.Drawing.Size(161, 20);
            this.label_totalCost.TabIndex = 4;
            this.label_totalCost.Text = "Общая стоимость";
            // 
            // textBox_totalCost
            // 
            this.textBox_totalCost.Location = new System.Drawing.Point(549, 307);
            this.textBox_totalCost.Name = "textBox_totalCost";
            this.textBox_totalCost.ReadOnly = true;
            this.textBox_totalCost.Size = new System.Drawing.Size(239, 20);
            this.textBox_totalCost.TabIndex = 5;
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(16, 331);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(364, 52);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Добавить в список продаж";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // button_editProduct
            // 
            this.button_editProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_editProduct.Location = new System.Drawing.Point(386, 331);
            this.button_editProduct.Name = "button_editProduct";
            this.button_editProduct.Size = new System.Drawing.Size(402, 52);
            this.button_editProduct.TabIndex = 7;
            this.button_editProduct.Text = "Редактор товара";
            this.button_editProduct.UseVisualStyleBackColor = true;
            this.button_editProduct.Click += new System.EventHandler(this.button_addProduct_Click);
            // 
            // label_salesList
            // 
            this.label_salesList.AutoSize = true;
            this.label_salesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_salesList.Location = new System.Drawing.Point(382, 9);
            this.label_salesList.Name = "label_salesList";
            this.label_salesList.Size = new System.Drawing.Size(138, 20);
            this.label_salesList.TabIndex = 8;
            this.label_salesList.Text = "Список продаж";
            // 
            // label_products
            // 
            this.label_products.AutoSize = true;
            this.label_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_products.Location = new System.Drawing.Point(12, 9);
            this.label_products.Name = "label_products";
            this.label_products.Size = new System.Drawing.Size(287, 20);
            this.label_products.TabIndex = 9;
            this.label_products.Text = "Товары, которые есть в наличие";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Task_2.Properties.Resources.Computer_Hardware_Notebook_icon;
            this.pictureBox.Location = new System.Drawing.Point(16, 64);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(364, 235);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label_products);
            this.Controls.Add(this.label_salesList);
            this.Controls.Add(this.button_editProduct);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_totalCost);
            this.Controls.Add(this.label_totalCost);
            this.Controls.Add(this.comboBox_products);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.listBox_salesList);
            this.Name = "Form1";
            this.Text = "Учет продаж";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_salesList;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.ComboBox comboBox_products;
        private System.Windows.Forms.Label label_totalCost;
        private System.Windows.Forms.TextBox textBox_totalCost;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_editProduct;
        private System.Windows.Forms.Label label_salesList;
        private System.Windows.Forms.Label label_products;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}


namespace Task_1
{
    partial class SearchForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel_path = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_masks = new System.Windows.Forms.TextBox();
            this.button_startSearch = new System.Windows.Forms.Button();
            this.listBox_files = new System.Windows.Forms.ListBox();
            this.button_openFolder = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_path});
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(370, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            // 
            // statusLabel_path
            // 
            this.statusLabel_path.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusLabel_path.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusLabel_path.Name = "statusLabel_path";
            this.statusLabel_path.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Маска поиска";
            // 
            // textBox_masks
            // 
            this.textBox_masks.Enabled = false;
            this.textBox_masks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_masks.Location = new System.Drawing.Point(202, 15);
            this.textBox_masks.Name = "textBox_masks";
            this.textBox_masks.Size = new System.Drawing.Size(100, 29);
            this.textBox_masks.TabIndex = 3;
            // 
            // button_startSearch
            // 
            this.button_startSearch.Enabled = false;
            this.button_startSearch.Image = global::Task_1.Properties.Resources.FauxS_XP__Cobalt__V1_5_Icon_28;
            this.button_startSearch.Location = new System.Drawing.Point(311, 11);
            this.button_startSearch.Name = "button_startSearch";
            this.button_startSearch.Size = new System.Drawing.Size(49, 36);
            this.button_startSearch.TabIndex = 4;
            this.button_startSearch.UseVisualStyleBackColor = true;
            // 
            // listBox_files
            // 
            this.listBox_files.Enabled = false;
            this.listBox_files.FormattingEnabled = true;
            this.listBox_files.Location = new System.Drawing.Point(12, 56);
            this.listBox_files.Name = "listBox_files";
            this.listBox_files.Size = new System.Drawing.Size(346, 290);
            this.listBox_files.TabIndex = 5;
            // 
            // button_openFolder
            // 
            this.button_openFolder.Image = global::Task_1.Properties.Resources.FauxS_XP__Cobalt__V1_5_Icon_25;
            this.button_openFolder.Location = new System.Drawing.Point(12, 12);
            this.button_openFolder.Name = "button_openFolder";
            this.button_openFolder.Size = new System.Drawing.Size(46, 35);
            this.button_openFolder.TabIndex = 1;
            this.button_openFolder.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 382);
            this.Controls.Add(this.listBox_files);
            this.Controls.Add(this.button_startSearch);
            this.Controls.Add(this.textBox_masks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_openFolder);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.Text = "Окно поиска";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_path;
        private System.Windows.Forms.Button button_openFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_masks;
        private System.Windows.Forms.Button button_startSearch;
        private System.Windows.Forms.ListBox listBox_files;
    }
}
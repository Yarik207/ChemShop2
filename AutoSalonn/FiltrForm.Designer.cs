namespace InternetShopofChemistryStuff
{
    partial class FiltrForm
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
            this.FindButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TypeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.FiltrPanel = new System.Windows.Forms.Panel();
            this.ReactivePanel = new System.Windows.Forms.Panel();
            this.FiltrPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.Location = new System.Drawing.Point(738, 2);
            this.FindButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(128, 37);
            this.FindButton.TabIndex = 17;
            this.FindButton.Text = "Показать";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(383, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Тип товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 50);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ценовая категория\r\nруб.";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(196, 39);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(191, 30);
            this.priceTextBox.TabIndex = 21;
            this.priceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.priceTextBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Название";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(196, 2);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(191, 30);
            this.NameTextBox.TabIndex = 27;
            this.NameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameTextBox_KeyDown);
            // 
            // TypeCheckedListBox
            // 
            this.TypeCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeCheckedListBox.FormattingEnabled = true;
            this.TypeCheckedListBox.Items.AddRange(new object[] {
            "Оксиды и металлы",
            "Кислоты",
            "Индикаторы",
            "Гидроксиды",
            "Защита",
            "Посуда",
            "Оборудование"});
            this.TypeCheckedListBox.Location = new System.Drawing.Point(514, 2);
            this.TypeCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TypeCheckedListBox.Name = "TypeCheckedListBox";
            this.TypeCheckedListBox.Size = new System.Drawing.Size(217, 104);
            this.TypeCheckedListBox.TabIndex = 28;
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.Controls.Add(this.TypeCheckedListBox);
            this.FiltrPanel.Controls.Add(this.FindButton);
            this.FiltrPanel.Controls.Add(this.NameTextBox);
            this.FiltrPanel.Controls.Add(this.label1);
            this.FiltrPanel.Controls.Add(this.label4);
            this.FiltrPanel.Controls.Add(this.label3);
            this.FiltrPanel.Controls.Add(this.priceTextBox);
            this.FiltrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FiltrPanel.Location = new System.Drawing.Point(0, 0);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(884, 108);
            this.FiltrPanel.TabIndex = 29;
            // 
            // ReactivePanel
            // 
            this.ReactivePanel.AutoScroll = true;
            this.ReactivePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReactivePanel.Location = new System.Drawing.Point(0, 108);
            this.ReactivePanel.Name = "ReactivePanel";
            this.ReactivePanel.Size = new System.Drawing.Size(884, 478);
            this.ReactivePanel.TabIndex = 30;
            this.ReactivePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ReactivePanel_Paint);
            // 
            // FiltrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 586);
            this.Controls.Add(this.ReactivePanel);
            this.Controls.Add(this.FiltrPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FiltrForm";
            this.Text = "Выбери товар";
            this.Load += new System.EventHandler(this.FiltrForm_Load);
            this.FiltrPanel.ResumeLayout(false);
            this.FiltrPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.CheckedListBox TypeCheckedListBox;
        private System.Windows.Forms.Panel FiltrPanel;
        private System.Windows.Forms.Panel ReactivePanel;
    }
}
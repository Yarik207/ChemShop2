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
            this.components = new System.ComponentModel.Container();
            this.FindButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinPriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TypeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.FiltrPanel = new System.Windows.Forms.Panel();
            this.HideButton = new System.Windows.Forms.Button();
            this.ReactivePanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MaxPriceTextBox = new System.Windows.Forms.TextBox();
            this.MinPraceLabel = new System.Windows.Forms.Label();
            this.MaxPraceLabel = new System.Windows.Forms.Label();
            this.FiltrPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.Location = new System.Drawing.Point(558, 25);
            this.FindButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(96, 30);
            this.FindButton.TabIndex = 17;
            this.FindButton.Text = "Показать";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(292, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Тип товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 40);
            this.label3.TabIndex = 20;
            this.label3.Text = "Цена \r\nруб.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MinPriceTextBox
            // 
            this.MinPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinPriceTextBox.Location = new System.Drawing.Point(152, 58);
            this.MinPriceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinPriceTextBox.Name = "MinPriceTextBox";
            this.MinPriceTextBox.Size = new System.Drawing.Size(144, 26);
            this.MinPriceTextBox.TabIndex = 21;
            this.MinPriceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            this.MinPriceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.priceTextBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Название";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(152, 25);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(144, 26);
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
            this.TypeCheckedListBox.Location = new System.Drawing.Point(390, 25);
            this.TypeCheckedListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TypeCheckedListBox.Name = "TypeCheckedListBox";
            this.TypeCheckedListBox.Size = new System.Drawing.Size(164, 67);
            this.TypeCheckedListBox.TabIndex = 28;
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.Controls.Add(this.MaxPriceTextBox);
            this.FiltrPanel.Controls.Add(this.MaxPraceLabel);
            this.FiltrPanel.Controls.Add(this.MinPraceLabel);
            this.FiltrPanel.Controls.Add(this.HideButton);
            this.FiltrPanel.Controls.Add(this.TypeCheckedListBox);
            this.FiltrPanel.Controls.Add(this.FindButton);
            this.FiltrPanel.Controls.Add(this.NameTextBox);
            this.FiltrPanel.Controls.Add(this.label1);
            this.FiltrPanel.Controls.Add(this.label4);
            this.FiltrPanel.Controls.Add(this.label3);
            this.FiltrPanel.Controls.Add(this.MinPriceTextBox);
            this.FiltrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FiltrPanel.Location = new System.Drawing.Point(0, 0);
            this.FiltrPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(663, 114);
            this.FiltrPanel.TabIndex = 29;
            this.FiltrPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FiltrPanel_Paint);
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point(13, 0);
            this.HideButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(119, 24);
            this.HideButton.TabIndex = 29;
            this.HideButton.Text = "Скрыть панель ";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click_1);
            // 
            // ReactivePanel
            // 
            this.ReactivePanel.AutoScroll = true;
            this.ReactivePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReactivePanel.Location = new System.Drawing.Point(0, 114);
            this.ReactivePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReactivePanel.Name = "ReactivePanel";
            this.ReactivePanel.Size = new System.Drawing.Size(663, 362);
            this.ReactivePanel.TabIndex = 30;
            this.ReactivePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ReactivePanel_Paint);
            this.ReactivePanel.Resize += new System.EventHandler(this.ReactivePanel_Resize);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // MaxPriceTextBox
            // 
            this.MaxPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxPriceTextBox.Location = new System.Drawing.Point(152, 88);
            this.MaxPriceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaxPriceTextBox.Name = "MaxPriceTextBox";
            this.MaxPriceTextBox.Size = new System.Drawing.Size(144, 26);
            this.MaxPriceTextBox.TabIndex = 30;
            // 
            // MinPraceLabel
            // 
            this.MinPraceLabel.AutoSize = true;
            this.MinPraceLabel.Location = new System.Drawing.Point(110, 58);
            this.MinPraceLabel.Name = "MinPraceLabel";
            this.MinPraceLabel.Size = new System.Drawing.Size(20, 13);
            this.MinPraceLabel.TabIndex = 31;
            this.MinPraceLabel.Text = "От";
            // 
            // MaxPraceLabel
            // 
            this.MaxPraceLabel.AutoSize = true;
            this.MaxPraceLabel.Location = new System.Drawing.Point(110, 96);
            this.MaxPraceLabel.Name = "MaxPraceLabel";
            this.MaxPraceLabel.Size = new System.Drawing.Size(22, 13);
            this.MaxPraceLabel.TabIndex = 32;
            this.MaxPraceLabel.Text = "До";
            // 
            // FiltrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 476);
            this.Controls.Add(this.ReactivePanel);
            this.Controls.Add(this.FiltrPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FiltrForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox MinPriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.CheckedListBox TypeCheckedListBox;
        private System.Windows.Forms.Panel FiltrPanel;
        private System.Windows.Forms.Panel ReactivePanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Label MaxPraceLabel;
        private System.Windows.Forms.Label MinPraceLabel;
        private System.Windows.Forms.TextBox MaxPriceTextBox;
    }
}
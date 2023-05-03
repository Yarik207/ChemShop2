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
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TypeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.FiltrPanel = new System.Windows.Forms.Panel();
            this.HideButton = new System.Windows.Forms.Button();
            this.ReactivePanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FiltrPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.Location = new System.Drawing.Point(744, 31);
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
            this.label1.Location = new System.Drawing.Point(389, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Тип товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 50);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ценовая планка \r\nруб.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(202, 65);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(191, 30);
            this.priceTextBox.TabIndex = 21;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            this.priceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.priceTextBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Название";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(202, 31);
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
            this.TypeCheckedListBox.Location = new System.Drawing.Point(520, 31);
            this.TypeCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TypeCheckedListBox.Name = "TypeCheckedListBox";
            this.TypeCheckedListBox.Size = new System.Drawing.Size(217, 104);
            this.TypeCheckedListBox.TabIndex = 28;
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.Controls.Add(this.HideButton);
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
            this.FiltrPanel.Size = new System.Drawing.Size(884, 140);
            this.FiltrPanel.TabIndex = 29;
            this.FiltrPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FiltrPanel_Paint);
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point(17, 0);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(159, 30);
            this.HideButton.TabIndex = 29;
            this.HideButton.Text = "Скрыть панель ";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click_1);
            // 
            // ReactivePanel
            // 
            this.ReactivePanel.AutoScroll = true;
            this.ReactivePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReactivePanel.Location = new System.Drawing.Point(0, 140);
            this.ReactivePanel.Name = "ReactivePanel";
            this.ReactivePanel.Size = new System.Drawing.Size(884, 446);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button HideButton;
    }
}
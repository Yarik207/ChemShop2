﻿namespace  InternetShopofChemistryStuff

{
    partial class LoginForm
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
            this.InpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RegButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InpButton
            // 
            this.InpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.InpButton.Location = new System.Drawing.Point(0, 336);
            this.InpButton.Name = "InpButton";
            this.InpButton.Size = new System.Drawing.Size(215, 47);
            this.InpButton.TabIndex = 0;
            this.InpButton.Text = "Войти";
            this.InpButton.UseVisualStyleBackColor = true;
            this.InpButton.Click += new System.EventHandler(this.InpButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите логин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(17, 64);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(182, 22);
            this.LoginTB.TabIndex = 2;
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(17, 163);
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(182, 22);
            this.PassTB.TabIndex = 3;
            this.PassTB.TextChanged += new System.EventHandler(this.PasstextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите пароль";
            // 
            // RegButton
            // 
            this.RegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RegButton.Location = new System.Drawing.Point(0, 279);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(213, 51);
            this.RegButton.TabIndex = 5;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(-2, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Нет профиля? Создай!\r\n";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 383);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InpButton);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InpButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Label label3;
    }
}
namespace AutoSalonn
{
    partial class SendMailForm
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
            this.AdressTB = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.EscButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdressTB
            // 
            this.AdressTB.Location = new System.Drawing.Point(12, 13);
            this.AdressTB.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AdressTB.Name = "AdressTB";
            this.AdressTB.Size = new System.Drawing.Size(422, 26);
            this.AdressTB.TabIndex = 0;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(12, 71);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(130, 62);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // EscButton
            // 
            this.EscButton.Location = new System.Drawing.Point(304, 71);
            this.EscButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.EscButton.Name = "EscButton";
            this.EscButton.Size = new System.Drawing.Size(130, 62);
            this.EscButton.TabIndex = 2;
            this.EscButton.Text = "Отмена";
            this.EscButton.UseVisualStyleBackColor = true;
            this.EscButton.Click += new System.EventHandler(this.EscButton_Click);
            // 
            // SendMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 160);
            this.Controls.Add(this.EscButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.AdressTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SendMailForm";
            this.Text = "Отправка на почту ";
            this.Load += new System.EventHandler(this.SendMailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdressTB;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button EscButton;
    }
}
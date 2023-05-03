using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace AutoSalonn
{
    public partial class FeedBackForm : Form
    {
        public FeedBackForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Выберите тему");
            }
            else
            {
                MailAddress fromMailAdress = new MailAddress("tarabanil@bk.ru");

                MailAddress toMailAdress = new MailAddress("tarabanil@bk.ru");

                using (MailMessage Message = new MailMessage(fromMailAdress, toMailAdress))

                using (SmtpClient smtpClient = new SmtpClient())
                {
                    Message.Subject = comboBox1.Text;
                    Message.Body = textBox1.Text;
                    Message.IsBodyHtml = true;

                    smtpClient.Host = "smtp.mail.ru";
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromMailAdress.Address, "dMbgbzzqugMXqtVsjtqr");

                    smtpClient.Send(Message);

                }
                MessageBox.Show("Письмо отправлено");
                Close();
            }
        }

        private void FeedBackForm_Load(object sender, EventArgs e)
        {

        }
    }
}

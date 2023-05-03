using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using InternetShopofChemistryStuff;

namespace AutoSalonn
{
    public partial class SendMailForm : Form
    {
        public SendMailForm()
        {
            InitializeComponent();
        }

        private void SendMailForm_Load(object sender, EventArgs e)
        {

        }

        private void EscButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {

            MailAddress fromMailAdress = new MailAddress(AdressTB.Text);

            if (AdressTB.Text == "")
            {
                MessageBox.Show("Введите адрес электронной почты");
            }
            else
            {
                MailAddress toMailAdress = new MailAddress(AdressTB.Text);

                using (MailMessage Message = new MailMessage(fromMailAdress, toMailAdress))

                using (SmtpClient smtpClient = new SmtpClient())
                {
                    Message.Subject = "Ваш список товаров";
                    Message.Body = "Здравствуйте. " + Environment.NewLine + "Мы прислали вам, ваш список выбранных товаров.";
                    Message.IsBodyHtml = true;

                    File.WriteAllText("Избранное.csv", "Название;Цена;Количество");
                    foreach(KeyValuePair<Reactive, int> myReactive in SelectedForm.MyReactive)
                    {
                        Reactive chem = myReactive.Key;
                        File.AppendAllText("Избранное.csv",
                            Environment.NewLine +
                           chem.name + ";" + chem.price + ";" + myReactive.Value);
                    }
                    Message.Attachments.Add(new Attachment("Избранное.csv"));

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
    }
}

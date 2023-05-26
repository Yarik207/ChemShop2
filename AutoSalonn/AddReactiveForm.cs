using System;
using System.IO;
using System.Windows.Forms;

namespace InternetShopofChemistryStuff
{
    public partial class AddReactiveForm : Form
    {
        public AddReactiveForm()
        {
            InitializeComponent();
            Text = "Добавление товара";
        }
       

        private void AddReactiveForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int a;
            if(!Int32.TryParse(PriceTB.Text, out a))
            {
                MessageBox.Show("Цена не указана");
                return;
            }

            if(NameTB.Text == "" || TypeCB.Text == "" || PriceTB.Text == "" || InfoTB.Text == "")
            {
                MessageBox.Show("Поля с * обязательны к заполнению");
                return;
            }

            File.AppendAllText("Reactive.txt",  
                NameTB.Text + ", " + 
                TypeCB.Text + ", " +
                PriceTB.Text + ", " +
                Environment.NewLine);

            if(FileNme != "")
            {
                File.Copy(FileNme, "../../Pictures/" + NameTB.Text + ".bmp");
            }

        string richInfoFile = "../../Pictures/" + NameTB.Text + ".txt";
            File.AppendAllText(richInfoFile, InfoTB.Text);

      MessageBox.Show("Сохранено");
            Close();
        }
      

        string FileNme = "";  

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileNme = openFileDialog1.FileName;
                pictureBox1.Load(FileNme);
            }
        }

        private void PriceCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void richInfoTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

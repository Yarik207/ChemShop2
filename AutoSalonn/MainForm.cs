using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  InternetShopofChemistryStuff;
using System.Security.Cryptography.X509Certificates;
using AutoSalonn;

namespace InternetShopofChemistryStuff
{
    public partial class MainForm : Form
    {
 
        public MainForm()
        {
            InitializeComponent();
            Draw();
        }
        private void Draw()
        {
            FiltrButton.Location = new Point(this.Size.Width/2 - FiltrButton.Size.Width/2, FiltrButton.Location.Y);
            SelectedButton.Location = new Point(FiltrButton.Location.X , SelectedButton.Location.Y);
            HelpButton.Location = new Point(FiltrButton.Location.X + FiltrButton.Size.Width - HelpButton.Size.Width, HelpButton.Location.Y);
            button1.Location = new Point(this.Size.Width / 2 - button1.Size.Width / 2, button1.Location.Y);
            pictureBox1.Location = new Point(FiltrButton.Location.X - (pictureBox1.Size.Width + 50), pictureBox1.Location.Y);
            pictureBox6.Location = new Point(FiltrButton.Location.X - (pictureBox6.Size.Width + 50), pictureBox6.Location.Y);
            pictureBox2.Location = new Point(FiltrButton.Location.X + FiltrButton.Size.Width + 50, pictureBox2.Location.Y);
            pictureBox3.Location = new Point(FiltrButton.Location.X + FiltrButton.Size.Width + 50, pictureBox3.Location.Y);
            pictureBox5.Location = new Point(FiltrButton.Location.X + 60, pictureBox5.Location.Y);
            pictureBox4.Location = new Point(FiltrButton.Location.X + 60, pictureBox4.Location.Y);
            UserLabel.Location = new Point(FiltrButton.Location.X , UserLabel.Location.Y);
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.ShowDialog();
        }   

        private void FiltrButton_Click(object sender, EventArgs e)
        {
            FiltrForm filtr = new FiltrForm();
            filtr.ShowDialog();
        }

        private void SelectedButton_Click(object sender, EventArgs e)
        {
            SelectedForm select = new SelectedForm();
            select.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FiltrForm.reactive_list.Clear(); 
            string[] strs = File.ReadAllLines("Reactive.txt");

            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] {", "}, StringSplitOptions.None);
                
                Reactive chem = new Reactive(parts[0], parts[1], Convert.ToInt32(parts[2]));
                FiltrForm.reactive_list.Add(chem);
            }
           
        }

        private void добавитьТоварыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginForm.isAdmin)
            {
                AddReactiveForm addChem = new AddReactiveForm();
                addChem.ShowDialog();
            }
            else
            {
                MessageBox.Show("Иди своей дорогой сталкер");
            }

            MainForm_Load(null, null);
        }


        private void удалитьТоварToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (LoginForm.isAdmin)
            {
                DeleteForm delChem = new DeleteForm();
                delChem.ShowDialog();
            }
            else
            {
                MessageBox.Show("Иди своей дорогой сталкер");
            }


            MainForm_Load(null, null);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginForm.name == "")
            { 
                LoginForm lf = new LoginForm();
                lf.ShowDialog();
            }
            else
            {
                LoginForm.name = "";
            }

            if(LoginForm.name == "")
            {
                UserLabel.Text = "";
                button1.Text = "Войти";
            }
            else
            { 
                UserLabel.Text = "Добрый день " + LoginForm.name + " " + LoginForm.Famil;
                button1.Text = "Выйти";  
            }  
        }

        private void FeedBackButton_Click(object sender, EventArgs e)
        {
            FeedBackForm fbf = new FeedBackForm();
            fbf.ShowDialog();
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            Draw();
        }
    }
}

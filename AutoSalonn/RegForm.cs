using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetShopofChemistryStuff;

namespace  InternetShopofChemistryStuff

{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (NameTB.Text == "" || FamilTB.Text == "" 
                || LoginTB.Text == "" || PassTB.Text == "" || SecondPassTB.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            if (NameTB.Text == "BetaTestUser123321" && PassTB.Text == "qwerty")
            {
                File.AppendAllText("Users.txt",
                               NameTB.Text + ", " +
                               FamilTB.Text + ", " +
                               LoginTB.Text + ", " +
                               PassTB.Text + ", 1" +
                               Environment.NewLine);
                MessageBox.Show("Вы зарегистрированы");
                Close();
            }
           else
            if (PassTB.Text == SecondPassTB.Text)
            {
                
                File.AppendAllText("Users.txt",
                                NameTB.Text + ", " +
                                FamilTB.Text + ", " +
                                LoginTB.Text + ", " +
                                PassTB.Text + ", 0" +
                                Environment.NewLine);
                MessageBox.Show("Вы зарегистрированы");
                Close();
            }
            else MessageBox.Show("Пароль неверен");

            
        }

    private void RegForm_Load(object sender, EventArgs e)
        {

        }
    }   
}

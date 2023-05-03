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
    public partial class LoginForm : Form
    {
        public static string name = "";
        public static string Famil = "";
        public static bool isAdmin = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void PasstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm rf = new RegForm();
            rf.ShowDialog();
        }

        private void InpButton_Click(object sender, EventArgs e)
        {
            string[] strs = File.ReadAllLines("Users.txt");

            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);

                if(LoginTB.Text == parts[2] && PassTB.Text == parts[3])
                {
                    name = parts[0];
                    Famil = parts[1];
                    isAdmin = (parts[4] == "1");
                    Close();
                    return;
                }
            }
            MessageBox.Show("Введен нверный логин/ пароль");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

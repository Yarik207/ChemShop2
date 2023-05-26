using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace InternetShopofChemistryStuff
{
    public partial class InfoReactForm : Form
    {
        Reactive chem;
        public InfoReactForm(Reactive _reactive)
        {
            chem = _reactive;
            InitializeComponent();

            Text = chem.name;
            label1.Text = chem.name;
            PriceLabel.Text = chem.price.ToString();
            try
            {
                pictureBox1.Load("../../Pictures/" + chem.name + ".bmp");             
            }
            catch (Exception) { }
            //try
            {
                textBox1.Text = File.ReadAllText("../../Pictures/" + chem.name + ".txt");
            }
            //catch (Exception) { }

        }

        private void InfoReactForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (SelectedForm.MyReactive.ContainsKey(chem))
            {
                SelectedForm.MyReactive[chem]++;
            }
            else
            {
                SelectedForm.MyReactive.Add(chem, 1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using InternetShopofChemistryStuff;
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

namespace  InternetShopofChemistryStuff

{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
            for(int i = 0; i<FiltrForm.reactive_list.Count; i++)
            {
                comboBox1.Items.Add(FiltrForm.reactive_list[i].name);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
         var result = MessageBox.Show("Подумай и скажи это еще раз", "Удаление объекта", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                File.Delete("Reactive.txt");
                for (int i = 0; i < FiltrForm.reactive_list.Count; i++)
                {
                    if (textBox1.Text == FiltrForm.reactive_list[i].name)
                    {

                    }
                    else
                    {
                        File.AppendAllText("Reactive.txt",
                        FiltrForm.reactive_list[i].name + ", " +
                        FiltrForm.reactive_list[i].type + ", " +
                        FiltrForm.reactive_list[i].price +
                        Environment.NewLine);
                    }
                }
                MessageBox.Show("Успешно удалено");
                Close();
            } 
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }
    }
}

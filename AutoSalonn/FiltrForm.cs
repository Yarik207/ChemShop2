using InternetShopofChemistryStuff.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetShopofChemistryStuff
{
    public struct Reactive
    {
        public string name;
        public string type;
        public int price;
        public Button btn;
        public PictureBox pb;

        public Reactive(string _name, string _type,  int _price)
        {
            name = _name;
            type = _type;
            price = _price;
            btn = new Button();
            btn.Text = name;
            pb = new PictureBox();
            try
            {
                pb.Load("../../Pictures/" + name + ".bmp");             
            }
            catch (Exception) { }
        }
    }

    public partial class FiltrForm : Form
    {
        public static List<Reactive> reactive_list = new List<Reactive>();

        public FiltrForm()
        {
            InitializeComponent();

            int x = 10;
            int y = 10;

            for (int i=0; i< reactive_list.Count; i++)
            {
                reactive_list[i].btn.Font = new Font("Microsoft Sans Serif", 12F);
                reactive_list[i].btn.Location = new Point(x, y);
                reactive_list[i].btn.Size = new Size(200, 30);
                reactive_list[i].btn.Click += new EventHandler(ChemClick);
                ReactivePanel.Controls.Add(reactive_list[i].btn);

                reactive_list[i].pb.Location = new Point(x, y);
                reactive_list[i].pb.Size = new Size(200, 200);
                reactive_list[i].pb.SizeMode = PictureBoxSizeMode.Zoom;
                ReactivePanel.Controls.Add(reactive_list[i].pb);

                x += 210;
                if(x + 200 > ReactivePanel.Width)
                {
                    x = 10;
                    y += 210;
                }
            } 
        }

        private void FiltrForm_Load(object sender, EventArgs e)
        {

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
            for (int i=0; i<reactive_list.Count; i++)
            {
                reactive_list[i].btn.Visible = true;
                reactive_list[i].pb.Visible = true;

                if (TypeCheckedListBox.CheckedItems.Count > 0 &&
                    !TypeCheckedListBox.CheckedItems.Contains(reactive_list[i].type))
                {
                    reactive_list[i].btn.Visible = false;
                    reactive_list[i].pb.Visible = false;
                }
                if (NameTextBox.Text != "" &&
                    !reactive_list[i].name.Contains(NameTextBox.Text))
                {
                    reactive_list[i].btn.Visible = false;
                    reactive_list[i].pb.Visible = false;
                }
                #region Price
                if (MinPriceTextBox.Text != "" &&
                    Convert.ToInt32(MinPriceTextBox.Text) >= reactive_list[i].price)
                {
                    reactive_list[i].btn.Visible = false;
                    reactive_list[i].pb.Visible = false;

                }
                if (MaxPriceTextBox.Text != "" &&
                   Convert.ToInt32(MaxPriceTextBox.Text) <= reactive_list[i].price)
                {
                    reactive_list[i].btn.Visible = false;
                    reactive_list[i].pb.Visible = false;

                }
                #endregion

                if (reactive_list[i].btn.Visible)
                {
                    reactive_list[i].btn.Location = new Point(x, y);                    
                    reactive_list[i].pb.Location = new Point(x, y);

                    x += 210;
                    if(x + 200 > ReactivePanel.Width)
                    {
                        x = 10;
                        y += 210;
                    }
                }                
            }
        }

        public static void ChemClick(object sender, EventArgs e)
        {
            for (int i = 0; i < reactive_list.Count; i++)
            {
                if (((Button)sender).Text == reactive_list[i].btn.Text)
                {
                    InfoReactForm chem = new InfoReactForm(reactive_list[i]);
                    chem.ShowDialog();
                }
            }
        }

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindButton_Click(null,null);
            }
        }

        private void priceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindButton_Click(null, null);
            }

        }

        private void ReactivePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ReactivePanel_Resize(object sender, EventArgs e)
        {
            FindButton_Click(null, null);
        }

        private void FiltrPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HideButton_Click(object sender, EventArgs e)
        {
           
        }

        private void HideButton_Click_1(object sender, EventArgs e)
        {
            if (HideButton.Text == "Скрыть панель ")
            {
                FiltrPanel.Height = HideButton.Height;
                HideButton.Text = "Развернуть";
            }
            else if (HideButton.Text == "Развернуть")
            {
                FiltrPanel.Height = 140;
                HideButton.Text = "Скрыть панель ";
            }
        }
    }
}

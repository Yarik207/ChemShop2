using AutoSalonn;
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
    public partial class SelectedForm : Form
    {
        public static Dictionary<Reactive, int> MyReactive = new Dictionary<Reactive, int>();

        public SelectedForm()
        {
            InitializeComponent();
            ReDraw();
        }

        void ReDraw()
        {
            Controls.Clear();
            Controls.Add(SendButton);

            int x = 10;
            int y = 10;

            foreach (KeyValuePair<Reactive, int> myReactive in MyReactive)
            {
                Reactive chem = myReactive.Key;

                #region 1 столбец
                PictureBox pb = new PictureBox();
                pb.Image = chem.pb.Image;
                pb.Location = new Point(x, y + AutoScrollPosition.Y);
                pb.Size = new Size(200, 200);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(pb);
                #endregion

                #region 2 столбец
                Label lbl_name = new Label();
                lbl_name.Text = "Название: " + chem.name;
                lbl_name.Font = new Font("Microsoft Sans Serif", 12F);
                lbl_name.Location = new Point(x + 220, y + AutoScrollPosition.Y);
                lbl_name.Size = new Size(200, 30);
                Controls.Add(lbl_name);

                Label lbl_type = new Label();
                lbl_type.Text = "Тип товара: " + chem.type;
                lbl_type.Font = new Font("Microsoft Sans Serif", 12F);
                lbl_type.Location = new Point(x + 220, y + 50 + AutoScrollPosition.Y);
                lbl_type.Size = new Size(200, 30);
                Controls.Add(lbl_type);

               
                #endregion

                #region 3 столбец
                Label lbl_price = new Label();
                lbl_price.Text = "Цена, руб.: " + chem.price.ToString();
                lbl_price.Font = new Font("Microsoft Sans Serif", 12F);
                lbl_price.Location = new Point(x + 440, y + AutoScrollPosition.Y);
                lbl_price.Size = new Size(200, 30);
                Controls.Add(lbl_price);

                Label lbl_value = new Label();
                lbl_value.Text = "Кол-во, шт.: " + myReactive.Value.ToString();
                lbl_value.Font = new Font("Microsoft Sans Serif", 12F);
                lbl_value.Location = new Point(x + 440, y + 50 + AutoScrollPosition.Y);
                lbl_value.Size = new Size(200, 30);
                Controls.Add(lbl_value);

                Button btn = new Button();
                btn.Text = chem.btn.Text;
                btn.Font = new Font("Microsoft Sans Serif", 12F);
                btn.Location = new Point(x + 440, y + 100 + AutoScrollPosition.Y);
                btn.Size = new Size(200, 30);
                btn.Click += new EventHandler(FiltrForm.ChemClick);
                Controls.Add(btn);
                #endregion

                #region 4 столбец
                Button btnDelete = new Button();
                btnDelete.Text = "Удалить";
                btnDelete.Font = new Font("Microsoft Sans Serif", 12F);
                btnDelete.Location = new Point(x + 660, y + AutoScrollPosition.Y);
                btnDelete.Size = new Size(200, 30);
                btnDelete.Click += new EventHandler(DeleteClick);
                Controls.Add(btnDelete);
                #endregion

                y += 210;

            }

        }

        void DeleteClick(object sender, EventArgs e)
        {
            int i = 0;
            Button btn = (Button)sender;
            Dictionary<Reactive, int> myReactive = new Dictionary<Reactive, int>();
            foreach (KeyValuePair<Reactive, int> MyReactive1 in MyReactive)
            {
                Reactive chem = MyReactive1.Key;
                if(btn.Location == new Point(670, 210*i + 10 + AutoScrollPosition.Y))
                {

                }
                else
                {
                    myReactive[MyReactive1.Key] = MyReactive1.Value;
                }
                i++;
            }
            MyReactive = myReactive;
            ReDraw(); 
        }

        private void SelectedForm_Load(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            SendMailForm smf = new SendMailForm();
            smf.ShowDialog();
        }
    }
}

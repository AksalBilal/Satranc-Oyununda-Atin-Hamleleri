using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satranç
{
    public partial class FrmSekizlik : Form
    {
        public FrmSekizlik()
        {
            InitializeComponent();
        }

        private void FrmSekizlik_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.RowCount = 8;
            for (int i = 0; i < 64; i++)
            {
                Button button = new Button();
                button.BackColor = Color.White;
                button.Size = new Size(40, 40);
                button.Text = i.ToString();
                button.Name = i.ToString();
                button.Click += buttonSekizlik_Click;
                tableLayoutPanel1.Controls.Add(button);
            }
        }

        private void buttonSekizlik_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0, d = 0;

            Button tıklanan = (sender as Button);


            for (int i = 0; i <64 ; i++)
            {
                if (tableLayoutPanel1.Controls[i].Name == tıklanan.Name)
                {
                    tableLayoutPanel1.Controls[i].BackColor = Color.Gray;
                    tableLayoutPanel1.Controls[i].Text = "X";
                    if (i == 0)
                    {

                        tableLayoutPanel1.Controls[i + 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 10].Enabled = true;

                        b = i + 10;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;

                        d = i + 17;
                    }
                    else if (i == 8)
                    {
                        tableLayoutPanel1.Controls[i - 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 6].Enabled = true;
                        tableLayoutPanel1.Controls[i + 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 10].Enabled = true;

                        b = i + 10;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;

                        d = i + 17;
                    }
                    else if (i == 1)
                    {
                        tableLayoutPanel1.Controls[i + 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 10].Enabled = true;

                        b = i + 10;
                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        c = i + 15;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;

                        d = i + 17;
                    }
                    else if (i >= 2 && i <= 5)
                    {
                        tableLayoutPanel1.Controls[i + 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 6].Enabled = true;
                        a = i + 6;
                        tableLayoutPanel1.Controls[i + 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 10].Enabled = true;

                        b = i + 10;
                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        c = i + 15;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;

                        d = i + 17;
                    }
                    else if (i == 6)
                    {
                        tableLayoutPanel1.Controls[i + 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 6].Enabled = true;
                        a = i + 6;

                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        c = i + 15;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;

                        d = i + 17;
                    }
                    else if (i == 7)
                    {
                        tableLayoutPanel1.Controls[i + 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 6].Enabled = true;
                        a = i + 6;

                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        c = i + 15;
                    }
                    else if (i == 9)
                    {
                        tableLayoutPanel1.Controls[i - 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 6].Enabled = true;

                        tableLayoutPanel1.Controls[i + 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 10].Enabled = true;

                        b = i + 10;

                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        c = i + 15;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;

                        d = i + 17;
                    }
                    else if (i >= 10 && i <= 13)
                    {
                        tableLayoutPanel1.Controls[i - 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 6].Enabled = true;

                        tableLayoutPanel1.Controls[i - 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 10].Enabled = true;

                        tableLayoutPanel1.Controls[i + 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 6].Enabled = true;
                        a = i + 6;

                        tableLayoutPanel1.Controls[i + 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 10].Enabled = true;

                        b = i + 10;

                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        c = i + 15;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;

                        d = i + 17;
                    }
                    else if (i == 14)
                    {


                        tableLayoutPanel1.Controls[i - 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 10].Enabled = true;

                        tableLayoutPanel1.Controls[i + 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 6].Enabled = true;
                        a = i + 6;

                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        c = i + 15;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;

                        d = i + 17;

                    }
                    else if (i == 15)
                    {
                        tableLayoutPanel1.Controls[i - 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 10].Enabled = true;

                        tableLayoutPanel1.Controls[i + 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 6].Enabled = true;
                        a = i + 6;

                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        c = i + 15;
                    }
                    else if (i == 17 || i == 25 || i == 33 || i == 41)
                    {
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;

                        tableLayoutPanel1.Controls[i - 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 6].Enabled = true;
                        tableLayoutPanel1.Controls[i + 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 10].Enabled = true;

                        b = i + 10;
                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        c = i + 15;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;

                        d = i + 17;
                    }
                    else if (i == 48)
                    {
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;
                        tableLayoutPanel1.Controls[i - 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 6].Enabled = true;
                        tableLayoutPanel1.Controls[i + 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 10].Enabled = true;

                        b = i + 10;
                    }
                    else if (i == 49)
                    {
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;

                        tableLayoutPanel1.Controls[i - 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 6].Enabled = true;
                        tableLayoutPanel1.Controls[i + 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 10].Enabled = true;

                        b = i + 10;
                    }
                    else if (i >= 50 && i <= 53)
                    {
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;

                        tableLayoutPanel1.Controls[i - 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 6].Enabled = true;
                        tableLayoutPanel1.Controls[i - 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 10].Enabled = true;

                        tableLayoutPanel1.Controls[i + 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 6].Enabled = true;
                        a = i + 6;
                        tableLayoutPanel1.Controls[i + 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 10].Enabled = true;

                        b = i + 10;

                    }
                    else if (i >= 58 && i <= 61)
                    {
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;

                        tableLayoutPanel1.Controls[i - 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 6].Enabled = true;
                        tableLayoutPanel1.Controls[i - 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 10].Enabled = true;
                    }

                    else if (i == 62)
                    {
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;
                        tableLayoutPanel1.Controls[i - 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 10].Enabled = true;
                    }
                    else if (i == 55)
                    {
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;
                        tableLayoutPanel1.Controls[i - 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 10].Enabled = true;
                        tableLayoutPanel1.Controls[i + 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 6].Enabled = true;
                        a = i + 6;

                    }
                    else if (i == 54)
                    {
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;

                        tableLayoutPanel1.Controls[i - 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 10].Enabled = true;

                        tableLayoutPanel1.Controls[i + 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 6].Enabled = true;
                        a = i + 6;
                    }
                    else if (i == 56)
                    {
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;
                        tableLayoutPanel1.Controls[i - 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 6].Enabled = true;
                    }
                    else if (i == 57)
                    {

                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;

                        tableLayoutPanel1.Controls[i - 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 6].Enabled = true;
                    }
                    else if (i == 63)
                    {
                        tableLayoutPanel1.Controls[i - 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 10].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;
                    }
                    else if (i == 23 || i == 31 || i == 39 || i == 47)
                    {
                        tableLayoutPanel1.Controls[i - 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 10].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;
                        tableLayoutPanel1.Controls[i + 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 6].Enabled = true;
                        a = i + 6;
                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        c = i + 15;
                    }
                    else if (i % 8 == 0 && i != 8 && i != 0 && i != 56 && i != 48)
                    {
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;
                        tableLayoutPanel1.Controls[i - 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 6].Enabled = true;
                        tableLayoutPanel1.Controls[i + 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 10].Enabled = true;

                        b = i + 10;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;

                        d = i + 17;
                    }
                    else if (i == 22 || i == 30 || i == 38 || i == 46)
                    {
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;


                        tableLayoutPanel1.Controls[i - 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 10].Enabled = true;
                        tableLayoutPanel1.Controls[i + 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 6].Enabled = true;
                        a = i + 6;
                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        c = i + 15;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;

                        d = i + 17;
                    }
                    else
                    {
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;

                        tableLayoutPanel1.Controls[i - 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 6].Enabled = true;
                        tableLayoutPanel1.Controls[i - 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i - 10].Enabled = true;

                        tableLayoutPanel1.Controls[i + 6].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 6].Enabled = true;
                        a = i + 6;
                        tableLayoutPanel1.Controls[i + 10].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 10].Enabled = true;

                        b = i + 10;
                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        c = i + 15;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Green;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;

                        d = i + 17;

                        continue;
                    }
                }
                if (i != a && i != b && i != c && i != d)
                {
                    tableLayoutPanel1.Controls[i].Enabled = false;
                    tableLayoutPanel1.Controls[i].BackColor = Color.White;
                }
                for (int j = 0; j < 64; j++)
                {
                    if (tableLayoutPanel1.Controls[j].Text == "X" || tableLayoutPanel1.Controls[j].BackColor == Color.White)
                    {
                        tableLayoutPanel1.Controls[j].Enabled = false;
                        tableLayoutPanel1.Controls[j].BackColor = Color.Gray;
                    }

                }
            }
        }
    }
}

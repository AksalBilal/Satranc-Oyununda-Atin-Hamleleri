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
    public partial class FrmYedilik : Form
    {
        public FrmYedilik()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmYedilik_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.RowCount = 7;
            for (int i = 0; i < 49; i++)
            {
                Button button = new Button();
                button.BackColor = Color.White;
                button.Size = new Size(40, 40);
                button.Text = i.ToString();
                button.Name = i.ToString();
                button.Click += buttonYedilik_Click;
                tableLayoutPanel1.Controls.Add(button);
            }
        }

        private void buttonYedilik_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0, d = 0;

            Button tıklanan = (sender as Button);

            for (int i = 0; i < 49; i++)
            {
                if (tableLayoutPanel1.Controls[i].Name == tıklanan.Name)
                {
                    tableLayoutPanel1.Controls[i].BackColor = Color.Pink;
                    tableLayoutPanel1.Controls[i].Text = "X";

                    if (i == 0)
                    {
                        tableLayoutPanel1.Controls[i + 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 9].Enabled = true;
                        b = i + 9;

                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        d = i + 15;
                    }
                    else if (i == 6)
                    {
                        tableLayoutPanel1.Controls[i + 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 5].Enabled = true;
                        a = i + 5;

                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;
                        c = i + 13;
                    }
                    else if (i == 1)
                    {
                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;
                        c = i + 13;

                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        d = i + 15;

                        tableLayoutPanel1.Controls[i + 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 9].Enabled = true;
                        b = i + 9;
                    }
                    else if (i == 5)
                    {
                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;
                        c = i + 13;

                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        d = i + 15;

                        tableLayoutPanel1.Controls[i + 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 5].Enabled = true;
                        a = i + 5;
                    }
                    else if (i > 1 && i < 5)
                    {
                        tableLayoutPanel1.Controls[i + 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 5].Enabled = true;
                        a = i + 5;

                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;
                        c = i + 13;

                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        d = i + 15;

                        tableLayoutPanel1.Controls[i + 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 9].Enabled = true;
                        b = i + 9;
                    }
                    else if (i == 7)
                    {
                        tableLayoutPanel1.Controls[i - 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 5].Enabled = true;

                        tableLayoutPanel1.Controls[i + 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 9].Enabled = true;
                        b = i + 9;

                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        c = i + 15;
                    }
                    else if (i == 13)
                    {
                        tableLayoutPanel1.Controls[i - 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 9].Enabled = true;

                        tableLayoutPanel1.Controls[i + 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 5].Enabled = true;
                        a = i + 5;

                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;
                        c = i + 13;
                    }
                    else if (i == 8)
                    {
                        tableLayoutPanel1.Controls[i - 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 5].Enabled = true;

                        tableLayoutPanel1.Controls[i + 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 9].Enabled = true;
                        b = i + 9;

                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;
                        c = i + 13;

                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        d = i + 15;
                    }
                    else if (i == 12)
                    {
                        tableLayoutPanel1.Controls[i - 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 9].Enabled = true;

                        tableLayoutPanel1.Controls[i + 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 5].Enabled = true;
                        a = i + 5;

                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;
                        c = i + 13;
                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        d = i + 15;
                    }
                    else if (i > 8 && i < 12)
                    {
                        tableLayoutPanel1.Controls[i - 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 9].Enabled = true;

                        tableLayoutPanel1.Controls[i + 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 5].Enabled = true;
                        a = i + 5;

                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;
                        c = i + 13;

                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        d = i + 15;

                        tableLayoutPanel1.Controls[i + 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 9].Enabled = true;
                        b = i + 9;

                        tableLayoutPanel1.Controls[i - 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 5].Enabled = true;

                    }
                    else if (i == 14 || i == 28 || i == 21)
                    {
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 5].Enabled = true;

                        tableLayoutPanel1.Controls[i + 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 9].Enabled = true;
                        b = i + 9;

                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        d = i + 15;
                    }

                    else if (i == 20 || i == 27 || i == 34)
                    {
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;

                        tableLayoutPanel1.Controls[i - 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 9].Enabled = true;

                        tableLayoutPanel1.Controls[i + 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 5].Enabled = true;
                        a = i + 5;

                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;
                        c = i + 13;
                    }
                    else if (i == 15 || i == 22 || i == 29)
                    {
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;

                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 5].Enabled = true;

                        tableLayoutPanel1.Controls[i + 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 9].Enabled = true;
                        b = i + 9;

                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;
                        c = i + 13;

                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        d = i + 15;
                    }
                    else if (i == 19 || i == 26 || i == 33)
                    {
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;

                        tableLayoutPanel1.Controls[i - 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 9].Enabled = true;

                        tableLayoutPanel1.Controls[i + 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 5].Enabled = true;
                        a = i + 5;

                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;
                        c = i + 13;

                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;
                        d = i + 15;
                    }
                    else if (i == 35)
                    {
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 5].Enabled = true;

                        tableLayoutPanel1.Controls[i + 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 9].Enabled = true;
                        b = i + 9;
                    }
                    else if (i == 36)
                    {
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;

                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 5].Enabled = true;

                        tableLayoutPanel1.Controls[i + 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 9].Enabled = true;
                        b = i + 9;

                    }
                    else if (i > 36 && i < 40)
                    {
                        tableLayoutPanel1.Controls[i - 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 5].Enabled = true;

                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;

                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 9].Enabled = true;

                        tableLayoutPanel1.Controls[i + 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 5].Enabled = true;
                        a = i + 5;
                        tableLayoutPanel1.Controls[i + 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 9].Enabled = true;
                        b = i + 9;
                    }
                    else if (i == 40)
                    {
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;

                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 9].Enabled = true;

                        tableLayoutPanel1.Controls[i + 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 5].Enabled = true;
                        a = i + 5;
                    }
                    else if (i == 41)
                    {
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;

                        tableLayoutPanel1.Controls[i - 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 9].Enabled = true;

                        tableLayoutPanel1.Controls[i + 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 5].Enabled = true;
                        a = i + 5;
                    }
                    else if (i == 42)
                    {
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 5].Enabled = true;


                    }
                    else if (i == 43)
                    {
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;

                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 5].Enabled = true;

                    }
                    else if (i > 43 && i < 47)
                    {
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;

                        tableLayoutPanel1.Controls[i - 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 9].Enabled = true;

                        tableLayoutPanel1.Controls[i - 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 5].Enabled = true;

                    }
                    else if (i == 48)
                    {
                        tableLayoutPanel1.Controls[i - 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 9].Enabled = true;

                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;

                    }
                    else if (i == 47)
                    {

                        tableLayoutPanel1.Controls[i - 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 9].Enabled = true;

                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;

                    }
                    else
                    {
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;
                        tableLayoutPanel1.Controls[i - 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 15].Enabled = true;

                        tableLayoutPanel1.Controls[i - 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 5].Enabled = true;
                        tableLayoutPanel1.Controls[i - 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i - 9].Enabled = true;

                        tableLayoutPanel1.Controls[i + 5].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 5].Enabled = true;
                        a = i + 5;
                        tableLayoutPanel1.Controls[i + 9].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 9].Enabled = true;

                        b = i + 9;
                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;
                        c = i + 13;
                        tableLayoutPanel1.Controls[i + 15].BackColor = Color.Turquoise;
                        tableLayoutPanel1.Controls[i + 15].Enabled = true;

                        d = i + 15;

                        continue;
                    }
                }
                if (i != a && i != b && i != c && i != d)
                {
                    tableLayoutPanel1.Controls[i].Enabled = false;
                    tableLayoutPanel1.Controls[i].BackColor = Color.White;
                }
                for (int j = 0; j < 49; j++)
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

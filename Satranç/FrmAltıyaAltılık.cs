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
    public partial class FrmAltılık : Form
    {
        public FrmAltılık()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.RowCount = 6;
            for (int i = 0; i < 36; i++)
            {
                Button button = new Button();
                button.BackColor = Color.White;
                button.Size = new Size(40, 40);
                button.Text = i.ToString();
                button.Name = i.ToString();
                button.Click += buttonAltilik_Click;
                tableLayoutPanel1.Controls.Add(button);
            }
        }

        private void buttonAltilik_Click(object sender, EventArgs e)
        {
             int a = 0, b = 0, c = 0, d = 0;

            Button tıklanan = (sender as Button);

            for (int i = 0; i < 36; i++)
            {
                if (tableLayoutPanel1.Controls[i].Name == tıklanan.Name)
                {
                    tableLayoutPanel1.Controls[i].BackColor = Color.Orange;
                    tableLayoutPanel1.Controls[i].Text = "X";

                    if (i == 0)
                    {
                        tableLayoutPanel1.Controls[i + 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 8].Enabled = true;

                        b = i + 8;
                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;

                        d = i + 13;
                    }
                    else if (i == 1)
                    {
                        tableLayoutPanel1.Controls[i + 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 8].Enabled = true;

                        b = i + 8;
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        c = i + 11;
                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;

                        d = i + 13;
                    }
                    else if (i==2||i==3)
                    {
                        tableLayoutPanel1.Controls[i + 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 4].Enabled = true;
                        a = i + 4;
                        tableLayoutPanel1.Controls[i + 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 8].Enabled = true;

                        b = i + 8;
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        c = i + 11;
                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;

                        d = i + 13;
                    }
                   
                    else if (i == 4)
                    {
                        tableLayoutPanel1.Controls[i + 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 4].Enabled = true;
                        a = i + 4;
                        
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        c = i + 11;
                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;

                        d = i + 13;
                    }
                    else if (i ==5)
                    {
                        tableLayoutPanel1.Controls[i + 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 4].Enabled = true;
                        a = i + 4;
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        c = i + 11;
                       
                    }
                    else if (i == 6)
                    {
                        tableLayoutPanel1.Controls[i - 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 4].Enabled = true;
                        tableLayoutPanel1.Controls[i + 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 8].Enabled = true;
                        b = i + 8;
                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;
                        d = i + 13;
                    }
                    else if (i == 7)
                    {
                        tableLayoutPanel1.Controls[i - 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 4].Enabled = true;
                        tableLayoutPanel1.Controls[i + 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 8].Enabled = true;
                        b = i + 8;
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        c = i + 11;
                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;
                        d = i + 13;
                    }
                    else if (i == 8||i==9)
                    {

                        tableLayoutPanel1.Controls[i - 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 4].Enabled = true;
                        tableLayoutPanel1.Controls[i - 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 8].Enabled = true;

                        tableLayoutPanel1.Controls[i + 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 4].Enabled = true;
                        a = i + 4;
                        tableLayoutPanel1.Controls[i + 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 8].Enabled = true;

                        b = i + 8;
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        c = i + 11;
                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;

                        d = i + 13;
                    }
                    else if (i == 10)
                    {
                        tableLayoutPanel1.Controls[i - 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 8].Enabled = true;
                        tableLayoutPanel1.Controls[i + 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 4].Enabled = true;
                        a = i + 4;
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        c = i + 11;
                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;

                        d = i + 13;
                    }
                    else if (i == 11)
                    {
                        tableLayoutPanel1.Controls[i - 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 8].Enabled = true;
                        tableLayoutPanel1.Controls[i + 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 4].Enabled = true;
                        a = i + 4;
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        c = i + 11;
                    }
                    else if (i==12||i==18)
                    {
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i - 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 4].Enabled = true;
                        tableLayoutPanel1.Controls[i + 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 8].Enabled = true;

                        b = i + 8;
                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;

                        d = i + 13;
                    }
                    else if (i == 13 || i == 19)
                    {
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;
                        tableLayoutPanel1.Controls[i - 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 4].Enabled = true;
                        tableLayoutPanel1.Controls[i + 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 8].Enabled = true;

                        b = i + 8;
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        c = i + 11;
                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;

                        d = i + 13;
                    }
                    else if (i==16||i==22)
                    {
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;
                        tableLayoutPanel1.Controls[i - 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 8].Enabled = true;
                        tableLayoutPanel1.Controls[i + 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 4].Enabled = true;
                        a = i + 4;
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        c = i + 11;
                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;

                        d = i + 13;

                    }
                    else if (i==17||i==23)
                    {
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;
                        tableLayoutPanel1.Controls[i - 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 8].Enabled = true;
                        tableLayoutPanel1.Controls[i + 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 4].Enabled = true;
                        a = i + 4;
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        c = i + 11;
                    }
                    else if(i==24)
                    {
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i - 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 4].Enabled = true;
                        tableLayoutPanel1.Controls[i + 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 8].Enabled = true;

                        b = i + 8;
                    }
                    else if (i==25)
                    {
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 4].Enabled = true;
                        tableLayoutPanel1.Controls[i + 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 8].Enabled = true;

                        b = i + 8;
                    }
                    else if (i==26||i==27)
                    {
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 4].Enabled = true;
                        tableLayoutPanel1.Controls[i - 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 8].Enabled = true;

                        tableLayoutPanel1.Controls[i + 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 4].Enabled = true;
                        a = i + 4;
                        tableLayoutPanel1.Controls[i + 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 8].Enabled = true;

                        b = i + 8;
                    }
                    else if (i==28)
                    {
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 8].Enabled = true;
                        tableLayoutPanel1.Controls[i + 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 4].Enabled = true;
                        a = i + 4;
                    }
                    else if (i==29)
                    {
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 8].Enabled = true;
                        tableLayoutPanel1.Controls[i + 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 4].Enabled = true;
                        a = i + 4;

                    }
                    else if (i==30)
                    {
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i - 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 4].Enabled = true;
                    }
                    else if (i==31)
                    {
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 4].Enabled = true;
                    }
                    else if (i==32||i==33)
                    {
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 4].Enabled = true;
                        tableLayoutPanel1.Controls[i - 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 8].Enabled = true;
                    }
                    else if (i==34)
                    {
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 8].Enabled = true;
                    }
                    else if (i==35)
                    {
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 8].Enabled = true;
                    }
                
                    else
                    {
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i - 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 13].Enabled = true;

                        tableLayoutPanel1.Controls[i - 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 4].Enabled = true;
                        tableLayoutPanel1.Controls[i - 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i - 8].Enabled = true;

                        tableLayoutPanel1.Controls[i + 4].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 4].Enabled = true;
                        a = i + 4;
                        tableLayoutPanel1.Controls[i + 8].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 8].Enabled = true;

                        b = i + 8;
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        c = i + 11;
                        tableLayoutPanel1.Controls[i + 13].BackColor = Color.Tomato;
                        tableLayoutPanel1.Controls[i + 13].Enabled = true;

                        d = i + 13;

                        continue;
                    }
                }
                if (i != a && i != b && i != c && i != d)
                {
                    tableLayoutPanel1.Controls[i].Enabled = false;
                    tableLayoutPanel1.Controls[i].BackColor = Color.White;
                }
                for (int j = 0; j < 36; j++)
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

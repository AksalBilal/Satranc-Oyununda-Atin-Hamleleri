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
    public partial class FrmBeslik : Form
    {
        Button button = new Button();
        public FrmBeslik()
        {
            InitializeComponent();
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
           
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.RowCount = 5;           
            for (int i = 0; i < 25; i++)
            {
                Button button = new Button();
                button.BackColor = Color.White;
                button.Size = new Size(100, 100);
                button.Click += buttonBeslik_Click;
                button.Text = i.ToString();
                button.Name = i.ToString();
                tableLayoutPanel1.Controls.Add(button);
            }
  


        }

        private void buttonBeslik_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0, d = 0;

            Button tıklanan = (sender as Button);

            for (int i = 0; i < 25; i++)
            {
                if (tableLayoutPanel1.Controls[i].Name == tıklanan.Name)
                {
                   
                    tableLayoutPanel1.Controls[i].BackColor = Color.Yellow;
                    tableLayoutPanel1.Controls[i].Text = "X";
                   
                    
                        if (i == 0)
                        {
                            tableLayoutPanel1.Controls[i + 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 7].Enabled = true;

                            b = i + 7;
                            tableLayoutPanel1.Controls[i + 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 11].Enabled = true;

                            d = i + 11;
                        }
                        else if (i == 1)
                        {
                            tableLayoutPanel1.Controls[i + 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 7].Enabled = true;

                            b = i + 7;
                            tableLayoutPanel1.Controls[i + 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 9].Enabled = true;
                            c = i + 9;
                            tableLayoutPanel1.Controls[i + 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 11].Enabled = true;

                            d = i + 11;
                        }
                        else if (i == 2)
                        {
                            tableLayoutPanel1.Controls[i + 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 3].Enabled = true;
                            a = i + 3;
                            tableLayoutPanel1.Controls[i + 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 7].Enabled = true;

                            b = i + 7;
                            tableLayoutPanel1.Controls[i + 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 9].Enabled = true;
                            c = i + 9;
                            tableLayoutPanel1.Controls[i + 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 11].Enabled = true;

                            d = i + 11;

                        }
                        else if (i == 3)
                        {
                            tableLayoutPanel1.Controls[i + 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 3].Enabled = true;
                            a = i + 3;

                            tableLayoutPanel1.Controls[i + 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 9].Enabled = true;
                            c = i + 9;
                            tableLayoutPanel1.Controls[i + 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 11].Enabled = true;

                            d = i + 11;
                        }
                        else if (i == 4)
                        {
                            tableLayoutPanel1.Controls[i + 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 3].Enabled = true;
                            a = i + 3;

                            tableLayoutPanel1.Controls[i + 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 9].Enabled = true;
                            c = i + 9;
                        }
                        else if (i == 5)
                        {
                            tableLayoutPanel1.Controls[i - 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 3].Enabled = true;

                            tableLayoutPanel1.Controls[i + 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 7].Enabled = true;

                            b = i + 7;
                            tableLayoutPanel1.Controls[i + 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 11].Enabled = true;

                            d = i + 11;
                        }
                        else if (i == 6)
                        {
                            tableLayoutPanel1.Controls[i - 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 3].Enabled = true;
                            tableLayoutPanel1.Controls[i + 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 7].Enabled = true;

                            b = i + 7;
                            tableLayoutPanel1.Controls[i + 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 9].Enabled = true;
                            c = i + 9;
                            tableLayoutPanel1.Controls[i + 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 11].Enabled = true;

                            d = i + 11;

                        }
                        else if (i == 7)
                        {
                            tableLayoutPanel1.Controls[i - 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 3].Enabled = true;
                            tableLayoutPanel1.Controls[i - 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 7].Enabled = true;
                            tableLayoutPanel1.Controls[i + 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 3].Enabled = true;
                            a = i + 3;
                            tableLayoutPanel1.Controls[i + 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 7].Enabled = true;

                            b = i + 7;
                            tableLayoutPanel1.Controls[i + 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 9].Enabled = true;
                            c = i + 9;
                            tableLayoutPanel1.Controls[i + 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 11].Enabled = true;

                            d = i + 11;

                        }
                        else if (i == 8)
                        {
                            tableLayoutPanel1.Controls[i - 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 7].Enabled = true;
                            tableLayoutPanel1.Controls[i + 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 3].Enabled = true;
                            a = i + 3;
                            tableLayoutPanel1.Controls[i + 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 9].Enabled = true;
                            c = i + 9;
                            tableLayoutPanel1.Controls[i + 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 11].Enabled = true;

                            d = i + 11;
                        }
                        else if (i == 9)
                        {
                            tableLayoutPanel1.Controls[i - 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 7].Enabled = true;
                            tableLayoutPanel1.Controls[i + 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 3].Enabled = true;
                            a = i + 3;
                            tableLayoutPanel1.Controls[i + 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 9].Enabled = true;
                            c = i + 9;
                        }
                        else if (i == 10)
                        {
                            tableLayoutPanel1.Controls[i - 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 3].Enabled = true;
                            tableLayoutPanel1.Controls[i - 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 9].Enabled = true;
                            tableLayoutPanel1.Controls[i + 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 7].Enabled = true;

                            b = i + 7;
                            tableLayoutPanel1.Controls[i + 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 11].Enabled = true;

                            d = i + 11;

                        }
                        else if (i == 11)
                        {
                            tableLayoutPanel1.Controls[i - 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 9].Enabled = true;
                            tableLayoutPanel1.Controls[i - 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 11].Enabled = true;

                            tableLayoutPanel1.Controls[i - 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 3].Enabled = true;
                            tableLayoutPanel1.Controls[i + 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 7].Enabled = true;

                            b = i + 7;
                            tableLayoutPanel1.Controls[i + 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 9].Enabled = true;
                            c = i + 9;
                            tableLayoutPanel1.Controls[i + 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 11].Enabled = true;

                            d = i + 11;
                        }
                        else if (i == 13)
                        {
                            tableLayoutPanel1.Controls[i - 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 7].Enabled = true;
                            tableLayoutPanel1.Controls[i - 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 9].Enabled = true;
                            tableLayoutPanel1.Controls[i - 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 11].Enabled = true;
                            tableLayoutPanel1.Controls[i + 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 3].Enabled = true;
                            a = i + 3;
                            tableLayoutPanel1.Controls[i + 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 9].Enabled = true;
                            c = i + 9;
                            tableLayoutPanel1.Controls[i + 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 11].Enabled = true;

                            d = i + 11;
                        }
                        else if (i == 14)
                        {
                            tableLayoutPanel1.Controls[i - 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 7].Enabled = true;
                            tableLayoutPanel1.Controls[i - 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 11].Enabled = true;
                            tableLayoutPanel1.Controls[i + 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 3].Enabled = true;
                            a = i + 3;
                            tableLayoutPanel1.Controls[i + 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 9].Enabled = true;
                            c = i + 9;

                        }
                        else if (i == 15)
                        {
                            tableLayoutPanel1.Controls[i - 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 9].Enabled = true;
                            tableLayoutPanel1.Controls[i - 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 3].Enabled = true;
                            tableLayoutPanel1.Controls[i + 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 7].Enabled = true;

                            b = i + 7;

                        }
                        else if (i == 16)
                        {
                            tableLayoutPanel1.Controls[i - 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 9].Enabled = true;
                            tableLayoutPanel1.Controls[i - 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 11].Enabled = true;
                            tableLayoutPanel1.Controls[i - 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 3].Enabled = true;
                            tableLayoutPanel1.Controls[i + 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 7].Enabled = true;

                            b = i + 7;
                        }
                        else if (i == 17)
                        {
                            tableLayoutPanel1.Controls[i - 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 9].Enabled = true;
                            tableLayoutPanel1.Controls[i - 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 11].Enabled = true;

                            tableLayoutPanel1.Controls[i - 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 3].Enabled = true;
                            tableLayoutPanel1.Controls[i - 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 7].Enabled = true;
                            tableLayoutPanel1.Controls[i + 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 3].Enabled = true;
                            a = i + 3;
                            tableLayoutPanel1.Controls[i + 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 7].Enabled = true;

                            b = i + 7;

                        }
                        else if (i == 18)
                        {
                            tableLayoutPanel1.Controls[i - 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 9].Enabled = true;
                            tableLayoutPanel1.Controls[i - 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 11].Enabled = true;

                            tableLayoutPanel1.Controls[i - 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 7].Enabled = true;
                            tableLayoutPanel1.Controls[i + 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 3].Enabled = true;
                            a = i + 3;
                        }
                        else if (i == 19)
                        {
                            tableLayoutPanel1.Controls[i - 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 11].Enabled = true;

                            tableLayoutPanel1.Controls[i - 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 7].Enabled = true;
                            tableLayoutPanel1.Controls[i + 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 3].Enabled = true;
                            a = i + 3;
                        }
                        else if (i == 20)
                        {
                            tableLayoutPanel1.Controls[i - 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 9].Enabled = true;
                            tableLayoutPanel1.Controls[i - 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 3].Enabled = true;
                        }
                        else if (i == 21)
                        {
                            tableLayoutPanel1.Controls[i - 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 11].Enabled = true;
                            tableLayoutPanel1.Controls[i - 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 9].Enabled = true;
                            tableLayoutPanel1.Controls[i - 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 3].Enabled = true;
                        }
                        else if (i == 22)
                        {
                            tableLayoutPanel1.Controls[i - 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 11].Enabled = true;
                            tableLayoutPanel1.Controls[i - 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 9].Enabled = true;
                            tableLayoutPanel1.Controls[i - 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 7].Enabled = true;
                            tableLayoutPanel1.Controls[i - 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 3].Enabled = true;
                        }
                        else if (i == 23)
                        {
                            tableLayoutPanel1.Controls[i - 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 11].Enabled = true;
                            tableLayoutPanel1.Controls[i - 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 9].Enabled = true;
                            tableLayoutPanel1.Controls[i - 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 7].Enabled = true;
                        }
                        else if (i == 24)
                        {
                            tableLayoutPanel1.Controls[i - 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 11].Enabled = true;
                            tableLayoutPanel1.Controls[i - 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 7].Enabled = true;
                        }

                        else
                        {


                            tableLayoutPanel1.Controls[i - 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 9].Enabled = true;
                            tableLayoutPanel1.Controls[i - 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 11].Enabled = true;

                            tableLayoutPanel1.Controls[i - 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 3].Enabled = true;
                            tableLayoutPanel1.Controls[i - 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i - 7].Enabled = true;

                            tableLayoutPanel1.Controls[i + 3].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 3].Enabled = true;
                            a = i + 3;
                            tableLayoutPanel1.Controls[i + 7].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 7].Enabled = true;

                            b = i + 7;

                            tableLayoutPanel1.Controls[i + 9].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 9].Enabled = true;
                            c = i + 9;
                            tableLayoutPanel1.Controls[i + 11].BackColor = Color.DarkGoldenrod;
                            tableLayoutPanel1.Controls[i + 11].Enabled = true;

                            d = i + 11;

                            continue;
                        }
                       
                    
                }
                if (i != a && i != b && i != c && i != d&&i!=0)
                {
                    tableLayoutPanel1.Controls[i].Enabled = false;
                    tableLayoutPanel1.Controls[i].BackColor = Color.White;
                }
                
                for (int j = 0; j < 25; j++)
                {
                    if (tableLayoutPanel1.Controls[j].Text=="X"||tableLayoutPanel1.Controls[j].BackColor==Color.White)
                    {
                        tableLayoutPanel1.Controls[j].Enabled = false;
                        tableLayoutPanel1.Controls[j].BackColor = Color.Gray;
                    }
                  
                }  
                   
                    
            }


        }
    }
}

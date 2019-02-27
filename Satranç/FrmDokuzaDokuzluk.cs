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
    public partial class FrmDokuzluk : Form
    {
        public FrmDokuzluk()
        {
            InitializeComponent();
        }

        private void FrmDokuzluk_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnCount = 9;
            tableLayoutPanel1.RowCount = 9;
            for (int i = 0; i < 81; i++)
            {
                Button button = new Button();
                button.BackColor = Color.White;
                button.Size = new Size(30,30);
                button.Text = i.ToString();
                button.Name = i.ToString();
                button.Click += buttonDokuzluk_Click;
                tableLayoutPanel1.Controls.Add(button);
            }
          
        }

        private void buttonDokuzluk_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0, d = 0;

            Button tıklanan = (sender as Button);


            for (int i = 0; i < 81; i++)
            {
                if (tableLayoutPanel1.Controls[i].Name == tıklanan.Name)
                {
                  
                    
                    tableLayoutPanel1.Controls[i].BackColor = Color.Red;
                    tableLayoutPanel1.Controls[i].Text = "X";
                       
                    if(i==0 )
                    {
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        b = i + 11;
                        tableLayoutPanel1.Controls[i + 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 19].Enabled = true;
                        d = i + 19;
                    }
                    else if (i==1)
                    {
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        b = i + 11;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;
                        c = i + 17;
                        tableLayoutPanel1.Controls[i + 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 19].Enabled = true;
                        d = i + 19;
                    }
                    else if (i == 7)
                    {

                        tableLayoutPanel1.Controls[i + 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 7].Enabled = true;
                        a = i + 7;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;
                        c = i + 17;
                        tableLayoutPanel1.Controls[i + 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 19].Enabled = true;
                        d = i + 19;
                    }
                    else if (i == 8)
                    {

                        tableLayoutPanel1.Controls[i + 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 7].Enabled = true;
                        a = i + 7;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;
                        c= i + 17;
                    }
                    else if (i>=2 && i<=6)
                    {
                        tableLayoutPanel1.Controls[i + 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 7].Enabled = true;
                        a = i + 7;
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        b = i + 11;

                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;
                        c = i + 17;
                        tableLayoutPanel1.Controls[i + 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 19].Enabled = true;
                        d = i + 19;
                    }
                    else if (i == 9)
                    {
                        tableLayoutPanel1.Controls[i - 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i -7].Enabled = true;
                       
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        b = i + 11;
                        tableLayoutPanel1.Controls[i + 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 19].Enabled = true;
                        d = i + 19;
                    }
                    else if (i == 10)
                    {
                        tableLayoutPanel1.Controls[i - 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 7].Enabled = true;
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        b = i + 11;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;
                        c = i + 17;
                        tableLayoutPanel1.Controls[i + 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 19].Enabled = true;

                        d = i + 19;
                    }
                    else if (i>=11&&i<=15)
                    {
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i - 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 7].Enabled = true;
                        tableLayoutPanel1.Controls[i + 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 7].Enabled = true;
                        a = i + 7;
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;

                        b = i + 11;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;
                        c = i + 17;
                        tableLayoutPanel1.Controls[i + 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 19].Enabled = true;

                        d = i + 19;

                    }
                    else if (i==16)
                    {
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i + 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 7].Enabled = true;
                        a = i + 7;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;
                        c = i + 17;
                        tableLayoutPanel1.Controls[i + 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 19].Enabled = true;

                        d = i + 19;
                    }
                    else if (i==17)
                    {
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i + 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 7].Enabled = true;
                        a = i + 7;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;
                        c = i + 17;
                    }
                    else if (i==26||i==35||i==44||i==53||i==62)
                    {
                        tableLayoutPanel1.Controls[i - 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 19].Enabled = true;
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i + 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 7].Enabled = true;
                        a = i + 7;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;
                        c = i + 17;

                    }
                    else if (i == 25 || i == 34 || i == 43 || i == 52 || i == 61)
                    {
                        tableLayoutPanel1.Controls[i - 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 19].Enabled = true;
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;
                        tableLayoutPanel1.Controls[i + 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 7].Enabled = true;
                        a = i + 7;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;
                        c = i + 17;
                        tableLayoutPanel1.Controls[i + 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 19].Enabled = true;
                        d = i + 19;
                    }
                    else if (i == 19 || i == 28 || i == 37 || i == 46 || i == 55)
                    {
                        tableLayoutPanel1.Controls[i - 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 19].Enabled = true;

                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;

                        tableLayoutPanel1.Controls[i - 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 7].Enabled = true;

                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;

                        b = i + 11;
                        tableLayoutPanel1.Controls[i + 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 17].Enabled = true;
                        c = i + 17;
                        tableLayoutPanel1.Controls[i + 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 19].Enabled = true;

                        d = i + 19;
                    }
                    else if (i >= 65 && i <= 69)
                    {
                        tableLayoutPanel1.Controls[i - 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 19].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i - 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 7].Enabled = true;
                        tableLayoutPanel1.Controls[i + 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 7].Enabled = true;
                        a = i + 7;
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        b = i + 11;
                    }
                    else if (i==63)
                    {
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;
                        tableLayoutPanel1.Controls[i - 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 7].Enabled = true;
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        b = i + 11;             
                    }
                    else if (i==64)
                    {
                        tableLayoutPanel1.Controls[i - 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 19].Enabled = true;

                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;

                        tableLayoutPanel1.Controls[i - 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 7].Enabled = true;

                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;

                        b = i + 11;
                    }
                    else if (i==70)
                    {
                        tableLayoutPanel1.Controls[i - 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 19].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i + 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 7].Enabled = true;
                        a = i + 7;
                    }
                    else if (i==71)
                    {
                        tableLayoutPanel1.Controls[i - 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 19].Enabled = true;
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i + 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 7].Enabled = true;
                        a = i + 7;
                    }
                    else if (i == 72)
                    {
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;
                        tableLayoutPanel1.Controls[i - 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 7].Enabled = true;
                     
                    }
                    else if (i==73)
                    {
                        tableLayoutPanel1.Controls[i - 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 19].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;
                        tableLayoutPanel1.Controls[i - 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 7].Enabled = true;
                    }
                    else if (i >= 74 && i <= 78)
                    {
                        tableLayoutPanel1.Controls[i - 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 19].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                        tableLayoutPanel1.Controls[i - 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 7].Enabled = true;
                    }
                    else if (i==79)
                    {
                        tableLayoutPanel1.Controls[i - 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 19].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                    }
                    else if (i==80)
                    {
                        tableLayoutPanel1.Controls[i - 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 19].Enabled = true;
                        tableLayoutPanel1.Controls[i - 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 11].Enabled = true;
                    }
                   
                    else if(i%9==0&&i!=9&&i!=0&&i!=72)
                    {
                        tableLayoutPanel1.Controls[i - 7].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 7].Enabled = true;
                        tableLayoutPanel1.Controls[i - 17].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i - 17].Enabled = true;
                        tableLayoutPanel1.Controls[i + 11].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 11].Enabled = true;
                        b = i + 11;
                        tableLayoutPanel1.Controls[i + 19].BackColor = Color.Blue;
                        tableLayoutPanel1.Controls[i + 19].Enabled = true;
                        d = i + 19;
                    }
                    else
                    
                    {
                       


                    tableLayoutPanel1.Controls[i - 17].BackColor = Color.Blue;
                    tableLayoutPanel1.Controls[i - 17].Enabled = true;
                    tableLayoutPanel1.Controls[i - 19].BackColor = Color.Blue;
                    tableLayoutPanel1.Controls[i - 19].Enabled = true;

                    tableLayoutPanel1.Controls[i - 7].BackColor = Color.Blue;
                    tableLayoutPanel1.Controls[i - 7].Enabled = true;
                    tableLayoutPanel1.Controls[i - 11].BackColor = Color.Blue;
                    tableLayoutPanel1.Controls[i - 11].Enabled = true;

                    tableLayoutPanel1.Controls[i + 7].BackColor = Color.Blue;
                    tableLayoutPanel1.Controls[i + 7].Enabled = true;
                    a = i + 7;
                    tableLayoutPanel1.Controls[i + 11].BackColor = Color.Blue;
                    tableLayoutPanel1.Controls[i + 11].Enabled = true;
                   
                    b = i + 11;
                    tableLayoutPanel1.Controls[i + 17].BackColor = Color.Blue;
                    tableLayoutPanel1.Controls[i + 17].Enabled = true;
                    c = i + 17;
                    tableLayoutPanel1.Controls[i + 19].BackColor = Color.Blue;
                    tableLayoutPanel1.Controls[i + 19].Enabled = true;
                    
                    d = i + 19;
                        continue;
                        
                    }
                    

                }
                if (i!=0&&i != a && i != b && i != c && i != d)
                {
                    tableLayoutPanel1.Controls[i].Enabled = false;
                    tableLayoutPanel1.Controls[i].BackColor = Color.White;
                }
                for (int j = 0; j < 81; j++)
                {
                    if (tableLayoutPanel1.Controls[j].Text == "X" || tableLayoutPanel1.Controls[j].BackColor == Color.White)
                    {
                        tableLayoutPanel1.Controls[j].Enabled = false;
                        tableLayoutPanel1.Controls[j].BackColor = Color.Gray;
                    }

                }
            }
        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
        }

    }
}

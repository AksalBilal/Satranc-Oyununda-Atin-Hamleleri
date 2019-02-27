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
    public partial class FrmHomePage : Form
    {
        public FrmHomePage()
        {
            InitializeComponent();
        }

        private void oyunToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmBeslik beslik = new FrmBeslik();
            beslik.Show();
           
          
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmAltılık altılık = new FrmAltılık();
            altılık.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmYedilik yedilik = new FrmYedilik();
            yedilik.Show();
          
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmSekizlik sekizlik = new FrmSekizlik();
            sekizlik.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmDokuzluk dokuzluk = new FrmDokuzluk();
            dokuzluk.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

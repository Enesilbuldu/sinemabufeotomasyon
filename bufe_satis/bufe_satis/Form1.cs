using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bufe_satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, toplam;
            misir = Convert.ToInt16(TxtMisir.Text);
            su = Convert.ToInt16(Txtsu.Text);
            cay=Convert.ToInt16(Txtcay.Text);
            bilet= Convert.ToInt16(Txtbilet.Text);

            toplam = misir * 4 + su * 1 + cay + 2 + bilet * 8;
            LblToplam.Text = toplam.ToString() + "TL";

            kasatutar = kasatutar + toplam;
            LblKasa.Text = kasatutar.ToString() + "TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Txtbilet.Text = "";
            Txtcay.Text = "";
            Txtsu.Text = "";
            TxtMisir.Text = "";
            TxtMisir.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osoba
{
    public partial class Glavna2 : Form
    {
        public Glavna2()
        {
            InitializeComponent();
        }

        private void raspodelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raspodela frm_s = new raspodela();
            frm_s.Show();
        }

        private void upisniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upisnica frm_s = new upisnica();
            frm_s.Show();
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba frm_osoba = new Osoba();
            frm_osoba.Show();
        }

        private void smeroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifarnik frm_s = new sifarnik("Smer");
            frm_s.Show();
        }

        private void skolskaGodinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifarnik frm_s = new sifarnik("Skolska_godina");
            frm_s.Show();
        }

        private void predmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifarnik frm_s = new sifarnik("Predmet");
            frm_s.Show();
        }

        private void oceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ocena frm_o = new Ocena();
            frm_o.Show();
        }
    }
}

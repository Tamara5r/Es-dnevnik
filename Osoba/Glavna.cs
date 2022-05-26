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
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void osobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba frm_osoba = new Osoba();
            frm_osoba.Show();
        }

        private void Glavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {
            string user = Program.user_ime + "" + Program.user_prezime;
            lbl_korisnik.Text = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void smerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            sifarnik frm_s = new sifarnik("Smer");
            frm_s.Show();
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifarnik frm_s = new sifarnik("osoba");
            frm_s.Show();
        }

        private void skolskaGodinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifarnik frm_s = new sifarnik("Skolska_godina");
            frm_s.Show();
        }

        private void predmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifarnik frm_s = new sifarnik("predmet");
            frm_s.Show();
        }

        private void raspodelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raspodela frm_s = new raspodela();
            frm_s.Show();
        }
    }
}

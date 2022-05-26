using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Osoba
{
    public partial class raspodela : Form
    {
        DataTable ras;
        int br_sloga;
        public raspodela()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Load_data()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from raspodela", veza);
            ras = new DataTable();
            adapter.Fill(ras);
        }

        private void raspodela_Load(object sender, EventArgs e)
        {
            Load_data();
            cmb_fill();
        }
        private void cmb_fill()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter;
            DataTable dt_godina, dt_nastavnik, dt_predmet, dt_odeljenje;
            adapter = new SqlDataAdapter("select * from skolska_godina", veza);
            dt_godina = new DataTable();
            adapter.Fill(dt_godina);

            dt_nastavnik = new DataTable();
            adapter = new SqlDataAdapter("select id, ime as naziv from osoba where uloga = 'profesor' ", veza);
            adapter.Fill(dt_nastavnik);

            dt_odeljenje = new DataTable();
            adapter = new SqlDataAdapter("select id, str(razred)+ indeks as naziv from odeljenje", veza);
            adapter.Fill(dt_odeljenje);

            dt_predmet = new DataTable();
            adapter = new SqlDataAdapter("select id , naziv from predmet", veza);
            adapter.Fill(dt_predmet);

            combogodina.DataSource = dt_godina;
            combogodina.ValueMember = "id";
            combogodina.DisplayMember = "naziv";

            combonastavnik.DataSource = dt_nastavnik;
            combonastavnik.ValueMember = "id";
            combonastavnik.DisplayMember = "naziv";

            comboodeljenje.DataSource = dt_odeljenje;
            comboodeljenje.ValueMember = "id";
            comboodeljenje.DisplayMember = "naziv";

            combopredmet.DataSource = dt_predmet;
            combopredmet.ValueMember = "id";
            combopredmet.DisplayMember = "naziv";

            textBox1.Text = ras.Rows[br_sloga]["id"].ToString();
            if (ras.Rows.Count == 0)
            {
                combonastavnik.SelectedValue = -1;
                comboodeljenje.SelectedValue = -1;
                combopredmet.SelectedValue = -1;
                combogodina.SelectedValue = -1;

            }
            else
            {
                combonastavnik.SelectedValue = ras.Rows[br_sloga]["id_nastavnika"];
                comboodeljenje.SelectedValue = ras.Rows[br_sloga]["id_odeljenja"];
                combopredmet.SelectedValue = ras.Rows[br_sloga]["id_predmeta"];
                combogodina.SelectedValue = ras.Rows[br_sloga]["id_godine"];

            }
            if (br_sloga == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            if (br_sloga == ras.Rows.Count - 1)
            {
                button6.Enabled = false;
                button7.Enabled = false;
            }
            else
            {
                button6.Enabled = true;
                button7.Enabled = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            br_sloga = 0;
            cmb_fill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            br_sloga--;
            cmb_fill();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            br_sloga++;
            cmb_fill();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            br_sloga = ras.Rows.Count - 1;
            cmb_fill();
        }

        private void butn_obrisi_Click(object sender, EventArgs e)
        {
            string naredba = "delete from raspodela where id = " + textBox1.Text;
            SqlConnection veza = Konekcija.Connect();
            SqlCommand comm = new SqlCommand(naredba, veza);
            bool obrisano = false;
            try
            {
                veza.Open();
                comm.ExecuteNonQuery();
                veza.Close();
                obrisano = true;
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            
            if (obrisano)
            {
                Load_data();
                if (br_sloga > 0) br_sloga--;
                cmb_fill();
            }
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("insert into raspodela(id_godine,id_nastavnika, id_predmeta, id_odeljenja) values('");
            Naredba.Append(combogodina.SelectedValue + "' , '");
            Naredba.Append(combonastavnik.SelectedValue + "', '");
            Naredba.Append(combopredmet.SelectedValue + "', '");
            Naredba.Append(comboodeljenje.SelectedValue + "')");
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            cmb_fill();
            br_sloga = ras.Rows.Count - 1;
            Load_data();

        }

        private void btn_izmeni_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("Update raspodela Set ");
            Naredba.Append("id_godine='" + combogodina.SelectedValue);
            Naredba.Append("',id_nastavnika='" + combonastavnik.SelectedValue);
            Naredba.Append("',id_odeljenja='" + comboodeljenje.SelectedValue);
            Naredba.Append("',id_predmeta='" + combopredmet.SelectedValue + "' ");
            Naredba.Append(" where id=" + textBox1.Text);
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            Load_data();
            cmb_fill();
           


        }
    }
}

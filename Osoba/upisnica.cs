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
    public partial class upisnica : Form
    {
        DataTable dt_upisnica;
        public upisnica()
        {
            InitializeComponent();
        }

        private void cmb_godina_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select id,naziv from skolska_godina", veza);
            DataTable dt_godina = new DataTable();
            adapter.Fill(dt_godina);
            comboGodina.DataSource = dt_godina;
            comboGodina.ValueMember = "id";
            comboGodina.DisplayMember = "naziv";
            comboGodina.SelectedValue = 2;
        }

        private void cmb_odeljenje_populate()
        {
            string godina = comboGodina.SelectedValue.ToString();
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, str(razred)+indeks as naziv from odeljenje where id_godina =' " + godina + "'", veza);
            DataTable dt_odeljenje = new DataTable();
            adapter.Fill(dt_odeljenje);
            comboOdeljenje.DataSource = dt_odeljenje;
            comboOdeljenje.ValueMember = "id";
            comboOdeljenje.DisplayMember = "naziv";
        }

        private void upisnica_Load(object sender, EventArgs e)
        {
            cmb_godina_populate();
            comboOdeljenje.SelectedIndex = -1;
            comboUcenik.Enabled = false;
            textBox1.Enabled = false;
        }

        private void comboUcenik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboOdeljenje_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }



        private void comboGodina_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }
        private void cmb_ucenik_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select id,ime + prezime as naziv from osoba where uloga ='ucenik' ", veza);
            DataTable dt_ucenik = new DataTable();
            adapter.Fill(dt_ucenik);
            comboUcenik.DataSource = dt_ucenik;
            comboUcenik.ValueMember = "id";
            comboUcenik.DisplayMember = "naziv";

        }
        private void grid_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select upisnica.id as id_upisnice, id,ime+prezime as naziv,osoba.id as ucenik from upisnica join osoba on osoba.id =id_osobe where id_odeljenja ="+ comboOdeljenje.SelectedValue.ToString(),veza);
            DataTable dt_upisnica = new DataTable();
            adapter.Fill(dt_upisnica);
            dataGridView1.DataSource = dt_upisnica;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns["ucenik"].Visible = false;

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int broj_sloga = dataGridView1.CurrentRow.Index;
                if (dt_upisnica.Rows.Count > 0 && broj_sloga >= 0)
                {
                    comboUcenik.SelectedValue = dataGridView1.Rows[broj_sloga].Cells["ucenik"].Value.ToString();
                    textBox1.Text = dataGridView1.Rows[broj_sloga].Cells["id"].Value.ToString();
                }
            }
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("insert into upisnica (odeljenje_id, osoba_id) values ('");
            naredba.Append(comboOdeljenje.SelectedValue.ToString() + "', '");
            naredba.Append(comboUcenik.SelectedValue.ToString() + "')");
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            grid_populate();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("update upisnica set ");
            naredba.Append("id_osobe = '" + comboUcenik.SelectedValue.ToString() + "' ");
            naredba.Append("where id = " + textBox1.Text);
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            grid_populate();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string naredba = "delete upisnica where id = " + textBox1.Text;
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            grid_populate();
        }

        private void comboGodina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboGodina.IsHandleCreated && comboGodina.Focused)
            {
                cmb_odeljenje_populate();
                comboOdeljenje.SelectedIndex = -1;
                while (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                }
                textBox1.Text = "";
                comboUcenik.SelectedIndex = -1;
                comboUcenik.Enabled = false;
            }
        }

        private void comboOdeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboOdeljenje.IsHandleCreated && comboOdeljenje.Focused)
            {
                cmb_ucenik_populate();
                comboUcenik.Enabled = true;
                grid_populate();

            }
        }
    }
}

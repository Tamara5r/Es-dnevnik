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
    public partial class Ocena : Form
    {
        DataTable dt_ocena;

        public Ocena()
        {
            InitializeComponent();
        }

        private void Ocena_Load(object sender, EventArgs e)
        {
            cmb_godina_populate();
            combo_predmet.Enabled = false;
            combo_odeljenje.Enabled = false;
            combo_ucenik.Enabled = false;
            combo_ocena.Items.Add(1);
            combo_ocena.Items.Add(2);
            combo_ocena.Items.Add(3);
            combo_ocena.Items.Add(4);
            combo_ocena.Items.Add(5);
            //cmb_ocena.Enabled = false;
            cmb_profesor_populate();
        }
        private void cmb_godina_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM skolska_godina", veza);
            DataTable dt_godina = new DataTable();
            adapter.Fill(dt_godina);
            combo_godina.DataSource = dt_godina;
            combo_godina.ValueMember = "id";
            combo_godina.DisplayMember = "naziv";
            combo_godina.SelectedValue = 2;
        }

        private void combo_godina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (combo_godina.IsHandleCreated && combo_godina.Focused)
            {
                cmb_profesor_populate();
            }
        }
        private void cmb_profesor_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            StringBuilder naredba = new StringBuilder("select distinct osoba.id as id, ime + ' ' + prezime AS naziv FROM osoba");
            naredba.Append(" join raspodela on osoba.id = id_nastavnika");
            naredba.Append(" where id_godine = " + combo_godina.SelectedValue.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_profesor = new DataTable();
            adapter.Fill(dt_profesor);
            combo_profesor.DataSource = dt_profesor;
            combo_profesor.ValueMember = "id";
            combo_profesor.DisplayMember = "naziv";
            combo_profesor.SelectedIndex = -1;
        }

        private void combo_profesor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (combo_profesor.IsHandleCreated && combo_profesor.Focused)
            {
                cmb_predmet_populate();
                combo_predmet.Enabled = true;

                combo_odeljenje.SelectedIndex = -1;
                combo_odeljenje.Enabled = false;

                combo_ucenik.SelectedIndex = -1;
                combo_ucenik.Enabled = false;

                combo_ocena.SelectedIndex = -1;
                combo_ocena.Enabled = false;

                dt_ocena = new DataTable();
                dataGridView1.DataSource = dt_ocena;
            }
        }
        private void cmb_predmet_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            StringBuilder naredba = new StringBuilder("select distinct predmet.id as id, naziv from predmet ");
            naredba.Append("join raspodela on predmet.id = id_predmeta ");
            naredba.Append("where id_godine = " + combo_godina.SelectedValue.ToString());
            naredba.Append(" and id_nastavnika = " + combo_profesor.SelectedValue.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_predmet = new DataTable();
            adapter.Fill(dt_predmet);
            combo_predmet.DataSource = dt_predmet;
            combo_predmet.ValueMember = "id";
            combo_predmet.DisplayMember = "naziv";
            combo_predmet.SelectedIndex = -1;
        }

        private void combo_predmet_SelectedValueChanged(object sender, EventArgs e)
        {
            if (combo_predmet.IsHandleCreated && combo_predmet.Focused)
            {
                cmb_odeljenje_populate();
                combo_odeljenje.Enabled = true;
                combo_odeljenje.SelectedIndex = -1;

                combo_ucenik.SelectedIndex = -1;
                combo_ucenik.Enabled = false;

                combo_ocena.SelectedIndex = -1;
                combo_ocena.Enabled = false;

                dt_ocena = new DataTable();
                dataGridView1.DataSource = dt_ocena;
            }
        }
        private void cmb_odeljenje_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            StringBuilder naredba = new StringBuilder("select distinct odeljenje.id as id, STR(razred) + '-' + indeks as naziv Ffrom odeljenje ");
            naredba.Append("join raspodela on odeljenje.id = id_odeljenja ");
            naredba.Append("where raspodela.id_godine = " + combo_godina.SelectedValue.ToString());
            naredba.Append(" and id_nastavnika = " + combo_profesor.SelectedValue.ToString());
            naredba.Append(" and id_predmeta = " + combo_predmet.SelectedValue.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_odeljenje = new DataTable();
            adapter.Fill(dt_odeljenje);
            combo_odeljenje.DataSource = dt_odeljenje;
            combo_odeljenje.ValueMember = "id";
            combo_odeljenje.DisplayMember = "naziv";
            combo_odeljenje.SelectedIndex = -1;
        }

        private void combo_odeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (combo_odeljenje.IsHandleCreated && combo_odeljenje.Focused)
            {
                cmb_ucenik_populate();
                combo_ucenik.Enabled = true;
                combo_ocena.Enabled = true;
                grid_populate();
                ucenik_ocena_id_set(0);
            }
        }
        private void cmb_ucenik_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            StringBuilder naredba = new StringBuilder("select osoba.id as id, ime + ' ' + prezime as naziv from osoba ");
            naredba.Append("join upisnica on osoba.id =id_osobe ");
            naredba.Append("where upisnica.id_odeljenja = " + combo_odeljenje.SelectedValue.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_ucenik = new DataTable();
            adapter.Fill(dt_ucenik);
            combo_ucenik.DataSource = dt_ucenik;
            combo_ucenik.ValueMember = "id";
            combo_ucenik.DisplayMember = "naziv";
            combo_ucenik.SelectedIndex = -1;
        }
        private void grid_populate()
        {
            StringBuilder naredba = new StringBuilder("selectT ocena.id AS id, ime + ' ' + prezime AS naziv, ocena, id_ucenika, datum FROM osoba ");
            naredba.Append("join ocena on osoba.id = id_ucenika ");
            naredba.Append("join raspodela on id_raspodele = raspodela.id ");
            naredba.Append("where id_raspodele = ");
            naredba.Append("(select id from raspodela ");
            naredba.Append("where id_godine = " + combo_godina.SelectedValue.ToString());
            naredba.Append(" and id_nastavnika = " + combo_profesor.SelectedValue.ToString());
            naredba.Append(" and id_predmeta = " + combo_predmet.SelectedValue.ToString());
            naredba.Append(" and id_odeljenja = " + combo_odeljenje.SelectedValue.ToString() + ")");

            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            dt_ocena = new DataTable();
            adapter.Fill(dt_ocena);
            dataGridView1.DataSource = dt_ocena;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns["ucenik_id"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ucenik_ocena_id_set(e.RowIndex);
            }
        }
        private void ucenik_ocena_id_set(int broj_sloga)
        {
            combo_ucenik.SelectedValue = dt_ocena.Rows[broj_sloga]["ucenik_id"];
            combo_ocena.SelectedItem = dt_ocena.Rows[broj_sloga]["ocena"];
            textBox1.Text = dt_ocena.Rows[broj_sloga]["id"].ToString();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("SELECT id FROM raspodela ");
            naredba.Append("WHERE godina_id = " + combo_godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + combo_profesor.SelectedValue.ToString());
            naredba.Append(" AND predmet_id = " + combo_predmet.SelectedValue.ToString());
            naredba.Append(" AND odeljenje_id = " + combo_odeljenje.SelectedValue.ToString());

            SqlConnection veza = Konekcija.Connect();
            SqlCommand comm = new SqlCommand(naredba.ToString(), veza);
            int id_raspodele = 0;

            try
            {
                veza.Open();
                id_raspodele = (int)comm.ExecuteScalar();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }

            if (id_raspodele > 0)
            {
                naredba = new StringBuilder("INSERT INTO ocena (datum, raspodela_id, ucenik_id, ocena) VALUES('");
                DateTime datum = dateTimePicker1.Value;
                naredba.Append(datum.ToString("yyyy-MM-dd") + "', '");
                naredba.Append(id_raspodele.ToString() + "', '");
                naredba.Append(combo_ucenik.SelectedValue.ToString() + "', '");
                naredba.Append(combo_ocena.SelectedItem.ToString() + "')");

                comm = new SqlCommand(naredba.ToString(), veza);

                try
                {
                    veza.Open();
                    comm.ExecuteNonQuery();
                    veza.Close();
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
            }

            grid_populate();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            DateTime datum = dateTimePicker1.Value;

            if (Convert.ToInt32(textBox1.Text) > 0)
            {
                StringBuilder naredba = new StringBuilder("update ocena set ");
                naredba.Append(" id_ucenik = '" + combo_ucenik.SelectedValue.ToString() + "', ");
                naredba.Append("ocena = '" + combo_ocena.SelectedItem.ToString() + "', ");
                naredba.Append("datum = '" + datum.ToString("yyyy-MM-dd") + "' ");
                naredba.Append("where id = " + textBox1.Text);

                SqlConnection veza = Konekcija.Connect();
                SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

                try
                {
                    veza.Open();
                    komanda.ExecuteNonQuery();
                    veza.Close();
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
                grid_populate();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) > 0)
            {
                string naredba = "delete from ocena id = " + textBox1.Text;
                SqlConnection veza = Konekcija.Connect();
                SqlCommand komanda = new SqlCommand(naredba, veza);
                try
                {
                    veza.Open();
                    komanda.ExecuteNonQuery();
                    veza.Close();
                    grid_populate();
                    ucenik_ocena_id_set(0);
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
            }
        }
    }
}



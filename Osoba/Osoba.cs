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
    public partial class Osoba : Form
    {
        int br_sloga = 0;
        DataTable tabela;

        public Osoba()
        {
            InitializeComponent();
        }

        private void Osoba_Load(object sender, EventArgs e)
        {
            Load_Data();
            Txt_load();
        }

        private void Load_Data()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from osoba",veza);
            tabela = new DataTable();
            adapter.Fill(tabela);

        }
        
        private void Txt_load()
        { if(tabela.Rows.Count == -1)
            {
                text_adresa.Text = "";
                text_email.Text = "";
                text_id.Text = "";
                text_ime.Text = "";
                text_jmbg.Text = "";
                text_pass.Text = "";
                text_prezime.Text = "";
                text_uloga.Text = "";
            }
            else { 
            text_id.Text = tabela.Rows[br_sloga]["id"].ToString();
            text_ime.Text = tabela.Rows[br_sloga]["ime"].ToString();
            text_prezime.Text = tabela.Rows[br_sloga]["prezime"].ToString();
            text_adresa.Text = tabela.Rows[br_sloga]["adresa"].ToString();
            text_jmbg.Text = tabela.Rows[br_sloga]["jmbg"].ToString();
            text_email.Text = tabela.Rows[br_sloga]["email"].ToString();
            text_pass.Text = tabela.Rows[br_sloga]["pass"].ToString();
            text_uloga.Text = tabela.Rows[br_sloga]["uloga"].ToString();
            }
        if(br_sloga == 0)
            {
                button_prvi.Enabled = false;
                button_prosli.Enabled = false;
            }
            else
            {
                button_prvi.Enabled =true;
                button_prosli.Enabled = true;
            }
            if (br_sloga == tabela.Rows.Count -1)
            {
                button_sledeci.Enabled = false;
                button_poslednji.Enabled = false;
            }
            else
            {
                button_sledeci.Enabled = true;
                button_poslednji.Enabled = true;
            }
        }

        private void button_prvi_Click(object sender, EventArgs e)
        {
            br_sloga = 0;
            Txt_load();
        }

        private void button_prosli_Click(object sender, EventArgs e)
        {
            br_sloga = br_sloga - 1;
            Txt_load();
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("insert into osoba(ime,prezime,adresa,jmbg,email,pass,uloga) values('");
            Naredba.Append(text_ime.Text + "' , '");
            Naredba.Append(text_prezime.Text + "', '");
            Naredba.Append(text_adresa.Text + "', '");
            Naredba.Append(text_jmbg.Text + "', '");
            Naredba.Append(text_email.Text + "', '");
            Naredba.Append(text_pass.Text + "', '");
            Naredba.Append(text_uloga.Text + "')");
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            Load_Data();
            br_sloga = tabela.Rows.Count - 1;
            Txt_load();

        }

        private void button_sledeci_Click(object sender, EventArgs e)
        {
            br_sloga = br_sloga + 1;
            Txt_load();
        }

        private void button_poslednji_Click(object sender, EventArgs e)
        {
            br_sloga = tabela.Rows.Count -1;
            Txt_load();
        }

        private void button_izmeni_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("Update osoba Set(");
            Naredba.Append("ime='" + text_ime);
            Naredba.Append("',prezime='" + text_prezime);
            Naredba.Append("',adresa='" + text_adresa);
            Naredba.Append("',jmbg='" + text_jmbg);
            Naredba.Append("',email='" + text_email);
            Naredba.Append("',pass='" + text_pass);
            Naredba.Append("',uloga='" + text_uloga +"') ");
            Naredba.Append(" where id=" + text_id.Text);
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
            Load_Data();
            br_sloga = tabela.Rows.Count - 1;
            Txt_load();

        
        }

        private void button_brisi_Click(object sender, EventArgs e)
        {
            string naredba = "delete from osoba where id = " + text_id.Text;
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
            Load_Data();
            br_sloga = tabela.Rows.Count - 1;
            Txt_load();
            if (obrisano)
            {
                Load_Data();
                if (br_sloga > 0) br_sloga--;
                Txt_load();
            }

        }
    }
}

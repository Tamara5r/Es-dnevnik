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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Proveri_Click(object sender, EventArgs e)
        {
            if(text_name1.Text == "" || text_password.Text == "")
            {
                MessageBox.Show("Nisu uneti svi podaci. Molimo ponovite unos");
            }
            else
            {
                try
                {
                    SqlConnection conn = Konekcija.Connect();
                    SqlCommand comm = new SqlCommand("select * from osoba where email = @gmail", conn);
                    comm.Parameters.AddWithValue("@gmail", text_name1.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    int brojac = tabela.Rows.Count;
                    if(brojac == 1)
                    {
                        if(String.Compare(tabela.Rows[0]["pass"].ToString(), text_password.Text)==0)
                        {
                            MessageBox.Show("Uspesan login");
                            this.Hide();
                        
                            Program.user_ime = tabela.Rows[0]["ime"].ToString();
                            Program.user_prezime = tabela.Rows[0]["prezime"].ToString();
                            Program.user_uloga = tabela.Rows[0]["uloga"].ToString();
                             Glavna frm_glavna = new Glavna();
                             frm_glavna.Show();
                        }
                        else
                        {
                            MessageBox.Show("Neispravna lozinka");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nepostojeci email");


                    }

                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }

        private void text_name1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class sifarnik : Form
    {
        SqlDataAdapter adapter;
        DataTable tabela;
        string ime_tabele;
        
        public sifarnik(string tabela)
        {
            ime_tabele = tabela;
            InitializeComponent();
        }

        private void sifarnik_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("select * from "+ ime_tabele, Konekcija.Connect());
            tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataGridView1.Columns["id"].ReadOnly = true;

        }

        private void butt_Click(object sender, EventArgs e)
        {
            DataTable menjamo = tabela.GetChanges();
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            if(menjamo != null)
            {
                adapter.Update(menjamo);
                this.Close();
            }

        }
    }
}

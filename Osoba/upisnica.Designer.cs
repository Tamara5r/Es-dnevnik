
namespace Osoba
{
    partial class upisnica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboGodina = new System.Windows.Forms.ComboBox();
            this.comboUcenik = new System.Windows.Forms.ComboBox();
            this.comboOdeljenje = new System.Windows.Forms.ComboBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.godina_lbl = new System.Windows.Forms.Label();
            this.Ucenik_lbl = new System.Windows.Forms.Label();
            this.Odeljenje_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 22);
            this.textBox1.TabIndex = 0;
            // 
            // comboGodina
            // 
            this.comboGodina.FormattingEnabled = true;
            this.comboGodina.Location = new System.Drawing.Point(153, 86);
            this.comboGodina.Name = "comboGodina";
            this.comboGodina.Size = new System.Drawing.Size(114, 24);
            this.comboGodina.TabIndex = 1;
            this.comboGodina.SelectedIndexChanged += new System.EventHandler(this.comboGodina_SelectedIndexChanged);
            this.comboGodina.SelectedValueChanged += new System.EventHandler(this.comboGodina_SelectedValueChanged);
            // 
            // comboUcenik
            // 
            this.comboUcenik.FormattingEnabled = true;
            this.comboUcenik.Location = new System.Drawing.Point(280, 86);
            this.comboUcenik.Name = "comboUcenik";
            this.comboUcenik.Size = new System.Drawing.Size(114, 24);
            this.comboUcenik.TabIndex = 2;
            this.comboUcenik.SelectedIndexChanged += new System.EventHandler(this.comboUcenik_SelectedIndexChanged);
            // 
            // comboOdeljenje
            // 
            this.comboOdeljenje.FormattingEnabled = true;
            this.comboOdeljenje.Location = new System.Drawing.Point(407, 86);
            this.comboOdeljenje.Name = "comboOdeljenje";
            this.comboOdeljenje.Size = new System.Drawing.Size(114, 24);
            this.comboOdeljenje.TabIndex = 3;
            this.comboOdeljenje.SelectedIndexChanged += new System.EventHandler(this.comboOdeljenje_SelectedIndexChanged);
            this.comboOdeljenje.SelectedValueChanged += new System.EventHandler(this.comboOdeljenje_SelectedValueChanged);
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(47, 39);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(19, 17);
            this.id_lbl.TabIndex = 4;
            this.id_lbl.Text = "id";
            // 
            // godina_lbl
            // 
            this.godina_lbl.AutoSize = true;
            this.godina_lbl.Location = new System.Drawing.Point(150, 39);
            this.godina_lbl.Name = "godina_lbl";
            this.godina_lbl.Size = new System.Drawing.Size(54, 17);
            this.godina_lbl.TabIndex = 5;
            this.godina_lbl.Text = "Godina";
            // 
            // Ucenik_lbl
            // 
            this.Ucenik_lbl.AutoSize = true;
            this.Ucenik_lbl.Location = new System.Drawing.Point(277, 39);
            this.Ucenik_lbl.Name = "Ucenik_lbl";
            this.Ucenik_lbl.Size = new System.Drawing.Size(51, 17);
            this.Ucenik_lbl.TabIndex = 6;
            this.Ucenik_lbl.Text = "Ucenik";
            // 
            // Odeljenje_lbl
            // 
            this.Odeljenje_lbl.AutoSize = true;
            this.Odeljenje_lbl.Location = new System.Drawing.Point(404, 39);
            this.Odeljenje_lbl.Name = "Odeljenje_lbl";
            this.Odeljenje_lbl.Size = new System.Drawing.Size(68, 17);
            this.Odeljenje_lbl.TabIndex = 7;
            this.Odeljenje_lbl.Text = "Odeljenje";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 248);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(253, 144);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(75, 23);
            this.button_insert.TabIndex = 9;
            this.button_insert.Text = "unesi";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(380, 144);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "izmeni";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(507, 144);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "obrisi";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // upisnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Odeljenje_lbl);
            this.Controls.Add(this.Ucenik_lbl);
            this.Controls.Add(this.godina_lbl);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.comboOdeljenje);
            this.Controls.Add(this.comboUcenik);
            this.Controls.Add(this.comboGodina);
            this.Controls.Add(this.textBox1);
            this.Name = "upisnica";
            this.Text = "upisnica";
            this.Load += new System.EventHandler(this.upisnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboGodina;
        private System.Windows.Forms.ComboBox comboUcenik;
        private System.Windows.Forms.ComboBox comboOdeljenje;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label godina_lbl;
        private System.Windows.Forms.Label Ucenik_lbl;
        private System.Windows.Forms.Label Odeljenje_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
    }
}
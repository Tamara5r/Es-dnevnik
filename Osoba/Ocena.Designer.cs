
namespace Osoba
{
    partial class Ocena
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
            this.combo_godina = new System.Windows.Forms.ComboBox();
            this.combo_profesor = new System.Windows.Forms.ComboBox();
            this.combo_predmet = new System.Windows.Forms.ComboBox();
            this.combo_odeljenje = new System.Windows.Forms.ComboBox();
            this.combo_ucenik = new System.Windows.Forms.ComboBox();
            this.combo_ocena = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_godina
            // 
            this.combo_godina.FormattingEnabled = true;
            this.combo_godina.Location = new System.Drawing.Point(13, 38);
            this.combo_godina.Name = "combo_godina";
            this.combo_godina.Size = new System.Drawing.Size(121, 24);
            this.combo_godina.TabIndex = 0;
            this.combo_godina.SelectedValueChanged += new System.EventHandler(this.combo_godina_SelectedValueChanged);
            // 
            // combo_profesor
            // 
            this.combo_profesor.FormattingEnabled = true;
            this.combo_profesor.Location = new System.Drawing.Point(140, 38);
            this.combo_profesor.Name = "combo_profesor";
            this.combo_profesor.Size = new System.Drawing.Size(121, 24);
            this.combo_profesor.TabIndex = 1;
            this.combo_profesor.SelectedValueChanged += new System.EventHandler(this.combo_profesor_SelectedValueChanged);
            // 
            // combo_predmet
            // 
            this.combo_predmet.FormattingEnabled = true;
            this.combo_predmet.Location = new System.Drawing.Point(267, 38);
            this.combo_predmet.Name = "combo_predmet";
            this.combo_predmet.Size = new System.Drawing.Size(121, 24);
            this.combo_predmet.TabIndex = 2;
            this.combo_predmet.SelectedValueChanged += new System.EventHandler(this.combo_predmet_SelectedValueChanged);
            // 
            // combo_odeljenje
            // 
            this.combo_odeljenje.FormattingEnabled = true;
            this.combo_odeljenje.Location = new System.Drawing.Point(394, 38);
            this.combo_odeljenje.Name = "combo_odeljenje";
            this.combo_odeljenje.Size = new System.Drawing.Size(121, 24);
            this.combo_odeljenje.TabIndex = 3;
            this.combo_odeljenje.SelectedValueChanged += new System.EventHandler(this.combo_odeljenje_SelectedValueChanged);
            // 
            // combo_ucenik
            // 
            this.combo_ucenik.FormattingEnabled = true;
            this.combo_ucenik.Location = new System.Drawing.Point(521, 38);
            this.combo_ucenik.Name = "combo_ucenik";
            this.combo_ucenik.Size = new System.Drawing.Size(121, 24);
            this.combo_ucenik.TabIndex = 4;
            // 
            // combo_ocena
            // 
            this.combo_ocena.FormattingEnabled = true;
            this.combo_ocena.Location = new System.Drawing.Point(648, 38);
            this.combo_ocena.Name = "combo_ocena";
            this.combo_ocena.Size = new System.Drawing.Size(121, 24);
            this.combo_ocena.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(440, 105);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(75, 23);
            this.button_insert.TabIndex = 8;
            this.button_insert.Text = "Insert";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(521, 105);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 9;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(602, 105);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 257);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Godina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Profesor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Predmet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Odeljenje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ucenik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(646, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ocena";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Datum";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(773, 22);
            this.textBox2.TabIndex = 20;
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.combo_ocena);
            this.Controls.Add(this.combo_ucenik);
            this.Controls.Add(this.combo_odeljenje);
            this.Controls.Add(this.combo_predmet);
            this.Controls.Add(this.combo_profesor);
            this.Controls.Add(this.combo_godina);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_godina;
        private System.Windows.Forms.ComboBox combo_profesor;
        private System.Windows.Forms.ComboBox combo_predmet;
        private System.Windows.Forms.ComboBox combo_odeljenje;
        private System.Windows.Forms.ComboBox combo_ucenik;
        private System.Windows.Forms.ComboBox combo_ocena;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
    }
}

namespace Osoba
{
    partial class Login
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
            this.text_name1 = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.Dobrodosli = new System.Windows.Forms.Label();
            this.Proveri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_name1
            // 
            this.text_name1.Location = new System.Drawing.Point(211, 159);
            this.text_name1.Name = "text_name1";
            this.text_name1.Size = new System.Drawing.Size(313, 22);
            this.text_name1.TabIndex = 0;
            this.text_name1.TextChanged += new System.EventHandler(this.text_name1_TextChanged);
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(211, 187);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(313, 22);
            this.text_password.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(104, 159);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(80, 187);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(69, 17);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password";
            // 
            // Dobrodosli
            // 
            this.Dobrodosli.AutoSize = true;
            this.Dobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dobrodosli.Location = new System.Drawing.Point(248, 59);
            this.Dobrodosli.Name = "Dobrodosli";
            this.Dobrodosli.Size = new System.Drawing.Size(188, 39);
            this.Dobrodosli.TabIndex = 4;
            this.Dobrodosli.Text = "Ulogujte se";
            // 
            // Proveri
            // 
            this.Proveri.Location = new System.Drawing.Point(255, 260);
            this.Proveri.Name = "Proveri";
            this.Proveri.Size = new System.Drawing.Size(181, 23);
            this.Proveri.TabIndex = 5;
            this.Proveri.Text = "OK";
            this.Proveri.UseVisualStyleBackColor = true;
            this.Proveri.Click += new System.EventHandler(this.Proveri_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Proveri);
            this.Controls.Add(this.Dobrodosli);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_name1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_name1;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label Dobrodosli;
        private System.Windows.Forms.Button Proveri;
    }
}
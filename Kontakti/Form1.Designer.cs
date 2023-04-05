namespace Kontakti
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtRedniBroj = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnDodajKontakt = new System.Windows.Forms.Button();
            this.btnPronadjiKontakt = new System.Windows.Forms.Button();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Redni broj: ";
            this.label1.Visible = false;
            // 
            // txtRedniBroj
            // 
            this.txtRedniBroj.Location = new System.Drawing.Point(96, 32);
            this.txtRedniBroj.Name = "txtRedniBroj";
            this.txtRedniBroj.Size = new System.Drawing.Size(100, 23);
            this.txtRedniBroj.TabIndex = 1;
            this.txtRedniBroj.Visible = false;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(96, 79);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(239, 23);
            this.txtIme.TabIndex = 3;
            this.txtIme.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime:";
            this.label2.Visible = false;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(96, 126);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(239, 23);
            this.txtPrezime.TabIndex = 5;
            this.txtPrezime.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prezime:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon:";
            this.label4.Visible = false;
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.Location = new System.Drawing.Point(96, 191);
            this.mtxtTelefon.Mask = "999/ 000-0009";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(71, 23);
            this.mtxtTelefon.TabIndex = 7;
            this.mtxtTelefon.Visible = false;
            // 
            // btnDodajKontakt
            // 
            this.btnDodajKontakt.Location = new System.Drawing.Point(19, 262);
            this.btnDodajKontakt.Name = "btnDodajKontakt";
            this.btnDodajKontakt.Size = new System.Drawing.Size(316, 38);
            this.btnDodajKontakt.TabIndex = 8;
            this.btnDodajKontakt.Text = "Dodaj kontakt";
            this.btnDodajKontakt.UseVisualStyleBackColor = true;
            this.btnDodajKontakt.Visible = false;
            this.btnDodajKontakt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPronadjiKontakt
            // 
            this.btnPronadjiKontakt.Location = new System.Drawing.Point(19, 319);
            this.btnPronadjiKontakt.Name = "btnPronadjiKontakt";
            this.btnPronadjiKontakt.Size = new System.Drawing.Size(316, 38);
            this.btnPronadjiKontakt.TabIndex = 9;
            this.btnPronadjiKontakt.Text = "Pronadji kontakt";
            this.btnPronadjiKontakt.UseVisualStyleBackColor = true;
            this.btnPronadjiKontakt.Visible = false;
            this.btnPronadjiKontakt.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(144, 173);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(175, 25);
            this.btnPrijava.TabIndex = 14;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(144, 99);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(221, 23);
            this.txtLozinka.TabIndex = 13;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(144, 32);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(221, 23);
            this.txtKorisnickoIme.TabIndex = 12;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(40, 99);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(50, 15);
            this.lblLozinka.TabIndex = 11;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(2, 40);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(88, 15);
            this.lblKorisnickoIme.TabIndex = 10;
            this.lblKorisnickoIme.Text = "Korisnicko ime:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 528);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.btnPronadjiKontakt);
            this.Controls.Add(this.btnDodajKontakt);
            this.Controls.Add(this.mtxtTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRedniBroj);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kontakti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtRedniBroj;
        private TextBox txtIme;
        private Label label2;
        private TextBox txtPrezime;
        private Label label3;
        private Label label4;
        private MaskedTextBox mtxtTelefon;
        private Button btnDodajKontakt;
        private Button btnPronadjiKontakt;
        private Button btnPrijava;
        private TextBox txtLozinka;
        private TextBox txtKorisnickoIme;
        private Label lblLozinka;
        private Label lblKorisnickoIme;
    }
}
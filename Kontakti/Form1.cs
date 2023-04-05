namespace Kontakti
{
    public partial class Form1 : Form
    {
        private List<Contact> listaKontakata = new List<Contact>();
        private Dictionary<string, string> recnik = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Login";
            txtLozinka.PasswordChar = '*';

            recnik["milan"] = "milan1";
            recnik["ana"] = "ana1";
            recnik["uros"] = "uros1";
            this.Size = new Size(500, 350);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!mtxtTelefon.MaskCompleted)
            {
                MessageBox.Show("Broj telefona nije ispravno unet.");
                return;
            }
            else
            {
                int broj = int.Parse(txtRedniBroj.Text);
                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;
                string telefon = mtxtTelefon.Text;
                Contact novaOsoba = new Contact(broj, ime, prezime, telefon);
                listaKontakata.Add(novaOsoba);
                Text = "Kontakti - " + listaKontakata.Count + " broj kontakata";
                txtRedniBroj.Clear();
                txtIme.Clear();
                txtPrezime.Clear();
                mtxtTelefon.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtRedniBroj.Text != "")
            {
                int b = int.Parse(txtRedniBroj.Text);
                foreach (Contact con in listaKontakata)
                {
                    if (con.RedniBroj == b)
                    {
                        txtIme.Text = con.Ime;
                        txtPrezime.Text = con.Prezime;
                        mtxtTelefon.Text = con.Telefon;
                        return;
                    }
                }
            }
            else if (txtIme.Text != "" && txtPrezime.Text != "")
            {
                string im = txtIme.Text;
                string pr = txtPrezime.Text;
                foreach (Contact con in listaKontakata)
                {
                    if (con.Ime == im && con.Prezime == pr)
                    {
                        txtRedniBroj.Text = con.RedniBroj.ToString();
                        mtxtTelefon.Text = con.Telefon;
                        return;
                    }
                }
            }
            else if (mtxtTelefon.Text != "")
            {
                string mtel = mtxtTelefon.Text;
                foreach (Contact con in listaKontakata)
                {
                    if (con.Telefon == mtel)
                    {
                        txtRedniBroj.Text = con.RedniBroj.ToString();
                        txtIme.Text = con.Ime;
                        txtPrezime.Text = con.Prezime;
                        return;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;

            if (recnik.Keys.Contains(korisnickoIme))
            {
                if (recnik[korisnickoIme] == lozinka)
                {
                    txtKorisnickoIme.Visible = false;
                    txtLozinka.Visible = false;
                    lblKorisnickoIme.Visible = false;
                    lblLozinka.Visible = false;
                    btnPrijava.Visible = false;
                    txtRedniBroj.Visible = true;
                    txtIme.Visible = true;
                    txtPrezime.Visible = true;
                    mtxtTelefon.Visible = true;
                    btnDodajKontakt.Visible = true;
                    btnPronadjiKontakt.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    this.Size = new Size(400, 500);
                }
                else
                    MessageBox.Show("Lozinka nije ispravna");
            }
            else
            {
                MessageBox.Show("Korisnicko ime ne postoji");
            }
        }
    }

    internal class Contact
    {
        private int redniBroj;
        private string ime;
        private string prezime;
        private string telefon;

        public Contact(int redniBroj, string ime, string prezime, string telefon)
        {
            this.RedniBroj = redniBroj;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Telefon = telefon;
        }

        public int RedniBroj { get => redniBroj; set => redniBroj = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Telefon { get => telefon; set => telefon = value; }
    }
}
namespace Kontakti
{
    public partial class Form1 : Form
    {
        private List<Contact> listaKontakata = new List<Contact>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
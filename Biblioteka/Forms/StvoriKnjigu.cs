using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class StvoriKnjigu : childForm
    {
        public StvoriKnjigu()
        {
            
        }
        static Form1 main = new Form1();
        public StvoriKnjigu(Form1 form)
        {
            InitializeComponent();
            main = form;
        }

        private void StvoriKnjigu_Load(object sender, EventArgs e)
        {

        }
        List<knjiga> knjige_list = new List<knjiga>();
        internal List<knjiga> Knjige_list { get => knjige_list; set => knjige_list = value; }
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string naziv = txtNaziv.Text, pisac = txtPisac.Text, izdavac = txtIzdavac.Text;
            int isbn = Convert.ToInt32(txtISBN.Text), godina_izdanja = Convert.ToInt32(txtGodinaIzdavanja.Text), broj_kopija = Convert.ToInt32(txtBrojKnjiga.Text);
            knjiga knjiga = new knjiga(naziv, isbn, godina_izdanja, broj_kopija,pisac, izdavac);
            txtBrojKnjiga.Clear();
            txtGodinaIzdavanja.Clear();
            txtISBN.Clear();
            txtIzdavac.Clear();
            txtNaziv.Clear();
            txtPisac.Clear();
            knjige_list.Add(knjiga);
        }
         
        private void CloseForm()
        {
            main.GettingCreatedObjects(this);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}

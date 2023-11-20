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
            InitializeComponent();
        }

        private void StvoriKnjigu_Load(object sender, EventArgs e)
        {

        }

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
        }
    }
}

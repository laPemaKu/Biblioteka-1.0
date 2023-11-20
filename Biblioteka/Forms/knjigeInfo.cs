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
    public partial class knjigeInfo : childForm
    {
        List<knjiga> knjige_list = new List<knjiga>();
        internal List<knjiga> Knjige_list { get => knjige_list; set => knjige_list = value; }
        public int Isbn1 { get => Isbn; set => Isbn = value; }

        int Isbn;
        public knjigeInfo(int isbn)
        {
            InitializeComponent();
            this.Isbn = isbn;
        }

        private void knjigeInfo_Load(object sender, EventArgs e)
        {
            foreach(knjiga knjiga in knjige_list)
            {
                if (knjiga.Isbn ==Isbn) {
                    txtNaziv.Text = knjiga.Naziv;
                    txtIzdavac.Text = knjiga.Izdavac;
                    txtGodinaIzdavanja.Text = knjiga.Godina_izdavanja + "";
                    txtPisac.Text = knjiga.Pisac;
                    txtBrojKnjiga.Text = knjiga.Broj_kopija + "";
                    txtISBN.Text = knjiga.Isbn + "";
                    break;
                }
            }
        }
    }
}

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
        private List<knjiga> list = new List<knjiga>();
        public knjigeInfo(Form1 form)
        {
            InitializeComponent();
            list = form.knjige_main;
        }

        private void knjigeInfo_Load(object sender, EventArgs e)
        {
            
        }

        public void Pretrazi(int isbn)
        {

            foreach (knjiga knjiga in list)
            {
                if (knjiga.Isbn == isbn)
                {
                    txtNaziv.Text = knjiga.Naziv;
                    txtIzdavac.Text = knjiga.Izdavac;
                    txtGodinaIzdavanja.Text = knjiga.Godina_izdavanja + "";
                    txtPisac.Text = knjiga.Pisac;
                    txtBrojKnjiga.Text = knjiga.Broj_kopija + "";
                    txtISBN.Text = knjiga.Isbn + "";
                    if (knjiga.Broj_kopija>0)
                    {
                                            
                    }
                        break;
                }
            }
        }

        private void btnPodizanjeKnjige_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

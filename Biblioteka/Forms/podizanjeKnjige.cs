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
    public partial class podizanjeKnjige : childForm
    {
        Form1 form;
        internal List<string> list_knj;
        List<knjiga> lista_knjiga = new List<knjiga>();
        public podizanjeKnjige(Form1 forma)
        {
            InitializeComponent();
            form = forma;
            lista_knjiga = forma.knjige_main;
            foreach (knjiga i in lista_knjiga)
            {
                list_knj.Add(i.Naziv + "\t\t" + i.Broj_kopija);
            }
        }

        public podizanjeKnjige(Form1 forma, string email, List<string> lista_knjiga)
        {
            InitializeComponent();
            form = forma;
            txtEMail.Text = email;
            list_knj = lista_knjiga;
            foreach(string i in lista_knjiga)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnOdabir_Click(object sender, EventArgs e)
        {
            if (list_knj == null)
            {
                KnjigaOdabir fomr = new KnjigaOdabir(form, txtEMail.Text, this);
                form.openForm(fomr);
            }else
            {
                KnjigaOdabir fomr = new KnjigaOdabir(form, txtEMail.Text, list_knj, this);
                form.openForm(fomr);
            }
            
        }

        private void dtpPocetnoVrijeme_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}

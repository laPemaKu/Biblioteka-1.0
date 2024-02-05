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
    public partial class KnjigaOdabir : childForm
    {
        Form1 forma;
        List<knjiga> lista;
        string emailk;
        List<string> lista_knj = new List<string>();
        public KnjigaOdabir(Form1 form, string email)
        {
            InitializeComponent();
            forma = form;
            lista = forma.knjige_main;
            emailk = email;
            foreach (knjiga i in lista)
            {
                if (i.Broj_kopija > 0)
                {
                    listBox1.Items.Add(i.Naziv + "\t\t" + i.Broj_kopija);
                }
            }
        }
        public KnjigaOdabir(Form1 form, string email, List<string> lista_Knjiga)
        {
            InitializeComponent();
            forma = form;
            lista = forma.knjige_main;
            emailk = email;
            lista_knj = lista_Knjiga;
            foreach (knjiga i in lista)
            {
                if (i.Broj_kopija > 0)
                {
                    listBox1.Items.Add(i.Naziv + "\t\t" + i.Broj_kopija);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (knjiga i in lista)
            {
                if (i.Broj_kopija > 0)
                {
                    if (i.Naziv == txtSearch.Text)
                    {
                        listBox1.Items.Add(i.Naziv + "\t\t" + i.Broj_kopija);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (knjiga i in lista)
            {
                if (i.Broj_kopija > 0)
                {
                    listBox1.Items.Add(i.Naziv + "\t\t" + i.Broj_kopija);
                }
            }
            txtSearch.Clear();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            foreach (knjiga i in lista)
            {
                if(i.Naziv + "\t\t" + i.Broj_kopija == listBox1.Text)
                {
                    i.Broj_kopija--;
                    lista_knj.Add(i.Naziv + "\t\t" + "1");
                }
            }
            podizanjeKnjige pod = new podizanjeKnjige(forma, emailk, lista_knj);
            forma.openForm(pod);

        }
        
    }
}

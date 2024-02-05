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
        List<string> list_knj;
        public podizanjeKnjige(Form1 forma)
        {
            InitializeComponent();
            form = forma;
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
                KnjigaOdabir fomr = new KnjigaOdabir(form, txtEMail.Text);
                form.openForm(fomr);
            }else
            {
                KnjigaOdabir fomr = new KnjigaOdabir(form, txtEMail.Text, list_knj);
                form.openForm(fomr);
            }
            
        }

        private void dtpPocetnoVrijeme_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}

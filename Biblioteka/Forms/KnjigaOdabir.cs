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
        public KnjigaOdabir(Form1 form, string email, DateTime vrijemePodizanja, DateTime vrijemeVračanja)
        {
            InitializeComponent();
            forma = form;
            lista = forma.knjige_main;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}

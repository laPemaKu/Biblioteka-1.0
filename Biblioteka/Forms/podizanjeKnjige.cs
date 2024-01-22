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
        public podizanjeKnjige(Form1 forma)
        {
            InitializeComponent();
            form = forma;
        }

        private void btnOdabir_Click(object sender, EventArgs e)
        {

            KnjigaOdabir fomr;
        }

        private void dtpPocetnoVrijeme_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}

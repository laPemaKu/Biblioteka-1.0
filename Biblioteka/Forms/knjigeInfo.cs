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
        public knjigeInfo()
        {
            InitializeComponent();
            try
            {
                int broj_knjiga = Convert.ToInt32(txtBrojKnjiga.Text);
                if (broj_knjiga < 0)
                {
                    btnPodizanjeKnjige.Visible = true;
                }
                else
                {
                    btnPodizanjeKnjige.Visible = false;
                }
            }
            catch (Exception ex)
            { }
                
        }
    }
}

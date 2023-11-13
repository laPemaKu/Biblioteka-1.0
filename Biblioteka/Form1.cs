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
    public partial class Form1 : Form
    {
        public Panel panel;
        public Form1()
        {
            InitializeComponent();
            panel = pnlForm;
        }

        public void openForm(childForm childForm)
        {
            panel.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.Show();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            openForm(new knjigeInfo());
        }
    }
}

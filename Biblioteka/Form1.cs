using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

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
        List<knjiga> knjige_list = new List<knjiga>();
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
            try {
                knjigeInfo Knjigeinfo = new knjigeInfo(Convert.ToInt32(txtISBN.Text));
                Knjigeinfo.Knjige_list = knjige_list;
                openForm(Knjigeinfo);
            } catch (Exception ex) {}
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            XDocument xml = new XDocument(new XElement("Knjiga",
                from knjiga in knjige_list
                select new XElement("Knjiga",
                new XAttribute("Naziv", knjiga.Naziv),
                new XAttribute("ISBN", knjiga.Isbn),
                new XAttribute("Pisac",knjiga.Pisac),
                new XAttribute("Izdavac", knjiga.Izdavac),
                new XAttribute("Godina_izdavanja", knjiga.Godina_izdavanja),
                new XAttribute("Broj_kopija", knjiga.Broj_kopija)
                )));

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Xml files (*.xml)|*.xml";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.DefaultExt = "*.xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine(xml.ToString());
                }
               
            }
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    XDocument xml = XDocument.Load(reader);
                    foreach(XElement element in xml.Elements())
                    {
                        knjiga knjiga = new knjiga(element.Attribute("Naziv").Value, Convert.ToInt32(element.Attribute("ISBN").Value), Convert.ToInt32(element.Attribute("Godina_izdavanja").Value), Convert.ToInt32(element.Attribute("Broj_kopija").Value), element.Attribute("Pisac").Value, element.Attribute("Izdavac").Value);
                    }
                }
            }
        }

        private void btnStvori_Click(object sender, EventArgs e)
        {
            openForm(new StvoriKnjigu());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

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
        List<knjiga> knjige_ = new List<knjiga>();
        internal List<knjiga> knjige_main = new List<knjiga>();
        private StvoriKnjigu forma_stvori = new StvoriKnjigu();
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
            try
            {
                int isbn = Convert.ToInt32(txtISBN.Text);
                knjige_main = this.SyncLists();
                knjigeInfo Knjigeinfo = new knjigeInfo(this);
                openForm(Knjigeinfo);
                Knjigeinfo.Pretrazi(isbn);
                txtISBN.Clear();
            }
            catch { }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            this.GettingCreatedObjects(forma_stvori);
            knjige_main = this.SyncLists();


            XDocument xml = new XDocument(new XElement("Knjiga",
            from knjiga in knjige_main
            select new XElement("Knjiga",
            new XAttribute("Naziv", knjiga.Naziv),
            new XAttribute("ISBN", knjiga.Isbn),
            new XAttribute("Pisac", knjiga.Pisac),
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
            knjige_list = new List<knjiga>();
            knjige_ = new List<knjiga>();
            knjige_main = new List<knjiga>();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    XElement xml = XElement.Load(reader);
                    foreach (XElement element in xml.Elements())
                    {
                        try
                        {
                            knjiga knj = new knjiga(element.Attribute("Naziv").Value, Convert.ToInt32(element.Attribute("ISBN").Value), Convert.ToInt32(element.Attribute("Godina_izdavanja").Value), Convert.ToInt32(element.Attribute("Broj_kopija").Value), element.Attribute("Pisac").Value, element.Attribute("Izdavac").Value);
                            knjige_list.Add(knj);
                        }
                        catch { }
                    }
                }
            }
            knjige_main = this.SyncLists();
        }

        private void btnStvori_Click(object sender, EventArgs e)
        {
            forma_stvori = new StvoriKnjigu(this);
            openForm(forma_stvori);

        }

        public void GettingCreatedObjects(StvoriKnjigu form)
        {
            knjige_ = form.Knjige_list;
            forma_stvori = form;
        }
        private List<knjiga> SyncLists()
        {
            List<knjiga> knjige_main = new List<knjiga>();
            this.GettingCreatedObjects(forma_stvori);

            foreach (knjiga knj in knjige_)
            {
                knjige_main.Add(knj);
            }
            foreach (knjiga knj in knjige_list)
            {
                knjige_main.Add(knj);
            }

            return knjige_main;
        }

        private void btnPodigni_Click(object sender, EventArgs e)
        {
            knjige_main = this.SyncLists();
            podizanjeKnjige forma = new podizanjeKnjige(this);
            openForm(forma);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka.dijalozi
{
    public partial class Dijalogpotraga : Form
    {
        private string autor;
        private string naziv;
        private string izdavac;

        public Dijalogpotraga()
        {
            InitializeComponent();
        }

        public string Autor { get => autor; }
        public string Naziv { get => naziv; }
        public string Izdavac { get => izdavac; }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            autor = txtBoxAutorTrazi.Text;
            naziv = txtBoxNazivTrazi.Text;
            izdavac = txtBoxIzdavacPretraga.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

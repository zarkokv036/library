using Biblioteka.dijalozi;
using Biblioteka.klase;
using Biblioteka.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class Form1 : Form
    {
        
        private Skladiste lista = new Skladiste();
        private Skladiste listaZaPretragu = new Skladiste();
        private Knjiga knjiga;
        private SerializeData zapis;
        private bool flag_naziv = false,flag_autor = false,flag_brstr=false,flag_izdavac=false;

        public Form1()
        {
            
            InitializeComponent();
            listView1.Font = (Font)Properties.Settings.Default.FONT;

            zapis = new SerializeData("podaci"); //giving the name to the file where we store our data
            lista = zapis.DeserializeObject();//deserializing of file if it exists
            listaZaPretragu = lista; //we use listaZaPretragu in deleting method
            txtBoxBrKnjiga.Text = lista.Knjige.Count.ToString();//writing number of books into textBox

            
            showListView();


        }

        private void btnDodajNaListu_Click(object sender, EventArgs e)
        {
            if (txtBoxNaziv.Text != "")
            {
                if (txtBoxAutor.Text != "")
                {
                    if (txtBoxBrStrana.Text != "")
                    {
                        if (txtBoxIzdavac.Text != "")
                        {
                            try
                            {
                                knjiga = new Knjiga(txtBoxNaziv.Text, txtBoxAutor.Text, Int32.Parse(txtBoxBrStrana.Text), txtBoxIzdavac.Text); //making of object book which uses arguments from textbox
                                                                                                                                               //lista.dodajKnjiguUlistu(knjiga);

                                zapis.SerializeObject(knjiga);//adding the object to the file
                                                              //zapis.closeStream();


                                lista = zapis.DeserializeObject(); //making object "list" equal to deserialized object which is acctualy list
                                listaZaPretragu = lista;

                                
                                showListView();

                                txtBoxNaziv.Text = "";
                                txtBoxAutor.Text = "";
                                txtBoxBrStrana.Text = "";
                                txtBoxIzdavac.Text = "";
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("Broj strana sme biti samo broj ");
                                txtBoxBrStrana.Text = "";
                                txtBoxBrStrana.Focus();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Unesite ime izdavaca ");
                            txtBoxIzdavac.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unesite broj strana knjige ");
                        txtBoxBrStrana.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Unesite ime autora");
                    txtBoxAutor.Focus();
                }
            }
            else
            {
                MessageBox.Show("Unesite naziv knjige");
                txtBoxNaziv.Focus();
            }

            txtBoxBrKnjiga.Text = lista.Knjige.Count.ToString();
        }

        private void unosNoveKnjigeToolStripMenuItem_Click(object sender, EventArgs e) //searching
        {

            Dijalogpotraga potraga = new Dijalogpotraga();
            DialogResult result = potraga.ShowDialog();
            if(result == DialogResult.OK)
            {
                Skladiste listaPretraga = new Skladiste();
                listView1.Items.Clear();
                lista = zapis.DeserializeObject(); 
                
                foreach (Knjiga k in lista.Knjige)
                {

                    if (potraga.Naziv != "" && potraga.Autor != "" && potraga.Izdavac != "")
                    {

                        if ((k.Naziv.ToLower()).Contains((potraga.Naziv).ToLower()) || k.Pisac.ToLower().Contains(potraga.Autor.ToLower()) || k.Izdavac.ToLower().Contains(potraga.Izdavac.ToLower()))
                        {
                            listaPretraga.Knjige.Add(k); //OVO JE PROBA ZA SORTIRANJE PRETRAZENIH KNJIGA

                            showListViewZaPretragu(k);
                        }


                    }
                    else if (potraga.Naziv == "" && potraga.Autor != "" && potraga.Izdavac != "")
                    {

                        if (k.Pisac.ToLower().Contains(potraga.Autor.ToLower()) || k.Izdavac.ToLower().Contains(potraga.Izdavac.ToLower()))
                        {

                            listaPretraga.Knjige.Add(k);

                            showListViewZaPretragu(k);
                        }
                    }
                    else if (potraga.Naziv == "" &&   potraga.Autor != "" && potraga.Izdavac == "")
                    {

                        if (k.Pisac.ToLower().Contains(potraga.Autor.ToLower()))
                        {
                            listaPretraga.Knjige.Add(k);

                            showListViewZaPretragu(k);
                        }
                    }
                    else if (potraga.Naziv != "" && potraga.Autor == "" && potraga.Izdavac == "")
                    {

                        if (k.Naziv.ToLower().Contains(potraga.Naziv.ToLower()))
                        {
                            listaPretraga.Knjige.Add(k);

                            showListViewZaPretragu(k);
                        }
                    }
                    else if (potraga.Naziv == "" && potraga.Autor == "" && potraga.Izdavac != "")
                    {

                        if (k.Izdavac.ToLower().Contains(potraga.Izdavac.ToLower()))
                        {
                            listaPretraga.Knjige.Add(k);

                            showListViewZaPretragu(k);
                        }
                    }

                }
                lista = listaPretraga; 
            }
        }

        private void btnPrikaziListu_Click(object sender, EventArgs e) //list showing
        {

            lista = zapis.DeserializeObject();
            showListView();

        }

        private void showListView()
        {
            listView1.Items.Clear();
            foreach (Knjiga k in lista.Knjige)
            {
                

                var red = new string[] { k.Naziv, k.Pisac, k.BrojStrana.ToString(), k.Izdavac };

                ListViewItem listV = new ListViewItem(red);
                listV.Tag = k;
                
                if (k.Procitana)
                {
                    listV.BackColor = Color.Yellow;
                }

                listView1.Items.Add(listV);

            }
        }
        private void showListViewZaPretragu(Knjiga k)
        {
            var red = new string[] { k.Naziv, k.Pisac, k.BrojStrana.ToString(), k.Izdavac };

            ListViewItem listV = new ListViewItem(red);
            listV.Tag = k;
            if (k.Procitana)
            {
                listV.BackColor = Color.Yellow;
            }
            listView1.Items.Add(listV);
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            
            if (listView1.SelectedItems.Count != 0) 
            {
                Knjiga k1 = null;
               
                var selektovana = (Knjiga)listView1.SelectedItems[0].Tag;

                

                foreach (Knjiga k in listaZaPretragu.Knjige) //searching of selected item in list
                {
                    if (k.getAllInfo().ToString().Equals(selektovana.getAllInfo()))
                    {
                        k1 = k;
                    }
                }
                listaZaPretragu.Knjige.Remove(k1);//removing it from list

                zapis.SerializeDeleteFolder();//deleting data file
                zapis.closeStream();

                foreach (Knjiga k in listaZaPretragu.Knjige)
                {
                    zapis.SerializeObject(k);//writing all new object from list in new data file with same old name 

                }
               // zapis.closeStream();

                lista = zapis.DeserializeObject(); //putting new objects in lista
                listaZaPretragu = lista;

                showListView();
            }

            txtBoxBrKnjiga.Text = lista.Knjige.Count.ToString();

        }

        private void promenaFontaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                listView1.Font = fontDialog1.Font;
                Properties.Settings.Default.FONT = fontDialog1.Font;
                Properties.Settings.Default.Save();
            }
        }

        private void btnProcitano_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {

                var selektovana = (Knjiga)listView1.SelectedItems[0].Tag;
                selektovana.Procitana = true;
                foreach (Knjiga k in listaZaPretragu.Knjige) //searching of selected item in list
                {
                    if (k.getAllInfo().ToString().Equals(selektovana.getAllInfo()))
                    {
                        k.Procitana = true;
                    }
                }

                //dodao si ovo za menjanje procitane knjige
                zapis.SerializeDeleteFolder();//deleting data file
                zapis.closeStream();

                foreach (Knjiga k in listaZaPretragu.Knjige)
                {
                    zapis.SerializeObject(k);//writing all new object from list in new data file with same old name 

                }
                // zapis.closeStream();

                lista = zapis.DeserializeObject(); //putting new objects in lista
                listaZaPretragu = lista;

                showListView();



            }
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Žarko Milojičić \nzarko.kv036@gmail.com");
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    



        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if(e.Column == 0) { //kolona naziv
                if (!flag_naziv)
                {
                    lista.sortByNaziv_A_Z();
                    showListView();
                    flag_naziv = true;
                }
                else
                {
                    lista.sortByNaziv_Z_A();
                    showListView();
                    flag_naziv = false;
                }

            }
            else if (e.Column == 1)
            {
                if (!flag_autor)
                {
                    lista.sortByPisac_A_Z();
                    showListView();
                    flag_autor = true;
                }
                else
                {
                    lista.sortByPisac_Z_A();
                    showListView();
                    flag_autor = false;
                }
            }
            else if (e.Column == 2)
            {
                if (!flag_brstr)
                {
                    lista.sortByBrojStranaRastuce();
                    showListView();
                    flag_brstr = true;
                }
                else
                {
                    lista.sortByBrojStranaOpadajuce();
                    showListView();
                    flag_brstr = false;
                }
            }
            else if (e.Column == 3)
            {
                if (!flag_izdavac)
                {
                    lista.sortByIzdavac_A_Z();
                    showListView();
                    flag_izdavac = true;
                }
                else
                {
                    lista.sortByIzdavac_Z_A();
                    showListView();
                    flag_izdavac = false;
                }
            }

        }
    }
}

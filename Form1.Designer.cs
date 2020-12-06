namespace Biblioteka
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNoveKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promenaFontaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBoxNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxBrStrana = new System.Windows.Forms.TextBox();
            this.btnDodajNaListu = new System.Windows.Forms.Button();
            this.btnPrikaziListu = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxBrKnjiga = new System.Windows.Forms.TextBox();
            this.txtBoxIzdavac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderNaziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBrStrana = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIzdavac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnProcitano = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNoveKnjigeToolStripMenuItem,
            this.promenaFontaToolStripMenuItem,
            this.autorToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // unosNoveKnjigeToolStripMenuItem
            // 
            this.unosNoveKnjigeToolStripMenuItem.Name = "unosNoveKnjigeToolStripMenuItem";
            this.unosNoveKnjigeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unosNoveKnjigeToolStripMenuItem.Text = "Pretraga";
            this.unosNoveKnjigeToolStripMenuItem.Click += new System.EventHandler(this.unosNoveKnjigeToolStripMenuItem_Click);
            // 
            // promenaFontaToolStripMenuItem
            // 
            this.promenaFontaToolStripMenuItem.Name = "promenaFontaToolStripMenuItem";
            this.promenaFontaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.promenaFontaToolStripMenuItem.Text = "Promena fonta";
            this.promenaFontaToolStripMenuItem.Click += new System.EventHandler(this.promenaFontaToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // txtBoxNaziv
            // 
            this.txtBoxNaziv.Location = new System.Drawing.Point(55, 40);
            this.txtBoxNaziv.Name = "txtBoxNaziv";
            this.txtBoxNaziv.Size = new System.Drawing.Size(151, 20);
            this.txtBoxNaziv.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Autor:";
            // 
            // txtBoxAutor
            // 
            this.txtBoxAutor.Location = new System.Drawing.Point(252, 40);
            this.txtBoxAutor.Name = "txtBoxAutor";
            this.txtBoxAutor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAutor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj strana:";
            // 
            // txtBoxBrStrana
            // 
            this.txtBoxBrStrana.Location = new System.Drawing.Point(438, 40);
            this.txtBoxBrStrana.Name = "txtBoxBrStrana";
            this.txtBoxBrStrana.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBrStrana.TabIndex = 6;
            // 
            // btnDodajNaListu
            // 
            this.btnDodajNaListu.Location = new System.Drawing.Point(363, 82);
            this.btnDodajNaListu.Name = "btnDodajNaListu";
            this.btnDodajNaListu.Size = new System.Drawing.Size(101, 23);
            this.btnDodajNaListu.TabIndex = 8;
            this.btnDodajNaListu.Text = "Dodaj na listu";
            this.btnDodajNaListu.UseVisualStyleBackColor = true;
            this.btnDodajNaListu.Click += new System.EventHandler(this.btnDodajNaListu_Click);
            // 
            // btnPrikaziListu
            // 
            this.btnPrikaziListu.Location = new System.Drawing.Point(363, 422);
            this.btnPrikaziListu.Name = "btnPrikaziListu";
            this.btnPrikaziListu.Size = new System.Drawing.Size(101, 23);
            this.btnPrikaziListu.TabIndex = 9;
            this.btnPrikaziListu.Text = "Prikaži sve knjige";
            this.btnPrikaziListu.UseVisualStyleBackColor = true;
            this.btnPrikaziListu.Click += new System.EventHandler(this.btnPrikaziListu_Click);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Location = new System.Drawing.Point(314, 140);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(195, 23);
            this.btnBrisanje.TabIndex = 10;
            this.btnBrisanje.Text = "Brisanje selektovane knjige";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Broj knjiga:";
            // 
            // txtBoxBrKnjiga
            // 
            this.txtBoxBrKnjiga.Location = new System.Drawing.Point(677, 85);
            this.txtBoxBrKnjiga.Name = "txtBoxBrKnjiga";
            this.txtBoxBrKnjiga.ReadOnly = true;
            this.txtBoxBrKnjiga.Size = new System.Drawing.Size(38, 20);
            this.txtBoxBrKnjiga.TabIndex = 12;
            // 
            // txtBoxIzdavac
            // 
            this.txtBoxIzdavac.Location = new System.Drawing.Point(615, 40);
            this.txtBoxIzdavac.Name = "txtBoxIzdavac";
            this.txtBoxIzdavac.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIzdavac.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Izdavač:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNaziv,
            this.columnHeaderAutor,
            this.columnHeaderBrStrana,
            this.columnHeaderIzdavac});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(105, 169);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(592, 247);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeaderNaziv
            // 
            this.columnHeaderNaziv.Text = "Naziv ";
            this.columnHeaderNaziv.Width = 200;
            // 
            // columnHeaderAutor
            // 
            this.columnHeaderAutor.Text = "Autor";
            this.columnHeaderAutor.Width = 150;
            // 
            // columnHeaderBrStrana
            // 
            this.columnHeaderBrStrana.Text = "Broj strana";
            this.columnHeaderBrStrana.Width = 100;
            // 
            // columnHeaderIzdavac
            // 
            this.columnHeaderIzdavac.Text = "Izdavač";
            this.columnHeaderIzdavac.Width = 150;
            // 
            // btnProcitano
            // 
            this.btnProcitano.Location = new System.Drawing.Point(344, 111);
            this.btnProcitano.Name = "btnProcitano";
            this.btnProcitano.Size = new System.Drawing.Size(134, 23);
            this.btnProcitano.TabIndex = 18;
            this.btnProcitano.Text = "Označi kao pročitanu";
            this.btnProcitano.UseVisualStyleBackColor = true;
            this.btnProcitano.Click += new System.EventHandler(this.btnProcitano_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 473);
            this.Controls.Add(this.btnProcitano);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxIzdavac);
            this.Controls.Add(this.txtBoxBrKnjiga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnPrikaziListu);
            this.Controls.Add(this.btnDodajNaListu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxBrStrana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNaziv);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Biblioteka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNoveKnjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBoxNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxBrStrana;
        private System.Windows.Forms.Button btnDodajNaListu;
        private System.Windows.Forms.Button btnPrikaziListu;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxBrKnjiga;
        private System.Windows.Forms.TextBox txtBoxIzdavac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderAutor;
        private System.Windows.Forms.ColumnHeader columnHeaderBrStrana;
        private System.Windows.Forms.ColumnHeader columnHeaderIzdavac;
        public System.Windows.Forms.ColumnHeader columnHeaderNaziv;
        private System.Windows.Forms.ToolStripMenuItem promenaFontaToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnProcitano;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
    }
}


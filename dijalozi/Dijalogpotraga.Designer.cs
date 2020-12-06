namespace Biblioteka.dijalozi
{
    partial class Dijalogpotraga
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxAutorTrazi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNazivTrazi = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxIzdavacPretraga = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Autor:";
            // 
            // txtBoxAutorTrazi
            // 
            this.txtBoxAutorTrazi.Location = new System.Drawing.Point(67, 68);
            this.txtBoxAutorTrazi.Name = "txtBoxAutorTrazi";
            this.txtBoxAutorTrazi.Size = new System.Drawing.Size(151, 20);
            this.txtBoxAutorTrazi.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naziv:";
            // 
            // txtBoxNazivTrazi
            // 
            this.txtBoxNazivTrazi.Location = new System.Drawing.Point(67, 30);
            this.txtBoxNazivTrazi.Name = "txtBoxNazivTrazi";
            this.txtBoxNazivTrazi.Size = new System.Drawing.Size(151, 20);
            this.txtBoxNazivTrazi.TabIndex = 8;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(12, 136);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(184, 136);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 12;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Izdavač:";
            // 
            // txtBoxIzdavacPretraga
            // 
            this.txtBoxIzdavacPretraga.Location = new System.Drawing.Point(67, 99);
            this.txtBoxIzdavacPretraga.Name = "txtBoxIzdavacPretraga";
            this.txtBoxIzdavacPretraga.Size = new System.Drawing.Size(151, 20);
            this.txtBoxIzdavacPretraga.TabIndex = 14;
            // 
            // Dijalogpotraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 174);
            this.Controls.Add(this.txtBoxIzdavacPretraga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxAutorTrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNazivTrazi);
            this.Name = "Dijalogpotraga";
            this.Text = "Pretraga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxAutorTrazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNazivTrazi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxIzdavacPretraga;
    }
}
namespace Biblioteka
{
    partial class StvoriKnjigu
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrojKnjiga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGodinaIzdavanja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPisac = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(440, 266);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 38;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Broj kopija:";
            // 
            // txtBrojKnjiga
            // 
            this.txtBrojKnjiga.Location = new System.Drawing.Point(440, 202);
            this.txtBrojKnjiga.Name = "txtBrojKnjiga";
            this.txtBrojKnjiga.Size = new System.Drawing.Size(167, 20);
            this.txtBrojKnjiga.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(161, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Naziv Knjige:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNaziv.Location = new System.Drawing.Point(144, 123);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(167, 31);
            this.txtNaziv.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Godina izdavanja:";
            // 
            // txtGodinaIzdavanja
            // 
            this.txtGodinaIzdavanja.Location = new System.Drawing.Point(440, 143);
            this.txtGodinaIzdavanja.Name = "txtGodinaIzdavanja";
            this.txtGodinaIzdavanja.Size = new System.Drawing.Size(167, 20);
            this.txtGodinaIzdavanja.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Izdavač:";
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.Location = new System.Drawing.Point(144, 311);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.Size = new System.Drawing.Size(167, 20);
            this.txtIzdavac.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Pisac:";
            // 
            // txtPisac
            // 
            this.txtPisac.Location = new System.Drawing.Point(144, 249);
            this.txtPisac.Name = "txtPisac";
            this.txtPisac.Size = new System.Drawing.Size(167, 20);
            this.txtPisac.TabIndex = 28;
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(153, 170);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(35, 13);
            this.ISBN.TabIndex = 27;
            this.ISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(144, 190);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(167, 20);
            this.txtISBN.TabIndex = 26;
            // 
            // StvoriKnjigu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 447);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBrojKnjiga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGodinaIzdavanja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIzdavac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPisac);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.txtISBN);
            this.Name = "StvoriKnjigu";
            this.Text = "StvoriKnjigu";
            this.Load += new System.EventHandler(this.StvoriKnjigu_Load);
            this.Controls.SetChildIndex(this.txtISBN, 0);
            this.Controls.SetChildIndex(this.ISBN, 0);
            this.Controls.SetChildIndex(this.txtPisac, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtIzdavac, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtGodinaIzdavanja, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtNaziv, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtBrojKnjiga, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnSpremi, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBrojKnjiga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGodinaIzdavanja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPisac;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.TextBox txtISBN;
    }
}
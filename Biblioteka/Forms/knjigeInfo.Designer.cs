﻿namespace Biblioteka
{
    partial class knjigeInfo
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
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPisac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGodinaIzdavanja = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrojKnjiga = new System.Windows.Forms.TextBox();
            this.btnPodizanjeKnjige = new System.Windows.Forms.Button();
            this.btnVracanjeKnjige = new System.Windows.Forms.Button();
            this.txtKnj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(41, 146);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(167, 20);
            this.txtISBN.TabIndex = 0;
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(50, 126);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(35, 13);
            this.ISBN.TabIndex = 1;
            this.ISBN.Text = "ISBN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pisac:";
            // 
            // txtPisac
            // 
            this.txtPisac.Location = new System.Drawing.Point(41, 205);
            this.txtPisac.Name = "txtPisac";
            this.txtPisac.ReadOnly = true;
            this.txtPisac.Size = new System.Drawing.Size(167, 20);
            this.txtPisac.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Izdavač:";
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.Location = new System.Drawing.Point(41, 267);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.ReadOnly = true;
            this.txtIzdavac.Size = new System.Drawing.Size(167, 20);
            this.txtIzdavac.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Godina izdavanja:";
            // 
            // txtGodinaIzdavanja
            // 
            this.txtGodinaIzdavanja.Location = new System.Drawing.Point(334, 146);
            this.txtGodinaIzdavanja.Name = "txtGodinaIzdavanja";
            this.txtGodinaIzdavanja.ReadOnly = true;
            this.txtGodinaIzdavanja.Size = new System.Drawing.Size(167, 20);
            this.txtGodinaIzdavanja.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(58, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Naziv Knjige:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNaziv.Location = new System.Drawing.Point(41, 79);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ReadOnly = true;
            this.txtNaziv.Size = new System.Drawing.Size(167, 31);
            this.txtNaziv.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Broj kopija:";
            // 
            // txtBrojKnjiga
            // 
            this.txtBrojKnjiga.Location = new System.Drawing.Point(334, 205);
            this.txtBrojKnjiga.Name = "txtBrojKnjiga";
            this.txtBrojKnjiga.ReadOnly = true;
            this.txtBrojKnjiga.Size = new System.Drawing.Size(167, 20);
            this.txtBrojKnjiga.TabIndex = 11;
            // 
            // btnPodizanjeKnjige
            // 
            this.btnPodizanjeKnjige.Location = new System.Drawing.Point(289, 265);
            this.btnPodizanjeKnjige.Name = "btnPodizanjeKnjige";
            this.btnPodizanjeKnjige.Size = new System.Drawing.Size(111, 23);
            this.btnPodizanjeKnjige.TabIndex = 13;
            this.btnPodizanjeKnjige.Text = "Podizanje knjige";
            this.btnPodizanjeKnjige.UseVisualStyleBackColor = true;
            this.btnPodizanjeKnjige.Visible = false;
            // 
            // btnVracanjeKnjige
            // 
            this.btnVracanjeKnjige.Location = new System.Drawing.Point(466, 264);
            this.btnVracanjeKnjige.Name = "btnVracanjeKnjige";
            this.btnVracanjeKnjige.Size = new System.Drawing.Size(97, 23);
            this.btnVracanjeKnjige.TabIndex = 14;
            this.btnVracanjeKnjige.Text = "Vraćanje Knjige";
            this.btnVracanjeKnjige.UseVisualStyleBackColor = true;
            // 
            // txtKnj
            // 
            this.txtKnj.Location = new System.Drawing.Point(41, 309);
            this.txtKnj.Multiline = true;
            this.txtKnj.Name = "txtKnj";
            this.txtKnj.Size = new System.Drawing.Size(179, 94);
            this.txtKnj.TabIndex = 15;
            // 
            // knjigeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 447);
            this.Controls.Add(this.txtKnj);
            this.Controls.Add(this.btnVracanjeKnjige);
            this.Controls.Add(this.btnPodizanjeKnjige);
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
            this.Name = "knjigeInfo";
            this.Text = "knjigeInfo";
            this.Load += new System.EventHandler(this.knjigeInfo_Load);
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
            this.Controls.SetChildIndex(this.btnPodizanjeKnjige, 0);
            this.Controls.SetChildIndex(this.btnVracanjeKnjige, 0);
            this.Controls.SetChildIndex(this.txtKnj, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPisac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGodinaIzdavanja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBrojKnjiga;
        private System.Windows.Forms.Button btnPodizanjeKnjige;
        private System.Windows.Forms.Button btnVracanjeKnjige;
        private System.Windows.Forms.TextBox txtKnj;
    }
}
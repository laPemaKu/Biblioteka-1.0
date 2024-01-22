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
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.btnStvori = new System.Windows.Forms.Button();
            this.btnPodigni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(29, 40);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(153, 20);
            this.txtISBN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISBN";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(212, 37);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 2;
            this.btnPretrazi.Text = "Pretraži:";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Location = new System.Drawing.Point(29, 92);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(746, 486);
            this.pnlForm.TabIndex = 3;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(607, 37);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 4;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(688, 38);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(75, 23);
            this.btnUcitaj.TabIndex = 5;
            this.btnUcitaj.Text = "Učitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // btnStvori
            // 
            this.btnStvori.Location = new System.Drawing.Point(306, 37);
            this.btnStvori.Name = "btnStvori";
            this.btnStvori.Size = new System.Drawing.Size(75, 23);
            this.btnStvori.TabIndex = 6;
            this.btnStvori.Text = "Stvori";
            this.btnStvori.UseVisualStyleBackColor = true;
            this.btnStvori.Click += new System.EventHandler(this.btnStvori_Click);
            // 
            // btnPodigni
            // 
            this.btnPodigni.Location = new System.Drawing.Point(401, 37);
            this.btnPodigni.Name = "btnPodigni";
            this.btnPodigni.Size = new System.Drawing.Size(75, 23);
            this.btnPodigni.TabIndex = 7;
            this.btnPodigni.Text = "Podigni";
            this.btnPodigni.UseVisualStyleBackColor = true;
            this.btnPodigni.Click += new System.EventHandler(this.btnPodigni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.btnPodigni);
            this.Controls.Add(this.btnStvori);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtISBN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.Button btnStvori;
        private System.Windows.Forms.Button btnPodigni;
    }
}


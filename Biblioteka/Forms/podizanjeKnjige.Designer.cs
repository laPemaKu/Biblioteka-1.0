﻿namespace Biblioteka
{
    partial class podizanjeKnjige
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
            this.Ime = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPodigni = new System.Windows.Forms.Button();
            this.btnOdabir = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.calPocetno = new System.Windows.Forms.MonthCalendar();
            this.calZavrsno = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ime.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Ime.Location = new System.Drawing.Point(30, 62);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(41, 13);
            this.Ime.TabIndex = 3;
            this.Ime.Text = "E-mail";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(21, 82);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(167, 20);
            this.txtEMail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(30, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Posuđivanje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(249, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Do:";
            // 
            // btnPodigni
            // 
            this.btnPodigni.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPodigni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPodigni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPodigni.ForeColor = System.Drawing.Color.White;
            this.btnPodigni.Location = new System.Drawing.Point(532, 369);
            this.btnPodigni.Name = "btnPodigni";
            this.btnPodigni.Size = new System.Drawing.Size(75, 23);
            this.btnPodigni.TabIndex = 15;
            this.btnPodigni.Text = "Podigni";
            this.btnPodigni.UseVisualStyleBackColor = false;
            // 
            // btnOdabir
            // 
            this.btnOdabir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOdabir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdabir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdabir.ForeColor = System.Drawing.Color.White;
            this.btnOdabir.Location = new System.Drawing.Point(210, 79);
            this.btnOdabir.Name = "btnOdabir";
            this.btnOdabir.Size = new System.Drawing.Size(106, 23);
            this.btnOdabir.TabIndex = 16;
            this.btnOdabir.Text = "Odabir knjiga";
            this.btnOdabir.UseVisualStyleBackColor = false;
            this.btnOdabir.Click += new System.EventHandler(this.btnOdabir_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(491, 137);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(227, 202);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // calPocetno
            // 
            this.calPocetno.Location = new System.Drawing.Point(7, 177);
            this.calPocetno.Name = "calPocetno";
            this.calPocetno.TabIndex = 18;
            // 
            // calZavrsno
            // 
            this.calZavrsno.Location = new System.Drawing.Point(252, 177);
            this.calZavrsno.Name = "calZavrsno";
            this.calZavrsno.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(18, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Od:";
            // 
            // podizanjeKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calZavrsno);
            this.Controls.Add(this.calPocetno);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnOdabir);
            this.Controls.Add(this.btnPodigni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.txtEMail);
            this.Name = "podizanjeKnjige";
            this.Text = "podizanjeKnjige";
            this.Controls.SetChildIndex(this.txtEMail, 0);
            this.Controls.SetChildIndex(this.Ime, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnPodigni, 0);
            this.Controls.SetChildIndex(this.btnOdabir, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.calPocetno, 0);
            this.Controls.SetChildIndex(this.calZavrsno, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPodigni;
        private System.Windows.Forms.Button btnOdabir;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MonthCalendar calPocetno;
        private System.Windows.Forms.MonthCalendar calZavrsno;
        private System.Windows.Forms.Label label1;
    }
}
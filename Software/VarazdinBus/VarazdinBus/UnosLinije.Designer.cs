namespace VarazdinBus
{
    partial class UnosLinije
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
            this.lblUnos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNazivLinije = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPocetnaStanica = new System.Windows.Forms.ComboBox();
            this.cmbZavrsnaStanica = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timePolaska = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.timeDolaska = new System.Windows.Forms.DateTimePicker();
            this.cmbVozac = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUnos
            // 
            this.lblUnos.AutoSize = true;
            this.lblUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUnos.Location = new System.Drawing.Point(37, 9);
            this.lblUnos.Name = "lblUnos";
            this.lblUnos.Size = new System.Drawing.Size(282, 42);
            this.lblUnos.TabIndex = 0;
            this.lblUnos.Text = "Unos nove linije";
            this.lblUnos.Click += new System.EventHandler(this.lblUnos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Osnovni podaci";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pojedinosti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Naziv linije";
            // 
            // txtNazivLinije
            // 
            this.txtNazivLinije.Location = new System.Drawing.Point(44, 162);
            this.txtNazivLinije.Name = "txtNazivLinije";
            this.txtNazivLinije.Size = new System.Drawing.Size(170, 20);
            this.txtNazivLinije.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Početna stanica";
            // 
            // cmbPocetnaStanica
            // 
            this.cmbPocetnaStanica.FormattingEnabled = true;
            this.cmbPocetnaStanica.Location = new System.Drawing.Point(44, 220);
            this.cmbPocetnaStanica.Name = "cmbPocetnaStanica";
            this.cmbPocetnaStanica.Size = new System.Drawing.Size(170, 21);
            this.cmbPocetnaStanica.TabIndex = 13;
            // 
            // cmbZavrsnaStanica
            // 
            this.cmbZavrsnaStanica.FormattingEnabled = true;
            this.cmbZavrsnaStanica.Location = new System.Drawing.Point(44, 278);
            this.cmbZavrsnaStanica.Name = "cmbZavrsnaStanica";
            this.cmbZavrsnaStanica.Size = new System.Drawing.Size(170, 21);
            this.cmbZavrsnaStanica.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Završna stanica";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Vrijeme polaska";
            // 
            // timePolaska
            // 
            this.timePolaska.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePolaska.Location = new System.Drawing.Point(413, 162);
            this.timePolaska.Name = "timePolaska";
            this.timePolaska.ShowUpDown = true;
            this.timePolaska.Size = new System.Drawing.Size(200, 20);
            this.timePolaska.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Vrijeme dolaska";
            // 
            // timeDolaska
            // 
            this.timeDolaska.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeDolaska.Location = new System.Drawing.Point(413, 221);
            this.timeDolaska.Name = "timeDolaska";
            this.timeDolaska.ShowUpDown = true;
            this.timeDolaska.Size = new System.Drawing.Size(200, 20);
            this.timeDolaska.TabIndex = 20;
            this.timeDolaska.ValueChanged += new System.EventHandler(this.timeDolaska_ValueChanged);
            // 
            // cmbVozac
            // 
            this.cmbVozac.FormattingEnabled = true;
            this.cmbVozac.Location = new System.Drawing.Point(44, 332);
            this.cmbVozac.Name = "cmbVozac";
            this.cmbVozac.Size = new System.Drawing.Size(170, 21);
            this.cmbVozac.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Vozač";
            // 
            // btnUnesi
            // 
            this.btnUnesi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUnesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUnesi.Location = new System.Drawing.Point(568, 450);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(130, 39);
            this.btnUnesi.TabIndex = 24;
            this.btnUnesi.Text = "Unesi liniju";
            this.btnUnesi.UseVisualStyleBackColor = false;
            this.btnUnesi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Location = new System.Drawing.Point(12, 450);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(130, 39);
            this.btnOdustani.TabIndex = 25;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.button2_Click);
            // 
            // UnosLinije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 501);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.cmbVozac);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timeDolaska);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.timePolaska);
            this.Controls.Add(this.cmbZavrsnaStanica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPocetnaStanica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNazivLinije);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UnosLinije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnosLinije";
            this.Load += new System.EventHandler(this.UnosLinije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNazivLinije;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPocetnaStanica;
        private System.Windows.Forms.ComboBox cmbZavrsnaStanica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker timePolaska;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker timeDolaska;
        private System.Windows.Forms.ComboBox cmbVozac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnOdustani;
    }
}
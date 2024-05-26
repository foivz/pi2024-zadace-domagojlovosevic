namespace VarazdinBus
{
    partial class PregledLinija
    {
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUnesiLiniju;

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUnesiLiniju = new System.Windows.Forms.Button();
            this.lblLinije = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1102, 427);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnUnesiLiniju
            // 
            this.btnUnesiLiniju.Location = new System.Drawing.Point(906, 104);
            this.btnUnesiLiniju.Name = "btnUnesiLiniju";
            this.btnUnesiLiniju.Size = new System.Drawing.Size(208, 36);
            this.btnUnesiLiniju.TabIndex = 1;
            this.btnUnesiLiniju.Text = "Unesi Liniju";
            this.btnUnesiLiniju.UseVisualStyleBackColor = true;
            // 
            // lblLinije
            // 
            this.lblLinije.AutoSize = true;
            this.lblLinije.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinije.Location = new System.Drawing.Point(12, 95);
            this.lblLinije.Name = "lblLinije";
            this.lblLinije.Size = new System.Drawing.Size(156, 39);
            this.lblLinije.TabIndex = 2;
            this.lblLinije.Text = "Sve linije";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PregledLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 585);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLinije);
            this.Controls.Add(this.btnUnesiLiniju);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PregledLinija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled Linija";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblLinije;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

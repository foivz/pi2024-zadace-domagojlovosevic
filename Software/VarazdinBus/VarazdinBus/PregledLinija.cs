using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarazdinBus.Repositories;

namespace VarazdinBus
{
    public partial class PregledLinija : Form
    {
        public PregledLinija()
        {
            InitializeComponent();
        }
        private void PrikaziLinije()
        {
            var linije = LinijaRepository.GetLinije();
            dataGridView1.DataSource = linije;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PregledLinija_Load(object sender, EventArgs e)
        {
            PrikaziLinije();
        }

        private void btnUnesiLiniju_Click(object sender, EventArgs e)
        {
            UnosLinije unosLinija = new UnosLinije("");
            Hide();
            unosLinija.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string odabranaLinija = dataGridView1.SelectedRows[0].Cells["NazivLinije"].Value.ToString();
            UnosLinije unosLinije = new UnosLinije(odabranaLinija);
            Hide();
            unosLinije.ShowDialog();
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string odabranaLinija = dataGridView1.SelectedRows[0].Cells["idLinije"].Value.ToString();
                LinijaRepository.DeleteTable(odabranaLinija);
                PrikaziLinije();
            } catch (Exception ex)
            {
                MessageBox.Show($"Greška kod brisanja podataka, odaberite cijeli red kada želite obrisati liniju", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var linije = LinijaRepository.GetLinijeSearch(txtSearch.Text);
            dataGridView1.DataSource = linije;
            if (txtSearch.Text == "")
            {
                PrikaziLinije();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PregledVozaca pregledVozaca = new PregledVozaca();
            Hide();
            pregledVozaca.ShowDialog();
            Close();
        }
    }
}

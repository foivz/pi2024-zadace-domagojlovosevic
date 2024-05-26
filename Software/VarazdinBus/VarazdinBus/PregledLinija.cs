using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            UnosLinije unosLinija = new UnosLinije();
            Hide();
            unosLinija.ShowDialog();
            Close();
        }
    }
}

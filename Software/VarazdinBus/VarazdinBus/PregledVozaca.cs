using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarazdinBus.Models;
using VarazdinBus.Repositories;

namespace VarazdinBus
{
    public partial class PregledVozaca : Form
    {
        public PregledVozaca()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            PregledLinija pregledLinija = new PregledLinija();
            Hide();
            pregledLinija.ShowDialog();
            Close();
        }

        private void btnDodajVozaca_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string dozvola = txtDozvola.Text;
            DateTime datumRodjenja = dateRodjenja.Value;
            DateTime datumZaposlenja = dateZaposlenja.Value;

            VozacRepository.CreateVozac(ime, prezime, username, password, dozvola, datumRodjenja, datumZaposlenja);
            PrikaziVozace();
        }
        private void PrikaziVozace()
        {
            var vozaci = VozacRepository.GetAllVozaci();
            dataGridView1.DataSource = vozaci;
        }
        private void PregledVozaca_Load(object sender, EventArgs e)
        {
            PrikaziVozace();
        }
    }
}

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
    public partial class UnosLinije : Form
    {
        public UnosLinije()
        {
            InitializeComponent();
        }

        private void lblUnos_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void DodajIzvorePodataka()
        {
            cmbVozac.DataSource = VozacRepository.GetAllVozaci();
            cmbVozac.DisplayMember = "imeVozaca";
            cmbVozac.ValueMember = "vozacId";
            cmbPocetnaStanica.DataSource = StanicaRepository.GetStanice();
            cmbPocetnaStanica.DisplayMember = "nazivStanice";
            cmbPocetnaStanica.ValueMember = "id_stanice";
            cmbZavrsnaStanica.DataSource = StanicaRepository.GetStanice();
            cmbZavrsnaStanica.DisplayMember = "nazivStanice";
            cmbZavrsnaStanica.ValueMember = "id_stanice";


        }
        private void button2_Click(object sender, EventArgs e)
        {
            PregledLinija pregledLinija = new PregledLinija();
            Hide();
            pregledLinija.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nazivLinije = txtNazivLinije.Text;
            int pocetnaStanicaID = (int)cmbPocetnaStanica.SelectedValue;
            int zavrsnaStanicaID = (int)cmbZavrsnaStanica.SelectedValue;
            TimeSpan vrijemePolaska = timePolaska.Value.TimeOfDay;
            TimeSpan vrijemeDolaska = timeDolaska.Value.TimeOfDay;
            int vozaciId = Convert.ToInt32(cmbVozac.SelectedValue);
      

            LinijaRepository.DodajNovuLiniju(nazivLinije, pocetnaStanicaID, zavrsnaStanicaID, vrijemePolaska, vrijemeDolaska, vozaciId);
        }

        private void UnosLinije_Load(object sender, EventArgs e)
        {
            DodajIzvorePodataka();
        }

        private void timeDolaska_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

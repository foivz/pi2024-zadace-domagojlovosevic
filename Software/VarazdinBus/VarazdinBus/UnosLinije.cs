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
    public partial class UnosLinije : Form
    {
        private Linija linija;
        private string imeLinije;
        public UnosLinije(string linijaIme)
        {
            imeLinije = linijaIme;
            InitializeComponent();
            linija = LinijaRepository.GetLinijaByName(linijaIme);
        }

        private void lblUnos_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void DodajIzvorePodataka()
        {
            if (imeLinije != "")
            {
                txtNazivLinije.Text = linija.NazivLinije;
                timePolaska.Value = DateTime.Today.Add(linija.VrijemePolaska.TimeOfDay);
                timeDolaska.Value = DateTime.Today.Add(linija.VrijemeDolaska.TimeOfDay);
            }
            
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

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            string nazivLinije = txtNazivLinije.Text;
            int pocetnaStanicaID = (int)cmbPocetnaStanica.SelectedValue;
            int zavrsnaStanicaID = (int)cmbZavrsnaStanica.SelectedValue;
            TimeSpan vrijemePolaska = timePolaska.Value.TimeOfDay;
            TimeSpan vrijemeDolaska = timeDolaska.Value.TimeOfDay;
            int vozaciId = Convert.ToInt32(cmbVozac.SelectedValue);

           
            int selectedLinijaId = linija.IdLinije;

            
            LinijaRepository.IzmjeniLiniju(selectedLinijaId, nazivLinije, pocetnaStanicaID, zavrsnaStanicaID, vrijemePolaska, vrijemeDolaska, vozaciId);

            
            MessageBox.Show("Linija je uspješno izmijenjena.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}

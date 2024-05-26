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
    /*      DJELATNIK
     * jknezevic  pass:password123
     * imaric     pass:password456
     * */ 
     /*      VOZAC
     * markohorvat  pass:marko123
     * ivananovak     pass:ivana456
     * */ 

    public partial class Login : Form
    {
        public static Vozac ulogiraniVozac { get; set; }
        public static Djelatnik ulogiraniDjelatnik { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Unesite korisničko ime!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtPassword.Text == "")
            {
                MessageBox.Show("Unesite lozinku!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (checkBoxVozac.Checked)
                {
                    ulogiraniVozac = VozacRepository.GetVozac(txtUsername.Text);
                    if (ulogiraniVozac != null && ulogiraniVozac.password == txtPassword.Text)
                    {
                        MessageBox.Show("Uspješna prijava vozača!", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    ulogiraniDjelatnik = DjelatnikRepository.GetDjelatnik(txtUsername.Text);
                    if (ulogiraniDjelatnik != null && ulogiraniDjelatnik.password == txtPassword.Text)
                    {
                        PregledLinija pregledLinija = new PregledLinija();
                        Hide();
                        pregledLinija.ShowDialog();
                        Close();
                    } else
                    {
                        MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void checkBoxVozac_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

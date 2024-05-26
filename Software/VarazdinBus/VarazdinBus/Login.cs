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
    public partial class Login : Form
    {
        public static Vozac ulogiraniVozac { get; set; }
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
                ulogiraniVozac   = VozacRepository.GetVozac(txtUsername.Text);
                if (ulogiraniVozac != null && ulogiraniVozac.password == txtPassword.Text)
                {
                    MessageBox.Show("Tocna lozinka!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

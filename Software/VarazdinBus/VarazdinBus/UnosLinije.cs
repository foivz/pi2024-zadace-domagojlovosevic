using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button2_Click(object sender, EventArgs e)
        {
            PregledLinija pregledLinija = new PregledLinija();
            Hide();
            pregledLinija.ShowDialog();
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void listadoDePersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personas ventana = new Personas();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}

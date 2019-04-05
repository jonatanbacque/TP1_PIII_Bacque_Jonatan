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
    public partial class Personas : Form
    {
        public Personas()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            int años = System.DateTime.Now.Year - fecha.Year;
            if (System.DateTime.Now.Subtract(fecha.AddYears(años)).TotalDays < 0)
                lblEdadCalculada.Text = Convert.ToString(años - 1);
            else
                lblEdadCalculada.Text = Convert.ToString(años);
        }
    }
}

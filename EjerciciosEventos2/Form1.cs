using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosEventos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbColores.SelectedItem == "Azul") {
                this.BackColor = Color.Blue;

            }

            else if (cbbColores.SelectedItem == "Rojo")
            {
                this.BackColor = Color.Red;

            }

            else if (cbbColores.SelectedItem == "Amarillo")
            {
                this.BackColor = Color.Yellow;

            }

            else
            {
                this.BackColor = Color.Green;

            }

        }
    }
}

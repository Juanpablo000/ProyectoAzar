using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        public void Inicializar() {
            txtSaldoInicial.Text = "0";
        }

        private void btnManual_Click(object sender, EventArgs e)
        {

        }

        private void btnAutomatico_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresarSaldo_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtSaldoInicial.Text) > 0)
            {

            }
            else { 
                //Ingrese un valor valido
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;
namespace Central_Telefónica
{
    public partial class FrmMenu : Form
    {
        public Centralita<string> centralita;

        private Centralita<string> MiCentralita
        {
            get
            {
                return this.centralita;
            }
        }

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            centralita = new Centralita<string>();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(this.MiCentralita);

            frmLlamador.ShowDialog();
        }

        private void btnFacturaciónTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Facturado: " + this.MiCentralita.GananciasPorTotal.ToString());
        }

        private void btnFacturaciónLocal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Facturado Local: " + this.MiCentralita.GananciasPorLocal.ToString());
        }

        private void btnFacturaciónProvincial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Facturado Provincial: " + this.MiCentralita.GananciasPorProvincial.ToString());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

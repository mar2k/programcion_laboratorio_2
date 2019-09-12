using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace EJ_23
{
  public partial class FrmMonedas : Form
  {

    Dolar dolar;
    Euro euro;
    Pesos pesos;

    public FrmMonedas()
    {
      InitializeComponent();
    }

    private void FrmMonedas_Load(object sender, EventArgs e)
    {
      btnLockCotizacion.ImageIndex = 0;



    }
    private void btnConvertEuro_Click(object sender, EventArgs e)
    {

    }

    private void btnConvertDolar_Click(object sender, EventArgs e)
    {

    }

    private void btnConvertPesos_Click(object sender, EventArgs e)
    {

    }

    private void btnLockCotizacion_Click(object sender, EventArgs e)
    {
      txtCotizacionDolar.ReadOnly = !txtCotizacionDolar.ReadOnly;
      txtCotizacionEuro.ReadOnly = !txtCotizacionEuro.ReadOnly;
      txtCotizacionPeso.ReadOnly = !txtCotizacionPeso.ReadOnly;

      if (txtCotizacionPeso.ReadOnly == true)
      {
        btnLockCotizacion.ImageIndex = 1;
      }
      else
      {
        btnLockCotizacion.ImageIndex = 0;
      }
    }

    
  }
}

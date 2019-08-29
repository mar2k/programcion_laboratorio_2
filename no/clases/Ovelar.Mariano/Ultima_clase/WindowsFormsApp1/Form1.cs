using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {

    public enum TipoManejador
    {
      LimiteSueldo,
      Log,
      Ambos
    }
    List<Empleado> empleados;
    public Form1()
    {
      InitializeComponent();
      foreach (TipoManejador item in Enum.GetValues(typeof(TipoManejador)))
      {
        this.cmbManejador.Items.Add(item);
      }
      this.empleados = new List<Empleado>();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      TipoManejador aux = (TipoManejador)Enum.Parse(typeof(TipoManejador), this.cmbManejador.Text);

      if (aux==TipoManejador.LimiteSueldo)
      {
        
      }
      else if (aux == TipoManejador.Log)
      {

      }
      else if (aux == TipoManejador.Ambos)
      {

      }

    }
  }
}

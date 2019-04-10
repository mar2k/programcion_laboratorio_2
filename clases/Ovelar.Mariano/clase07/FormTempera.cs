using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Tempera;
namespace clase07
{
    public partial class FormTempera : Form
  {
    private Tempera _miTempera;

    public Tempera MiTempera
    {
      get { return _miTempera; }
      set { _miTempera = value; }
    }
    public FormTempera()
    {
      InitializeComponent();

      foreach(ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
      {
        this.comboBox1.Items.Add(c);
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      this._miTempera = new Tempera(ConsoleColor.Black, "sss", 3);
      this.DialogResult = DialogResult.OK;
    }

    private void FormTempera_Load(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }
  }
}

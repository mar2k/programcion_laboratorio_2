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
      get
      {
        return _miTempera;
      }
      set
      {
        _miTempera = value;
      }
    }
    public FormTempera()
    {
      InitializeComponent();

      foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
      {
        this.comboBox1.Items.Add(c);
      }
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox1.SelectedIndex = 0;
    }

    public FormTempera(Tempera miTempera):this()
    {
      
      MiTempera = miTempera;
      sbyte cantidad = MiTempera;
      this.textBox2.Text = cantidad.ToString();
      this.textBox1.Text = MiTempera.Marca;
      this.comboBox1.SelectedItem=MiTempera.Color;

      
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      this._miTempera = new Tempera((ConsoleColor)this.comboBox1.SelectedItem, this.textBox1.Text, sbyte.Parse(this.textBox2.Text));
      this.DialogResult = DialogResult.OK;
    }
    private void button2_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }

    private void lblResultado_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }
  }
}

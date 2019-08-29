using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase07
{
  public partial class frmPrincipal : Form
  {
    public frmPrincipal()
    {
      InitializeComponent();
      this.IsMdiContainer = true;
      this.WindowState = FormWindowState.Maximized;
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      
    }

    private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      Form1 paleta = new Form1();
      paleta.MdiParent = this;
      paleta.StartPosition = FormStartPosition.CenterScreen;
      paleta.Show();
    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
    private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
    {
      if(MessageBox.Show("Seguro de Salir?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question )== DialogResult.No)
      {
        e.Cancel = true;
      }
    }


  }
}

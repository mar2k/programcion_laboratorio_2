using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ_68
{
    public partial class FormPersona : Form
    {
        private Persona persona;

        public FormPersona()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (this.persona is null)
            {
                this.persona = new Persona();
                persona.EventoString += this.NotificarCambio;
                this.btnCerrar.Text = "Actualizar";
            }
            if (this.txtNombre.Text.CompareTo(this.persona.Nombre) != 0)
            {
                this.persona.Nombre = this.txtNombre.Text;
            }
            if (this.txtApellido.Text.CompareTo(this.persona.Apellido) != 0)
            {
                this.persona.Apellido = this.txtApellido.Text;
            }

            MessageBox.Show(this.persona.Mostrar());
        }
        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }
    }
}

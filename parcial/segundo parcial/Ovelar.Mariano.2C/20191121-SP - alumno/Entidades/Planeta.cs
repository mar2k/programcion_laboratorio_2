using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Planeta
    {
        public delegate void InformacionDeAvance(object sender, PlanetaEventArgs e);
        private short velocidadTraslacion;
        private short posicionActual;
        private short radioRespectoSol;
        private object objetoAsociado;
        public event InformacionDeAvance InformarAvance;

        public Planeta(short velocidad, short posicion, short radioRespectoSol, object objetoVisual)
        {
            this.VelocidadTraslacion = velocidad;
            this.PosicionActual = posicion;
            this.objetoAsociado = objetoVisual;
            this.RadioRespectoSol = radioRespectoSol;
        }

        /// <summary>
        /// PictureBox u objeto gráfico asociado al planeta.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public object ObjetoAsociado
        {
            get
            {
                return this.objetoAsociado;
            }
            set
            {
                this.objetoAsociado = value;
            }
        }

        public short VelocidadTraslacion { get => velocidadTraslacion; set => velocidadTraslacion = value; }
        public short PosicionActual { get => posicionActual; set => posicionActual = value; }
        public short RadioRespectoSol { get => radioRespectoSol; set => radioRespectoSol = value; }

        /// <summary>
        /// Avance del planeta según su velocidad
        /// </summary>
        public short Avanzar()
        {
            this.PosicionActual += VelocidadTraslacion;
            return this.PosicionActual;
        }

        /// <summary>
        /// Simulación del movimiento del planeta
        /// </summary>
        public void AnimarSistemaSolar()
        {
            do
            {
                PlanetaEventArgs pEA = new PlanetaEventArgs(this.Avanzar(), this.radioRespectoSol);
                this.InformarAvance.Invoke(this,pEA);
                System.Threading.Thread.Sleep(60 + this.VelocidadTraslacion);
            } while (true);
        }
    }
}

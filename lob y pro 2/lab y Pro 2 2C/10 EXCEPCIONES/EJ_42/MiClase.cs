using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_42
{
    public class MiClase
    {
        public MiClase()
        {
         
        }
        public MiClase(string str)
        {
            try
            {
                MiClase.MetodoEstatico();
            }
            catch (Exception e)
            {

                throw new Exception("MiClase(string str)",e);
            }
        }
        public MiClase(int num)
        {
            try
            {
                new MiClase("");
            }
            catch (Exception e)
            {
                throw new NuevaException("MiClase(int num)",e);
            }

        }
        public static void MetodoEstatico()
        {
            throw new DivideByZeroException("MetodoEstatico");
        }
        public void Metodo()
        {
            try
            {
                new MiClase(1);
            }
            catch (Exception e)
            {
                throw new MiException("MetodoNoEstatico", e);
            }
        }

    }
}

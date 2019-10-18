using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ_42;
namespace EJ_45
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMiClaseString()
        {
            MiClase miClase;

            try
            {
                miClase = new MiClase("");
            }
            catch (Exception e)
            {
                if (!(e is DivideByZeroException))
                {
                    throw e;
                }
            }
        }

        public void TestMiClaseInt()
        {
            MiClase miClase;

            try
            {
                miClase = new MiClase(2);
            }
            catch (Exception e)
            {
                if (!(e is NuevaException))
                {
                    throw e;
                }
            }
        }

        public void TestMetodoEstatico()
        {

            try
            {
                MiClase.MetodoEstatico();
            }
            catch (Exception e)
            {
                if (!(e is NuevaException))
                {
                    throw e;
                }
            }
            
        }

        public void TestMetodoInstancia()
        {
            MiClase miClase = new MiClase();
            try
            {
                miClase.Metodo();
            }
            catch (Exception e)
            {
                if (!(e is MiException))
                {
                    throw e;
                }
            }
            
        }

    }
}

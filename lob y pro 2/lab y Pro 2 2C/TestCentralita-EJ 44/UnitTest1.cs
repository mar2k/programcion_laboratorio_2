using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Central_Telefónica;
using CentralitaHerencia;
using CentralitaException_EJ_41;

namespace TestCentralita_EJ_44
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void validarListaDeLlamadasSeaIstanciada()
        {
            Centralita centralita = new Centralita();
            if (centralita.Llamadas is null)
            {
                throw new Exception("No se istacia lista");
            }
        }
        [TestMethod]
        public void validarCentralitaExcepcionLocal()
        {
            Centralita centralita = new Centralita();
            Llamada llamada = new Local("1", 1, "1", 1);
            try
            {
                centralita = centralita + llamada;
                centralita = centralita + llamada;
            }
            catch (Exception e)
            {
                if (!(e is CentralitaException))
                {
                    throw new Exception("Otro Error", e);
                }
            }


        }
        [TestMethod]
        public void validarCentralitaExcepcionProvincial()
        {
            Centralita centralita = new Centralita();
            Llamada llamada = new Provincial("1", Provincial.Franja.Franja_1, 1, "1");
            try
            {
                centralita = centralita + llamada;
                centralita = centralita + llamada;
            }
            catch (Exception e)
            {
                if (!(e is CentralitaException))
                {
                    throw new Exception("Otro Error", e);
                }
            }
        }
        [TestMethod]
        public void validarCentralitaExcepcion()
        {

            Llamada provincial1 = new Provincial("1", Provincial.Franja.Franja_1, 1, "1");
            Llamada provincial2 = provincial1;
            Llamada local1 = new Local("1", 1, "1", 1);
            Llamada local2 = local1;

            if (local1==local2)
            {
                if (provincial1==provincial2)
                {
                    if (local1 != provincial1 )
                    {
                        throw new Exception("NO");
                    }

                }

            }


        }
    }
}

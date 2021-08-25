using System;
using System.IO;
using System.Text.Json;

namespace Problema03
{

    class Program
    {
        static void Main(string[] args)
        {
            Auto Auto1 = CrearAutoFiat(2020);            
            MostrarAuto(Auto1);            

            Auto Auto2 = CrearAutoPeugeot();
            MostrarAuto(Auto2);
        }

        static Auto CrearAutoFiat(int? anio = null)
        {
            Auto auto = null;

            if (anio != null)
            {
                auto = new Auto()
                {
                    Anio = anio.Value,
                    Modelo = "Fiat"
                };
            }

            return auto;
        }

        static Auto CrearAutoPeugeot(int? anio = null)
        {
            Auto auto = null;
            
            if (anio != null)
            {
                auto = new Auto()
                {
                    Anio = anio.Value,
                    Modelo = "Peugeot"
                };
            }

            return auto;
        }

        static void MostrarAuto(Auto auto)
        {
            try
            {
                Console.WriteLine("{0} - {1}", auto.Modelo, auto.Anio);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("#ERROR El auto posee datos con valor nulo.");
                
            }

            Console.ReadLine();
        }
    }
}

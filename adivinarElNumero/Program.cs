using System;
using System.IO;
using System.Text.Json;

namespace adivinarElNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numeroRand = random.Next(0, 100) + 1;
            int numeroUsuario= 0;
            int intentos= 0;
           
            Console.WriteLine("### ADIVINA EL NUMERO ###");

            do
            {
                try
                {
                    Console.WriteLine("\nIngrese el numero: ");
                    numeroUsuario = Convert.ToInt32(Console.ReadLine());

                    if (numeroUsuario > numeroRand)
                    {
                        Console.WriteLine("\nEl numero ingresado es mayor que el numero por adivinar. Intenta de nuevo");
                        intentos++;
                    }else if(numeroUsuario < numeroRand)
                    {
                        Console.WriteLine("\nEl numero ingresado es menor que el numero por adivinar. Intenta de nuevo");
                        intentos++;
                    }
                    else
                    {
                        intentos++;
                        Console.WriteLine($"FELICIDADES!! El numero era {numeroRand}");
                        Console.WriteLine($"Usted ha adivinado el numero en {intentos} intentos.");
                    }
                }

                catch(OverflowException ex)
                {
                    Console.WriteLine("\n#ERROR El numero ingresado es demasiado grande. Debe estar entre 1 y 100.\n");
                    FileStream archivo = new FileStream("Error.log", FileMode.Create);

                    using (StreamWriter strWriter = new StreamWriter(archivo))
                    {
                        string excepcionStr = JsonSerializer.Serialize(ex.Message);
                        strWriter.WriteLine("{0}", excepcionStr);
                        strWriter.Close();
                    }
                    intentos++;
                }

                catch(Exception)
                {
                    Console.WriteLine("\n#ERROR El dato ingresado no es un numero.");
                    intentos++;
                }

            } while (numeroRand != numeroUsuario);
        }
    }
}

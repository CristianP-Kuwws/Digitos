using System; 

namespace UnoODosDigitos
{
    class Program
    {
        static void Main(string[] args)
        {
            UnoODosDigitos calculadora = new UnoODosDigitos();
            calculadora.Digitos();
        }
    }

    public class UnoODosDigitos
    {
        public void Digitos()
        {
            try
            {
                double numero = 0;

                Console.WriteLine("Ingrese su numero aqui: ");
                numero = double.Parse(Console.ReadLine());

                if (numero <= 9)
                {

                    Console.WriteLine("Su numero tiene un digito.");

                }

                else if (numero >= 10 && numero <= 99)
                {
                    Console.Write("Su numero tiene dos digitos.");
                }

                else
                {
                    Console.WriteLine("Ingrese un numero entre 0 y 99.");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");

            }
        }
    }
}

using System;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int resultado = 23 / Convert.ToInt32(Console.ReadLine());
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("No se puede dividir entre 0");
            }

            finally
            {
                // Siempre va a saltar el finally aunque no haya un error

                Console.WriteLine("Vuleve a intentarlo");
            }
        }
    }
}

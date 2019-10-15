using System;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int resultado = 23 / Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                int numeroMes = int.Parse(Console.ReadLine());
                Console.WriteLine(ObtnerSignoZodiaco(numeroMes));
                
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally 
            {

                Console.WriteLine("Bloque Finally");
            }

           



        //// Hacer comprobaciones aritmeticas en numeros enteros
        //    checked 
            
        //    {
        //        int valor = int.MaxValue;
        //        valor++;
        //        Console.WriteLine(valor);

        //    }

           
            //int valor = 10;
            //Console.WriteLine(valor/0);

            //string numeroEnCadena = "10";
            //int valor = int.Parse(numeroEnCadena);

            //try
            //{
            //    //string numeroEnCadena = "1a";
            //    int valor = 10;
            //    //int valor1 = int.Parse(numeroEnCadena);
            //    int division = valor / 0;


            //}

            //catch (Exception ex) 
            //{
            //    Console.WriteLine(ex.Message);
            
            //}

            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);


            //}

            //catch (DivideByZeroException ex1)
            //{
            //    Console.WriteLine(ex1.Message);

            //}

            //catch (Exception ex2)
            //{
            //    Console.WriteLine(ex2.Message);

            //}

          

            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);


            //}

            //catch (DivideByZeroException ex1)
            //{
            //    Console.WriteLine(ex1.Message);

            //}

            //catch (Exception ex2)
            //{
            //    Console.WriteLine(ex2.Message);

            //}

            Console.ReadLine();

        }

        static string  ObtnerSignoZodiaco(int numeroMes) 
        {
            string resultado = string.Empty;


            switch ( numeroMes)
            {

                case 1: 
                {
                        resultado = "Aries";
                        break;
                    
                }

                case 2:
                    {
                        resultado = "Tauro";
                        break;

                    }

                case 3:
                    {
                        resultado = "Geminis";
                        break;

                    }

                case 4:
                    {
                        resultado = "Cancer";
                        break;

                    }

                default:
                    throw new InvalidOperationException("Mes Invalido");
                   
            }
            return resultado;





        }
    }
}

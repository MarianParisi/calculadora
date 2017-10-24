using System;

namespace Calculadora
{
    class Program
    {
        /// <summary>
        /// Muestra el menú de la aplicación.
        /// </summary>
        /// <param name= "numero1"></param>
        /// <param name= "numero2"></param>
        /// <returns> resultado de la operacion </returns>
        static void MostrarMenu()
        {
            Console.WriteLine("Qué querés hacer?");
            Console.WriteLine();
            Console.WriteLine("1- Sumar dos números");
            Console.WriteLine("2- Multiplicar dos números");
            Console.WriteLine("0- Salir");
        }
        static int multiplicacion(int numero1, int numero2)
        {
            return numero1 * numero2;
        } 
        static int suma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }       
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora");
            MostrarMenu();

            int opcion = int.Parse(Console.ReadLine());
            while(opcion != 0)
            {                
                switch(opcion)
                {
                    case 1:

                        Console.WriteLine("ingrese el primer numero"); 
                        int numero1= int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el segundo numero"); 
                        int numero2= int.Parse(Console.ReadLine());  
                        int resultado= suma(numero1, numero2);   
                        Console.WriteLine("El resultado es: "+ resultado);
                        MostrarMenu();
                        opcion = int.Parse(Console.ReadLine());         
                        break;
                    case 2:         
                        
                        Console.WriteLine("ingrese el primer numero"); 
                        int numero3= int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el segundo numero"); 
                        int numero4= int.Parse(Console.ReadLine());  
                        int resultadoSuma= multiplicacion(numero3, numero4);   
                        Console.WriteLine("El resultado es: "+ resultadoSuma);
                        MostrarMenu();
                        opcion = int.Parse(Console.ReadLine());         
                        break;
                    default:
                        Console.WriteLine("Opción inválida");                    
                        MostrarMenu();
                        opcion = int.Parse(Console.ReadLine());
                        break;            
                }
            }

            Console.WriteLine("Chau!!!!");
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {   int numeroUsuario=0;
            int numeroAleatorio = new Random().Next(1, 5);// Genera un número aleatorio entre 1 y 5
            Console.WriteLine("¡Bienvenido al juego de adivinar el número!");
            Console.WriteLine("Introduce un número:");
            while (true)
            {
                try
                {
                    numeroUsuario = int.Parse(Console.ReadLine());// Lee la entrada del usuario y la convierte a un número entero
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Formato erroneo.");
                    continue;
                }
            }            
               
            int intentos = 0;
            do {
                intentos++;
                if(numeroUsuario < numeroAleatorio)
                {
                    Console.WriteLine("El número es mayor. Intenta de nuevo:");
                    numeroUsuario = int.Parse(Console.ReadLine());
                }
                else if (numeroUsuario > numeroAleatorio)
                {
                    Console.WriteLine("El número es menor. Intenta de nuevo:");
                    numeroUsuario = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"¡Felicidades! Has adivinado el número en {intentos} intentos.");
                    break;
                }
            }while (intentos < 6) ;
            Console.WriteLine("¡Gracias por jugar! El número era: " + numeroAleatorio);
        }
    }
}

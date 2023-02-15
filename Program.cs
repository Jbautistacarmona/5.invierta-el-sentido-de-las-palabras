using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.invierta_el_sentido_de_las_palabras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce la cadena de texto que quieres invertir:");
            string input = Console.ReadLine();///representa secuencia de texto, 

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray); //para invertir los caracteres introducidos en una dimension.

            string reversed = new string(charArray);
            Console.WriteLine("La cadena invertida es: " + reversed); //para imprimir el nuevo caracter generado

            Console.ReadLine();// imprimir resultado en pantalla
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        /**
         * función final() 
         * Basicamente consiste en una función que fuerza al programa a,
         * pedir una entrada por teclado para cerrar el terminal.
         * PD: Si no, se cierra automáticamente.
         **/
        static void final(){
            System.Console.ReadLine();
        }

        /**
         *Función echo() 
         * fácil, esta funcion sirve para.... IMPRIMIR POR PANTALLA, patán!
         * es una ahorro considerable para no repetir código.
         **/
        static void echo(String texto)
        {
            System.Console.WriteLine(texto);
        }

        static void Main(string[] args)
        {
            //escritura por pantalla.
            System.Console.WriteLine("Hola, Qué tal?, cómo se llama?");
            String nombre;
            //Lectura de teclado.
            nombre = System.Console.ReadLine();
            echo("Hola, "+nombre);
            int edad = Convert.ToInt32(args[0]);
            echo("Tiene "+edad+" años, verdad?");
            final();
        }
    }

    
}

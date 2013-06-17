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

        /**
         * Función ArrayIntToString()
         * recibe como argumento un array de enteros y lo devuelve como String
         **/
        static String ArrayIntToString(int [] array)
        {
            String salida;
            if(array.Length >= 1)
            {
                salida = ""+array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    salida += ", "+array[i];
                }
            }
            else
            {
                salida = "El array introducido está vacío";
            }
            return salida; 
         }
        
        /**
         *Función primos(int x)
         *esta función devuelve los x primeros números primos y los devuelve en forma de array.
         * 
         **/
        static int [] primos(int longitud)
        {
            int cuenta = 1;
            int[] salida = new int[longitud];
            for (int i = 0; i < longitud; i++)
            {
                //echo("contador " + i);
                while(!primo(cuenta))
                {
                    //echo("cuenta " + cuenta);
                    cuenta++;   
                }
                salida[i] = cuenta;
                cuenta++;
            }
            return salida;
        }

        /**
         * Función primo(int x)
         * esta función devuelve true si x es primo, o false si no lo és
         * en caso de ser 1, devuelve directamente true.
         * */
        static bool primo(int numero)
        {
            if (numero == 1) return true;
            int divisibles = 0;
            for (int i = numero; i > 0; i--)
            {
                if (numero % i == 0)
                {
                    divisibles++;
                }
            }
            if (divisibles == 2)
            {
                return true;
            }
            return false;
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
            int[] prim;
            int longitud = 10;
            prim = new int[longitud];
            prim = primos(longitud);
            echo(ArrayIntToString(prim));
            //echo(""+primo(27));
            final();
        }
    }

    
}

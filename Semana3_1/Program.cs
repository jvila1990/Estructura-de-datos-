using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pilas...");

            Stack<ClasePrograma> PilaPrograma = new Stack<ClasePrograma>();

            // Agregar elementos usando push
            ClasePrograma programa1 = new ClasePrograma();
            {
                programa1.Nombre = "Program 1";
                programa1.Tipo = "Suma";
            }
            
            ClasePrograma programa2 = new ClasePrograma();
            {
                programa2.Nombre = "Program 2";
                programa2.Tipo = "Resta";
            }
          
            ClasePrograma programa3 = new ClasePrograma();
            {
                programa3.Nombre = "Program 3";
                programa3.Tipo = "Multiplicacion";
            }
           
            ClasePrograma programa4 = new ClasePrograma();
            {
                programa4.Nombre = "Program 4";
                programa4.Tipo = "Division";
            }
            

            ClasePrograma programa5 = new ClasePrograma();
            {
                programa5.Nombre = "Program 5";
                programa5.Tipo = "Potenciacion";
            }
          

            PilaPrograma.Push(programa1);
            PilaPrograma.Push(programa2);
            PilaPrograma.Push(programa3);
            PilaPrograma.Push(programa4);
            PilaPrograma.Push(programa5);


            // Recorrer elementos
            foreach (var elem in PilaPrograma)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine("");


            // Eliminar el primer elemento
            PilaPrograma.Pop();

            foreach (var elem in PilaPrograma)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine("");

            //Obtener el valor del el primer elemento
            Console.WriteLine(PilaPrograma.Peek());
            Console.WriteLine("");
            Console.Read();




          

        }
    }
}

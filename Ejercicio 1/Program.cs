using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BorrarPantalla();
            
        }
        public static void BorrarPantalla()
        {
             Console.Clear();

            int i;
            for (i = 0; i <= (25-1); i++)
            {
                Console.WriteLine("____________________________________________________________________________________");
            }
        }

    }
    
}

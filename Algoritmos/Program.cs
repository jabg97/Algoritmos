using System;

namespace Algoritmos
{
    public class Program
    {


        private static Menu menu = new Menu();
        public static void Main(string[] args)
        {
            try
            {
                ushort desicion = 0;
                do
                {
                    desicion = menu.Principal();
                    Console.Clear();
                    switch (desicion)
                    {
                        case 1:
                            menu.Cesar();
                            break;
                        case 2:
                            menu.Euclides();
                            break;
                        case 3:
                            menu.Binario();
                            break;
                        case 4:
                            menu.Primalidad();
                            break;
                        case 5:
                            menu.Pascal();
                            break;
                        case 6:
                            menu.Combinatoria();
                            break;
                        case 7:
                            menu.Factorial();
                            break;
                        case 8:
                            menu.Fibonacci();
                            break;
                        case 9:
                            menu.Cajero();
                            break;
                        case 10:
                            menu.Descomponer();
                            break;
                        case 0:
                            Console.WriteLine(" ===============");
                            Console.WriteLine(" [ HASTA LUEGO ]");
                            Console.WriteLine(" ===============");
                            Console.WriteLine(" Fin del programa!");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine(" =======================");
                            Console.WriteLine(" [ OPERACION NO VALIDA ]");
                            Console.WriteLine(" =======================");
                            Console.WriteLine(" La entrada \"{0}\" no esta definida.", desicion);
                            Console.Write(" Presiona cualquier tecla para continuar.");
                            Console.ReadKey();
                            break;
                    }
                }
                while (desicion != 0);
            }
            catch (Exception error)
            {
                Console.Clear();
                Console.Beep();
                Console.WriteLine(" =================");
                Console.WriteLine(" [ Error Critico ]");
                Console.WriteLine(" =================");
                Console.WriteLine(" Hubo un error y el programa tiene que finalizar.");
                Console.WriteLine(" Error! " + error.Message);
            }
            Console.Write(" Presiona cualquier tecla para continuar.");
            Console.ReadKey();
        }
    }
}

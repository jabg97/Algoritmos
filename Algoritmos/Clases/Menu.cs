using System;
using System.Diagnostics;

namespace Algoritmos
{
    public class Menu
    {
        private Cesar cesar = new Cesar();
        private Pascal pascal = new Pascal();
        private Euclides euclides = new Euclides();
        private Binario binario = new Binario();
        private Fibonacci fibonacci = new Fibonacci();
        private Factorial factorial = new Factorial();
        private Primalidad primalidad = new Primalidad();
        private Combinatoria combinatoria = new Combinatoria();
        private Cajero cajero = new Cajero();
        private Descomponer descomponer = new Descomponer();

        public void Cesar()
        {
            Stopwatch reloj;
            ushort desicion, llave = 0;
            string palabra, cifrado, descifrado = "";
            do
            {
                Console.Clear();
                Console.WriteLine(" ======================");
                Console.WriteLine(" [ ALGORITMO DE CESAR ]");
                Console.WriteLine(" ======================");
                Console.WriteLine(" 1) Cifrar.");
                Console.WriteLine(" 2) Descifrar.");
                Console.WriteLine(" 3) Demostracion.");
                Console.WriteLine(" 0) Volver.");
                Console.Write(" Escriba el numero (0-3): ");
                desicion = Convert.ToUInt16(Console.ReadLine());
                if (desicion >= 1 && desicion <= 3)
                {
                    Console.Write(" Escriba la palabra: ");
                    palabra = Console.ReadLine();
                    Console.Write(" Escriba la llave: ");
                    llave = Convert.ToUInt16(Console.ReadLine());
                    reloj = Stopwatch.StartNew();

                    cifrado = palabra;
                    descifrado = palabra;

                    if (desicion == 1)
                    {
                        cifrado = cesar.Algoritmo(palabra, llave, true);
                    }
                    else if (desicion == 2)
                    {
                        descifrado = cesar.Algoritmo(cifrado, llave, false);
                    }
                    else if (desicion == 3)
                    {
                        cifrado = cesar.Algoritmo(palabra, llave, true);
                        descifrado = cesar.Algoritmo(cifrado, llave, false);
                    }

                    reloj.Stop();

                    Console.Clear();
                    Console.WriteLine(" =============");
                    Console.WriteLine(" [ RESULTADO ]");
                    Console.WriteLine(" =============");
                    Console.WriteLine(" Cifrado: {0}.", cifrado);
                    Console.WriteLine(" Descifrado: {0}.", descifrado);
                    Console.WriteLine(" Tiempo de ejecucion: ({0} ms) ({1} seg).", reloj.ElapsedMilliseconds, reloj.ElapsedMilliseconds / 1000);
                    Console.Write(" Presiona cualquier tecla para continuar.");
                    Console.ReadKey();
                }
                else
                {
                    if (desicion != 0)
                    {
                        Console.Clear();
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" [ OPERACION NO VALIDA ]");
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" La entrada \"{0}\" no esta definida.", desicion);
                        Console.Write(" Presiona cualquier tecla para continuar.");
                        Console.ReadKey();
                    }

                }

            }
            while (desicion != 0);
        }

        public void Factorial()
        {
            ushort desicion = 0;
            uint n = 0;
            ulong resultado = 0;
            Stopwatch reloj;
            do
            {
                Console.Clear();
                Console.WriteLine(" =============");
                Console.WriteLine(" [ FACTORIAL ]");
                Console.WriteLine(" =============");
                Console.WriteLine(" 1) Factorial Recursivo.");
                Console.WriteLine(" 2) Factorial con Memoria.");
                Console.WriteLine(" 3) Factorial Iterativo.");
                Console.WriteLine(" 0) Volver.");
                Console.Write(" Escriba el numero (0-3): ");

                desicion = Convert.ToUInt16(Console.ReadLine());
                if (desicion >= 1 && desicion <= 3)
                {
                    Console.Write(" Escriba el numero (n): ");
                    n = Convert.ToUInt32(Console.ReadLine());
                    reloj = Stopwatch.StartNew();
                    if (desicion == 1)
                    {
                        resultado = factorial.FactorialRecursivo(n);
                    }
                    else if (desicion == 2)
                    {
                        factorial.SetBuffer(n);
                        resultado = factorial.FactorialMemory(n);
                    }
                    else if (desicion == 3)
                    {
                        resultado = factorial.FactorialIterativo(n);
                    }
                    reloj.Stop();

                    Console.Clear();
                    Console.WriteLine(" =============");
                    Console.WriteLine(" [ RESULTADO ]");
                    Console.WriteLine(" =============");
                    Console.WriteLine(" Factorial de {0}: {1}.", n, resultado);
                    Console.WriteLine(" Tiempo de ejecucion: ({0} ms) ({1} seg).", reloj.ElapsedMilliseconds, reloj.ElapsedMilliseconds / 1000);
                    Console.Write(" Presiona cualquier tecla para continuar.");
                    Console.ReadKey();
                }
                else
                {
                    if (desicion != 0)
                    {
                        Console.Clear();
                        Console.WriteLine(" La entrada \"{0}\" no esta definida.", desicion);
                        Console.Write(" Presiona cualquier tecla para continuar.");
                        Console.ReadKey();
                    }

                }

            }
            while (desicion != 0);
        }

        public void Binario()
        {
            ushort desicion = 0;
            ulong n = 0;
            string resultado = "";
            Stopwatch reloj;
            do
            {
                Console.Clear();
                Console.WriteLine(" =====================");
                Console.WriteLine(" [ DECIMAL A BINARIO ]");
                Console.WriteLine(" =====================");
                Console.WriteLine(" 1) Convertir.");
                Console.WriteLine(" 0) Volver.");
                Console.Write(" Escriba el numero (0-1): ");
                desicion = Convert.ToUInt16(Console.ReadLine());
                if (desicion == 1)
                {
                    Console.Write(" Escriba el numero (n): ");
                    n = Convert.ToUInt64(Console.ReadLine());
                    reloj = Stopwatch.StartNew();
                    resultado = binario.ImprimirBinario(n);
                    reloj.Stop();
                    Console.Clear();
                    Console.WriteLine(" =============");
                    Console.WriteLine(" [ RESULTADO ]");
                    Console.WriteLine(" =============");
                    Console.WriteLine(" Binario de {0}: {1}.", n, resultado);
                    Console.WriteLine(" Tiempo de ejecucion: ({0} ms) ({1} seg).", reloj.ElapsedMilliseconds, reloj.ElapsedMilliseconds / 1000);
                    Console.Write(" Presiona cualquier tecla para continuar.");
                    Console.ReadKey();
                }
                else
                {
                    if (desicion != 0)
                    {
                        Console.Clear();
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" [ OPERACION NO VALIDA ]");
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" La entrada \"{0}\" no esta definida.", desicion);
                        Console.Write(" Presiona cualquier tecla para continuar.");
                        Console.ReadKey();
                    }

                }


            }
            while (desicion != 0);
        }


        public void Cajero()
        {
            ushort desicion = 0;
            int n = 0;
            string resultado = "";
            Stopwatch reloj;
            do
            {
                Console.Clear();
                Console.WriteLine(" =====================");
                Console.WriteLine(" [ CAJERO AUTOMATICO ]");
                Console.WriteLine(" =====================");
                Console.WriteLine(" SALDO ACTUAL:{0}", cajero.total);
                Console.WriteLine(" 1) Retirar Dinero Infinito.");
                Console.WriteLine(" 2) Retirar Dinero con Limite.");
                Console.WriteLine(" 3) LLenar Cajero.");
                Console.WriteLine(" 0) Volver.");
                Console.Write(" Escriba el numero (0-1): ");
                desicion = Convert.ToUInt16(Console.ReadLine());
                if (desicion >= 1 && desicion <= 2)               
                {
                    Console.Write(" Ingrese el monto (n): ");
                    n = Convert.ToInt32(Console.ReadLine());
                    reloj = Stopwatch.StartNew();
                    if (desicion == 1)
                    {
                        resultado = cajero.RetirarInfinito(n);
                    }
                    else if (desicion == 2)
                    {
                        resultado = cajero.RetirarLimite(n);
                    }
                       
                    reloj.Stop();
                    Console.Clear();
                    Console.WriteLine(" =============");
                    Console.WriteLine(" [ RESULTADO ]");
                    Console.WriteLine(" =============");
                    Console.WriteLine(" Debe devolver de {0}:", n);
                    Console.WriteLine(" =============");
                    Console.WriteLine(resultado);
                    Console.WriteLine(" Tiempo de ejecucion: ({0} ms) ({1} seg).", reloj.ElapsedMilliseconds, reloj.ElapsedMilliseconds / 1000);
                    Console.Write(" Presiona cualquier tecla para continuar.");
                    Console.ReadKey();
                }else if (desicion == 3)
                {
                    LLenarCajero();
                }
                else
                {
                    if (desicion != 0)
                    {
                        Console.Clear();
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" [ OPERACION NO VALIDA ]");
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" La entrada \"{0}\" no esta definida.", desicion);
                        Console.Write(" Presiona cualquier tecla para continuar.");
                        Console.ReadKey();
                    }

                }


            }
            while (desicion != 0);
        }

        public void LLenarCajero()
        {
            ushort desicion = 0;
            int n = 0;
            string tipo = "";
            do
            {
                Console.Clear();
                Console.WriteLine(" ============================");
                Console.WriteLine(" [ LLENAR CAJERO AUTOMATICO ]");            
                Console.WriteLine(" ============================");
                Console.WriteLine(" SALDO ACTUAL:{0}",cajero.total);

                for (int i = 0; i < cajero.billetes.Length; i++)
                {
                    tipo = (cajero.billetes[i] < 1000) ? "moneda" : "billete";
                    Console.WriteLine(" {0}) Insertar {1} de {2}.",i+1,tipo, cajero.billetes[i]);
                }

                Console.WriteLine(" 0) Volver.");
                Console.Write(" Seleccione cual insertar (0-{0}): ",cajero.billetes.Length);
                desicion = Convert.ToUInt16(Console.ReadLine());
                if (desicion >= 1 && desicion <= cajero.billetes.Length)
                {
                    Console.Write(" Ingrese el monto (n): ");
                    n = Convert.ToInt32(Console.ReadLine());
                    cajero.ModificarCajero(n,desicion-1);
                }
                else
                {
                    if (desicion != 0)
                    {
                        Console.Clear();
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" [ OPERACION NO VALIDA ]");
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" La entrada \"{0}\" no esta definida.", desicion);
                        Console.Write(" Presiona cualquier tecla para continuar.");
                        Console.ReadKey();
                    }

                }


            }
            while (desicion != 0);
        }

        public void Descomponer()
        {
            ushort desicion = 0;
            int n = 0;
            string resultado = "";
            Stopwatch reloj;
            do
            {
                Console.Clear();
                Console.WriteLine(" =======================");
                Console.WriteLine(" [ DESCOMPONER NUMEROS ]");
                Console.WriteLine(" =======================");
                Console.WriteLine(" 1) Descomponer en Sumas.");
                Console.WriteLine(" 0) Volver.");
                Console.Write(" Escriba el numero (0-1): ");
                desicion = Convert.ToUInt16(Console.ReadLine());
                if (desicion == 1)
                {
                    Console.Write(" Ingrese el numero (n): ");
                    n = Convert.ToInt32(Console.ReadLine());
                    reloj = Stopwatch.StartNew();
                    resultado = descomponer.Sumas(n);
                    reloj.Stop();
                    Console.Clear();
                    Console.WriteLine(" =============");
                    Console.WriteLine(" [ RESULTADO ]");
                    Console.WriteLine(" =============");
                    Console.WriteLine(" Descomposicion de {0}:", n);
                    Console.WriteLine(" =============");
                    Console.WriteLine(resultado);
                    Console.WriteLine(" Tiempo de ejecucion: ({0} ms) ({1} seg).", reloj.ElapsedMilliseconds, reloj.ElapsedMilliseconds / 1000);
                    Console.Write(" Presiona cualquier tecla para continuar.");
                    Console.ReadKey();
                }
                else
                {
                    if (desicion != 0)
                    {
                        Console.Clear();
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" [ OPERACION NO VALIDA ]");
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" La entrada \"{0}\" no esta definida.", desicion);
                        Console.Write(" Presiona cualquier tecla para continuar.");
                        Console.ReadKey();
                    }

                }


            }
            while (desicion != 0);
        }

        public void Combinatoria()
        {
            ushort desicion = 0;
            uint n1, n2, temp = 0;
            ulong resultado = 0;
            Stopwatch reloj;
            do
            {
                Console.Clear();
                Console.WriteLine(" ================");
                Console.WriteLine(" [ COMBINATORIA ]");
                Console.WriteLine(" ================");
                Console.WriteLine(" 1) Permutacion.");
                Console.WriteLine(" 2) Combinacion.");
                Console.WriteLine(" 3) Formula de Pascal.");
                Console.WriteLine(" 4) Triangulo de Pascal.");
                Console.WriteLine(" 0) Volver.");
                Console.Write(" Escriba el numero (0-3): ");
                desicion = Convert.ToUInt16(Console.ReadLine());
                if (desicion >= 1 && desicion <= 4)
                {
                    Console.Write(" Escriba el primer numero (n1): ");
                    n1 = Convert.ToUInt32(Console.ReadLine());
                    Console.Write(" Escriba el segundo numero (n2): ");
                    n2 = Convert.ToUInt32(Console.ReadLine());
                    reloj = Stopwatch.StartNew();
                    if (n1 < n2)
                    {
                        temp = n1;
                        n1 = n2;
                        n2 = temp;
                    }
                    if (desicion == 1)
                    {
                        resultado = combinatoria.Permutaciones(n1, n2);
                    }
                    else if (desicion == 2)
                    {
                        resultado = combinatoria.Combinaciones(n1, n2);
                    }
                    else if (desicion == 3)
                    {
                        resultado = combinatoria.FormulaPascal(n1, n2);
                    }
                    else if (desicion == 4)
                    {
                        resultado = combinatoria.TrianguloPascal(n1 + 1, n2 + 1);
                    }

                    reloj.Stop();
                    Console.Clear();
                    Console.WriteLine(" =============");
                    Console.WriteLine(" [ RESULTADO ]");
                    Console.WriteLine(" =============");
                    Console.WriteLine(" Combinatoria entre {0} y {1}: {2}.", n1, n2, resultado);
                    Console.WriteLine(" Tiempo de ejecucion: ({0} ms) ({1} seg).", reloj.ElapsedMilliseconds, reloj.ElapsedMilliseconds / 1000);
                    Console.Write(" Presiona cualquier tecla para continuar.");
                    Console.ReadKey();
                }
                else
                {
                    if (desicion != 0)
                    {
                        Console.Clear();
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" [ OPERACION NO VALIDA ]");
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" La entrada \"{0}\" no esta definida.", desicion);
                        Console.Write(" Presiona cualquier tecla para continuar.");
                        Console.ReadKey();
                    }

                }

            }
            while (desicion != 0);
        }

        public void Euclides()
        {
            ushort desicion = 0;
            ulong n1, n2, resultado, temp = 0;
            Stopwatch reloj;
            do
            {
                Console.Clear();
                Console.WriteLine(" =========================");
                Console.WriteLine(" [ AlGORITMO DE EUCLIDES ]");
                Console.WriteLine(" =========================");
                Console.WriteLine(" 1) Hallar MCD.");
                Console.WriteLine(" 0) Volver.");
                Console.Write(" Escriba el numero (0-1): ");
                desicion = Convert.ToUInt16(Console.ReadLine());
                if (desicion == 1)
                {
                    Console.Write(" Escriba el primer numero (n1): ");
                    n1 = Convert.ToUInt64(Console.ReadLine());
                    Console.Write(" Escriba el segundo numero (n2): ");
                    n2 = Convert.ToUInt64(Console.ReadLine());
                    reloj = Stopwatch.StartNew();
                    if (n1 < n2)
                    {
                        temp = n1;
                        n1 = n2;
                        n2 = temp;
                    }
                    resultado = euclides.MCD(n1, n2);
                    reloj.Stop();
                    Console.Clear();
                    Console.WriteLine(" =============");
                    Console.WriteLine(" [ RESULTADO ]");
                    Console.WriteLine(" =============");
                    Console.WriteLine(" MCD entre {0} y {1}: {2}.", n1, n2, resultado);
                    Console.WriteLine(" Tiempo de ejecucion: ({0} ms) ({1} seg).", reloj.ElapsedMilliseconds, reloj.ElapsedMilliseconds / 1000);
                    Console.Write(" Presiona cualquier tecla para continuar.");
                    Console.ReadKey();
                }
                else
                {
                    if (desicion != 0)
                    {
                        Console.Clear();
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" [ OPERACION NO VALIDA ]");
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" La entrada \"{0}\" no esta definida.", desicion);
                        Console.Write(" Presiona cualquier tecla para continuar.");
                        Console.ReadKey();
                    }

                }


            }
            while (desicion != 0);
        }

        public void Fibonacci()
        {
            ushort desicion = 0;
            uint n = 0;
            ulong resultado = 0;
            Stopwatch reloj;
            do
            {
                Console.Clear();
                Console.WriteLine(" =============");
                Console.WriteLine(" [ FIBONACCI ]");
                Console.WriteLine(" =============");
                Console.WriteLine(" 1) Fibonacci Recursivo.");
                Console.WriteLine(" 2) Fibonacci con Memoria.");
                Console.WriteLine(" 3) Fibonacci Iterativo.");
                Console.WriteLine(" 0) Salir.");
                Console.Write(" Escriba el numero (0-3): ");
                desicion = Convert.ToUInt16(Console.ReadLine());
                if (desicion >= 1 && desicion <= 3)
                {
                    Console.Write(" Escriba el numero (n): ");
                    n = Convert.ToUInt32(Console.ReadLine());
                    reloj = Stopwatch.StartNew();
                    if (desicion == 1)
                    {
                        resultado = fibonacci.FibonacciRecursivo(n);
                    }
                    else if (desicion == 2)
                    {
                        fibonacci.SetBuffer(n);
                        resultado = fibonacci.FibonacciMemory(n);
                    }
                    else if (desicion == 3)
                    {
                        resultado = fibonacci.FibonacciIterativo(n);
                    }

                    reloj.Stop();

                    Console.Clear();
                    Console.WriteLine(" =============");
                    Console.WriteLine(" [ RESULTADO ]");
                    Console.WriteLine(" =============");
                    Console.WriteLine(" Fibonacci de {0}: {1}.", n, resultado);
                    Console.WriteLine(" Tiempo de ejecucion: ({0} ms) ({1} seg).", reloj.ElapsedMilliseconds, reloj.ElapsedMilliseconds / 1000);
                    Console.Write(" Presiona cualquier tecla para continuar.");
                    Console.ReadKey();
                }
                else
                {
                    if (desicion != 0)
                    {
                        Console.Clear();
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" [ OPERACION NO VALIDA ]");
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" La entrada \"{0}\" no esta definida.", desicion);
                        Console.Write(" Presiona cualquier tecla para continuar.");
                        Console.ReadKey();
                    }

                }


            }
            while (desicion != 0);
        }

        public void Pascal()
        {
            ushort desicion = 0;
            uint h = 0;
            Stopwatch reloj;
            do
            {
                Console.Clear();
                Console.WriteLine(" =======================");
                Console.WriteLine(" [ TRIANGULO DE PASCAL ]");
                Console.WriteLine(" =======================");
                Console.WriteLine(" 1) Pascal Recursivo.");
                Console.WriteLine(" 2) Pascal con Memoria.");
                Console.WriteLine(" 3) Pascal Iterativo.");
                Console.WriteLine(" 0) Volver.");
                Console.Write(" Escriba el numero (0-3): ");
                desicion = Convert.ToUInt16(Console.ReadLine());
                if (desicion >= 1 && desicion <= 3)
                {
                    Console.Write(" Escriba la altura del triangulo (h): ");
                    h = 1 + Convert.ToUInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine(" =============");
                    Console.WriteLine(" [ RESULTADO ]");
                    Console.WriteLine(" =============");
                    reloj = Stopwatch.StartNew();

                    if (desicion == 1)
                    {
                        pascal.PascalRecursivo(h);
                    }
                    else if (desicion == 2)
                    {
                        pascal.SetHeight(h);
                        pascal.PascalRecursivoMemory(h);
                        pascal.DibujarPascal();
                    }
                    else if (desicion == 3)
                    {
                        pascal.SetHeight(h);
                        pascal.PascalIterativo(h);
                        pascal.DibujarPascal();
                    }
                    reloj.Stop();

                    Console.WriteLine(" Tiempo de ejecucion: ({0} ms) ({1} seg).", reloj.ElapsedMilliseconds, reloj.ElapsedMilliseconds / 1000);
                    Console.Write(" Presiona cualquier tecla para continuar.");
                    Console.ReadKey();
                }
                else
                {
                    if (desicion != 0)
                    {
                        Console.Clear();
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" [ OPERACION NO VALIDA ]");
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" La entrada \"{0}\" no esta definida.", desicion);
                        Console.Write(" Presiona cualquier tecla para continuar.");
                        Console.ReadKey();
                    }

                }


            }
            while (desicion != 0);
        }

        public void Primalidad()
        {
            ushort desicion = 0;
            uint n = 0;
            bool resultado = false;
            Stopwatch reloj;
            do
            {
                Console.Clear();
                Console.WriteLine(" ======================");
                Console.WriteLine(" [ TEST DE PRIMALIDAD ]");
                Console.WriteLine(" ======================");
                Console.WriteLine(" 1) Teorema de Wilson.");
                Console.WriteLine(" 2) Busqueda Lineal.");
                Console.WriteLine(" 0) Salir.");
                Console.Write(" Escriba el numero (0-2): ");
                desicion = Convert.ToUInt16(Console.ReadLine());
                if (desicion >= 1 && desicion <= 2)
                {
                    Console.Write(" Escriba el numero (n): ");
                    n = Convert.ToUInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine(" =============");
                    Console.WriteLine(" [ RESULTADO ]");
                    Console.WriteLine(" =============");
                    reloj = Stopwatch.StartNew();
                    resultado = false;
                    if (desicion == 1)
                    {
                        resultado = primalidad.TeoremaWilson(n);
                    }
                    else if (desicion == 2)
                    {
                        resultado = primalidad.BusquedaLineal(n);
                    }

                    reloj.Stop();

                    Console.WriteLine(" Test de Primalidad: {0} es un numero {1}.", n, resultado ? "PRIMO" : "COMPUESTO");
                    Console.WriteLine(" Tiempo de ejecucion: ({0} ms) ({1} seg).", reloj.ElapsedMilliseconds, reloj.ElapsedMilliseconds / 1000);
                    Console.Write(" Presiona cualquier tecla para continuar.");
                    Console.ReadKey();
                }
                else
                {
                    if (desicion != 0)
                    {
                        Console.Clear();
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" [ OPERACION NO VALIDA ]");
                        Console.WriteLine(" =======================");
                        Console.WriteLine(" La entrada \"{0}\" no esta definida.", desicion);
                        Console.Write(" Presiona cualquier tecla para continuar.");
                        Console.ReadKey();
                    }

                }
            }
            while (desicion != 0);
        }

        public ushort Principal()
        {
            Console.Clear();
            Console.WriteLine(" ==================");
            Console.WriteLine(" [ MENU PRINCIPAL ]");
            Console.WriteLine(" ==================");
            Console.WriteLine(" 1) Algortimo de Cesar.");
            Console.WriteLine(" 2) Algortimo de Euclides.");
            Console.WriteLine(" 3) Decimal a Binario.");
            Console.WriteLine(" 4) Test de Primalidad.");
            Console.WriteLine(" 5) Triangulo de Pascal.");
            Console.WriteLine(" 6) Combinatoria.");
            Console.WriteLine(" 7) Factorial.");
            Console.WriteLine(" 8) Fibonacci.");
            Console.WriteLine(" 9) Cajero.");
            Console.WriteLine(" 10) Descomponer.");
            Console.WriteLine(" 0) Salir.");
            Console.Write(" Escriba el numero (0-9): ");
            return Convert.ToUInt16(Console.ReadLine());
        }
    }
}


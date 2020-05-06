
namespace Algoritmos
{
    public class Primalidad
    {
        private Factorial factorial = new Factorial();

        public bool TeoremaWilson(uint n)
        {
            /*
             * Formula: (n - 1)! es congruente con -1 (Mod n)
             * (n - 1)! % n == -1 %n;
             * =================================================
             * Formula Alternativa: (n - 1)! - (-1) % n == 0
             * es decir (n - 1)! + 1 % n == 0
             */
            //return Convert.ToInt32(FactorialIterativo(n - 1)) - (-1) % n == 0;
            return (factorial.FactorialIterativo(n - 1) + 1) % n == 0;
            //return Convert.ToInt32(FactorialIterativo(n-1)) % n == -1 % n; //(No Funciona)
        }

        public bool BusquedaLineal(uint n)
        {
            for (uint i = n - 1; i > 1; i--)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

}

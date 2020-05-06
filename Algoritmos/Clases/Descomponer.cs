
namespace Algoritmos
{
    public class Descomponer
    {

        public string Sumas(int n)
        {
            string resultado = "";

            for (int i = 1; i <= n / 2; i++)
            {
                resultado += "\n " + (n - i) + " + " + i;
            }
            return resultado;
        }
    }

}

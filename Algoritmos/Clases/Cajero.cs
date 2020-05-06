
namespace Algoritmos
{
    public class Cajero
    {
        public int[] billetes = { 100000, 50000, 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50 };
        public int[] cantidad_billetes = { 2, 1, 0, 10, 0, 0, 0, 0, 0, 0, 0 };
        //{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int total = 350000;


        public void ModificarCajero(int cantidad, int i)
        {
            cantidad_billetes[i] += cantidad;
            total += cantidad * billetes[i];
        }

        public string RetirarLimite(int monto)
        {
            int cantidad, diferencia = 0;
            string resultado = "";
            string tipo = "";

            if (monto < 50 || monto % 50 != 0)
            {
                return "El monto debe ser mayor o igual a 50 y multiplo de 50 ";
            }
            for (int i = 0; i < billetes.Length; i++)
            {

                cantidad = 0;
                if (monto % billetes[i] != monto)
                {
                    cantidad = monto / billetes[i];
                    monto = monto % billetes[i];

                    if (cantidad_billetes[i] < cantidad)
                    {
                        diferencia = cantidad - cantidad_billetes[i];
                        cantidad = cantidad_billetes[i];
                        monto += billetes[i] * diferencia;
                    }

                }
                if (cantidad > 0)
                {
                    tipo = (billetes[i] < 1000) ? "moneda" : "billete";
                    resultado += "\n " + cantidad + " " + ((cantidad == 1) ? tipo : tipo + "s") + " de " + billetes[i];
                    ModificarCajero(-cantidad, i);
                }


            }
            return resultado;
        }


        public string RetirarInfinito(int monto)
        {
            int cantidad = 0;
            string resultado = "";
            string tipo = "";

            if (monto < 50 || monto % 50 != 0)
            {
                return "El monto debe ser mayor o igual a 50 y multiplo de 50 ";
            }
            for (int i = 0; i < billetes.Length; i++)
            {

                cantidad = 0;
                if (monto % billetes[i] != monto)
                {
                    cantidad = monto / billetes[i];
                    monto = monto % billetes[i];
                }
                if (cantidad > 0)
                {
                    tipo = (billetes[i] < 1000) ? "moneda" : "billete";
                    resultado += "\n " + cantidad + " " + ((cantidad == 1) ? tipo : tipo + "s") + " de " + billetes[i];
                }


            }
            return resultado;
        }
    }

}

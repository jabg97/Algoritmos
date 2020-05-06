using System;
using System.Collections;

namespace Algoritmos
{
    public class Cesar
    {

        private Hashtable buscar_letra = new Hashtable();
        private Hashtable buscar_indice = new Hashtable();
        private int modulo = 0;

        public Cesar()
        {
            Iniciar();
        }

        public void Iniciar()
        {
            string alfabeto = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!#$%&/()=?¡¿¨´*{},.-_:;[]+^~`|'°¬àáâäãåąćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð";
            modulo = alfabeto.Length;
            for (int i = 0; i < modulo; i++)
            {
                buscar_indice.Add(alfabeto[i], i);
                buscar_letra.Add(i, alfabeto[i]);
            }
        }

        public string Algoritmo(string palabra, ushort llave, bool cifrar)
        {
            if (llave < 0 || llave > modulo - 1)
            {
                throw new Exception("La llave debe estar dentro del intervalo cerrado [0," + (modulo - 1) + "].");
            }
            string resultado = "";
            if (cifrar)
            {
                for (int i = 0; i < palabra.Length; i++)
                {
                    resultado += buscar_letra[(Convert.ToUInt16(buscar_indice[palabra[i]]) + llave) % modulo];
                }
            }
            else
            {
                for (int i = 0; i < palabra.Length; i++)
                {
                    resultado += buscar_letra[(Convert.ToUInt16(buscar_indice[palabra[i]]) - llave) % modulo];
                }
            }

            return resultado;
        }
    }
}


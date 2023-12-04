using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avance_de_matriz
{
    class NEnt
    {
        //--------------------
        private int n;

        // CONSTRUCTOR----------------
        public NEnt()
        {
            n = 0;
        }

        // CARGAR---------------------------
        public void Cargar(int dato)
        {
            n = dato;
        }

        // VERIFICAR PRIMO----------------------
        public bool VerifPri()
        {
            int i, cont;
            cont = 0;
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }
            return (cont == 2);
        }
        //VERIFICAR PAR
        public bool verifpar()
        {
            return n % 2 == 0;
        }

        // VERIFICAR SI CAPICUA
        public bool verifCapicua(int num)
        {
            int numreverso, numoriginal;
            numreverso = 0; numoriginal = num;
            while (num > 0)
            {
                int digito = num % 10;
                numreverso = (numreverso * 10) + digito;
                num = num / 10;
            }
            return (numoriginal == numreverso);
        }
        //VERIFICA FIBONACCI
        public bool VerifFibo()
        {
            int a, b, c;
            a = 0; b = 1;
            c = -1;
            while (a < n)
            {
                a = b + c;
                c = b;
                b = a;
            }
            return (a == n);
        }
    }
}

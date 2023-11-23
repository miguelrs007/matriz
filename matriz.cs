using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avance_de_matriz
{
    class matriz
    {
        const int maxf = 50;
        const int maxc = 50;
        private int[,] x;
        private int f;
        private int c;
        public matriz()
        {
            f = 0; c = 0;
            x = new int[maxf, maxc];
        }
        public void cargar(int nf, int nc, int a, int b)
        {
            f = nf; c = nc;
            Random r = new Random();
            for (int i = 1; i <= f; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    x[i, j] = r.Next(a, b);
                }
            }
        }
        public string descargar()
        {
            string s = "";
            for (int i = 1; i <= f; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    s = s + x[i, j] + " | "

                        ;
                }
            }
            return s;
        }
    }
}

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
        private int f,c;
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
                for (int j = 1; j <= c; j++)
                    x[i, j] = r.Next(a, b+1);
        }
        public string descargar()
        {
            string s = "";
            for (int i = 1; i <= f; i++)
            {
                for (int j = 1; j <= c; j++)
                    s = s + x[i, j] + "\x0009";
                s = s + "\x000d" + "\x000a";
            }
            return s;
        }
        public void intercambio(int a,int b,int c,int d)
        {
            int aux = x[a, b];
            x[a, b] = x[c, d];
            x[c, d] = aux;
        }
        public void ordenamiento()
        {
            int f1, c1,f2,c2;
            for (f1 = 1; f1 <= f - 1; f1++)
            {
                for (c1 = 1; c1 <= c - 1; c1++)
                {
                    for (f2 = f1+1; f2 <= f; f2++)
                    {
                        for (c2 = c1+1; c2 <= c; c2++)
                        {
                            if (x[f1, c1] > x[f2, c2])
                                intercambio(f1, c1, f2, c2);
                        }
                    }  
                }
                
            }
                
        }
        //    for (p = dim; p >= 2; p--)
        //        for (d = 1; d <= p - 1; d++)
        //            if (v[d] < v[p])
        //                intercambiar(d, p);
        //}
        public void transp(ref matriz m2)
        {
            int f1, c1;
            
            for (f1 = 1; f1 <= f; f1++)
                for (c1 = 1; c1 <= c; c1++)
                    m2.x[c1, f1] = x[f1, c1];
            m2.f = c;
            m2.c = f;
        }
        public void cargar1(int nf, int nc, int vi, int r)
        {
            int f1, c1, i=0;
            f = nf;c = nc;
            for (f1 = f; f1 <= 1; f1--)
                for (c1 = c; c1 <= 1; c1--)
                {
                    i++;
                    x[f1, c1] = vi + (i - 1) * r;
                }
        }
        public void cargar2(int nf, int nc, int vi, int r)
        {
            int f1, c1, i = 0;
            f = nf; c = nc;
            for (f1 = 1; f1 <= f; f1++)
                for (c1 = 1; c1 <= c; c1++)
                {
                    i++;
                    x[f1, c1] = vi + (i - 1) * r;
                }
        }
        public double prom()
        {
            double s;
            s = 0;
            int f1, c1;
            for (f1 = 1; f1 <= f; f1++)
                for (c1 = 1; c1 <= c; c1++)
                    s = s + x[f1, c1];
            return s / (c * f);
        }
        public int myor()
        {
            int f1, c1;
            int mayor = x[1, 1];
            for (f1 = 1; f1 <= f; f1++)
                for (c1 = 1; c1 <= c; c1++)
                {
                    if (x[f1, c1] > mayor)
                        mayor = x[f1, c1];
                }
            return mayor; 
         }
        public int frecuencia(int ele)
        {
            int f1, c1, fr;
            fr = 0;
            for (f1 = 1; f1 <= f; f1++)
                for (c1 = 1; c1 <= c; c1++)
                {
                    if (x[f1, c1] == ele)
                        fr++;
                }
            return fr;
        }
        public bool busqsec(int ele)
        {
            bool b = false;
            int c1 = 1;
            while (c1 <= c&&(b==false))
            {
                int f1 = 1;
                while (f1 <= f && (b == false))
                {
                    if (x[f1, c1] == ele)
                        b = true;
                    f1++;
                }
                c1++;
            }
            return b;
        }
        public bool todoiguales()
        {
            bool b = true;
            int c1 = 1,refe=x[1,1];
            while (c1 <= c && (b == true))
            {
                int f1 = 1;
                while (f1 <= f && (b == true))
                {
                    if (x[f1, c1] == refe)
                    {
                       f1++;
                    }
                    else
                    {
                        b = false;
                    }
                }
                c1++;
            }
            return b;
        }
    }
}

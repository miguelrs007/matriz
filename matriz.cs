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
        private int f, c;
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
                    x[i, j] = r.Next(a, b + 1);
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
        public void intercambio(int a, int b, int c, int d)
        {
            int aux = x[a, b];
            x[a, b] = x[c, d];
            x[c, d] = aux;
        }
        public void ordenamientoFIL1()
        {
            int fp, cp, fd, cd, ic;
            for (fp = 1; fp <= f; fp++)
                for (cp = 1; cp <= c; cp++)
                    for (fd = fp; fd <= f; fd++)
                    {
                        if (fp == fd)
                            ic = cp;
                        else
                            ic = 1;
                        for (cd = ic; cd <= c; cd++)
                            if (x[fd, cd] < x[fp, cp])
                                intercambio(fp, cp, fd, cd);
                    }
        }
        public void ordenamientoFIL2()
        {
            int fp, cp, fd, cd, ic;
            for (fp = 1; fp <= f; fp++)
                for (cp = c; cp >= 1; cp--)
                    for (fd = fp; fd <= f; fd++)
                    {
                        if (fp == fd)
                            ic = cp;
                        else
                            ic = c;
                        for (cd = ic; cd >= 1; cd--)
                            if (x[fd, cd] < x[fp, cp])
                                intercambio(fd, cd, fp, cp);
                    }
        }
        public void ordenamientoFIL3()
        {
            int fp, cp, fd, cd, ic;
            for (fp = f; fp >= 1; fp--)
                for (cp = 1; cp <= c; cp++)
                    for (fd = fp; fd >= 1; fd--)
                    {
                        if (fp == fd)
                            ic = cp;
                        else
                            ic = 1;
                        for (cd = ic; cd <= c; cd++)
                            if (x[fd, cd] < x[fp, cp])
                                intercambio(fd, cd, fp, cp);
                    }
        }
        public void ordenamientoFIL4()
        {
            int fp, cp, fd, cd, ic;
            for (fp = f; fp >= 1; fp--)
                for (cp = c; cp >= 1; cp--)
                    for (fd = fp; fd >= 1; fd--)
                    {
                        if (fp == fd)
                            ic = cp;
                        else
                            ic = c;
                        for (cd = ic; cd >= 1; cd--)
                            if (x[fd, cd] < x[fp, cp])
                                intercambio(fd, cd, fp, cp);
                    }
        }
        public void ordenamientoXCOLS1()
        {
            int fp, cp, fd, cd;
            for (cp = 1; cp <= c; cp++)
                for (fp = 1; fp <= f; fp++)
                    for (cd = 1; cd <= c; cd++)
                        for (fd = 1; fd <= f; fd++)
                            if (x[fd, cd] > x[fp, cp])
                                intercambio(fp, cp, fd, cd);
        }
        public void ordenamientoXCOLS2()
        {
            int fp, cp, fd, cd;
            for (cp = 1; cp <= c; cp++)
                for (fp = f; fp >= 1; fp--)
                    for (cd = 1; cd <= c; cd++)
                        for (fd = f; fd >= 1; fd--)
                            if (x[fd, cd] > x[fp, cp])
                                intercambio(fp, cp, fd, cd);

        }
        public void ordenamientoXCOLS3()
        {
            int fp, cp, fd, cd;
            for (cp = c; cp >= 1; cp--)
                for (fp = 1; fp <= f; fp++)
                    for (cd = c; cd >= 1; cd--)
                        for (fd = 1; fd <= f; fd++)
                            if (x[fd, cd] > x[fp, cp])
                                intercambio(fp, cp, fd, cd);

        }
        public void ordenamientoXCOLS4()
        {
            int fp, cp, fd, cd;
            for (cp = c; cp >= 1; cp--)
                for (fp = f; fp >= 1; fp--)
                    for (cd = c; cd >= 1; cd--)
                        for (fd = f; fd >= 1; fd--)
                            if (x[fd, cd] > x[fp, cp])
                                intercambio(fp, cp, fd, cd);

        }
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
            int f1, c1, i = 0;
            f = nf; c = nc;
            for (f1 = f; f1 >= 1; f1--)
                for (c1 = c; c1 >= 1; c1--)
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
        public int num_menor()
        {
            int f1, c1;
            int menor = x[1, 1];
            for (f1 = 1; f1 <= f; f1++)
                for (c1 = 1; c1 <= c; c1++)
                {
                    if (x[f1, c1] < menor)
                        menor = x[f1, c1];
                }
            return menor;
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
            while (c1 <= c && (b == false))
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
            int c1 = 1, refe = x[1, 1];
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
        public string hallar_posicion(int dig)
        {
            int i = 1, j, pf, pc; bool b = false; string s = "";
            while ((i <= f) && (b == false))
            {
                ;
                j = 1;
                while ((j <= c) && (b == false))
                {
                    if (dig == x[i, j])
                    {
                        pf = i; pc = j; s = "[" + pf + "," + pc + "]";
                        b = true;
                    }
                    j++;
                }
                i++;
            }
            return s;
        }
        public string hallar_posicion2(int dig)
        {
            int i = 1, j, pf, pc; string s = "";
            while ((i <= f))
            {
                ;
                j = 1;
                while ((j <= c))
                {
                    if (dig == x[i, j])
                    {
                        pf = i; pc = j; s = s + "[" + pf + "," + pc + "]";
                    }
                    j++;
                }
                i++;
            }
            return s;
        }
        public int hallarposfila(int dig)
        {
            int i = 1, j, p = 0; bool b = false;
            while ((i <= f) && (b == false))
            {
                j = 1;
                while ((j <= c) && (b == false))
                {
                    if (dig == x[i, j])
                    {
                        b = true; p = i;
                    }
                    j++;
                }
                i++;
            }
            return p;
        }
        public int hallarposcolumna(int dig)
        {
            int i = 1, j, p = 0; bool b = false;
            while ((i <= f) && (b == false))
            {
                j = 1;
                while ((j <= c) && (b == false))
                {
                    if (dig == x[i, j])
                    {
                        b = true; p = j;
                    }
                    j++;
                }
                i++;
            }
            return p;
        }
        public void serie_enteros(int nf, int nc)
        {
            f = nf; c = nc; int s = 0;
            for (int i = 1; i <= f; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    s++; x[i, j] = s;
                }
            }
        }
        public void serie_enteros2(int nf, int nc)
        {
            f = nf; c = nc; int s = 0;
            for (int i = f; i >= 1; i--)
            {
                for (int j = c; j >= 1; j--)
                {
                    s++; x[i, j] = s;
                }
            }
        }

        public void serie_enteros3(int nf, int nc)
        {
            f = nf; c = nc; int s = 0;
            for (int i = f; i >= 1; i--)
            {
                for (int j = 1; j <= c; j++)
                {
                    s++; x[i, j] = s;
                }
            }
        }
        public void serie_enteros4(int nf, int nc)
        {
            f = nf; c = nc; int s = 0;
            for (int i = 1; i <= f; i++)
            {
                for (int j = c; j >= 1; j--)
                {
                    s++; x[i, j] = s;
                }
            }
        }
        public void serie_pares(int nf, int nc)
        {
            f = nf; c = nc; int s = 0;
            for (int i = 1; i <= f; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    s++; x[i, j] = s * 2;
                }
            }
        }
        public void serie_impares(int nf, int nc)
        {
            f = nf; c = nc; int s = 0;
            for (int i = 1; i <= f; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    s++; x[i, j] = (s * 2) - 1;
                }
            }
        }
        public void serie_fibonacci(int nf, int nc)
        {
            int a = -1, b = 1, s = 0;
            f = nf; c = nc;
            for (int i = 1; i <= f; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    s = a + b;
                    x[i, j] = s;
                    a = b;
                    b = s;
                }
            }
        }
// ELEMENTO MAYOR DE SOLO FILAS O COLUMNAS (AGREGANDO FILS O COLS A LO ULTIMO)
        public int mayfil(int nf)
        {
            int i, may;
            may = x[nf, 1];
            for (i = 2; i <= c; i++)
            {
                if (x[nf, i] > may)
                    may = x[nf, i];
            }
            return may;
        }
        public void mayfils()
        {
            int f1;
            for (f1 = 1; f1 <= f; f1++)
                x[f1, c + 1] = mayfil(f1);
            c++;
        }
        public int maycol(int nc)
        {
            int i, may;
            may = x[1,nc];
            for (i = 2; i <= f; i++)
            {
                if (x[i, nc] > may)
                    may = x[i, nc];
            }
            return may;
        }
        public void maycols()
        {
            int c1;
            for (c1 = 1; c1 <= c; c1++)
                x[f+1,c1] = maycol(c1);
            f++;
        }
//ORDENAMIENRO SOLO FILAS SOLO COLUMNAS ASCENDENTE DESCENDENTE
        public void ordcol(int nc)
        {
            int t, d;
            for (t = 1; t <= f - 1; t++)
                for (d = f; d >= t + 1; d--)
                    if (x[d, nc] < x[d - 1, nc])
                        intercambio(d, nc, d - 1, nc);
        }
        public void ordcols()
        {
            for (int c1 = 1; c1 <= c; c1++)
                ordcol(c1);
        }
        public void ordfil(int nf)
        {
            int t, d;
            for (t = 1; t <= c - 1; t++)
                for (d = c; d >= t + 1; d--)
                    if (x[nf, d] < x[nf, d - 1])
                        intercambio(d, nf, d - 1, nf);
        }
        public void ordfils()
        {
            for (int f1 = 1; f1 <= c; f1++)
                ordcol(f1);
        }
// INTECAMBIO Y ORDENAMIENTO DE FILAS Y COLUMNAS ---(POR SU ELEMENTO MAYOR)---
        public void interfils(int f1, int f2)
        {
            for (int c1 = 1; c1 <= c; c1++)
                intercambio(f1, c1, f2, c1);
        }
        public void interfilsmay()
        {
            int p, d;
            for (p = 1; p <= f - 1; p++)
                for (d = p + 1; d <= f; d++)
                    if (mayfil(d) < mayfil(p))
                        interfils(d, p);
        }
        public void ex_interfilsporCOL(int nc)
        {
            int p, d;
            for (p = 1; p <= f - 1; p++)
                for (d = p + 1; d <= f; d++)
                    if (x[p,nc] > x[d, nc])
                        interfils(d, p);
        }
        public void ex_interfilsporNELEMDISTINTOS()
        {
            int p, d;
            for (p = 1; p <= f - 1; p++)
                for (d = p + 1; d <= f; d++)
                    if (cantelemdifFIL(d) > cantelemdifFIL(p))
                        interfils(d, p);
        }
        public int cantelemdifFIL(int nf)
        {
            int i = 1, cont = 0,elem;
            ordfil(nf);
            while (i <= f)
            {
                elem = x[nf, i];
                while(x[nf, i]==elem)
                {
                   i++;
                }
                cont++;
            }
            return cont;
        }
        public void intercols(int c1, int c2)
        {
            for (int f1 = 1; f1 <= f; f1++)
                intercambio(f1, c1, f1, c2);
        }
        public void intercolsmay()
        {
            int p, d;
            for (p = 1; p <= c - 1; p++)
                for (d = p + 1; d <= c; d++)
                    if (maycol(d) < maycol(p))
                        intercols(d, p);
        }
        public void interfilsmayDES()
        {
            int p, d;
            for (p = 1; p <= f - 1; p++)
                for (d = p + 1; d <= f; d++)
                    if (mayfil(d) > mayfil(p))
                        interfils(d, p);
        }
        public void intercolsmayDES()
        {
            int p, d;
            for (p = 1; p <= c - 1; p++)
                for (d = p + 1; d <= c; d++)
                    if (maycol(d) > maycol(p))
                        intercols(d, p);
        }
// VERIFICACION DE RANGOS CON Y SIN RAZON (NUMERO DE SECUENCIA)
        public bool verifordasc()
        {
            bool b = true;
            int c1 = 1, ant = x[1, 1], f1;
            while ((c1 <= c) && b)
            {
                f1 = 1;
                while ((f1 <= f) && b)
                {
                    if (x[f1, c1] > ant)
                    {
                        ant = x[f1, c1];
                    }
                    else
                    {
                        b = false;
                    }
                    f1++;
                }
                c1++;
            }
            return b;
        }
        public bool verifordascrango(int r)
        {
            bool b = true;
            int c1 = 1, ant = x[1, 1] - r, f1;
            while ((c1 <= c) && b)
            {
                f1 = 1;
                while ((f1 <= f) && b)
                {
                    if (x[f1, c1] - r > ant)
                    {
                        ant = x[f1, c1];
                    }
                    else
                    {
                        b = false;
                    }
                    f1++;
                }
                c1++;
            }
            return b;
        }
// SEGMENTACION DE TODA LA MATRIZ PAR IMPAR FIBONACCI CAPICUA PRIMO
        public void segmentarparimpar()
        {
            int fp, cp, fd, cd, fi;
            NEnt n1 = new NEnt();
            NEnt n2 = new NEnt();
            for (cp = 1; cp <= c; cp++)
                for (fp = f; fp >= 1; fp--)
                    for (cd = cp; cd <= c; cd++)
                    {
                        if (cp == cd)
                            fi = fp;
                        else
                            fi = f;
                        for (fd = fi; fd >= 1; fd--)
                        {
                            n1.Cargar(x[fp, cp]);
                            n2.Cargar(x[fd, cd]);
                            if (n2.verifpar() && !n1.verifpar() ||
                                n2.verifpar() && n1.verifpar() && x[fd, cd] < x[fp, cp] ||
                                !n2.verifpar() && !n1.verifpar() && x[fd, cd] < x[fp, cp])
                                intercambio(fd, cd, fp, cp);
                        }
                    }
        }
//INTERCALACION (UNO SI UNO NO) PAR IMPAR FIBONACCI CAPICUA PRIMO
        public void intercalarparNpar()
        {
            int fp, cp, fd, cd, if1;
            bool b = true;
            NEnt n1 = new NEnt();
            NEnt n2 = new NEnt();
            for (cp = 1; cp <= c; cp++)
                for (fp = f; fp >= 1; fp--)
                {
                    if (b)
                        for (cd = cp; cd <= c; cd++)
                        {
                            if (cd == cp)
                                if1 = fp;
                            else
                                if1 = f;
                            for (fd = if1; fd >= 1; fd--)
                            {
                                n1.Cargar(x[fd, cd]);
                                n2.Cargar(x[fp, cp]);
                                if (n1.verifpar() && !n2.verifpar() ||
                                    n1.verifpar() && n2.verifpar() && x[fd, cd] < x[fp, cp] ||
                                    !n1.verifpar() && !n2.verifpar() && x[fd, cd] < x[fp, cp])
                                    intercambio(fd, cd, fp, cp);
                            }
                        }
                    else
                        for (cd = cp; cd <= c; cd++)
                        {
                            if (cd == cp)
                                if1 = fp;
                            else
                                if1 = f;
                            for (fd = if1; fd >= 1; fd--)
                            {
                                n1.Cargar(x[fd, cd]);
                                n2.Cargar(x[fp, cp]);
                                if (!n1.verifpar() && n2.verifpar() ||
                                    !n1.verifpar() && !n2.verifpar() && x[fd, cd] < x[fp, cp] ||
                                    n1.verifpar() && n2.verifpar() && x[fd, cd] < x[fp, cp])
                                    intercambio(fd, cd, fp, cp);
                            }
                        }
                    b = !b;
                }
        }
        public void intercalarprimoNopri()
        {
            int fp, cp, fd, cd, if1;
            bool b = true;
            NEnt n1 = new NEnt();
            NEnt n2 = new NEnt();
            for (cp = 1; cp <= c; cp++)
                for (fp = f; fp >= 1; fp--)
                {
                    if (b)
                        for (cd = cp; cd <= c; cd++)
                        {
                            if (cd == cp)
                                if1 = fp;
                            else
                                if1 = f;
                            for (fd = if1; fd >= 1; fd--)
                            {
                                n1.Cargar(x[fd, cd]);
                                n2.Cargar(x[fp, cp]);
                                if (n1.VerifPri() && !n2.VerifPri() ||
                                    n1.VerifPri() && n2.VerifPri() && x[fd, cd] < x[fp, cp] ||
                                    !n1.VerifPri() && !n2.VerifPri() && x[fd, cd] < x[fp, cp])
                                    intercambio(fd, cd, fp, cp);
                            }
                        }
                    else
                        for (cd = cp; cd <= c; cd++)
                        {
                            if (cd == cp)
                                if1 = fp;
                            else
                                if1 = f;
                            for (fd = if1; fd >= 1; fd--)
                            {
                                n1.Cargar(x[fd, cd]);
                                n2.Cargar(x[fp, cp]);
                                if (!n1.VerifPri() && n2.VerifPri() ||
                                    !n1.VerifPri() && !n2.VerifPri() && x[fd, cd] < x[fp, cp] ||
                                    n1.VerifPri() && n2.VerifPri() && x[fd, cd] < x[fp, cp])
                                    intercambio(fd, cd, fp, cp);
                            }
                        }
                    b = !b;
                }
        }
        public void intercalarcapicuaNOcap()
        {
            int fp, cp, fd, cd, if1;
            bool b = true;
            NEnt n1 = new NEnt();
            NEnt n2 = new NEnt();
            for (cp = 1; cp <= c; cp++)
                for (fp = f; fp >= 1; fp--)
                {
                    if (b)
                        for (cd = cp; cd <= c; cd++)
                        {
                            if (cd == cp)
                                if1 = fp;
                            else
                                if1 = f;
                            for (fd = if1; fd >= 1; fd--)
                            {
                                if (n1.verifCapicua(x[fd,cd]) && !n2.verifCapicua(x[fp, cp]) ||
                                    n1.verifCapicua(x[fd, cd]) && n2.verifCapicua(x[fp, cp]) && x[fd, cd] < x[fp, cp] ||
                                    !n1.verifCapicua(x[fd, cd]) && !n2.verifCapicua(x[fp, cp]) && x[fd, cd] < x[fp, cp])
                                    intercambio(fd, cd, fp, cp);
                            }
                        }
                    else
                        for (cd = cp; cd <= c; cd++)
                        {
                            if (cd == cp)
                                if1 = fp;
                            else
                                if1 = f;
                            for (fd = if1; fd >= 1; fd--)
                            {
                                if (!n1.verifCapicua(x[fd, cd]) && n2.verifCapicua(x[fp, cp]) ||
                                    !n1.verifCapicua(x[fd, cd]) && !n2.verifCapicua(x[fp, cp]) && x[fd, cd] < x[fp, cp] ||
                                    n1.verifCapicua(x[fd, cd]) && n2.verifCapicua(x[fp, cp]) && x[fd, cd] < x[fp, cp])
                                    intercambio(fd, cd, fp, cp);
                            }
                        }
                    b = !b;
                }
        }
        public void intercalarfiboNofibo()
        {
            int fp, cp, fd, cd, if1;
            bool b = true;
            NEnt n1 = new NEnt();
            NEnt n2 = new NEnt();
            for (cp = 1; cp <= c; cp++)
                for (fp = f; fp >= 1; fp--)
                {
                    if (b)
                        for (cd = cp; cd <= c; cd++)
                        {
                            if (cd == cp)
                                if1 = fp;
                            else
                                if1 = f;
                            for (fd = if1; fd >= 1; fd--)
                            {
                                n1.Cargar(x[fd, cd]);
                                n2.Cargar(x[fp, cp]);
                                if (n1.VerifFibo() && !n2.VerifFibo() ||
                                    n1.VerifFibo() && n2.VerifFibo() && x[fd, cd] < x[fp, cp] ||
                                    !n1.VerifFibo() && !n2.VerifFibo() && x[fd, cd] < x[fp, cp])
                                    intercambio(fd, cd, fp, cp);
                            }
                        }
                    else
                        for (cd = cp; cd <= c; cd++)
                        {
                            if (cd == cp)
                                if1 = fp;
                            else
                                if1 = f;
                            for (fd = if1; fd >= 1; fd--)
                            {
                                n1.Cargar(x[fd, cd]);
                                n2.Cargar(x[fp, cp]);
                                if (!n1.VerifFibo() && n2.VerifFibo() ||
                                    !n1.VerifFibo() && !n2.VerifFibo() && x[fd, cd] < x[fp, cp] ||
                                    n1.VerifFibo() && n2.VerifFibo() && x[fd, cd] < x[fp, cp])
                                    intercambio(fd, cd, fp, cp);
                            }
                        }
                    b = !b;
                }
        }
//ORDENAMIENTO DE TRIANGULARES SUPERIOR (IZQUIERDO DERECHO) INFERIOR (IZQUIERDO DERECHO)
        public void ordenarTSD1()
        {
            int pf, pc, df, dc, ic;
            for (pf = 1; pf <= f; pf++)
                for (pc = pf + 1; pc <= c; pc++)
                    for (df = pf; df <= f; df++)
                    {
                        if (pf == df)
                            ic = pc;
                        else
                            ic = df + 1;
                        for (dc = ic; dc <= c; dc++)
                        {
                            if (x[df, dc] < x[pf, pc])
                                intercambio(pf, pc, df, dc);
                        }
                    }
        }
        public void ordenarTSD2()
        {
            int pf, pc, df, dc, ic;
            for (pf = 1; pf <= f; pf++)
                for (pc = pf + 1; pc <= c; pc++)
                    for (df = pf; df <= f; df++)
                    {
                        if (pf == df)
                            ic = pc;
                        else
                            ic = df + 1;
                        for (dc = ic; dc <= c; dc++)
                        {
                            if (x[df, dc] > x[pf, pc])
                                intercambio(pf, pc, df, dc);
                        }
                    }
        }
        public void ordenarTSI1()
        {
            int pf, pc, df, dc, ic;
            for (pf = f-1; pf >= 1; pf--)
                for (pc = 1; pc <= c-pf; pc++)
                    for (df = pf; df >= 1; df--)
                    {
                        if (pf == df)
                            ic = pc;
                        else
                            ic = 1;
                        for (dc = ic; dc <= c-df; dc++)
                        {
                            if (x[df, dc] < x[pf, pc])
                                intercambio(pf, pc, df, dc);
                        }
                    }
        }
        public void ordenarTII1()
        {
            int pf, pc, df, dc, ic;
            for (pf = 2; pf <= f; pf++)
                for (pc = 1; pc <= pf - 1; pc++)
                    for (df = pf; df <= f; df++) 
                    {
                        if (pf == df)
                            ic = pc;
                        else
                            ic = 1;
                        for (dc = ic; dc <= df-1; dc++)
                        {
                            if (x[df, dc] < x[pf, pc])
                                intercambio(pf, pc, df, dc);
                        }
                    }
        }
        public void ordenarTID1()
        {
            int pf, pc, df, dc, ic;
            for (pf = 2; pf <= f; pf++)
                for (pc = c; pc >= c - pf + 2; pc--)
                    for (df = pf; df <= f; df++)
                    {
                        if (pf == df)
                            ic = pc;
                        else
                            ic = pc;
                        for (dc = ic; dc >= c - df + 2; dc--)
                        {
                            if (x[df, dc] < x[pf, pc])
                                intercambio(pf, pc, df, dc);
                        }
                    }
        }
        public void ordenarTID2()
        {
            int pf, pc, df, dc, ic;
            for (pf = 2; pf <= f; pf++)
                for (pc =c-pf+2; pc <= c; pc++)
                    for (df = pf; df <= f; df++)
                    {
                        if (pf == df)
                            ic = pc;
                        else
                            ic = c-df+2;
                        for (dc = ic; dc <= c; dc++)
                        {
                            if (x[df, dc] < x[pf, pc])
                                intercambio(pf, pc, df, dc);
                        }
                    }
        }
//SEGMENTACION TRIANGULARES (IZQUIERDA DERECHA; ARRIBA ABAJO)  PAR IMPAR FIBONACCI PRIMO CAPICUA
        public void segmparimparTSD1()
        {
            int pf, pc, df, dc, ic;
            NEnt n1 = new NEnt();
            NEnt n2 = new NEnt();
            for (pf = 1; pf <= f; pf++)
                for (pc = pf + 1; pc <= c; pc++)
                    for (df = pf; df <= f; df++)
                    {
                        if (pf == df)
                            ic = pc;
                        else
                            ic = df + 1;
                        for (dc = ic; dc <= c; dc++)
                        {
                            n1.Cargar(x[pf, pc]);
                            n2.Cargar(x[df, dc]);
                            if (n2.verifpar() && !n1.verifpar() ||
                                n2.verifpar() && n1.verifpar() && x[df, dc] < x[pf, pc] ||
                                !n2.verifpar() && !n1.verifpar() && x[df, dc] < x[pf, pc])
                                intercambio(df, dc, pf, pc);
                        }
                    }
        }
        //ORDEN DE DIAGONALES (PRINCIPAL Y SECUNDARIA)
        public void ordDP1()
        {
            int f1, d;
            for (f1 = 1; f1 < f; f1++)
                for (d = f1 + 1; d <= f; d++)
                    if (x[d, d] < x[f1, f1])    
                        intercambio(d, d, f1, f1);
        }
        public void ordDP2()
        {
            int f1, d;
            for (f1 = 1; f1 < f; f1++)
                for (d = f1 + 1; d <= f; d++)
                    if (x[d, d] > x[f1, f1])
                        intercambio(d, d, f1, f1);
        }
        public void ordDS1()
        {
            int fp, fd;
            for (fp = 1; fp < f; fp++)
                for (fd = fp + 1; fd <= f; fd++)
                    if (x[fd, f - fd + 1] > x[fp, f - fp + 1])
                        intercambio(fd, f - fd + 1, fp, f - fp + 1);
        }
        public void ordDS2()
        {
            int fp, fd;
            for (fp = 1; fp < f; fp++)
                for (fd = fp + 1; fd <= f; fd++)
                    if (x[fd, f - fd + 1] < x[fp, f - fp + 1])
                        intercambio(fd, f - fd + 1, fp, f - fp + 1);
        }
        
        public int sumaDIGprincipal()
        {
            int s=0, i, j;
            for (i = 1; i <= f; i++)
                for (j = 1; j <= c; j++)
                    if (i == j)
                        s = s + x[i, j];
            return s;
        }
        public int sumaDIGsecun()
        {
            int s = 0, i, j;
            for (i = 1; i <= f; i++)
                for (j = 1; j <= c; j++)
                    if (i + j == f + 1)
                        s = s + x[i, j];
            return s;
        }
        public void transpuestatriglar()
        {
            for (int fp = 2; fp <= f; fp++)
                for (int cp = 1; cp <= fp - 1; cp++)
                    intercambio(fp, cp, cp, fp);
        }
        public void cargarv(ref vector v1)
        {
            int fp, cp;
            for (fp = 2; fp <= f; fp++)
                for (cp = 1; cp <= fp - 1; cp++)
                    v1.cargar_1_x_1(x[fp, cp]);
        }
        public void descargav(vector v1)
        {
            int fp, cp, i = 0;
            for(fp=2;fp<=f;fp++)
                for(cp=1;cp<=fp-1;cp++)
                {
                    i++;
                    x[fp, cp] = v1.retornar_Elemto(i);
                }
        }
        public void triordvector(ref vector v1)
        {
            cargarv(ref v1);
            v1.ordinamiento_intercambio();
            descargav(v1);
        }
        //PRACTICA PARA EL EXAMEN-------------||||||||||||||||||||||||------------------
        public void ordencolsconRg(int af,int bf,int ac,int bc)
        {
            int fp, cp, fd, cd;
            for (cp = ac; cp <= bc; cp++)
                for (fp = af; fp <= bf; fp++)
                    for (cd = ac; cd <= bc; cd++)
                        for (fd = af; fd <= bf; fd++)
                            if (x[fd, cd] > x[fp, cp])
                                intercambio(fp, cp, fd, cd);
        }
 
       public void exam_ordTIDsegmparimpar()
        {
            int pf, pc, df, dc, ic;
            NEnt n1 = new NEnt();
            NEnt n2 = new NEnt();
            for (pf = f; pf >= 2; pf--)
                for (pc = f-pf+2; pc <= c; pc++)
                    for (df = pf; df >= 2; df--)
                    {
                        if (pf == df)
                            ic = pc;
                        else
                            ic = f - df + 2;
                        for (dc = ic; dc <= c; dc++)
                        {
                            n1.Cargar(x[pf, pc]);
                            n2.Cargar(x[df, dc]);
                            if (n2.verifpar() && !n1.verifpar() ||
                                n2.verifpar() && n1.verifpar() && x[df, dc] < x[pf, pc] ||
                                !n2.verifpar() && !n1.verifpar() && x[df, dc] < x[pf, pc])
                                intercambio(df, dc, pf, pc);
                        }
                    }
        
    }
        public int cantprimosfil(int nf)
        {
            NEnt n = new NEnt();
            int i, s = 0;
            for (i = 1; i <= c; i++)
            {
                n.Cargar(x[nf, i]);
                if (n.VerifPri())
                    s++;
            }
            return s;
        }
        public int frecdefila(int nf)
        {
            NEnt n = new NEnt();
            int i, s = 0;
            for (i = 1; i <= c; i++)
            {
                n.Cargar(x[nf, i]);
                if (n.VerifPri())
                    s++;
            }
            return s;
        }
        public int cantprimoscol(int nc)
        {
            NEnt n = new NEnt();
            int i, s = 0;
            for (i = 1; i <= f; i++)
            {
                n.Cargar(x[i,nc]);
                if (n.VerifPri())
                    s++;
            }
            return s;
        }

        public void exa_interfilsmayprim()
        {
            int p, d;
            for (p = 1; p <= f - 1; p++)
                for (d = p + 1; d <= f; d++)
                    if (cantprimosfil(p) > cantprimosfil(d))
                        interfils(d, p);
        }
        public void exa_intercolsmayprim()
        {
            int p, d;
            for (p = 1; p <= c - 1; p++)
                for (d = p + 1; d <= c; d++)
                    if (cantprimoscol(p) > cantprimoscol(d))
                        intercols(d, p);
        }
        public void ordenconRGinterparimpar(int af, int bf, int ac, int bc)
        {
            int fp, cp, fd, cd;
            for (cp = ac; cp <= bc; cp++)
                for (fp = af; fp <= bf; fp++)
                    for (cd = ac; cd <= bc; cd++)
                        for (fd = af; fd <= bf; fd++)
                            if (x[fd, cd] > x[fp, cp])
                                intercambio(fp, cp, fd, cd);
        }
        public void ex_intercalarparNparconRG(int af, int bf, int ac, int bc)
        {
            int fp, cp, fd, cd, if1;
            bool b = true;
            NEnt n1 = new NEnt();
            NEnt n2 = new NEnt();
            for (cp = ac; cp <= bc; cp++)
                for (fp = bf; fp >= af; fp--)
                {
                    if (b)
                        for (cd = cp; cd <= bc; cd++)
                        {
                            if (cd == cp)
                                if1 = fp;
                            else
                                if1 = bf;
                            for (fd = if1; fd >= 1; fd--)
                            {
                                n1.Cargar(x[fd, cd]);
                                n2.Cargar(x[fp, cp]);
                                if (n1.verifpar() && !n2.verifpar() ||
                                    n1.verifpar() && n2.verifpar() && x[fd, cd] < x[fp, cp] ||
                                    !n1.verifpar() && !n2.verifpar() && x[fd, cd] < x[fp, cp])
                                    intercambio(fd, cd, fp, cp);
                            }
                        }
                    else
                        for (cd = cp; cd <= bc; cd++)
                        {
                            if (cd == cp)
                                if1 = fp;
                            else
                                if1 = bf;
                            for (fd = if1; fd >= 1; fd--)
                            {
                                n1.Cargar(x[fd, cd]);
                                n2.Cargar(x[fp, cp]);
                                if (!n1.verifpar() && n2.verifpar() ||
                                    !n1.verifpar() && !n2.verifpar() && x[fd, cd] < x[fp, cp] ||
                                    n1.verifpar() && n2.verifpar() && x[fd, cd] < x[fp, cp])
                                    intercambio(fd, cd, fp, cp);
                            }
                        }
                    b = !b;
                }
        }
        public int frecelemporfila(int nf,int dato)
        {
            int cont = 0;
            for (int i = 1; i <= c; i++) 
            {
                if (x[nf, i] == dato)
                    cont++;
            }
            return cont;
        }
        public int obtenerelemmayfrec(int nf)
        {
            int dato1, dato2, cant1, cant2;
            dato1 = x[nf, 1];
            cant1 = frecelemporfila(nf, dato1);
            for (int i = 2; i <= c; i++) 
            {
                dato2 = x[nf, i];
                cant2 = frecelemporfila(nf, dato2);
                if (cant2 > cant1)
                {
                    dato1 = dato2;
                    cant1 = cant2;
                }
            }
            return dato1;
        }
        public void ex_numconmayorfrec()
        {
            int dato, cant;
            for (int i = 1; i <= f; i++)
            {
                dato = obtenerelemmayfrec(i);
                cant = frecelemporfila(i, dato);
                x[i, c + 1] = dato;
                x[i, c + 2] = cant;
            }
            c = c + 2;
        }
        public void ordenacolsmenAmay(int pc,int a, int b)
        {
            int d1, d2;
            for (int i = a; i < b; i++)
            {
                d1 = x[i, pc];
                for (int j = i + 1; j <= b; j++)
                {
                    d2 = x[j, pc];
                    if (d2 < d1)
                    {
                        intercambio(i, pc, j, pc);
                    }
                }
            }
        }
        public void ex_ordcolsTID()
        {
            int a = 2;
            for (int i = c; i >= 2; i--)
            {
                ordenacolsmenAmay(i, a, f);
                a++;
            }
        }
    }
}
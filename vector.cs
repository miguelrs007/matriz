using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avance_de_matriz
{
    class vector
    {
        const int MAX = 100;
        private int[] v;
        private int dim;
        public vector()
        {
            dim = 0;
            v = new int[MAX];
        }
        public void cargar(int d, int a, int b)
        {
            dim = d;
            Random r;
            r = new Random();
            for (int i = 1; i <= dim; i++)
            {
                v[i] = r.Next(a, b);
            }
        }
        public string descargar_vector()
        {
            string s;
            s = "";
            for (int i = 1; i <= dim; i++)
            {
                s = s + v[i] + " ! ";
            }
            return s;
        }
        public void cargar_1_x_1(int dato)
        {
            dim++;
            v[dim] = dato;
        }
        public void cargar_fibonaci(int d)
        {
            int a, b, c;
            dim = d; a = -1; b = 1;
            for (int i = dim; i >= 1; i--)
            {
                c = a + b;
                v[i] = c;
                a = b;
                b = c;
            }
        }
        public int sumar_vectores()
        {
            int suma;
            suma = 0;
            for (int i = 1; i <= dim; i++)
            {
                suma = suma + v[i];
            }
            return suma;
        }
        public double media_o_promedio()
        {
            return sumar_vectores() / (double)dim;
        }
        public double desviacion_media()
        {
            double a, m, dm;
            m = media_o_promedio();
            a = 0;
            for (int i = 1; i <= dim; i++)
            {
                a = a + Math.Abs(v[i] - m);//sumatoria de los vectores - la media
            }
            dm = a / dim;
            return dm;
        }
        public double desviacion_estandar()
        {
            double m, de, sum;
            m = media_o_promedio();
            sum = 0;
            for (int i = 1; i <= dim; i++)
            {
                sum = sum + Math.Pow(v[i] - m, 2);
            }
            de = Math.Sqrt(sum / (dim - 1));
            return de;
        }
        public void saleccion_de_posiciones(int m, ref vector s)
        //muestra posiciones saltado de (m en m)
        {
            int numesp;
            numesp = dim / m;
            for (int i = 1; i <= numesp; i++)
            {
                s.cargar_1_x_1(v[i * m]);
            }
        }
        public void seleccionar_exelentes(ref vector s)
        {
            double is1;
            s.dim = 0;
            is1 = media_o_promedio() + desviacion_estandar();
            for (int i = 1; i <= dim; i++)
            {
                if (v[i] > is1)
                    s.cargar_1_x_1(v[i]);
            }
        }
        public int maximo()
        {
            int mayor, d;
            mayor = 0;

            for (int i = 1; i <= dim; i++)
            {
                d = v[i];
                if (d > mayor)
                {
                    mayor = d;
                }
            }
            return mayor;
        }
        public int Frec(int ele)
        {
            int t = 0;

            for (int i = 1; i <= dim; i++)
                if (v[i] == ele)
                    t++;
            return t;
        }
        public void maxfrec(ref int max, ref int frec)
        {
            //ref se usa para que el parametro o el valor de donde esta llamada pueda cambiar en el metodo
            //si no estubiera el ref el valor de la llamada solo se podria copiar en otra variable pero no cambiar 
            max = maximo();
            frec = Frec(max);
        }
        public int retornar_dim()
        {
            return dim;
        }
        public int retornar_Elemto(int i)
        {
            return v[i];
        }
        public int busqueda_secuencial(int ele)
        //este metodo ve si el digito esta en el vector
        //se va usar para el metodo interseccion
        {
            int i, pos;
            pos = 0;i = 1;
            while ((i <= dim) && (pos == 0))
            {
                if (v[i] == ele)
                    pos = 1;//si es 1 es igual y pasa al sgte elemento
                i++;
            }
            return pos;
        }
        public bool verifica_pri()
        {
            int i;
            bool b;
            NEnt n1 = new NEnt();
            i = dim; b = false;
            while ((i >= 1) && (b == false))
            {
                n1.Cargar(v[i]);
                if (n1.VerifPri() == true)
                    b = true;
                i--;
            }
            return b;
        }
        public void interseccion(vector v2, ref vector v3)
        {
            v3 = new vector();
            for (int i = 1; i <= dim; i++)
            {
                if (v2.busqueda_secuencial(v[i]) > 0)
                    v3.cargar_1_x_1(v[i]);
            }
        }
        public bool verificar_aprobado(int iap)
        {
            int i;
            bool b;
            i = 1; b = true;
            while ((i <= dim) && (b == true))
            {
                if (!(v[i] > iap))
                    b = false;
                i++;
            }
            return b;
        }
        public bool verificar_primos()
        {
            int i;
            bool b;
            NEnt n1 = new NEnt();
            i = 1; b = true;
            while ((i <= dim) && (b == true))// posi
            {
                n1.Cargar(v[i]);
                if (!(n1.VerifPri()))
                    b = false;
                i++;
            }
            return b;
        }
        public bool verificar_orden()
        {
            int i;
            bool b;
            i = 1; b = true;
            while ((i <= dim) && (b == true))// posi
            {
                if (!(v[i] <= v[i + 1]))
                    b = false;
                i++;
            }
            return b;
        }
        public bool verificar_orden1(ref int p1, ref int p2)
        {
            p1 = 0; p2 = 0;
            int i = 1;
            bool b = true;
            while ((i <= dim - 1) && (b = true))
            {
                if (!(v[i] <= v[i + 1]))
                {
                    b = false; p1 = i; p2 = i + 1;
                }
                else
                {
                    i++;
                }
            }
            return b;
        }
        public void intercambiar(int p1, int p2)
        {
            int a;
            a = v[p1];
            v[p1] = v[p2];
            v[p2] = a;
        }

        public void ordinamiento_intercambio()
        {
            int p, d;
            for (p = 1; p <= dim - 1; p++)
                for (d = p + 1; d <= dim; d++)
                    if (v[d] < v[p])
                        intercambiar(d, p);

        }
        public void ordenamiento_intercambio_des()
        {
            int p, d;
            for (p = 1; p <= dim - 1; p++)
                for (d = p + 1; d <= dim; d++)
                    if (v[d] > v[p])
                        intercambiar(d, p);
        }
        public void ordenamiento_intercambi_dfrente()
        {
            int p, d;
            for (p = dim; p >= 2; p--)
                for (d = 1; d <= p - 1; d++)
                    if (v[d] < v[p])
                        intercambiar(d, p);
        }
        public void ordenamiento_selectivo()
        {
            int p, s, d;
            for (p = 1; p <= dim - 1; p++)//54621 
            {
                s = p;
                for (d = p + 1; d <= dim; d++)
                    if (v[d] < v[s])//4>5=si,6>5=si,
                        s = d;//s=2,3,4
                if (p != s)
                    intercambiar(s, p);//45621,4
            }
        }
        public void ordenamiento_burbuja()
        {
            for (int t = dim; t >= 2; t--)
                for (int d = 1; d <= t - 1; d++)
                {
                    if (v[d] > v[d + 1])
                        intercambiar(d, d + 1);
                }
        }
        public void ordBurburbuja2()
        {
            int t, d;
            for (t = 1; t <= dim - 1; t++)
                for (d = dim; d >= t + 1; d--)
                {
                    if (v[d] < v[d + 1])
                        intercambiar(d, d - 1);
                }
        }
        public void ordBurburbujamiguel()
        {
            int t, d;
            for (t = 1; t <= dim - 1; t++)
                for (d = t + 1; d <= dim; d++)
                {
                    if (v[d] < v[t])
                        intercambiar(d, t);
                }
        }
        public void push(int ele)
        {
            dim++;
            v[dim] = ele;
        }
        public int pop()
        {
            int ele;
            ele = v[dim];
            dim--;
            return ele;
        }
        public bool under()
        {
            return (dim == 0);
        }
        public void orden_quick()
        {
            vector p1, p2;
            int i, d, id, dd, pivot;
            p1 = new vector(); p2 = new vector();
            p1.push(1); p2.push(dim);
            while (!(p1.under()))
            {
                i = p1.pop(); d = p2.pop();
                while (i < d)
                {
                    pivot = v[(i + d) / 2];
                    id = i; dd = d;
                    while (id <= dd)
                    {
                        while ((id <= dd) && (v[id] < pivot))
                            id++;
                        while ((id <= dd) && (v[dd] > pivot))
                            dd--;
                        if (id <= dd)
                        {
                            intercambiar(id, dd); id++; dd--;
                        }
                    }
                    p1.push(id); p2.push(d);
                    d = dd;
                }      
            }
        }
        public void segpar_impar()
        {
            int d, p;
            NEnt n1, n2;
            n1 = new NEnt(); n2 = new NEnt();
            for (p=1; p<=dim-1;p++)
                for(d=p+1; d<=dim; d++)
                {
                    n1.Cargar(v[d]); n2.Cargar(v[p]);
                    if (((n1.verifpar() == true) && (!(n2.verifpar()==true)))||
                        ((n1.verifpar() == true) && (n2.verifpar() == true) && (v[d] < v[p])) ||
                        (!(n1.verifpar() == true) && !(n2.verifpar() == true) && (v[d] < v[p])))
                        intercambiar(d, p);
                }
        }
        public void segprimo_noprimo()
        {
            int d, p;
            NEnt n1, n2;
            n1 = new NEnt(); n2 = new NEnt();
            for (p = 1; p <= dim - 1; p++)
                for (d = p + 1; d <= dim; d++)
                {
                    n1.Cargar(v[d]); n2.Cargar(v[p]);
                    if (((n1.VerifPri() == true) && (!(n2.VerifPri() == true))) ||
                       ((n1.VerifPri() == true) && (n2.VerifPri() == true) && (v[d] < v[p])) ||
                       (!(n1.VerifPri() == true) && !(n2.VerifPri() == true) && (v[d] < v[p])))
                        intercambiar(d, p);
                }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public int movimientos = 0;
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (a.Top < b.Top || b.isEmpty())
            {
                Disco d = a.pop();
                b.push(d);
                m++;
            }

            else 
            {
                Disco d = b.pop();
                a.push(d);
                m++;
            }
        }

        public int iterativo (int n, Pila ini, Pila fin, Pila aux)
        {
            
            if (n % 2==0)
            {
                while (fin.Size != n)
                {
                    mover_disco(ini, fin);
                    mover_disco(ini, aux);
                    mover_disco(aux, fin);
                }
            }
            else
            {
                mover_disco(ini, aux);
                mover_disco(ini, fin);
                mover_disco(aux, fin);
            }
            return movimientos;
        }

    }
}

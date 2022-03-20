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
            if (a.isEmpty())
            {
            
                a.push(b.pop());
                movimientos++;
            }
            else if(b.isEmpty()){
                b.push(a.pop());
                movimientos++;
            }
            else if(a.Top<b.Top)
            {
                b.push(a.pop());
                movimientos++;
            }
            else
            {
                a.push(b.pop());
                movimientos++;
            }
        }

        public int iterativo (int n, Pila ini, Pila fin, Pila aux)
        {
            
            if (n % 2!=0)
            {
                while (fin.Size != n)
                {
                    mover_disco(ini, fin);
                    Console.Write("Numero de movimientos: " + movimientos+"\n");
                    mover_disco(ini, aux);
                    Console.Write("Numero de movimientos: " + movimientos + "\n");
                    mover_disco(aux, fin);
                    Console.Write("Numero de movimientos: " + movimientos + "\n");
                }
            }
            else
            {
                mover_disco(ini, aux);
                Console.Write("Numero de movimientos: " + movimientos + "\n");
                mover_disco(ini, fin);
                Console.Write("Numero de movimientos: " + movimientos + "\n");
                mover_disco(aux, fin);
                Console.Write("Numero de movimientos: " + movimientos + "\n");
            }
            return movimientos;
        }

    }
}

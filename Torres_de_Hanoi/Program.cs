using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;

            Console.WriteLine("Cuantos discos le quieres meter?");
            n = Convert.ToInt32(Console.ReadLine());
            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();
            Hanoi a = new Hanoi();

            for(int i=n; i>0; i--)
            {
                Disco disco = new Disco(i);
                ini.push(disco);
            }

            int m = a.iterativo(n, ini, fin, aux);
            

            



        }
    }
}

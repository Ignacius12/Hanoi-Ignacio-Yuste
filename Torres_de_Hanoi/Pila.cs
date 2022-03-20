using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }

        //TODO: Elegir tipo de Top
        public int Top { get; set; }
                
        
        // TODO: Elegir tipo de Elementos
       
        public List<Disco> Elementos { get; set; }
        

        /* TODO: Implementar métodos */
        public Pila()
        {
            Size = 0;
            Top = 0;
            Elementos = new List<Disco>();
        }
        
 

        public void push(Disco d)
        {
            Elementos.Add(d);
            Size=Elementos.Count();
            Top = d.Valor;
        }

        public Disco pop()
        {
             Disco quitado= Elementos.Last();
             Elementos.RemoveAt(Elementos.Count-1);
             Size=Elementos.Count;
             
            if (Elementos.Count == 0)
            {
                Top = 0;
            }
            else
            {
                Top = Elementos.Last().Valor;
            }
            return quitado;
            
           
        }                

        public bool isEmpty()
        {
            if (Size == 0)
            {
                return true;
            }
            return false;
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class Stacks<T> : DoublyLinkedLIists<T>
    {
        public void Push(T val)
        {
            AddLast(val);
            
            return;
        }
        public void Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            RemoveLast();
            return;
        }
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            Console.WriteLine(Head.Value);
            
            return Head.Value;
            
        }
        
        
         
        

    }
}

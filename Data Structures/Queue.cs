using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class Queue<T>
    {
        int Count;
        T[] QueueArray;
        int Head;
        int Tail;
        
        public Queue(int capacity = 10)
        {
            QueueArray = new T[capacity];
              
            Head = 0;
            Tail = Head;
            Count = 0;

        }

        public Queue()
            : this(10)
        {
        }

        public void Enqueue(T value)
        {
            // check capacity
            // resize as needed

            if (Count == QueueArray.Length)
            {
                SizeUp();
            }

            QueueArray[Tail] = value;
            Tail++;
            Count++;
        }
        
        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            T temp = QueueArray[Head];
            Head++;
            Count--;
            return temp;
        }
        
        public T Peek()
        {
            return QueueArray[Head];
        }

        public void SizeUp()
        {
            T[] newArray = new T[QueueArray.Length + 1];
            for(int i = QueueArray.Length-1; i < newArray.Length; i++)
            {
                newArray[i + 1] = QueueArray[i];
            }
            QueueArray = newArray; 
        }
        public void SizeDown()
        {
            T[] temp = new T[QueueArray.Length - 1];
            for(int i = 1; i < temp.Length; i++)
            {
                temp[i - 1] = QueueArray[i];
            }
            QueueArray = temp;
        }

        public void Printlist()
        {
            Console.WriteLine("-------------------------------->");
            for (int i = Head; i < Tail; i++)
            {
                Console.WriteLine(QueueArray[i]);
            }
            Console.WriteLine("<-------");
        }
    }
}

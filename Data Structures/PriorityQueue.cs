using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{

    class PNode<T> 
    {
        T Value;
        public int Priority { get; private set; }

        public PNode(T val, int prior)
        {
            Value = val;
            Priority = prior;
        }

        public override string ToString()
        {
            return $"Value: {Value}, Priority: {Priority}";
        }
    }
    class PriorityQueue <T>
    {
        PNode<T>[] PriorityList;
        int Count;
        int Capacity;
        public PriorityQueue(int capacity = 10)
        {
            Capacity = capacity;
            PriorityList = new PNode<T>[capacity];
 
            Count = 0;
        }

        public void Enqueue(T val, int prior)
        {
            //increase size
            if (Count >= Capacity)
            {
                Capacity *= 2;
                PNode<T>[] temp = new PNode<T>[Capacity];

                for (int i = 0; i < PriorityList.Length; i++)
                {
                    temp[i] = PriorityList[i];
                }

                PriorityList = temp;
            }


            for (int i = 0; i < PriorityList.Length; i++)
            {
                if (PriorityList[i] == null)
                {
                    PriorityList[i] = new PNode<T>(val, prior);
                    break;

                }
            }


            Count++;
            Sort();


        }

        private void Sort()
        {
            for (int i = 0; i < PriorityList.Length; i++)
            {
                for (int j = 0; j < PriorityList.Length; j++)
                {
                    if (i != j && (PriorityList[i] != null && PriorityList[j] != null))
                    {
                        if (PriorityList[i].Priority < PriorityList[j].Priority)
                        {
                            Swap(ref PriorityList[i], ref PriorityList[j]);
                        }
                    }

                }

            }
        }

        public PNode<T> Dequeue()
        {   
            if (Count == 0)
            {
                throw new InvalidOperationException("queue empty");
            }
            
            PNode<T> val = null;
            for (int i = 0; i < PriorityList.Length; i++)
            {
                if (PriorityList[i] != null)
                {
                    val = PriorityList[i];
                    PriorityList[i] = null;
                    
                    break;                                    
                }
            }
            Count--;
            return val;
        }
        /*
        public int Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            return 
        }
        */
       

        /*
        public void not necessary()
        {         
        }
           public static void InsertionSort(int[] list)
                {
                    for (int i = 1; i < list.Length; i++)
                    {
                        int j = i;

                        while (j > 0 && list[j] < list[j - 1])
                        {
                            Swap(ref list[j], ref list[j - 1]);
                            j--;
                        }
                    }
                } 
        */
       
        private static void Swap(ref PNode<T> a, ref PNode<T> b)
        {
            PNode<T> temp = a;
            a = b;
            b = temp;
        }

        public void Printlist()
        {
            Console.WriteLine("-------------------------------->");
            for (int i = 0; i < PriorityList.Length; i++)
            {
                if (PriorityList[i] != null)
                {
                    Console.WriteLine(PriorityList[i]);
                }
            }
            Console.WriteLine("<-------");
        }



    }
}



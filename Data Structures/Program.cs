using System;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddFirst(5);
            list.AddFirst(10);
            list.AddFirst(15);
            list.AddLast(77);
            list.AddLast(88);
            list.AddAfter(list.Find(15), 99);
            list.AddBefore(list.Find(88), 100);

            list.PrintList();
            Console.WriteLine("-------------------------------------");

            list.Remove(100);

            list.PrintList();
            Console.WriteLine("-------------------------------------");

            list.RemoveFirst();

            list.PrintList();
            Console.WriteLine("-------------------------------------");

            list.RemoveLast();

            list.PrintList();
            Console.WriteLine("-------------------------------------");

      56 3 90 53458 13

            
            Console.ReadKey();
            */
            /*
            Stacks<int> list = new Stacks<int>();

            list.Push(49);
            list.PrintListForwards();
            list.Push(2);
            list.PrintListForwards();
            list.Pop();
            list.PrintListForwards();
            list.Push(55);
            list.PrintListForwards();
            list.Pop();
            list.PrintListForwards();
            list.Push(100);
            list.PrintListForwards();
            list.Push(105);
            list.PrintListForwards();
            list.Peek();
        


            Console.ReadKey(); 

    *//*
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(5);
            queue.Printlist();
            queue.Enqueue(6);
            queue.Printlist();
            queue.Dequeue();
            queue.Printlist();

            Console.ReadKey();
*/
      /*
                  LinkedListQueue<int> queuelist = new LinkedListQueue<int>();
                  queuelist.Peek();
                  queuelist.Enqueue(5);
                  queuelist.PrintList();
                  queuelist.Enqueue(6);
                  queuelist.PrintList();
                  queuelist.Enqueue(7);
                  queuelist.PrintList();
                  queuelist.Enqueue(8);
                  queuelist.PrintList();
                  queuelist.Enqueue(9);
                  queuelist.PrintList();
                  queuelist.Dequeue();
                  queuelist.PrintList();
                  queuelist.Dequeue();
                  queuelist.PrintList();




                 // System.Collections.Generic.Queue<int> test = new System.Collections.Generic.Queue<int>();

                 // test.Dequeue();


                  Console.ReadKey();
      */

            var names = new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "jimbo"};



            PriorityQueue<string> notrelevant = new PriorityQueue<string>();

            Random gen = new Random();


            for (int i = 0; i < 11; i++)
            {
                notrelevant.Enqueue(names[gen.Next(names.Length)], gen.Next(1,10));

                notrelevant.Printlist();

            }
            ///1
            notrelevant.Dequeue();
            notrelevant.Printlist();
            ///2
            notrelevant.Dequeue();
            notrelevant.Printlist();
            ///3
            notrelevant.Dequeue();
            notrelevant.Printlist();
            ///4
            notrelevant.Dequeue();
            notrelevant.Printlist();
            ///5
            notrelevant.Dequeue();
            notrelevant.Printlist();
            ///6
            notrelevant.Dequeue();
            notrelevant.Printlist();
            ///7
            notrelevant.Dequeue();
            notrelevant.Printlist();
            ///8
            notrelevant.Dequeue();
            notrelevant.Printlist();
            ///9
            notrelevant.Dequeue();
            notrelevant.Printlist();
            ///10
            notrelevant.Dequeue();
            notrelevant.Printlist();
            ///11
            notrelevant.Dequeue();
            notrelevant.Printlist();
            ///12
            notrelevant.Dequeue();
            notrelevant.Printlist();
            //System.Collections.Generic.Queue<int> test = new System.Collections.Generic.Queue<int>();

            //test.Dequeue();


            Console.ReadKey();




            //list.PrintList();//
            //list.AddLast(3);
            //list.PrintList();//
            //list.AddAfter(list.Find(1), 2);
            //list.PrintList();//
            //list.AddAfter(list.Find(3), 4);
            //list.PrintList();//
            //list.AddBefore(list.Find(1), 14);
            //list.PrintList();//
            //list.AddAfter(list.Find(3), 35);
            //list.PrintList();//
            //list.AddFirst(0);
            //list.PrintList();//
            //list.Remove(14);
            //list.PrintList();//
            //list.Remove(1);
            //list.PrintList();//
            //list.Remove(35);
            //list.PrintList();//
            //list.AddAfter(list.Find(1), 5);
            //list.PrintList();//
            //list.AddFirst(1);
            //list.PrintList();//
            //list.Remove(1);
            //list.PrintList();//
            //list.RemoveLast();
            //list.PrintList();//
            //list.RemoveLast();
            //list.PrintList();//
            //list.RemoveLast();
            //list.PrintList();//
            //list.RemoveLast();
            //list.PrintList();//
            //list.AddFirst(1);


        }
    }
}

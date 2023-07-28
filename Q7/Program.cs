using System;
using System.Collections.Generic;
namespace CollectionTest
{
    public class CollectionTest
    {
        public void Teste()
        {
            TesteStack();
            TesteList();
            TesteQueue();
            TesteHashSet();
        }

        private void TesteStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(7);
            stack.Push(9);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine("Stack:");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }

        private void TesteList()
        {
            List<int> list = new List<int>() { 5, 7, 9, 4, 5 };

            Console.WriteLine("List:");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        private void TesteQueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(7);
            queue.Enqueue(9);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine("Queue:");
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }
        }

        private void TesteHashSet()
        {
            HashSet<int> hashSet = new HashSet<int>() { 5, 7, 9, 4, 5 };

            Console.WriteLine("HashSet:");
            foreach (int i in hashSet)
            {
                Console.WriteLine(i);
            }
        }
        static void Main()
        {
            CollectionTest teste = new CollectionTest();
            teste.Teste();
        }
    }

}

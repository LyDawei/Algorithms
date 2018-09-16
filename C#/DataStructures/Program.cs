using System;
using DataStructures.library;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<string>();
            list.PushTail("David");
            list.PushTail("Ly");
            list.PushTail("Likes");
            list.PushTail("Jurassic");
            list.PushTail("World");

            list.InsertAfter("Ly", "And");
            list.InsertAfter("And", "Nhan");


            list.Print();
            Console.WriteLine("-------------");
            var secondList = list.Reverse();
            secondList.Print();

        }
    }
}

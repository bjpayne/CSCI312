using System;
using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedList<Int32> sortedLinkedList = new SortedLinkedList<Int32>();

            Int32[] numbers = {7, 6, 10, 15, 4, 0, 10, -5, 3, 11, 6, 3, 0, 1, 8};

            foreach (Int32 number in numbers)
            {
                sortedLinkedList.Add(number);
            }
            
            sortedLinkedList.Display();
        }
    }
}
using System;
using System.Collections.Generic;

namespace SortedList
{
    public class SortedLinkedList<T> where T : IComparable
    {
        private LinkedList<T> _list;

        public SortedLinkedList()
        {
            _list = new LinkedList<T>();
        }

        public void Add(T element)
        {
            // List is empty. Add element.
            if (_list.Count == 0)
            {
                _list.AddFirst(element);

                return;
            }

            // Current element is smaller than the first item in the list
            if (_list.First.Value.CompareTo(element) > 0)
            {
                _list.AddBefore(_list.First, element);

                return;
            }

            // Current element is larger than the last item in the list
            if (_list.Last.Value.CompareTo(element) < 0)
            {
                _list.AddAfter(_list.Last, element);

                return;
            }

            // Current element is larger than the first item in the list, but smaller than the list
            if (_list.First.Value.CompareTo(element) < 0 && _list.Last.Value.CompareTo(element) > 0)
            {
                LinkedListNode<T> currentNode = _list.First;

                while (currentNode != null)
                {
                    // Same value, add after
                    if (currentNode.Value.CompareTo(element) == 0)
                    {
                        _list.AddAfter(currentNode, element);

                        break;
                    }

                    LinkedListNode<T> nextNode = currentNode.Next;

                    // Current element is large than the currentNode and the nextNode is not null and the element
                    // is smaller than the next node
                    if (currentNode.Value.CompareTo(element) < 0 &&
                        (nextNode != null && nextNode.Value.CompareTo(element) > 0))
                    {
                        _list.AddAfter(currentNode, element);

                        break;
                    }

                    currentNode = nextNode;
                }
            }
        }

        public void Display()
        {
            LinkedListNode<T> currentNode = _list.First;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);

                currentNode = currentNode.Next;
            }
        }
    }
}
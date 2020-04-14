using System;
using System.Collections.Generic;

namespace Hashing
{
    public class HashTable<T>
    {
        private LinkedList<KeyValuePair<Int32, T>>[] studentIndex;

        private Int32 size;

        public HashTable(Int32 size)
        {
            this.size = size;
            
            studentIndex = new LinkedList<KeyValuePair<Int32 ,T>>[size];
        }

        public void Add(T student)
        {
            Int32 hashIndex = GetHashIndex(student);

            LinkedList<KeyValuePair<Int32, T>> students = studentIndex[hashIndex];

            // No students have been added at this index
            if (students == null)
            {
                students = new LinkedList<KeyValuePair<Int32, T>>();

                studentIndex[hashIndex] = students;
            }
            
            KeyValuePair<Int32, T> studentValuePair = new KeyValuePair<Int32, T>(student.GetHashCode(), student);

            // Add the student to the end of the linked list at the index
            // Accounts for 0..n students
            students.AddLast(studentValuePair);
        }

        public T Find(Int32 hashCode)
        {
            Int32 hashIndex = GetHashIndex(hashCode);
            
            LinkedList<KeyValuePair<Int32, T>> students = studentIndex[hashIndex];

            // Student is not in hash table at all
            if (students == null)
            {
                return default;
            }

            // If there is only one element or the first element in
            // the chained list is the student
            if (students.First.Value.Key.Equals(hashCode))
            {
                return students.First.Value.Value;
            }

            // O(1) check if element is at the end
            if (students.Last.Value.Key.Equals(hashCode))
            {
                return students.Last.Value.Value;
            }
            
            // O(n) check. Loop through students in the linked list until student
            // is found.
            foreach (KeyValuePair<Int32, T> student in students)
            {
                if (student.Key.Equals(hashCode))
                {
                    return student.Value;
                }
            }

            // No student found
            return default;
        }

        private Int32 GetHashIndex(Int32 hashCode)
        {
            Int32 index = hashCode % size;

            return index;
        }
        
        private Int32 GetHashIndex(T student)
        {
            return GetHashIndex(student.GetHashCode());
        }
    }
}
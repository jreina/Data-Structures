using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }
        T Data { get; set; }


        public Node(T data)
        {
            Data = data;
        }

        public Node<T> SetNext(Node<T> newNext)
        {
            Next = newNext;
            return this;
        }

        public Node<T> SetPrev(Node<T> newPrev)
        {
            Prev = newPrev;
            return this;
        }
    }
}

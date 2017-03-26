using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList<T>
    {
        private Node<T> _head { get; set; }
        private Node<T> _tail { get; set; }
        private Node<T> _userPointer { get; set; }

        public int Count()
        {
            var tNode = _head;
            var count = 0;
            while (tNode != null)
            {
                tNode = tNode.Next;
                count++;
            }
            return count;
        }

        public void Add(int index, T data)
        {
            var newNode = new Node<T>(data);
            var count = Count();

            if (index > count || index < 0) return;
            if (index == 0)
            {
                newNode.SetNext(_head);
                _head = newNode;
            }
            else if (index == count)
            {
                if (_head == null)
                {
                    _head = newNode;
                    return;
                }
                var tNode = _head;

                while (tNode.Next != null) tNode = tNode.Next;
                newNode.SetNext(tNode.Next);
                tNode.SetNext(newNode);
            }
            else if (index < count)
            {
                var tNode = _head;
                for (int i = 0; i < index - 1; i++) tNode = tNode.Next;
                newNode.SetNext(tNode);
                tNode.SetNext(newNode);
            }
        }

        public void AddFirst(T data)
        {

        }

        public void AddLast(T data)
        {

        }

        public void Remove(T data) { }

        public void RemoveFirst() { }

        public void RemoveLast() { }

        public T Get(int index) { throw new NotImplementedException(); }

        public T GetFirst() { throw new NotImplementedException(); }

        public T GetLast() { throw new NotImplementedException(); }

        public void Dump() { }
    }
}

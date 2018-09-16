using System;

namespace DataStructures.library
{
    public class DoublyLinkedList<T>
    {
        private DoublyLinkedListNode<T> _front;
        public DoublyLinkedListNode<T> Front
        {
            get { return _front; }
        }
        private DoublyLinkedListNode<T> _last;
        public DoublyLinkedListNode<T> Last
        {
            get { return _last; }
        }

        private int _length { get; set; }
        public int Length
        {
            get
            {
                return _length;
            }
        }

        public DoublyLinkedList()
        {
            _front = null;
            _last = null;
            _length = 0;
        }

        public DoublyLinkedList(T value)
        {
            Init(value);
            _length = 1;
        }

        public void InsertAfter(T key, T value)
        {
            var afterNode = Search(_front, key);
            if (afterNode == null)
            {
                PushEnd(value);
                return;
            }
            var newNode = new DoublyLinkedListNode<T>(value);
            newNode.Previous = afterNode;
            newNode.Next = afterNode.Next;
            afterNode.Next = newNode;
            _length++;
        }

        public void DeleteNode(T key)
        {
            var target = Search(_front, key);
            var prev_node = target.Previous;
            prev_node.Next = target.Next;
            target.Previous = null;
            target.Next = null;
            _length--;
        }

        public void PushEnd(T value)
        {
            if (_front == null)
            {
                Init(value);
                _length++;
            }
            else
            {
                var newNode = new DoublyLinkedListNode<T>(value);
                newNode.Previous = _last;
                _last.Next = newNode;
                _last = newNode;
                _length++;
            }
        }

        public void PushFront(T value)
        {
            if (_front == null)
            {
                Init(value);
                _length++;
            }
            else
            {
                var newNode = new DoublyLinkedListNode<T>(value);
                newNode.Next = _front;
                _front.Previous = newNode;
                _front = newNode;
                _length++;
            }
        }

        public void PopFront()
        {
            if (_front != null)
            {
                _front = _front.Next;
                _front.Previous = null;
                _length--;
            }
        }

        public void PopEnd()
        {
            if (_last == null)
            {
                return;
            }
            if (_last != null)
            {
                if (Length == 1)
                {
                    _front = _last = null;
                    _length--;
                }
                else
                {
                    _last = _last.Previous;
                    _last.Next = null;
                    _length--;
                }
            }
        }

        public void Print()
        {
            var currNode = _front;
            while (currNode != null)
            {
                Console.WriteLine(currNode.Value);
                currNode = currNode.Next;
            }
            Console.WriteLine($"Length: {Length}");
        }

        private void Init(T value)
        {
            _front = _last = new DoublyLinkedListNode<T>(value);
        }

        private DoublyLinkedListNode<T> Search(DoublyLinkedListNode<T> target, T key)
        {
            if (target.Next == null)
            {
                return null;
            }

            if (target.Value.Equals(key))
            {
                return target;
            }

            return Search(target.Next, key);
        }
    }
}
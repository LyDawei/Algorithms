using System;

namespace DataStructures.library
{
    public class LinkedList<T>
    {
        private LinkedListNode<T> _head;
        public LinkedListNode<T> Head
        {
            get { return _head; }
        }

        private int _length { get; set; }
        public int Length
        {
            get
            {
                return _length;
            }
        }

        public LinkedList()
        {
            _head = null;
            _length = 0;
        }

        public LinkedList(T value)
        {
            Init(value);
            _length = 1;
        }

        public void InsertAfter(T key, T value)
        {
            var currNode = Search(_head, key);
            if (currNode == null)
            {
                throw new Exception("[LINKED_LIST]: Could not locate node to insert after.");
            }

            var newNode = new LinkedListNode<T>(value);
            newNode.Next = currNode.Next;
            currNode.Next = newNode;
            _length++;

        }

        public void DeleteNode(T key)
        {
            if (_length == 1)
            {
                _head = null;
                return;
            }

            if (_head.Value.Equals(key))
            {
                var temp = _head;
                _head = _head.Next;
                temp.Next = null;
                _length--;
                return;
            }

            var currNode = _head.Next;
            var prevNode = _head;
            while (!currNode.Value.Equals(key) && currNode.Next != null)
            {
                prevNode = currNode;
                currNode = currNode.Next;
            }

            if (currNode.Next == null && !prevNode.Value.Equals(key) && !currNode.Value.Equals(key))
            {
                return;
            }

            prevNode.Next = currNode.Next;
            currNode.Next = null;
            currNode = null;
            _length--;
        }

        public void PushTail(T value)
        {
            var newNode = new LinkedListNode<T>(value);

            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                var tail = GetTail(_head);
                tail.Next = newNode;
            }

            _length++;
        }

        public void PushHead(T value)
        {
            var newNode = new LinkedListNode<T>(value);
            newNode.Next = _head;
            _head = newNode;
            _length++;
        }

        public LinkedListNode<T> PopHead()
        {
            if (_head == null)
            {
                return null;
            }

            var temp = _head;
            _head = _head.Next;
            temp.Next = null;
            _length--;
            return temp;
        }

        public LinkedListNode<T> PopTail()
        {
            if (_head == null)
            {
                return null; ;
            }

            if (_length == 1)
            {
                var retVal = new LinkedListNode<T>(_head);
                _head = null;
                _length--;
                return retVal;
            }

            var tail = _head.Next;
            var prevTail = _head;

            while (tail.Next != null)
            {
                prevTail = tail;
                tail = tail.Next;
            }

            prevTail.Next = null;
            _length--;
            return tail;

        }

        public LinkedList<T> Reverse()
        {
            if (_length == 1)
            {
                return new LinkedList<T>(_head.Value);
            }

            var newList = new LinkedList<T>();

            while (_length > 0)
            {
                newList.PushTail(this.PopTail().Value);
            }

            return newList;
        }

        public void Print()
        {
            var currNode = _head;
            while (currNode != null)
            {
                Console.WriteLine(currNode.Value);
                currNode = currNode.Next;
            }
            Console.WriteLine($"Length: {Length}");
        }

        private void Init(T value)
        {
            _head = new LinkedListNode<T>(value);
        }

        private LinkedListNode<T> Search(LinkedListNode<T> start, T key)
        {
            if (start.Next == null && !start.Value.Equals(key))
            {
                return null;
            }

            if (start.Value.Equals(key))
            {
                return start;
            }

            return Search(start.Next, key);
        }

        private LinkedListNode<T> GetTail(LinkedListNode<T> node)
        {
            if (node.Next != null)
            {
                return GetTail(node.Next);
            }
            else
            {
                return node;
            }
        }
    }
}
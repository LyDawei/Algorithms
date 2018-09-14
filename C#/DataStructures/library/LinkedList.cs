namespace DataStructures
{
    public class LinkedList<T>
    {
        private LinkedListNode<T> _front;
        public LinkedListNode<T> Front
        {
            get { return _front; }
        }
        private LinkedListNode<T> _last;
        public LinkedListNode<T> Last
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

        public LinkedList()
        {
            _front = null;
            _last = null;
            _length = 0;
        }

        public LinkedList(T value)
        {
            Init(value);
            _length = 0;
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
                var newNode = new LinkedListNode<T>(value);
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
                var newNode = new LinkedListNode<T>(value);
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
            if (_last.Previous != null)
            {
                _last = _last.Previous;
                _last.Next = null;
                _length--;
            }
        }

        private void Init(T value)
        {
            _front = new LinkedListNode<T>(value);
            _last = new LinkedListNode<T>(value);
        }
    }
}
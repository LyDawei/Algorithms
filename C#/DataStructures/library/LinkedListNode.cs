namespace DataStructures
{
    public class LinkedListNode<T>
    {
        public LinkedListNode<T> Next { get; set; }
        public LinkedListNode<T> Previous { get; set; }
        public T Value { get; set; }

        public LinkedListNode(T value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
}
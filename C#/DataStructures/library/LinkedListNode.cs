namespace DataStructures.library
{
    public class LinkedListNode<T>
    {
        public LinkedListNode<T> Next { get; set; }
        public T Value { get; set; }

        public LinkedListNode(T value)
        {
            this.Value = value;
            this.Next = null;
        }

        public LinkedListNode(LinkedListNode<T> node)
        {
            this.Value = node.Value;
            this.Next = node.Next;
        }
    }
}
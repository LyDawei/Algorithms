namespace DataStructures.library
{
    public class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Previous { get; set; }
        public T Value { get; set; }

        public DoublyLinkedListNode(T value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
}
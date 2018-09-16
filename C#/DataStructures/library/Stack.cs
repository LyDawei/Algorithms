using System;

namespace DataStructures.library
{
    /// <summary>
    /// Generic stack datastructure
    /// </summary>
    /// <typeparam name="T">DataType</typeparam>
    public class Stack<T>
    {
        private int _capacity;
        private int _top = -1; // Top of the stack.

        /// <summary>
        /// Retrieves size of the stack.
        /// </summary>
        /// <value></value>
        public int Size
        {
            get
            {
                if (_top == -1)
                {
                    return 0;
                }
                return this._top + 1;
            }
        }

        /// <summary>
        /// Returns top element of the stack.
        /// </summary>
        /// <value></value>
        public T Top
        {
            get
            {
                if (_top == -1)
                {
                    throw new Exception("[STACK_ERROR]: Stack is empty.");
                }
                return _stack[_top];
            }
        }
        private T[] _stack; // Stack

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="capacity">Maximum number of elements stack can hold.</param>
        public Stack(int capacity = 10)
        {
            this._capacity = capacity;
            _stack = new T[this._capacity];
        }

        /// <summary>
        /// Accepts array to convert into stack.
        /// </summary>
        /// <param name="collection"></param>
        public Stack(T[] collection)
        {
            this._capacity = collection.Length;
            this._stack = new T[this._capacity];

            for (var idx = 0; idx < this._capacity; idx++)
            {
                this._stack[idx] = collection[idx];
                this._top++;
            }
        }

        private bool IsFull()
        {
            return _top == this._capacity - 1;
        }

        /// <summary>
        /// Adds argument to the stack.
        /// </summary>
        /// <param name="data"></param>
        public void Push(T data)
        {
            if (this.IsFull())
                throw new Exception("[STACK_ERROR]: Stack is full. Cannot push data into stack.");

            _stack[++_top] = data;
        }

        /// <summary>
        /// Removes top-most element from stack.
        /// </summary>
        public void Pop()
        {
            if (_top == -1)
                return;

            _top--;
        }
    }
}
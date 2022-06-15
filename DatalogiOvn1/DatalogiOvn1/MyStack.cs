namespace DatalogiOvn1
{
    using System;

    internal class MyStack<T> : ISimpleStack<T>, ISimpleQueue<T>
    {
        private Node<T>? _top;
        private Node<T>? _bottom;
        public int Count { get; set; }

        public void Push(T value)
        {
            var node = new Node<T>(value);
            node.Next = _top;
            _top = node;
            if (_bottom is null)
            {
                _bottom = node;
            }
            Count++;
        }

        public T Pop()
        {
            if (_top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            
            var value = _top.Data;
            _top = _top.Next;
            Count--;
            if (_top == null) _bottom = null;
            return value;
        }
        
        public T Peek()
        {
            if (_top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return _top.Data;
        }

        public void AddLast(T value)
        {
            if (_bottom is null)
            {
                Push(value);
            }
            else
            {
                var node = new Node<T>(value);
                _bottom.Next = node;
                _bottom = node;
                Count++;
            }
        }

        public T GetFirst() => Peek();

        public void RemoveFirst() => Pop();
    }
}

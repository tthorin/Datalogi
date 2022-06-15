namespace DatalogiOvn1
{
    public interface ISimpleStack<T>
    {
        public void Push(T value);
        public T Pop();
        public T Peek();
    }

}

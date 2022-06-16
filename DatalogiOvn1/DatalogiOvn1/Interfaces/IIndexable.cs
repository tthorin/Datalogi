namespace DatalogiOvn1.Interfaces
{
    public interface IIndexable<T>
    {
        public int Length();
        public T GetAt(int index);
        public void SetAt(int index, T value);
        public void RemoveAt(int index);
    }

}

namespace DatalogiOvn1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ISimpleQueue<T>
    {
        public void AddLast(T value);
        public T GetFirst();
        public void RemoveFirst();
    }

}

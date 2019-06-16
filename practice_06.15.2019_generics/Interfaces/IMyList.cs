using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_06._15._2019_generics.Task1_MyList
{
    public interface IMyList<T>
    {
        void Add(T item);
        T this[int index] { get; }
        int Count { get; }
        void Clear();
        bool Contains(T item);
    }
}

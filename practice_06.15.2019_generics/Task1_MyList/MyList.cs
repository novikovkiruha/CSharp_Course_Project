using System;

namespace practice_06._15._2019_generics.Task1_MyList
{
    public class MyList<T> : IMyList<T>
    {
        protected T[] array;

        public MyList()
        {
            this.array = new T[0];
        }

        public int Count
        {
            get
            {
                return this.array.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index > array.Length - 1)
                    throw new IndexOutOfRangeException("Array doesn't containt this index");
                else
                    return this.array[index];
            }
        }

        public void Add(T item)
        {
            T[] tempArray = new T[this.array.Length + 1];
            this.array.CopyTo(tempArray, 0);
            tempArray[tempArray.Length - 1] = item;
            this.array = tempArray;
        }

        public void Clear()
        {
            this.array = new T[0];
        }

        public bool Contains(T item)
        {
            bool result = false;
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].Equals(item))
                    result = true;
            }

            return result;
        }

        public override string ToString()
        {
            return $"Size: {this.Count}{Environment.NewLine}" +
                $"Elements: {string.Join(", ", this.array)}";
        }
    }
}

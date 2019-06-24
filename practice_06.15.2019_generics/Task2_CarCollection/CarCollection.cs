using System;
using System.Collections.Generic;
using practice_06._15._2019_generics.Interfaces;
using practice_06._15._2019_generics.Task1_MyList;

namespace practice_06._15._2019_generics.Task2_CarCollection
{
    public class CarCollection<T> : MyList<T> where T : ICar
    {
        public T this[string name]
        {
            get
            {
                T result = default(T);
                for (int i = 0; i < this.array.Length; i++)
                {
                    if (this.array[i].CarName == name)
                    {
                        result = this.array[i];
                    }
                }

                return result;
            }
        }

        public override string ToString()
        {
            var cars = "";
            for (int i = 0; i < this.array.Length; i++)
            {
                if (i != this.array.Length - 1)
                    cars += $"{array[i].CarName} - {array[i].CarYear}{Environment.NewLine}";
                else
                    cars += $"{array[i].CarName} - {array[i].CarYear}";
            }

            if (this.Count != 0)
                return $"Size: {this.Count}{Environment.NewLine}" +
                $"Elements:{Environment.NewLine}{cars}";
            else
                return $"{GetType().Name} is blank";
        }
    }
}

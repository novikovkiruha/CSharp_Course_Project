using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project
{
    public static class Collections
    {
        public static void Execute()
        {
            //object[] objArr = new object[3];
            //int[] days = { 1, 2, 3 };
            //object[] objArr2 = days;

            ICollection<int> col = new Collection<int> { 1, 2, 3 };
            col.Add(1);
            col.Remove(3);

            foreach (var item in col)
            {
                Console.WriteLine(item);
            }
        }
    }
}

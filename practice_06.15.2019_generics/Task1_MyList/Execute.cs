using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_06._15._2019_generics.Task1_MyList
{
    public class Execute
    {
        public void CodeExecute()
        {
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine($"Count before adding: {list.Count}");
            list.Add(1);
            list.Add(5);
            list.Add(8);
            Console.WriteLine($"Count after adding: {list.Count}");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            if (list.Contains(1))
            {
                Console.WriteLine("This item is contained in array");
            }
            else
            {
                Console.WriteLine("This item is NOT contained in array");
            }

            list.Clear();
            Console.WriteLine($"Count after clearing: {list.Count}");
        }
    }
}

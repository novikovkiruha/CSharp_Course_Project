using System;

namespace practice_06._15._2019_generics.Task1_MyList
{
    public class Execute
    {
        public void CodeExecute()
        {
            MyList<int> list = new MyList<int>();
            
            Console.WriteLine($"Count before adding: {list.Count}");
            list.Add(1);
            list.Add(5);
            list.Add(8);
            Console.WriteLine($"Count after adding: {list.Count}");

            if (list.Contains(1))
                Console.WriteLine("This item is contained in array");
            else
                Console.WriteLine("This item is NOT contained in array");

            Console.WriteLine(list.ToString());

            list.Clear();
            Console.WriteLine($"Count after clearing: {list.Count}");
        }
    }
}

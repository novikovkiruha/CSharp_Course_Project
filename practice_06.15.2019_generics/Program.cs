using practice_06._15._2019_generics.Task1_MyList;
using practice_06._15._2019_generics.Task2_CarCollection;
using practice_06._15._2019_generics.Task3_LinkedList;
using System;

namespace practice_06._15._2019_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Execute().CodeExecute();
            //new CarList().CarDisplay();

            var list = new LinkedList<int>();
            list.Add(5);
            list.Add(1);
            list.Add(9);
            if (list.Contains(5))
            {
                list.Remove(5);
            }
            Console.WriteLine(list.Count);
        }
    }
}

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

            //read only collection
            IReadOnlyCollection<int> roc = new ReadOnlyCollection<int>(new Collection<int>());

            List<int> list = new List<int>(); // не поддерживает кастомизацию
            Collection<int> collection = new Collection<int>(); // поддерживает кастомизацию: содержит некоторые virtual/override методы
            ObservableCollection<int> obCol = new ObservableCollection<int>(); //выдача уведомлений при получении и удалении элементов: CollectionChanged
            LinkedList<int> linked = new LinkedList<int>(); // двунаправленный список
            Stack<int> stack = new Stack<int>(); // последний пришел - первый вышел (LIFO)
            Queue<int> queue = new Queue<int>(); // первый пришел - первый вышел
            SortedList<int, string> sortedList = new SortedList<int, string>(); // сортирует по ключу. Реализован в виде списка
            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>(); // дерево бинарного поиска, где все объекты отсортированы по ключу. Бинарное дерево поиска. Реализован в виде словаря

            Dictionary<int, string> dictionary = new Dictionary<int, string>(); // отношение ключ-значение или hash-таблица
            dictionary.Add(1, "1");
            dictionary.Add(2, "2");
            dictionary.Add(3, "3");
            dictionary.Add(4, "4");
            dictionary.Add(5, "5");
            //dictionary.Add(5, "6");

            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine(item.GetHashCode() + " - " + item.Key + "-" + item.Value);
            }
            Console.WriteLine(dictionary.Comparer);

            string nextKey;

            
        }
    }
}

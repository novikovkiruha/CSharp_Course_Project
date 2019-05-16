using System;

namespace CSharp_Course_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.GetInstance();
            singleton.DoSomething();
            singleton.field = 100;
        }
    }

    public class NonStaticClass
    {
        public static int staticField;
        
        public NonStaticClass()
        {
            Console.WriteLine("NonStatic nonstatic constructor");
        }

        static NonStaticClass()
        {
            Console.WriteLine("NonStatic static constructor");
            Console.WriteLine(StaticClass.staticField);
        }
    }

    public static class StaticClass
    {
        public static int staticField;

        static StaticClass()
        {
            Console.WriteLine("NonStatic static constructor");
        }
    }

    class Singleton
    {
        private static Singleton instance;

        public int field;

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

        public void DoSomething()
        {
        }
    }
}
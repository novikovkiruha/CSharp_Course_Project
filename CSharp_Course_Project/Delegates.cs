using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project
{
    public class Delegates
    {
        //public class MyClass
        //{
        //    //public void Method()
        //    //{
        //    //    Console.WriteLine("Method");
        //    //}

        //    public string Method1(string name)
        //    {
        //        return "Hello " + name;
        //    }
        //}

        ////public delegate void MyDelegate();

        //public string MyDelegate1(string name);

        //public void Execute()
        //{
        //    // for static MyClass
        //    //MyDelegate myDelegate = new MyDelegate(MyClass.Method);

        //    MyClass instance = new MyClass();

        //    //2
        //    //MyDelegate myDelegate = new MyDelegate(instance.Method);
        //    //myDelegate.Invoke();
        //    //myDelegate();

        //    //3
        //    MyDelegate1 myDelegate1 = new MyDelegate1(instance.Method1);

        //    string greeting = myDelegate1.Invoke("Kirill");
        //    Console.WriteLine(greeting);
        //}

        //
        // 4
        //
        public delegate void MyDelegate();

        public static void Method1()
        {
            Console.WriteLine("Method1");
        }

        public static void Method2()
        {
            Console.WriteLine("Method2");
        }

        public static void Method3()
        {
            Console.WriteLine("Method3");
        }

        public void Execute()
        {
            MyDelegate myDelegate = null;
            var myDelegate1 = new MyDelegate(Method1);
            var myDelegate2 = new MyDelegate(Method2);
            var myDelegate3 = new MyDelegate(Method3);

            myDelegate = myDelegate1 + myDelegate2 + myDelegate3;

            Console.WriteLine("Введите число от 1 до 7");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    myDelegate1.Invoke();
                    break;
                case "2":
                    myDelegate2.Invoke();
                    break;
                case "3":
                    myDelegate3.Invoke();
                    break;
                case "4":
                    MyDelegate myDelegate4 = myDelegate - myDelegate1; 
                    myDelegate4.Invoke();
                    break;
                case "5":
                    MyDelegate myDelegate5 = myDelegate - myDelegate2;
                    myDelegate5.Invoke();
                    break;
                case "6":
                    MyDelegate myDelegate6 = myDelegate - myDelegate3;
                    myDelegate6.Invoke();
                    break;
                case "7":
                    myDelegate.Invoke();
                    break;
                default:
                    Console.WriteLine("Wrong!");
                    break;
            }
        }
    }
}

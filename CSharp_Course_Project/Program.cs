using CSharp_Course_Project.Task1_StudentList;
using CSharp_Course_Project.Task2_StudentDictionary;
using CSharp_Course_Project.Task3_Queue;
using CSharp_Course_Project.Task4_Stack;
using System;

namespace CSharp_Course_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //new StudentManager().ManageStudentList();
            //new StudentDictionary().ManageStudentDictionary();
            //new StudentQueue().ManageStudentQueue();
            new StudentStack().ManageStudentStack();
        }
    }
}
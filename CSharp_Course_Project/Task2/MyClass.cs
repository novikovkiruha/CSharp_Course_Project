using System;

namespace CSharp_Course_Project.Task2
{
    public class MyClass
    {
        private string change;

        public string GetClassField()
        {
            return this.change;
        }

        public void SetClassField(string fieldValue)
        {
            this.change = fieldValue;
        }
    }
}

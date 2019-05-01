using System;

namespace CSharp_Course_Project.Task2
{
    public struct MyStruct
    {
        private string change;

        public string GetStructureField()
        {
            return this.change;
        }

        public void SetStructureField(string fieldValue)
        {
            this.change = fieldValue;
        }
    }
}

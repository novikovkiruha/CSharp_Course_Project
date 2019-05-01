using System;

namespace CSharp_Course_Project.Task2
{
    class Handler
    {
        public void Execute()
        {
            MyClass myClassInstance = new MyClass();
            myClassInstance.SetClassField("Original class");

            MyStruct myStructureInstance = new MyStruct();
            myStructureInstance.SetStructureField("Original structure");

            this.ClassTaker(myClassInstance);
            this.StructTaker(myStructureInstance);
            Console.WriteLine($"Class field is: {myClassInstance.GetClassField()}");
            Console.WriteLine($"Structure field is: {myStructureInstance.GetStructureField()}");
        }

        private void ClassTaker(MyClass myClass)
        {
            myClass.SetClassField("Changed class");
        }

        private void StructTaker(MyStruct myStruct)
        {
            myStruct.SetStructureField("Changed structure");
        }
    }
}

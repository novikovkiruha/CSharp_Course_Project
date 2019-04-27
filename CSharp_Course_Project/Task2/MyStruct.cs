using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project.Task2
{
    public struct MyStruct
    {
        private string change;

        public string Execute()
        {
            return this.change;
        }

        public void SetStructureFields(string fieldValue)
        {
            this.change = fieldValue;
        }
    }
}

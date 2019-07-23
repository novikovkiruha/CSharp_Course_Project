using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project
{
    public class Reflection
    {
        public string name;
        public void Execute()
        {
            //Assembly.ReflectionOnlyLoadFrom(this.name);
            var reflection = new Reflection();
            var getType = reflection.GetType();
            
            Console.WriteLine($"GetType(): {getType}");

            var typeOf = typeof(Reflection);
            Console.WriteLine("typeof:");
            foreach (var item in typeOf.GetMembers())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}

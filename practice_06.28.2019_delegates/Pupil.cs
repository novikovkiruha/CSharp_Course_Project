using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_06._28._2019_delegates
{
    public class Pupil
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string School { get; set; }

        public Pupil()
        {
        }

        public Pupil(string name, string surname, string school)
        {
            this.Name = name;
            this.Surname = surname;
            this.School = school;
        }
    }
}

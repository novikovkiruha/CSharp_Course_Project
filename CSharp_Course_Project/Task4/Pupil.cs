using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
c
Выведите на экран в виде таблички значения из массива.
Для ученика обязательными характеристиками состояния являются дата рождения, имя и фамилия.
Школа и класс должны устанавливаться через соответствующие свойства. Возраст должен рассчитываться.
*/

namespace CSharp_Course_Project.Task4
{
    class Pupil
    {
        private string name;

        private string surname;

        private int age;

        private int schoolNumber;

        private string schoolGroup;

        public Pupil()
        {
        }

        //public Pupil(string name, string surname, int age, int schoolNumber, string schoolGroup)
        //{
        //    this.name = name;
        //    this.surname = surname;
        //    this.age = age;
        //    this.schoolNumber = schoolNumber;
        //    this.schoolGroup = schoolGroup;
        //}

        public string GetName() => this.name;

        public string GetSurname() => this.surname;

        public int GetAge() => this.age;

        public int GetSchoolNumber() => this.schoolNumber;

        public string GetSchoolGroup() => this.schoolGroup;

        public void SetName(string name) => this.name = name;

        public void SetSurname(string surname) => this.surname = surname;

        public void SetAge(int age) => this.age = age;

        public void SetSchoolNumber(int schoolNumber) => this.schoolNumber = schoolNumber;

        public void SetSchoolGroup(string schoolGroup) => this.schoolGroup = schoolGroup;
    }
}

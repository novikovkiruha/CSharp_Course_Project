using System;

namespace CSharp_Course_Project.Task4
{
    /*
    Выведите на экран в виде таблички значения из массива.
    Для ученика обязательными характеристиками состояния являются дата рождения, имя и фамилия.
    Школа и класс должны устанавливаться через соответствующие свойства. Возраст должен рассчитываться.
    */
    public class Pupil
    {
        private int age;

        private int schoolNumber;

        private string name;

        private string surname;

        private string schoolGroup;

        private DateTime dateOfBirth;

        public Pupil(string name, string surname, DateTime dateOfBirth)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));

            if (string.IsNullOrWhiteSpace(surname))
                throw new ArgumentException(nameof(surname));

            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public int SchoolNumber
        {
            get
            {
                return schoolNumber;
            }
            set
            {
                schoolNumber = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Surname {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public string SchoolGroup {
            get
            {
                return schoolGroup;
            }
            set
            {
                schoolGroup = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }
    }
}

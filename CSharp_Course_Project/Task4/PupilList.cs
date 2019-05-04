using System;

namespace CSharp_Course_Project.Task4
{
    class PupilList
    {
        private const int PupilsMaxNumber = 2;

        private Pupil[] pupils;

        public PupilList()
        {
            this.pupils = new Pupil[PupilList.PupilsMaxNumber];
        }

        public void Execute()
        {
            this.pupils = FillPupilList();

            for (int i = 0; i < pupils.Length; i++)
            {
                pupils[i].Age = CalculateAge(pupils[i]);
            }

            Console.WriteLine(String.Format("{0, 8} | {1, 8} | {2, 15} | {3, 4} | {4, 7} | {5, 7}\n",
                "Name",
                "Surname",
                "Date of Birth",
                "Age",
                "School",
                "Group"));
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.Write(String.Format("{0, 8} | {1, 8} | {2, 15} | {3, 4} | {4, 7} | {5, 7}",
                    this.pupils[i].Name,
                    this.pupils[i].Surname,
                    this.pupils[i].DateOfBirth.ToString("MM/dd/yyyy"),
                    this.pupils[i].Age,
                    this.pupils[i].SchoolNumber,
                    this.pupils[i].SchoolGroup));
                Console.WriteLine();
            }
        }

        public int CalculateAge(Pupil pupil)
        {
            return Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(pupil.DateOfBirth.Year);
        }
        
        public Pupil[] FillPupilList()
        {
            for (int i = 0; i < PupilList.PupilsMaxNumber; i++)
            {
                this.pupils[i] = this.GetNewPupil();
                this.pupils[i].SchoolNumber = PupilList.GetSchoolNumber();
                this.pupils[i].SchoolGroup = PupilList.GetSchoolGroup();
            }

            return this.pupils;
        }

        private static int GetSchoolNumber()
        {
            int schoolNumber = 0;
            while (true)
            {
                Console.Write("Enter a school number: ");

                if (Int32.TryParse(Console.ReadLine(), out schoolNumber))
                    break;
            }

            return schoolNumber;
        }

        private static string GetSchoolGroup()
        {
            string schoolGroup = string.Empty;
            while (true)
            {
                Console.Write("Enter a school group: ");

                schoolGroup = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(schoolGroup))
                    break;
            }

            return schoolGroup;
        }

        private Pupil GetNewPupil()
        {
            string name = string.Empty;
            while (true)
            {
                Console.Write("Enter pupil name: ");

                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    break;
            }

            string surname = string.Empty;
            while (true)
            {
                Console.Write("Enter pupil surname: ");

                surname = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(surname))
                    break;
            }

            DateTime dateOfBirth;
            while (true)
            {
                Console.Write("Enter pupil's date of birth: ");

                if (DateTime.TryParse(Console.ReadLine(), out dateOfBirth))
                    break;
            }

            return new Pupil(name, surname, dateOfBirth);
        }
    }
}

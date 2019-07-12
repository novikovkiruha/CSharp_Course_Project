using System.Collections;
using System.Collections.Generic;

namespace practice_06._28._2019_delegates.Task2_DeferedInitialization
{
    public static class EmployeeList
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee(1, "Vladislav", "Radchenko", Gender.Male),
                new Employee(2, "Aleksandr", "Matsegora", Gender.Male),
                new Employee(3, "Andrey", "Fedorchenko", Gender.Male),
                new Employee(4, "Anton", "Isaev", Gender.Male),
                new Employee(5, "Artem", "Kravchenko", Gender.Male),
                new Employee(6, "Elena", "Zub", Gender.Female),
                new Employee(7, "Evgeniya", "Gladyscheva", Gender.Female),
                new Employee(8, "Kirill", "Novikov", Gender.Male),
                new Employee(9, "Oleg", "Reshetilo", Gender.Male),
                new Employee(10, "Olga", "Pavlenko", Gender.Female),
                new Employee(11, "Tetiana", "Ryzhik", Gender.Female),
                new Employee(12, "Valeriy", "Malinosvkiy", Gender.Male),
                new Employee(26, "Tirion", "Lannister", Gender.Male),
                new Employee(22, "Ariya", "Stark", Gender.Female)
            };
        }

        public static List<Employee> GetCompanyEmployees()
        {
            return new List<Employee>
            {
                new Employee(21, "Eddard", "Stark", Gender.Male, 50, "Stark Industries"),
                new Employee(22, "Ariya", "Stark", Gender.Female, 12, "Stark Industries"),
                new Employee(23, "Rob", "Stark", Gender.Male, 20, "Stark Industries"),
                new Employee(24, "John", "Snow", Gender.Male, 19, "Stark Industries"),
                new Employee(25, "Sansa", "Stark", Gender.Female, 15, "Stark Industries"),
                new Employee(26, "Tirion", "Lannister", Gender.Male, 40, "Lannister LTD"),
                new Employee(27, "Jayme", "Lannister", Gender.Male, 42, "Lannister LTD"),
                new Employee(28, "Serseya", "Lannister", Gender.Female, 43, "Lannister LTD"),
                new Employee(29, "Deyneris", "Targarien", Gender.Female, 18, "Targarien International Corp."),
                new Employee(30, "Drago", "Targarien", Gender.Male, 45, "Targarien International Corp.")
            };
        }

        public static Employee[] GetInteticsEmployees()
        {
            return new Employee[]
            {
                new Employee(1, "Vladislav", "Radchenko", Gender.Male),
                new Employee(2, "Aleksandr", "Matsegora", Gender.Male),
                new Employee(3, "Andrey", "Fedorchenko", Gender.Male),
                new Employee(4, "Anton", "Isaev", Gender.Male),
                new Employee(5, "Artem", "Kravchenko", Gender.Male),
                new Employee(6, "Elena", "Zub", Gender.Female),
                new Employee(7, "Evgeniya", "Gladyscheva", Gender.Female),
                new Employee(8, "Kirill", "Novikov", Gender.Male),
                new Employee(9, "Oleg", "Reshetilo", Gender.Male),
                new Employee(10, "Olga", "Pavlenko", Gender.Female),
                new Employee(11, "Tetiana", "Ryzhik", Gender.Female),
                new Employee(12, "Valeriy", "Malinosvkiy", Gender.Male),
                new Employee(26, "Tirion", "Lannister", Gender.Male),
                new Employee(22, "Ariya", "Stark", Gender.Female)
            };
        }

        public static Employee[] GetGoTEmployees()
        {
            return new Employee[]
            {
                new Employee(21, "Eddard", "Stark", Gender.Male, 50, "Stark Industries"),
                new Employee(22, "Ariya", "Stark", Gender.Female, 12, "Stark Industries"),
                new Employee(23, "Rob", "Stark", Gender.Male, 20, "Stark Industries"),
                new Employee(24, "John", "Snow", Gender.Male, 19, "Stark Industries"),
                new Employee(25, "Sansa", "Stark", Gender.Female, 15, "Stark Industries"),
                new Employee(26, "Tirion", "Lannister", Gender.Male, 40, "Lannister LTD"),
                new Employee(27, "Jayme", "Lannister", Gender.Male, 42, "Lannister LTD"),
                new Employee(28, "Serseya", "Lannister", Gender.Female, 43, "Lannister LTD"),
                new Employee(29, "Deyneris", "Targarien", Gender.Female, 18, "Targarien International Corp."),
                new Employee(30, "Drago", "Targarien", Gender.Male, 45, "Targarien International Corp.")
            };
        }
    }
}

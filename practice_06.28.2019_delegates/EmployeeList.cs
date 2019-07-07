using System.Collections.Generic;

namespace practice_06._28._2019_delegates.Task2_DeferedInitialization
{
    public static class EmployeeList
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee(1, "Eddard", "Stark", Gender.Male),
                new Employee(2, "Ariya", "Stark", Gender.Female),
                new Employee(3, "Rob", "Stark", Gender.Male),
                new Employee(4, "John", "Snow", Gender.Male),
                new Employee(5, "Sansa", "Stark", Gender.Female),
                new Employee(6, "Tirion", "Lannister", Gender.Male),
                new Employee(7, "Jayme", "Lannister", Gender.Male),
                new Employee(8, "Serseya", "Lannister", Gender.Female),
                new Employee(9, "Deyneris", "Targarien", Gender.Female),
                new Employee(10, "Drago", "Targarien", Gender.Male)
            };
        }

        public static List<Employee> GetCompanyEmployees()
        {
            return new List<Employee>
            {
                new Employee(1, "Eddard", "Stark", Gender.Male, 50, "Stark Industries"),
                new Employee(2, "Ariya", "Stark", Gender.Female, 12, "Stark Industries"),
                new Employee(3, "Rob", "Stark", Gender.Male, 20, "Stark Industries"),
                new Employee(4, "John", "Snow", Gender.Male, 19, "Stark Industries"),
                new Employee(5, "Sansa", "Stark", Gender.Female, 15, "Stark Industries"),
                new Employee(6, "Tirion", "Lannister", Gender.Male, 40, "Lannister LTD"),
                new Employee(7, "Jayme", "Lannister", Gender.Male, 42, "Lannister LTD"),
                new Employee(8, "Serseya", "Lannister", Gender.Female, 43, "Lannister LTD"),
                new Employee(9, "Deyneris", "Targarien", Gender.Female, 18, "Targarien International Corp."),
                new Employee(10, "Drago", "Targarien", Gender.Male, 45, "Targarien International Corp.")
            };
        }
    }
}

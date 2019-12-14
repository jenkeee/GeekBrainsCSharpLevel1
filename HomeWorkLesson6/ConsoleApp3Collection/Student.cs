using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3Collection
{
    /// <summary>
    /// Один студент
    /// </summary>
    class Student
    {
        public string LastName;
        public string FirstName;
        public string University;
        public string Facilty;
        public int Course;
        public string Department;
        public int Group;
        public string City;
        public int Age;
        public Student(string lastName, string firstName, string university,
            string facilty, int course, string department, int group, string city, int age)
        {
            LastName = lastName;
            FirstName = firstName;
            University = university;
            Facilty = facilty;
            Course = course;
            Department = department;
            Group = group;
            City = city;
            Age = age;
        }


        /// <summary>
        /// Создание файла с исходными данными
        /// </summary>
        /// <param name="fileName"></param>
        public static void GenNSaveStudentsToFile(string fileName)
        {
            List<Student> list = new List<Student>
            {
                new Student("Петров", "Дмитрий", "МГУ", "Мехмат", 1, "Математический", 1, "Москва", 18),
                new Student("Теплов", "Андрей", "СПГУ", "Мехмат", 1, "Механический", 2, "Петербург", 23),
                new Student("Гавасяв", "Емеля", "МГУ", "Инженерный", 3, "Математический", 1, "Москва", 22),
                new Student("Юров", "Вася", "МГУ", "Логический", 3, "Математический", 2, "Владивосток", 21),
                new Student("Берендеев", "Сергей", "СПУ", "Логический", 4, "Математический", 1, "Петербург", 18),
                new Student("Жуликов", "Алексей", "МГУ", "Мехмат", 4, "Механический", 3, "Петербург", 25),
                new Student("Иванов", "Андрей", "МГУ", "Инженерный", 5, "Механический", 1, "Москва", 24),
                new Student("Логинов", "Михаил", "МГУ", "Инженерный", 5, "Механический", 4, "Москва", 19),
                new Student("Пужев", "Степан", "МГУ", "Мехмат", 6, "Биологический", 5, "Владивосток", 21),
                new Student("Жуков", "Иван", "МГУ", "Мехмат", 6, "Гуманитарный", 4, "Владивосток", 22),
                new Student("Лужков", "Дмитрий", "МГУ", "Мехмат", 2, "Математический", 1, "Москва", 19),
                new Student("Варьянов", "Андрей", "СПГУ", "Мехмат", 2, "Механический", 2, "Петербург", 23),
            };
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Student el in list)
                {
                    string s = string.Join(";", el.LastName, el.FirstName, el.University, el.Facilty, el.Course,
                        el.Department, el.Group, el.City, el.City);
                    writer.WriteLine(s);
                }
            }
        }
    }
}

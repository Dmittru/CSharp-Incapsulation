using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1UniOS
{
    internal class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string HairColor { get; set; }
        public int Age { get; set; }

        public Student(string name, string gender, string hairColor, int age)
        {
            Name = name;
            Gender = gender;
            HairColor = hairColor;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Gender: {Gender}, Hair Color: {HairColor}, Age: {Age}";
        }

        public static Student AddStudents(params Student[] students)
        {
            if (students == null || students.Length == 0)
                throw new ArgumentException("At least one student must be provided.");

            string combinedName = string.Join(" & ", students.Select(s => s.Name));
            string combinedGender = string.Join(", ", students.Select(s => s.Gender).Distinct());
            string combinedHairColor = string.Join(", ", students.Select(s => s.HairColor).Distinct());
            int combinedAge = (int)students.Average(s => s.Age); // Средний возраст

            return new Student(combinedName, combinedGender, combinedHairColor, combinedAge);
        }
    }
}

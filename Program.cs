using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    // Base class for CClass
    class CClass
    {
        public string ClassName { get; set; }
        public int ClassStrength { get; set; }

        public void DisplayClassInfo()
        {
            Console.WriteLine($"Class: {ClassName}, Strength: {ClassStrength}");
        }
    }

    // Base class for Teacher
    class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void DisplayTeacherInfo()
        {
            Console.WriteLine($"Teacher: {Name}, Age: {Age}");
        }
    }

    // Inherited class for SubjectTeacher
    class SubjectTeacher : Teacher
    {
        public string Subject { get; set; }

        public void DisplaySubject()
        {
            Console.WriteLine($"Subject: {Subject}");
        }
    }

    // Inherited class for ClassTeacher
    class ClassTeacher : Teacher
    {
        public string ClassHandled { get; set; }

        public void DisplayClassHandled()
        {
            Console.WriteLine($"Class Handled: {ClassHandled}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of inherited classes
            SubjectTeacher subjectTeacher = new SubjectTeacher
            {
                Name = "John Doe",
                Age = 30,
                Subject = "Math"
            };

            ClassTeacher classTeacher = new ClassTeacher
            {
                Name = "Jane Smith",
                Age = 35,
                ClassHandled = "Grade 5"
            };

            // Displaying information using methods from base and inherited classes
            subjectTeacher.DisplayTeacherInfo();
            subjectTeacher.DisplaySubject();

            classTeacher.DisplayTeacherInfo();
            classTeacher.DisplayClassHandled();

            Console.ReadLine();
        }
    }
}

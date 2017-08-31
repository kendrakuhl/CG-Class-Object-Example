using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teacher is the class... but the next three lines are me creating
            // a teacher object and assigning the properties.
            var teacher = new Teacher();
            teacher.Name = "Mrs. Butterworth";
            teacher.Email = "mrsbutterworth@myschool.com";
            teacher.Class = "3rd Grade";

            // Student is the class... but the next three lines are me creating
            // a student object and assigning the properties.
            var student = new Student();
            student.Name = "Brainy Smurf";
            student.Email = "brainysmurf@gmail.com";
            student.Grade = "3";

            // Now... I'm going to create another student object... with different values.
            var studentTwo = new Student();
            studentTwo.Name = "Smurfette";
            studentTwo.Email = "smurfette@gmail.com";
            studentTwo.Grade = "3";

            // Now. I'm going to make my two students students of Mrs. Butterworth
            teacher.Students = new Student[2];
            teacher.Students[0] = student; // Here's student one...
            teacher.Students[1] = studentTwo; // Here's student two...

            // Now I'm going to have my teacher teach the students:
            teacher.Teaches();

            // Now I'm going to have the teacher email the students:
            teacher.SendEmail(student.Email);
            teacher.SendEmail(studentTwo.Email);

            // And finally... I'm going to have my students email back my teacher:
            student.SendEmail(teacher.Email);
            studentTwo.SendEmail(teacher.Email);

            Console.ReadLine();

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public void SendEmail(string to)
        {
            // this is me sending an email to the Email property above.
            Console.WriteLine("I sent an email to " + to  + " from " + Email);
        }
    }

    // Teacher inherits from Person (that's the : Person notation below)
    public class Teacher : Person
    {
        public string Class { get; set; }
        public Student[] Students { get; set; }

        public void Teaches()
        {
            // This is where I would do the method to teach something
            var studentNames = string.Empty;

            foreach (var student in Students)
            {
                studentNames = studentNames + ", " + student.Name;
            }

            Console.WriteLine("I'm teaching: " + studentNames + " this year in Class: " + Class);
        }

    }

    // Student inherits from Person (that's the : Person notation below)
    public class Student : Person
    {
        public string Grade { get; set; }

    }
}
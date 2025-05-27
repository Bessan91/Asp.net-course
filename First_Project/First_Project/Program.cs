using System;

namespace First_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create School
            School mySchool = new School();

            // Create Teachers
            Teacher t1 = new Teacher(1, "Mr. Khaled", 40, "Math");
            Teacher t2 = new Teacher(2, "Ms. Laila", 35, "Science");

            mySchool.AddTeacher(t1);
            mySchool.AddTeacher(t2);

            // Create Courses
            Course math = new Course(101, "Mathematics", t1);
            Course science = new Course(102, "Science", t2);

            mySchool.AddCourse(math);
            mySchool.AddCourse(science);

            // Assign Courses to Teachers
            t1.AssignCourse(math);
            t2.AssignCourse(science);

            // Create Students
            Student s1 = new Student(1001, "Ahmed", 15);
            Student s2 = new Student(1002, "Sara", 14);

            mySchool.AddStudent(s1);
            mySchool.AddStudent(s2);

            // Enroll Students in Courses
            s1.EnrollInCourse(math);
            s2.EnrollInCourse(math);
            s2.EnrollInCourse(science);

            // Display All Data
            mySchool.DisplayAllTeachers();
            mySchool.DisplayAllCourses();
            mySchool.DisplayAllStudents();

            Console.ReadKey();
        }
    }
}

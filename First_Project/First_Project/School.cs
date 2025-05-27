internal class School
{
    private List<Student> Students = new List<Student>();
    private List<Teacher> Teachers = new List<Teacher>();
    private List<Course> Courses = new List<Course>();

    public void AddStudent(Student student)
    {
        Students.Add(student);
        Console.WriteLine($"Student {student.Name} added.");
    }

    public void AddTeacher(Teacher teacher)
    {
        Teachers.Add(teacher);
        Console.WriteLine($"Teacher {teacher.Name} added.");
    }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
        Console.WriteLine($"Course {course.Name} added.");
    }

    public void DisplayAllStudents()
    {
        Console.WriteLine("\n--- Students ---");
        foreach (var student in Students)
        {
            student.DisplayDetails(); // ✅ Use existing DisplayDetails
            Console.WriteLine(); // Blank line for readability
        }
    }

    public void DisplayAllTeachers()
    {
        Console.WriteLine("\n--- Teachers ---");
        foreach (var teacher in Teachers)
        {
            Console.WriteLine(teacher.GetTeacherDetails());
        }
    }

    public void DisplayAllCourses()
    {
        Console.WriteLine("\n--- Courses ---");
        foreach (var course in Courses)
        {
            course.DisplayAllCourse();
        }
    }
}

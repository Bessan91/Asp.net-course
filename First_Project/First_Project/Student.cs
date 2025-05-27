using First_Project;

internal class Student : Person
{
    private List<Course> Courses = new List<Course>();

    public Student(int id, string name, int age)
        : base(id, name, age) { }

    public void EnrollInCourse(Course course)
    {
        if (Courses.Any(c => c.Name == course.Name))
        {
            Console.WriteLine($"Already enrolled in {course.Name}.\n");
            return;
        }

        Courses.Add(course);
        Console.WriteLine($"{Name} has been enrolled in {course.Name}.\n");
    }

    public List<Course> GetEnrolledCourses()
    {
        return Courses;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails(); // Calls Person.DisplayDetails()

        Console.WriteLine("Enrolled Courses:");
        if (Courses.Count == 0)
        {
            Console.WriteLine(" - None");
        }
        else
        {
            foreach (var course in Courses)
            {
                Console.WriteLine($" - {course.Name}");
            }
        }
    }
}

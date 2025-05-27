using First_Project;
using System.Text;

internal class Teacher : Person
{
    public string Subject { get; set; }
    private List<Course> AssignedCourses = new List<Course>();

    public Teacher(int id, string name, int age, string subject)
        : base(id, name, age)
    {
        Subject = subject;
    }

    public void AssignCourse(Course course)
    {
        if (AssignedCourses.Any(c => c.Name == course.Name))
        {
            Console.WriteLine($"Course '{course.Name}' is already assigned to {Name}.\n");
            return;
        }

        AssignedCourses.Add(course);
        Console.WriteLine($"Course '{course.Name}' has been assigned to {Name}.\n");
    }

    public List<Course> GetAssignedCourses()
    {
        return AssignedCourses;
    }

    public string GetTeacherDetails()
    {
        StringBuilder details = new StringBuilder();
        details.AppendLine($"ID: {Id}");
        details.AppendLine($"Name: {Name}");
        details.AppendLine($"Age: {Age}");
        details.AppendLine($"Subject: {Subject}");
        details.AppendLine("Assigned Courses:");

        if (AssignedCourses.Count == 0)
        {
            details.AppendLine(" - None");
        }
        else
        {
            foreach (var course in AssignedCourses)
            {
                details.AppendLine($" - {course.Name}");
            }
        }

        return details.ToString();
    }
}

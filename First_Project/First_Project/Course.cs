internal class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Teacher AssignedTeacher { get; set; }

    public Course(int id, string name, Teacher assignedTeacher = null)
    {
        Id = id;
        Name = name;
        AssignedTeacher = assignedTeacher;
    }

    public void DisplayAllCourse()
    {
        Console.WriteLine(GetCourseDetails());
    }

    public string GetCourseDetails()
    {
        string teacherInfo = AssignedTeacher != null
            ? $"{AssignedTeacher.Name} (ID: {AssignedTeacher.Id})"
            : "No teacher assigned";

        return $"Course ID: {Id}\nCourse Name: {Name}\nAssigned Teacher: {teacherInfo}\n";
    }
}

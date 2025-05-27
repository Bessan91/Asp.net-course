internal class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public DateTime AdmissionDate { get; private set; }

    protected const string SchoolName = "Palestine School";

    public Person(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
        AdmissionDate = DateTime.Now; // Sets admission date on object creation
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}");
        Console.WriteLine($"Admitted On: {AdmissionDate.ToShortDateString()}");
        Console.WriteLine($"School: {SchoolName}");
    }
}

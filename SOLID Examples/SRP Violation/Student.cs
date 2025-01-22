namespace SOLID_Examples.SRP_Violation_Example;

public class Student
{
    public string Name { get; set; }
    private Dictionary<string, double> CoursesAndGrades = new Dictionary<string, double>();
    public void EnrollCourse(string courseName)
    {
        CoursesAndGrades[courseName] = 0; // default grade
    }
    public void AssignGrade(string courseName, double grade)
    {
        if (CoursesAndGrades.ContainsKey(courseName))
        {
            CoursesAndGrades[courseName] = grade;
        }
    }
    public double CalculateGPA()
    {
        // Basic GPA calculation logic
        return CoursesAndGrades.Values.Average();
    }
    public void PrintTranscript()
    {
        Console.WriteLine($"Transcript for {Name}");
        foreach (var course in CoursesAndGrades)
        {
            Console.WriteLine($"{course.Key}: {course.Value}");
        }
        Console.WriteLine($"GPA: {CalculateGPA()}");
    }
}
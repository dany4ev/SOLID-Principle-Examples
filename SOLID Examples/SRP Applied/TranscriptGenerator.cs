namespace SOLID_Examples.SRP_Applied_Example;

public class TranscriptGenerator
{
    private GPACalculator _gpaCalculator;
    public TranscriptGenerator(GPACalculator gpaCalculator)
    {
        _gpaCalculator = gpaCalculator;
    }
    public void PrintTranscript(Student student)
    {
        Console.WriteLine($"Transcript for {student.Name}");
        foreach (var course in student.CoursesAndGrades)
        {
            Console.WriteLine($"{course.Key}: {course.Value}");
        }
        Console.WriteLine($"GPA: {_gpaCalculator.CalculateGPA(student)}");
    }
}
namespace SOLID_Examples.SRP_Applied_Example;

public class GPACalculator
{
    public double CalculateGPA(Student student)
    {
        // Basic GPA calculation logic
        return student.CoursesAndGrades.Values.Average();
    }
}
namespace SOLID_Examples.SRP_Applied_Example;

public class Student
{
    public string Name { get; set; }
    public Dictionary<string, double> CoursesAndGrades = new Dictionary<string, double>();
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
}
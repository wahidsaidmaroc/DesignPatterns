namespace Singleton._01_Logger.After.Services;


public class StudentService
{
    public void CreateStudent(string fullName)
    {
        Logger.Instance.Log(
            nameof(StudentService),
            $"Student '{fullName}' created");
    }
}

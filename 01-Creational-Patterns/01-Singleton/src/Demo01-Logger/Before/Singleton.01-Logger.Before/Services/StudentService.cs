namespace Singleton._01_Logger.Before.Services;

public class StudentService
{
    private readonly Logger _logger =
        new Logger();

    public void CreateStudent()
    {
        _logger.Log("Student Created");
    }
}
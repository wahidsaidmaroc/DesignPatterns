namespace Singleton._01_Logger.Before.Services;

public class CourseService
{
    private readonly Logger _logger =
        new Logger();

    public void CreateCourse()
    {
        _logger.Log("Course Created");
    }
}
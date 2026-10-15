using Singleton._01_Logger.After;
using Singleton._01_Logger.After.Services;




StudentService studentService =
    new StudentService();

CourseService courseService =
    new CourseService();

CertificationService certificationService =
    new CertificationService();

studentService.CreateStudent(
    "Said WAHID");

courseService.CreateCourse(
    "Design Patterns with .NET");

certificationService.IssueCertificate(
    "Said WAHID",
    "Design Patterns with .NET");

Console.WriteLine();
Console.WriteLine(
    "Verifying Singleton instance...");
Console.WriteLine();

var logger1 = Logger.Instance;
var logger2 = Logger.Instance;
var logger3 = Logger.Instance;

Console.WriteLine(
    $"Logger 1 HashCode : {logger1.GetHashCode()}");

Console.WriteLine(
    $"Logger 2 HashCode : {logger2.GetHashCode()}");

Console.WriteLine(
    $"Logger 3 HashCode : {logger3.GetHashCode()}");

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine(
    $"Same Instance logger 1 and 2: " +
    $"{ReferenceEquals(logger1, logger2)}");

Console.WriteLine(
    $"Same Instance logger 2 and 3: " +
    $"{ReferenceEquals(logger2, logger3)}");

Console.ReadKey();
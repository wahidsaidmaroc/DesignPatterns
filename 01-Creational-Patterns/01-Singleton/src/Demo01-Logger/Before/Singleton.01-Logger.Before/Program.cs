using Singleton._01_Logger.Before.Services;

StudentService studentService =
    new StudentService();

CourseService courseService =
    new CourseService();

CertificationService certificationService =
    new CertificationService();

studentService.CreateStudent();
courseService.CreateCourse();
certificationService.CreateCertification();

Console.Read();
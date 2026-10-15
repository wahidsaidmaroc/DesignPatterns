using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton._01_Logger.After.Services;

public class CourseService
{
    public void CreateCourse(string courseName)
    {
        Logger.Instance.Log(
            nameof(CourseService),
            $"Course '{courseName}' created");
    }
}


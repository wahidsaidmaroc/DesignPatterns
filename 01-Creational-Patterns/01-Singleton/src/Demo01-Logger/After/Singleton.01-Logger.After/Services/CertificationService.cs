using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton._01_Logger.After.Services;

public class CertificationService
{
    public void IssueCertificate(
        string studentName,
        string courseName)
    {
        Logger.Instance.Log(
            nameof(CertificationService),
            $"Certificate issued to '{studentName}' for '{courseName}'");
    }
}
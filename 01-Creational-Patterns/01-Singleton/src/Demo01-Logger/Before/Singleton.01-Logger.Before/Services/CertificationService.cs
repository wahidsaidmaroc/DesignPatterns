namespace Singleton._01_Logger.Before.Services;

public class CertificationService
{
    private readonly Logger _logger =
        new Logger();

    public void CreateCertification()
    {
        _logger.Log(
            "Certification Created");
    }
}
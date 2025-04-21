
namespace DP_Singleton;

public class ClientService
{
    /// Singleton instance
    public ClientService()
    {
        
        if (ClientService == null)
        {
            ClientService = this;
        }
        else
        {
            throw new Exception("Singleton instance already exists.");
        }
    }
}

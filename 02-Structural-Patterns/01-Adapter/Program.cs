IPaymentProcessor processor = new OldPaymentAdapter(new OldPaymentService());
processor.Pay(25m);

public interface IPaymentProcessor
{
    void Pay(decimal amount);
}

public sealed class OldPaymentService
{
    public void MakePayment(double total) =>
        Console.WriteLine($"Ancien service : paiement de {total:F2} EUR.");
}

public sealed class OldPaymentAdapter(OldPaymentService service) : IPaymentProcessor
{
    public void Pay(decimal amount) => service.MakePayment((double)amount);
}

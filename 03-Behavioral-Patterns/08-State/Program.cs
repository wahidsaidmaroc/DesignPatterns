var order = new Order();
order.Ship();
order.Deliver();
order.Deliver();

public interface IOrderState
{
    void Ship(Order order);
    void Deliver(Order order);
}

public sealed class Order
{
    private IOrderState _state = new NewOrderState();

    public void SetState(IOrderState state) => _state = state;
    public void Ship() => _state.Ship(this);
    public void Deliver() => _state.Deliver(this);
}

public sealed class NewOrderState : IOrderState
{
    public void Ship(Order order)
    {
        Console.WriteLine("Commande expédiée.");
        order.SetState(new ShippedOrderState());
    }

    public void Deliver(Order order) => Console.WriteLine("La commande doit d'abord être expédiée.");
}

public sealed class ShippedOrderState : IOrderState
{
    public void Ship(Order order) => Console.WriteLine("La commande est déjà expédiée.");

    public void Deliver(Order order)
    {
        Console.WriteLine("Commande livrée.");
        order.SetState(new DeliveredOrderState());
    }
}

public sealed class DeliveredOrderState : IOrderState
{
    public void Ship(Order order) => Console.WriteLine("Impossible : la commande est livrée.");
    public void Deliver(Order order) => Console.WriteLine("La commande est déjà livrée.");
}

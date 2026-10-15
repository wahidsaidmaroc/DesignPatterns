using DesignPattern.Builder.Order.Models;

namespace DesignPattern.Builder.Order.Builders;

public class OrderBuilder
{
    private readonly Models.Order _order = new();

    public OrderBuilder SetClient(string client)
    {
        _order.Client = client;
        Console.WriteLine($"→ Client : {client}");
        // this permet de poursuivre la construction de la même commande.
        return this;
    }

    public OrderBuilder AddProduct(string name, int quantity)
    {
        _order.Products.Add(new OrderItem { Name = name, Quantity = quantity });
        Console.WriteLine($"→ Product : {name} x {quantity}");
        return this;
    }

    public OrderBuilder SetDelivery(string deliveryType)
    {
        _order.DeliveryType = deliveryType;
        Console.WriteLine($"→ DeliveryType : {deliveryType}");
        return this;
    }

    public OrderBuilder SetPayment(string paymentMethod)
    {
        _order.PaymentMethod = paymentMethod;
        Console.WriteLine($"→ PaymentMethod : {paymentMethod}");
        return this;
    }

    public OrderBuilder SetDiscount(decimal discount)
    {
        _order.Discount = discount;
        Console.WriteLine($"→ Discount : {discount} %");
        return this;
    }

    public OrderBuilder SetDeliveryAddress(string deliveryAddress)
    {
        _order.DeliveryAddress = deliveryAddress;
        Console.WriteLine($"→ DeliveryAddress : {deliveryAddress}");
        return this;
    }

    // Un Builder par objet : Build retourne l'instance préparée.
    public Models.Order Build()
    {
        Console.WriteLine("→ Build()");
        return _order;
    }
}

namespace DesignPattern.Builder.Order.Models;

public class Order
{
    public string Client { get; internal set; } = string.Empty;
    public List<OrderItem> Products { get; } = new();
    public string DeliveryType { get; internal set; } = string.Empty;
    public string PaymentMethod { get; internal set; } = string.Empty;
    public decimal Discount { get; internal set; }
    public string DeliveryAddress { get; internal set; } = string.Empty;

    public override string ToString()
    {
        var products = Products.Count == 0
            ? "    Aucun produit"
            : string.Join(Environment.NewLine, Products.Select(product => $"    - {product.Name} x {product.Quantity}"));

        return $"""
            Commande :
              Client : {Client}
              Products :
            {products}
              DeliveryType : {DeliveryType}
              PaymentMethod : {PaymentMethod}
              Discount : {Discount} %
              DeliveryAddress : {DeliveryAddress}
            """;
    }
}

// Une ligne de commande associe un produit à sa quantité.
public class OrderItem
{
    public string Name { get; init; } = string.Empty;
    public int Quantity { get; init; }
}

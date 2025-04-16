using System;

public abstract class Document
{
    public string DocumentNumber { get; set; }
    public DateTime Date { get; set; }

    public Document(string documentNumber, DateTime date)
    {
        DocumentNumber = documentNumber;
        Date = date;
    }

    public abstract Document Clone();
}

public class Order : Document
{
    public string OrderDetails { get; set; }

    public Order(string documentNumber, DateTime date, string orderDetails)
        : base(documentNumber, date)
    {
        OrderDetails = orderDetails;
    }

    public override Document Clone()
    {
        return new Order(DocumentNumber, Date, OrderDetails);
    }
}

public class Invoice : Document
{
    public decimal Amount { get; set; }

    public Invoice(string documentNumber, DateTime date, decimal amount)
        : base(documentNumber, date)
    {
        Amount = amount;
    }

    public override Document Clone()
    {
        return new Invoice(DocumentNumber, Date, Amount);
    }
}

public class DeliveryNote : Document
{
    public string DeliveryDetails { get; set; }

    public DeliveryNote(string documentNumber, DateTime date, string deliveryDetails)
        : base(documentNumber, date)
    {
        DeliveryDetails = deliveryDetails;
    }

    public override Document Clone()
    {
        return new DeliveryNote(DocumentNumber, Date, DeliveryDetails);
    }
}

class Program
{
    static void Main()
    {
        Order originalOrder = new Order("ORD123", DateTime.Now, "Order details here");
        Order clonedOrder = (Order)originalOrder.Clone();

        Invoice originalInvoice = new Invoice("INV123", DateTime.Now, 1500.00m);
        Invoice clonedInvoice = (Invoice)originalInvoice.Clone();

        DeliveryNote originalDeliveryNote = new DeliveryNote("DLV123", DateTime.Now, "Delivery details here");
        DeliveryNote clonedDeliveryNote = (DeliveryNote)originalDeliveryNote.Clone();

        Console.WriteLine($"Order - Number: {clonedOrder.DocumentNumber}, Date: {clonedOrder.Date}, Details: {clonedOrder.OrderDetails}");
        Console.WriteLine($"Invoice - Number: {clonedInvoice.DocumentNumber}, Date: {clonedInvoice.Date}, Amount: {clonedInvoice.Amount}");
        Console.WriteLine($"Delivery Note - Number: {clonedDeliveryNote.DocumentNumber}, Date: {clonedDeliveryNote.Date}, Details: {clonedDeliveryNote.DeliveryDetails}");
    }
}

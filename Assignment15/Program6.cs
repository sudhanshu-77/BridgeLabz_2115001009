using System;

class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }

    public Order(int orderId, DateTime orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }

    public virtual string GetOrderStatus()
    {
        return "Order placed";
    }
}

class ShippedOrder : Order
{
    public string TrackingNumber { get; set; }

    public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }

    public override string GetOrderStatus()
    {
        return "Order shipped";
    }
}

class DeliveredOrder : ShippedOrder
{
    public DateTime DeliveryDate { get; set; }

    public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }

    public override string GetOrderStatus()
    {
        return "Order delivered";
    }
}

class MainOrder
{
    static void Main(string[] args)
    {
        Order order = new Order(1, DateTime.Now);
        ShippedOrder shippedOrder = new ShippedOrder(2, DateTime.Now, "TRACK123");
        DeliveredOrder deliveredOrder = new DeliveredOrder(3, DateTime.Now, "TRACK456", DateTime.Now.AddDays(3));

        Console.WriteLine(order.GetOrderStatus());
        Console.WriteLine(shippedOrder.GetOrderStatus());
        Console.WriteLine(deliveredOrder.GetOrderStatus());
    }
}

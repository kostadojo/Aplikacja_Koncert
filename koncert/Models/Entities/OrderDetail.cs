namespace koncert.Models.Entities;

public class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int Amount { get; set; }

    public decimal Price { get; set; }

    public int ConcertId { get; set; }

    public Concert Concert { get; set; } = default!;

    public int OrderId { get; set; }

    public Order Order { get; set; } = default!;
}
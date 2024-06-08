namespace koncert.Models.Entities;

    public class ShoppingCartItem
    {
    public int ShoppingCartItemId { get; set; }
    public Concert concert { get; set; } = default!;
    public int Amount { get; set; }
    public string? ShoppingCartId { get; set; }
    }


// Models/ConfirmPurchaseViewModel.cs
using TigerTix.Web.Models;

public class ConfirmPurchaseViewModel
{
    public required Event Event { get; set; }
    public int TicketQuantity { get; set; }
    public decimal TotalPrice { get; set; }
    public bool IsStudent { get; set; }
}

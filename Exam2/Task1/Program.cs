
    struct Ticket
{
    public int TicketNumber { get; set; }
    public int Price { get; set; }

    public Ticket(int ticketNumber, int price)
    {
        TicketNumber = ticketNumber;
        Price = price;
    }
}
    

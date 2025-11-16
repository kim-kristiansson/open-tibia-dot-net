namespace OpenTibiaDotNet.Domain.Entities.Game;

public class House
{
    public int Id { get; set; }

    public int Owner { get; set; }
    public int Paid { get; set; }
    public int Warnings { get; set; }

    public string Name { get; set; } = string.Empty;
    public int Rent { get; set; }
    public int TownId { get; set; }
    public Town? Town { get; set; }

    public int Bid { get; set; }
    public int BidEnd { get; set; }
    public int LastBid { get; set; }
    public int HighestBidder { get; set; }

    public int Size { get; set; }
    public int Beds { get; set; }

    public ICollection<HouseList> Lists { get; set; } = new List<HouseList>();
    public TileStore? TileStore { get; set; }
}
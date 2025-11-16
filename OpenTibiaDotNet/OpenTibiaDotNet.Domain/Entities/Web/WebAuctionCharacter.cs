namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebAuctionCharacter
{
    public int Id { get; set; }
    public int PlayerId { get; set; }
    public int OriginalAccountId { get; set; }
    public int BidderAccountId { get; set; }

    public int TimeBegin { get; set; }
    public int TimeEnd { get; set; }

    public int Price { get; set; }
    public int Bid { get; set; }
    public int Deposit { get; set; }

    public bool Sold { get; set; }
    public bool Claimed { get; set; }
}
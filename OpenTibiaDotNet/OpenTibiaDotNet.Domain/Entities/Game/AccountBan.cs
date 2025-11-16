namespace OpenTibiaDotNet.Domain.Entities.Game;

public class AccountBan
{
    public int AccountId { get; set; }
    public Account? Account { get; set; }

    public string Reason { get; set; } = string.Empty;
    public long BannedAt { get; set; }
    public long ExpiresAt { get; set; }

    public int BannedById { get; set; }
    public Player? BannedBy { get; set; }
}
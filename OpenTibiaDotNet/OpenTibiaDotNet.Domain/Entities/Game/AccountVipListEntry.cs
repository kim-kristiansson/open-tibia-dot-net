namespace OpenTibiaDotNet.Domain.Entities.Game;

public class AccountVipListEntry
{
    public int AccountId { get; set; }
    public Account? Account { get; set; }

    public int PlayerId { get; set; }
    public Player? Player { get; set; }

    public string Description { get; set; } = string.Empty;
    public byte Icon { get; set; }
    public bool Notify { get; set; }
}
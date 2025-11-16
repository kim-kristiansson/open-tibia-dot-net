namespace OpenTibiaDotNet.Domain.Entities.Game;

public class Account
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty; 
    public string? Secret { get; set; }
    public int Type { get; set; } = 1;
    public int PremiumEndsAt { get; set; }
    public string Email { get; set; } = string.Empty;
    public int Creation { get; set; }

    public ICollection<Player> Players { get; set; } = new List<Player>();
    public AccountBan? Ban { get; set; }
    public ICollection<AccountBanHistory> BanHistory { get; set; } = new List<AccountBanHistory>();
    public ICollection<AccountStorage> Storage { get; set; } = new List<AccountStorage>();
    public ICollection<AccountVipListEntry> VipList { get; set; } = new List<AccountVipListEntry>();
}
namespace OpenTibiaDotNet.Domain.Entities.Game;

public class PlayerNameLock
{
    public int PlayerId { get; set; }
    public Player? Player { get; set; }

    public string Reason { get; set; } = string.Empty;
    public long NameLockedAt { get; set; }

    public int NameLockedById { get; set; }
    public Player? NameLockedBy { get; set; }
}
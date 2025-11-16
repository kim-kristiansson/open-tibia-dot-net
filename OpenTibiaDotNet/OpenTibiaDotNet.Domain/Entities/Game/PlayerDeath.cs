namespace OpenTibiaDotNet.Domain.Entities.Game;

public class PlayerDeath
{
    public int PlayerId { get; set; }
    public Player? Player { get; set; }

    public ulong Time { get; set; }
    public int Level { get; set; }
    public string KilledBy { get; set; } = string.Empty;
    public bool IsPlayer { get; set; }

    public string MostDamageBy { get; set; } = string.Empty;
    public bool MostDamageIsPlayer { get; set; }

    public bool Unjustified { get; set; }
    public bool MostDamageUnjustified { get; set; }
}
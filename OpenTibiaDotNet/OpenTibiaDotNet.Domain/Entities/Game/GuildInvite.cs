namespace OpenTibiaDotNet.Domain.Entities.Game;

public class GuildInvite
{
    public int PlayerId { get; set; }
    public Player? Player { get; set; }

    public int GuildId { get; set; }
    public Guild? Guild { get; set; }
}

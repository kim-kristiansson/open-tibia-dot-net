namespace OpenTibiaDotNet.Domain.Entities.Game;

public class GuildMembership
{
    public int PlayerId { get; set; }
    public Player? Player { get; set; }

    public int GuildId { get; set; }
    public Guild? Guild { get; set; }

    public int RankId { get; set; }
    public GuildRank? Rank { get; set; }

    public string Nick { get; set; } = string.Empty;
}

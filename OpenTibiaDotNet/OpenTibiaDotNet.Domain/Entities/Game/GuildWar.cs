namespace OpenTibiaDotNet.Domain.Entities.Game;

public class GuildWar
{
    public int Id { get; set; }

    public int Guild1Id { get; set; }
    public int Guild2Id { get; set; }

    public string Name1 { get; set; } = string.Empty;
    public string Name2 { get; set; } = string.Empty;

    public int Status { get; set; }
    public long Started { get; set; }
    public long Ended { get; set; }

    public ICollection<GuildWarKill> Kills { get; set; } = new List<GuildWarKill>();
}
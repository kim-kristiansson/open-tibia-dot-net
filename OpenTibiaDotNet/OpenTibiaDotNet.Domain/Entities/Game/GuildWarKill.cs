namespace OpenTibiaDotNet.Domain.Entities.Game;

public class GuildWarKill
{
    public int Id { get; set; }

    public string Killer { get; set; } = string.Empty;
    public string Target { get; set; } = string.Empty;

    public int KillerGuildId { get; set; }
    public int TargetGuildId { get; set; }

    public int WarId { get; set; }
    public GuildWar? War { get; set; }

    public long Time { get; set; }
}
namespace OpenTibiaDotNet.Domain.Entities.Game;

public class GuildRank
{
    public int Id { get; set; }

    public int GuildId { get; set; }
    public Guild? Guild { get; set; }

    public string Name { get; set; } = string.Empty;
    public int Level { get; set; }
}
namespace OpenTibiaDotNet.Domain.Entities.Game;

public class Guild
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public int OwnerId { get; set; }
    public Player? Owner { get; set; }

    public int CreationData { get; set; }
    public string Motd { get; set; } = string.Empty;

    public ICollection<GuildRank> Ranks { get; set; } = new List<GuildRank>();
    public ICollection<GuildMembership> Members { get; set; } = new List<GuildMembership>();
}
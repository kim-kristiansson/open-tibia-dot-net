namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebForumBoard
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public byte Access { get; set; }
    public byte Closed { get; set; }
    public byte Hidden { get; set; }

    public int GuildId { get; set; }
}
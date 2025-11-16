namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebForumThread
{
    public int Id { get; set; }
    public int ForumId { get; set; }

    public int PlayerId { get; set; }
    public string PlayerName { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;

    public int Created { get; set; }
    public int Updated { get; set; }

    public byte Sticky { get; set; }
    public byte Hidden { get; set; }
    public byte Closed { get; set; }
}
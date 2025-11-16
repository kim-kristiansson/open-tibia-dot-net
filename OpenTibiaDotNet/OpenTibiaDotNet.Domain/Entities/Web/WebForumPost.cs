namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebForumPost
{
    public int Id { get; set; }
    public int ThreadId { get; set; }

    public int PlayerId { get; set; }
    public string PlayerName { get; set; } = string.Empty;

    public string Text { get; set; } = string.Empty;
    public int Created { get; set; }
    public int Updated { get; set; }
}
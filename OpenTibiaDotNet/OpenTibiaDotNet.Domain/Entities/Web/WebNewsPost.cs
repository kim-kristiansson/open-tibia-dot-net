namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebNewsPost
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public int Date { get; set; } // unix timestamp
    public int PlayerId { get; set; } // pid (usually author)
}
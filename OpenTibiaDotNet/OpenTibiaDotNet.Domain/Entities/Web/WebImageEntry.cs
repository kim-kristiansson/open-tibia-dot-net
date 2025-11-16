namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebImageEntry
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Date { get; set; }
    public int Status { get; set; }      // 0/1 etc
    public string Image { get; set; } = string.Empty;   // filename
    public string DeleteHash { get; set; } = string.Empty;
    public int AccountId { get; set; }
}
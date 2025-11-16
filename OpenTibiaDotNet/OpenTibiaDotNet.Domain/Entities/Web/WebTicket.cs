namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebTicket
{
    public int Id { get; set; }
    public int Owner { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public long Ip { get; set; }

    public int Creation { get; set; }
    public string Status { get; set; } = string.Empty;
}
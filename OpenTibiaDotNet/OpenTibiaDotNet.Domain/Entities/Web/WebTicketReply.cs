namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebTicketReply
{
    public int Id { get; set; }
    public int TicketId { get; set; } 
    public string Username { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public int Created { get; set; }
}
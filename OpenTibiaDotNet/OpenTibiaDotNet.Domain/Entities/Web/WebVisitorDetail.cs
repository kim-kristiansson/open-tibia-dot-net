namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebVisitorDetail
{
    public int Id { get; set; }
    public long Ip { get; set; }
    public int Time { get; set; }
    public byte Type { get; set; }
    public int AccountId { get; set; }
}
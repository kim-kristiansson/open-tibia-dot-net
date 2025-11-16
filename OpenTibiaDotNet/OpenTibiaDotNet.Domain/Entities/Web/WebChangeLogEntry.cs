namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebChangeLogEntry
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public int Time { get; set; }
    public int ReportId { get; set; }
    public byte Status { get; set; }
}
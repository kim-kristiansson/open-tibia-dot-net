namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebPlayerReport
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public int PosX { get; set; }
    public int PosY { get; set; }
    public int PosZ { get; set; }

    public string Description { get; set; } = string.Empty;
    public int Date { get; set; }
    public byte Status { get; set; } // 0 = open, etc.
}
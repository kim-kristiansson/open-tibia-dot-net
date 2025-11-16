namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebMeta
{
    public int Id { get; set; }
    public string Version { get; set; } = string.Empty; 
    public int Installed { get; set; }
    public int? Cached { get; set; }
}
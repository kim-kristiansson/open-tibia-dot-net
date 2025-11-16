namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebDeletedCharacter
{
    public int Id { get; set; }
    public int OriginalAccountId { get; set; }
    public string CharacterName { get; set; } = string.Empty;
    public DateTime Time { get; set; }
    public bool Done { get; set; }
}
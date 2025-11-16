namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebPlayerInfo
{
    public int Id { get; set; }          // row id
    public int PlayerId { get; set; }    // points to players.id i game DB
    public int Created { get; set; }
    public bool HideCharacter { get; set; }
    public string Comment { get; set; } = string.Empty;
}
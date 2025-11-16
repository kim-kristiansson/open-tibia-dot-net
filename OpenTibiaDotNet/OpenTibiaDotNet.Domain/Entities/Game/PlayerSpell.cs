namespace OpenTibiaDotNet.Domain.Entities.Game;

public class PlayerSpell
{
    public int PlayerId { get; set; }
    public Player? Player { get; set; }

    public string Name { get; set; } = string.Empty;
}
namespace OpenTibiaDotNet.Domain.Entities.Game;

public class Town
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public int PosX { get; set; }
    public int PosY { get; set; }
    public int PosZ { get; set; }

    public ICollection<Player> Players { get; set; } = new List<Player>();
    public ICollection<House> Houses { get; set; } = new List<House>();
}
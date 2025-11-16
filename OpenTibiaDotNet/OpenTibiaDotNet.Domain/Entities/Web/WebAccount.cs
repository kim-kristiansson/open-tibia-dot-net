namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebAccount
{
    public int Id { get; set; }              // row id
    public int AccountId { get; set; }       // points to accounts.id in game DB
    public ulong Ip { get; set; }
    public int Created { get; set; }
    public int Points { get; set; }
    public int Cooldown { get; set; }
    public bool Active { get; set; }
    public bool ActiveEmail { get; set; }
    public int ActiveKey { get; set; }
    public string Flag { get; set; } = string.Empty;
    public string? Secret { get; set; }
}
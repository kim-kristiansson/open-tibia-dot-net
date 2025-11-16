namespace OpenTibiaDotNet.Domain.Entities.Game;

public class AccountStorage
{
    public int AccountId { get; set; }
    public Account? Account { get; set; }

    public uint Key { get; set; }
    public int Value { get; set; }
}
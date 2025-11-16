namespace OpenTibiaDotNet.Domain.Entities.Game;

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public int GroupId { get; set; } = 1;
    public int AccountId { get; set; }
    public Account? Account { get; set; }

    public int Level { get; set; } = 1;
    public int Vocation { get; set; }
    public int Health { get; set; } = 150;
    public int HealthMax { get; set; } = 150;
    public long Experience { get; set; }

    public int LookBody { get; set; }
    public int LookFeet { get; set; }
    public int LookHead { get; set; }
    public int LookLegs { get; set; }
    public int LookType { get; set; } = 136;
    public int LookAddons { get; set; }

    public byte Direction { get; set; } = 2;

    public int MagicLevel { get; set; }
    public int Mana { get; set; }
    public int ManaMax { get; set; }
    public long ManaSpent { get; set; }
    public uint Soul { get; set; }

    public int TownId { get; set; } = 1;
    public Town? Town { get; set; }

    public int PosX { get; set; }
    public int PosY { get; set; }
    public int PosZ { get; set; }

    public byte[]? Conditions { get; set; }

    public int Cap { get; set; } = 400;
    public int Sex { get; set; }

    public long LastLogin { get; set; }
    public uint LastIp { get; set; }
    public bool Save { get; set; } = true;

    public int Skull { get; set; }
    public long SkullTime { get; set; }

    public long LastLogout { get; set; }
    public int Blessings { get; set; }

    public long OnlineTime { get; set; }
    public long Deletion { get; set; }

    public ulong Balance { get; set; }

    public ushort OfflineTrainingTime { get; set; } = 43200;
    public int OfflineTrainingSkill { get; set; } = -1;

    public ushort Stamina { get; set; } = 2520;

    public uint SkillFist { get; set; } = 10;
    public ulong SkillFistTries { get; set; }

    public uint SkillClub { get; set; } = 10;
    public ulong SkillClubTries { get; set; }

    public uint SkillSword { get; set; } = 10;
    public ulong SkillSwordTries { get; set; }

    public uint SkillAxe { get; set; } = 10;
    public ulong SkillAxeTries { get; set; }

    public uint SkillDistance { get; set; } = 10;
    public ulong SkillDistanceTries { get; set; }

    public uint SkillShielding { get; set; } = 10;
    public ulong SkillShieldingTries { get; set; }

    public uint SkillFishing { get; set; } = 10;
    public ulong SkillFishingTries { get; set; }

    public ICollection<PlayerDeath> Deaths { get; set; } = new List<PlayerDeath>();
    public ICollection<PlayerItem> Items { get; set; } = new List<PlayerItem>();
    public ICollection<PlayerSpell> Spells { get; set; } = new List<PlayerSpell>();
    public ICollection<PlayerStorage> Storage { get; set; } = new List<PlayerStorage>();
    public ICollection<MarketHistory> MarketHistory { get; set; } = new List<MarketHistory>();
    public ICollection<MarketOffer> MarketOffers { get; set; } = new List<MarketOffer>();

    public GuildMembership? GuildMembership { get; set; }
}
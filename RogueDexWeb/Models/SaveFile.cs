using System.Text.Json.Serialization;

namespace RogueDexWeb.Models
{
    public class SaveFile
    {
        [JsonPropertyName("secretId")]
        public int SecretId { get; set; }

        [JsonPropertyName("trainerId")]
        public int TrainerId { get; set; }

        [JsonPropertyName("achvUnlocks")]
        public Dictionary<string, long> AchievementUnlocks { get; set; } = [];

        [JsonPropertyName("dexData")]
        public Dictionary<int, DexData> DexData { get; set; } = [];

        [JsonPropertyName("starterData")]
        public Dictionary<int, StarterData> StarterData { get; set; } = [];

        [JsonPropertyName("voucherUnlocks")]
        public Dictionary<string, long> VoucherUnlocks { get; set; } = [];

        [JsonPropertyName("gameStats")]
        public GameStats GameStats { get; set; } = new();

        [JsonPropertyName("unlockPity")]
        public int[] UnlockPity { get; set; } = [];

        [JsonPropertyName("eggPity")]
        public int[] EggPity { get; set; } = [];

        [JsonPropertyName("eggs")]
        public EggData[] Eggs { get; set; } = [];

        [JsonPropertyName("unlocks")]
        public Dictionary<string, bool> Unlocks { get; set; } = [];

        [JsonPropertyName("voucherCounts")]
        public Dictionary<string, int> VoucherCounts { get; set; } = [];

        [JsonPropertyName("gameVersion")]
        public string GameVersion { get; set; } = string.Empty;

        [JsonPropertyName("gender")]
        public Gender Gender { get; set; }

        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }
    }

    public enum Gender
    {
        Male = 0,
        Female = 1,
    }

    public class DexData
    {
        [JsonPropertyName("$sa")]
        [JsonConverter(typeof(DexAttrConverter))]
        public DexAttr SeenAttr { get; set; }

        [JsonPropertyName("$ca")]
        [JsonConverter(typeof(DexAttrConverter))]
        public DexAttr CaughtAttr { get; set; }

        [JsonPropertyName("$na")]
        public NatureAttr NatureAttr { get; set; }

        [JsonPropertyName("$s")]
        public int SeenCount { get; set; }

        [JsonPropertyName("$c")]
        public int CaughtCount { get; set; }

        [JsonPropertyName("$hc")]
        public int HatchedCount { get; set; }

        [JsonPropertyName("$i")]
        public int[] IVs { get; set; } = [];

        [JsonPropertyName("ribbons")]
        public string HexStringRibbons { get; set; } = string.Empty;
    }

    public enum DexAttr : long
    {
        NonShiny = 1 << 0,
        Shiny = 1 << 1,
        Male = 1 << 2,
        Female = 1 << 3,
        DefaultVariant = 1 << 4,
        Variant2 = 1 << 5,
        Variant3 = 1 << 6,
        DefaultForm = 1 << 7,
    }

    public enum Nature
    {
        Hardy = 0,
        Lonely = 1,
        Brave = 2,
        Adamant = 3,
        Naughty = 4,
        Bold = 5,
        Docile = 6,
        Relaxed = 7,
        Impish = 8,
        Lax = 9,
        Timid = 10,
        Hasty = 11,
        Serious = 12,
        Jolly = 13,
        Naive = 14,
        Modest = 15,
        Mild = 16,
        Quiet = 17,
        Bashful = 18,
        Rash = 19,
        Calm = 20,
        Gentle = 21,
        Sassy = 22,
        Careful = 23,
        Quirky = 24,
    }

    public enum NatureAttr : long
    {
        Hardy = 1 << Nature.Hardy,
        Lonely = 1 << Nature.Lonely,
        Brave = 1 << Nature.Brave,
        Adamant = 1 << Nature.Adamant,
        Naughty = 1 << Nature.Naughty,
        Bold = 1 << Nature.Bold,
        Docile = 1 << Nature.Docile,
        Relaxed = 1 << Nature.Relaxed,
        Impish = 1 << Nature.Impish,
        Lax = 1 << Nature.Lax,
        Timid = 1 << Nature.Timid,
        Hasty = 1 << Nature.Hasty,
        Serious = 1 << Nature.Serious,
        Jolly = 1 << Nature.Jolly,
        Naive = 1 << Nature.Naive,
        Modest = 1 << Nature.Modest,
        Mild = 1 << Nature.Mild,
        Quiet = 1 << Nature.Quiet,
        Bashful = 1 << Nature.Bashful,
        Rash = 1 << Nature.Rash,
        Calm = 1 << Nature.Calm,
        Gentle = 1 << Nature.Gentle,
        Sassy = 1 << Nature.Sassy,
        Careful = 1 << Nature.Careful,
        Quirky = 1 << Nature.Quirky,
    }

    public class StarterData
    {
        [JsonPropertyName("$a")]
        public AbilityAttr AbilityAttr { get; set; }

        [JsonPropertyName("$pa")]
        public PassiveAttr PassiveAttr { get; set; }

        [JsonPropertyName("$vr")]
        public int ValueReduction { get; set; }

        [JsonPropertyName("$em")]
        public EggMoveAttr EggMoves { get; set; }

        [JsonPropertyName("$x")]
        public int CandyCount { get; set; }

        [JsonPropertyName("$f")]
        public int Friendship { get; set; }

        [JsonPropertyName("$wc")]
        public int ClassicWinCount { get; set; }

        [JsonPropertyName("$m")]
        public object? Moveset { get; set; }
    }

    public enum AbilityAttr : long
    {
        First = 1 << 0,
        Second = 1 << 1,
        Hidden = 1 << 2,
    }

    public enum PassiveAttr : long
    {
        Unlocked = 1 << 0,
        Enabled = 1 << 1,
    }

    public enum EggMove
    {
        First = 0,
        Second = 1,
        Third = 2,
        Rare = 3,
    }

    public enum EggMoveAttr : long
    {
        First = 1 << EggMove.First,
        Second = 1 << EggMove.Second,
        Third = 1 << EggMove.Third,
        Rare = 1 << EggMove.Rare,
    }

    public class GameStats
    {
        [JsonPropertyName("battles")]
        public int Battles { get; set; }

        [JsonPropertyName("classicSessionsPlayed")]
        public int ClassicSessionsPlayed { get; set; }

        [JsonPropertyName("dailyRunSessionsPlayed")]
        public int DailyRunSessionsPlayed { get; set; }

        [JsonPropertyName("dailyRunSessionsWon")]
        public int DailyRunSessionsWon { get; set; }

        [JsonPropertyName("eggsPulled")]
        public int EggsPulled { get; set; }

        [JsonPropertyName("endlessSessionsPlayed")]
        public int EndlessSessionsPlayed { get; set; }

        [JsonPropertyName("epicEggsPulled")]
        public int EpicEggsPulled { get; set; }

        [JsonPropertyName("highestDamage")]
        public int HighestDamage { get; set; }

        [JsonPropertyName("highestEndlessWave")]
        public int HighestEndlessWave { get; set; }

        [JsonPropertyName("highestHeal")]
        public int HighestHeal { get; set; }

        [JsonPropertyName("highestLevel")]
        public int HighestLevel { get; set; }

        [JsonPropertyName("highestMoney")]
        public long HighestMoney { get; set; }

        [JsonPropertyName("legendaryEggsPulled")]
        public int LegendaryEggsPulled { get; set; }

        [JsonPropertyName("legendaryPokemonCaught")]
        public int LegendaryPokemonCaught { get; set; }

        [JsonPropertyName("legendaryPokemonHatched")]
        public int LegendaryPokemonHatched { get; set; }

        [JsonPropertyName("legendaryPokemonSeen")]
        public int LegendaryPokemonSeen { get; set; }

        [JsonPropertyName("manaphyEggsPulled")]
        public int ManaphyEggsPulled { get; set; }

        [JsonPropertyName("mythicalPokemonCaught")]
        public int MythicalPokemonCaught { get; set; }

        [JsonPropertyName("mythicalPokemonHatched")]
        public int MythicalPokemonHatched { get; set; }

        [JsonPropertyName("mythicalPokemonSeen")]
        public int MythicalPokemonSeen { get; set; }

        [JsonPropertyName("playTime")]
        public int PlayTime { get; set; }

        [JsonPropertyName("pokemonCaught")]
        public int PokemonCaught { get; set; }

        [JsonPropertyName("pokemonDefeated")]
        public int PokemonDefeated { get; set; }

        [JsonPropertyName("pokemonFused")]
        public int PokemonFused { get; set; }

        [JsonPropertyName("pokemonHatched")]
        public int PokemonHatched { get; set; }

        [JsonPropertyName("pokemonSeen")]
        public int PokemonSeen { get; set; }

        [JsonPropertyName("rareEggsPulled")]
        public int RareEggsPulled { get; set; }

        [JsonPropertyName("hatchWaves")]
        public int RibbonsOwned { get; set; }

        [JsonPropertyName("sessionsWon")]
        public int SessionsWon { get; set; }

        [JsonPropertyName("shinyPokemonCaught")]
        public int ShinyPokemonCaught { get; set; }

        [JsonPropertyName("shinyPokemonHatched")]
        public int ShinyPokemonHatched { get; set; }

        [JsonPropertyName("shinyPokemonSeen")]
        public int ShinyPokemonSeen { get; set; }

        [JsonPropertyName("subLegendaryPokemonCaught")]
        public int SubLegendaryPokemonCaught { get; set; }

        [JsonPropertyName("subLegendaryPokemonHatched")]
        public int SubLegendaryPokemonHatched { get; set; }

        [JsonPropertyName("subLegendaryPokemonSeen")]
        public int SubLegendaryPokemonSeen { get; set; }

        [JsonPropertyName("trainersDefeated")]
        public int TrainersDefeated { get; set; }

    }

    public class EggData
    {
        [JsonPropertyName("eggMoveIndex")]
        public EggMove EggMoveIndex { get; set; }

        [JsonPropertyName("hatchWaves")]
        public int HatchWaves { get; set; }

        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("isShiny")]
        public bool IsShiny { get; set; }

        [JsonPropertyName("overrideHiddenAbility")]
        public bool OverrideHiddenAbility { get; set; }

        [JsonPropertyName("sourceType")]
        public EggSourceType EggSourceType { get; set; }

        [JsonPropertyName("species")]
        public int SpeciesID { get; set; }

        [JsonPropertyName("tier")]
        public EggTier Tier { get; set; }

        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }

        [JsonPropertyName("variantTier")]
        public VariantTier VariantTier { get; set; }
    }

    public enum EggSourceType
    {
        GachaMove = 0,
        GachaLegendary = 1,
        GachaShiny = 2,
        SameSpeciesEgg = 3,
        Event = 4,
    }

    public enum EggTier
    {
        Common = 0,
        Rare = 1,
        Epic = 2,
        Legendary = 3,
    }

    public enum VariantTier
    {
        Standard = 0,
        Rare = 1,
        Epic = 2,
    }
}

using RogueDexWeb.Models.Sheet;

namespace RogueDexWeb.Models
{
    public class FullDexData
    {
        public FullDexData()
        {
        }

        public FullDexData(DexData dexData, StarterData starterData, Species species)
        {
            DexNr = species.DexNr;
            Species = species;
            SeenAttr = dexData.SeenAttr;
            CaughtAttr = dexData.CaughtAttr;
            NatureAttr = dexData.NatureAttr;
            EggMoves = starterData.EggMoves;
            AbilityAttr = starterData.AbilityAttr;
            PassiveAttr = starterData.PassiveAttr;
            IVs = dexData.IVs;
            SeenCount = dexData.SeenCount;
            CaughtCount = dexData.CaughtCount;
            HatchedCount = dexData.HatchedCount;
            CandyCount = starterData.CandyCount;
            Friendship = starterData.Friendship;
            ValueReduction = starterData.ValueReduction;
            ClassicWins = starterData.ClassicWinCount;
            HexStringRibbons = dexData.HexStringRibbons;
        }

        public int DexNr { get; set; }
        public Species Species { get; set; } = new();
        public DexAttr SeenAttr { get; set; }
        public DexAttr CaughtAttr { get; set; }
        public NatureAttr NatureAttr { get; set; }
        public EggMoveAttr EggMoves { get; set; }
        public AbilityAttr AbilityAttr { get; set; }
        public PassiveAttr PassiveAttr { get; set; }
        public int[] IVs { get; set; } = [];
        public int SeenCount { get; set; }
        public int CaughtCount { get; set; }
        public int HatchedCount { get; set; }
        public int CandyCount { get; set; }
        public int Friendship { get; set; }
        public int ValueReduction { get; set; }
        public int ClassicWins { get; set; }
        public string HexStringRibbons { get; set; } = string.Empty;
    }

    public class Species
    {
        public Species()
        {
        }

        public Species(SheetPokemon sheetData, SheetPokemon starterSheetData)
        {
            Name = sheetData.SheetName;
            FullName = sheetData.FullName;
            CleanName = sheetData.CleanName;
            Region = Helper.GetRegion(CleanName);
            DexNr = sheetData.DexNr;
            StarterDexNr = starterSheetData.DexNr;
            StarterFullName = starterSheetData.FullName;
            StarterCost = starterSheetData.StarterCost.GetValueOrDefault();
            Generation = sheetData.Generation.GetValueOrDefault();
            SubLegendary = sheetData.SubLegendary;
            Legendary = sheetData.Legendary;
            Mythical = sheetData.Mythical;
            SpeciesType = sheetData.SpeciesType;
            Type1 = sheetData.Type1;
            Type2 = sheetData.Type2;
            Height = sheetData.Height;
            Weight = sheetData.Weight;
            Ability1 = sheetData.Ability1;
            Ability2 = sheetData.Ability2;
            HiddenAbility = sheetData.HiddenAbility;
            BST = sheetData.BST;
            HP = sheetData.HP;
            ATK = sheetData.ATK;
            DEF = sheetData.DEF;
            SPATK = sheetData.SPATK;
            SPDEF = sheetData.SPDEF;
            SPEED = sheetData.SPEED;
            CatchRate = sheetData.CatchRate;
            BaseFriendship = sheetData.BaseFriendship;
            BaseExp = sheetData.BaseExp;
            GrowthRate = sheetData.GrowthRate;
            HasVariants = sheetData.HasVariants;

            if (double.TryParse(sheetData.MaleChance, out var maleChance))
            {
                MaleChance = maleChance;
                Genderless = false;
                Male = MaleChance > 0;
                Female = MaleChance < 100;
            }
            else
            {
                MaleChance = 0;
                Genderless = true;
                Male = false;
                Female = false;
            }
        }

        public string Name { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string CleanName { get; set; } = string.Empty;
        public int DexNr { get; set; }
        public int StarterDexNr { get; set; }
        public string StarterFullName { get; set; } = string.Empty;
        public int StarterCost { get; set; }
        public int Generation { get; set; }
        public bool SubLegendary { get; set; }
        public bool Legendary { get; set; }
        public bool Mythical { get; set; }
        public string SpeciesType { get; set; } = string.Empty;
        public string Type1 { get; set; } = string.Empty;
        public string Type2 { get; set; } = string.Empty;
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Ability1 { get; set; } = string.Empty;
        public string Ability2 { get; set; } = string.Empty;
        public string HiddenAbility { get; set; } = string.Empty;
        public int BST { get; set; }
        public int HP { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        public int SPATK { get; set; }
        public int SPDEF { get; set; }
        public int SPEED { get; set; }
        public int CatchRate { get; set; }
        public int BaseFriendship { get; set; }
        public int BaseExp { get; set; }
        public string GrowthRate { get; set; } = string.Empty;
        public double MaleChance { get; set; }
        public bool Genderless { get; set; }
        public bool Male { get; set; }
        public bool Female { get; set; }
        public bool HasVariants { get; set; }
    }
}

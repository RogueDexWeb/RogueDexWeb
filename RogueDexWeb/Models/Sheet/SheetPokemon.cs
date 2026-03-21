using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace RogueDexWeb.Models.Sheet
{
    public class SheetPokemon
    {
        [JsonPropertyName("Full Name")]
        public string FullName { get; set; } = string.Empty;

        [JsonPropertyName("Sheet Name")]
        public string SheetName { get; set; } = string.Empty;

        [JsonPropertyName("Form Name")]
        public string FormName { get; set; } = string.Empty;

        [JsonPropertyName("Gen")]
        public string GenerationString { get; set; } = string.Empty;

        [JsonIgnore]
        public int? Generation
        {
            get
            {
                if (int.TryParse(GenerationString, out var cost))
                {
                    return cost;
                }

                return null;
            }
        }

        [JsonPropertyName("SubLegendary")]
        public string SubLegendaryString { get; set; } = string.Empty;

        [JsonIgnore]
        public bool SubLegendary 
        {
            get
            {
                return SubLegendaryString == "TRUE";
            }
        }

        [JsonPropertyName("Legendary")]
        public string LegendaryString { get; set; } = string.Empty;

        [JsonIgnore]
        public bool Legendary
        {
            get
            {
                return LegendaryString == "TRUE";
            }
        }

        [JsonPropertyName("Mythical")]
        public string MythicalString { get; set; } = string.Empty;
        
        [JsonIgnore]
        public bool Mythical
        {
            get
            {
                return MythicalString == "TRUE";
            }
        }

        [JsonPropertyName("Species")]
        public string SpeciesType { get; set; } = string.Empty;

        [JsonPropertyName("Type 1")]
        public string Type1 { get; set; } = string.Empty;

        [JsonPropertyName("Type 2")]
        public string Type2 { get; set; } = string.Empty;

        [JsonPropertyName("Height (m)")]
        public double Height { get; set; }

        [JsonPropertyName("Weight (kg)")]
        public double Weight { get; set; }

        [JsonPropertyName("Ability 1")]
        public string Ability1 { get; set; } = string.Empty;

        [JsonPropertyName("Ability 2")]
        public string Ability2 { get; set; } = string.Empty;

        [JsonPropertyName("Hidden Ability")]
        public string HiddenAbility { get; set; } = string.Empty;

        [JsonPropertyName("BST")]
        public int BST { get; set; }

        [JsonPropertyName("HP")]
        public int HP { get; set; }

        [JsonPropertyName("ATK")]
        public int ATK { get; set; }

        [JsonPropertyName("DEF")]
        public int DEF { get; set; }

        [JsonPropertyName("SP. ATK")]
        public int SPATK { get; set; }

        [JsonPropertyName("SP. DEF")]
        public int SPDEF { get; set; }

        [JsonPropertyName("SPD")]
        public int SPEED { get; set; }

        [JsonPropertyName("catchRate")]
        public int CatchRate { get; set; }

        [JsonPropertyName("baseFriendship")]
        public int BaseFriendship { get; set; }

        [JsonPropertyName("baseExp")]
        public int BaseExp { get; set; }

        [JsonPropertyName("growthRate")]
        public string GrowthRate { get; set; } = string.Empty;

        [JsonPropertyName("MALE%")]
        public string MaleChance { get; set; } = string.Empty;

        [JsonPropertyName("Clean Name")]
        public string CleanName { get; set; } = string.Empty;

        [JsonPropertyName("Starter")]
        public string StarterName { get; set; } = string.Empty;

        [JsonPropertyName("hasVariants")]
        public string HasVariantsString { get; set; } = string.Empty;

        [JsonIgnore]
        public bool HasVariants
        {
            get
            {
                return HasVariantsString == "TRUE";
            }
        }

        [JsonPropertyName("dex #")]
        public int DexNr { get; set; }

        [JsonPropertyName("starterCost")]
        public string StarterCostString { get; set; } = string.Empty;

        [JsonIgnore]
        public int? StarterCost
        {
            get
            {
                if (int.TryParse(StarterCostString, out var cost))
                {
                    return cost;
                }

                return null;
            }
        }

        [JsonPropertyName("starterDex")]
        public int StarterDexNr { get; set; }
    }
}

namespace RogueDexWeb.Models
{
    public static class Helper
    {
        public static string GetRegion(string cleanName)
        {
            if (cleanName.StartsWith("Alola "))
            {
                return "Alola";
            }
            else if (cleanName.StartsWith("Galar "))
            {
                return "Galar";
            }
            else if (cleanName.StartsWith("Hisui "))
            {
                return "Hisui";
            }
            else if (cleanName.StartsWith("Paldea "))
            {
                return "Paldea";
            }

            return string.Empty;
        }
    }
}

using System.Text.Json;
using System.Text.Json.Serialization;

namespace RogueDexWeb.Models
{
    public class DexAttrConverter : JsonConverter<DexAttr>
    {
        public override DexAttr Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                if (long.TryParse(reader.GetString(), out long result))
                {
                    return (DexAttr)result;
                }

                return 0;
            }

            return (DexAttr)reader.GetInt64();
        }

        public override void Write(
            Utf8JsonWriter writer,
            DexAttr dexAttr,
            JsonSerializerOptions options) 
        {
            writer.WriteStringValue(dexAttr.ToString());
        }
    }
}

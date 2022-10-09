using System.Text.Json.Serialization;

namespace first_project.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,

        Mage = 2,

        Cleric = 3,

        Wizzard = 4,
    }
}
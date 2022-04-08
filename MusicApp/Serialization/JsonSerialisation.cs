using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MusicApp.Serialization;

public class JsonSerialisation
{
    private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
        ContractResolver = new JsonContractResolver(),
        NullValueHandling = NullValueHandling.Ignore
    };

    public static string SerializeObject(object o)
    {
        return JsonConvert.SerializeObject(o, Formatting.Indented, Settings);
    }

    public sealed class JsonContractResolver : CamelCasePropertyNamesContractResolver
    {
    }
}
namespace Ubicacion;
using System.Text.Json.Serialization;

public class PosicionGeo
{

    [JsonPropertyName ("lat")]
    public double Lat
    {
        get; set;
    }
    
    [JsonPropertyName ("lng")]
        public double Lng
    {
        get; set;
    }
}
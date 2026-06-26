namespace InfoEmpresa;
using System.Text.Json.Serialization;
public class Empresa
{
    [JsonPropertyName ("name")]
    public string? Nombre
    {
        get; set;
    }

    [JsonPropertyName ("catchPhrase")]
    public string? CathPhrase
    {
        get; set;
    }

    [JsonPropertyName ("bs")]
    public string? Bs
    {
        get; set;
    }
}
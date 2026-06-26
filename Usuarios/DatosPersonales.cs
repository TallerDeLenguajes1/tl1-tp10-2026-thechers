namespace InfoPersonal;
using System.Text.Json.Serialization;

public class DatosPersonales
{

    [JsonPropertyName ("street")]
  public string? Direccion
    {
        get; set;
    }

    [JsonPropertyName ("suite")]
  public string? Suite
    {
        get; set;
    }     

[JsonPropertyName ("city")]
   public string? Ciudad
    {
        get; set;
    }

[JsonPropertyName ("zipcode")]
   public string? CodigoPostal
    {
        get; set;
    }



}
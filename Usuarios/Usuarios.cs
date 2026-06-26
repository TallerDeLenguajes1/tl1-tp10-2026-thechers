namespace InfoUsuarios;
using InfoPersonal;
using InfoEmpresa;
using Ubicacion;
using System.Text.Json.Serialization;


public class Usuarios
{
   [JsonPropertyName("id")]
   public int Id
    {
        get;set;

    }
    [JsonPropertyName("name")]
   public string? Nombre
    {
        get;set;
        
    }

    [JsonPropertyName("username")]
   public string? Usuario
    {
        get;set;
        
    }

    [JsonPropertyName("email")]
   public string? Email
    {
        get;set;
        
    }

    [JsonPropertyName("address")]
    public DatosPersonales? Info
    {
        get; set;
    }

    [JsonPropertyName("phone")]
    public string? Telefono
    {
        get; set;
    }

    [JsonPropertyName("website")]
    public string? SitioWeb
    {
        get; set;
    }

    [JsonPropertyName("company")]
     public Empresa? InfoEmpresa
    {
        get; set;
    }

}
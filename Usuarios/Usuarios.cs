namespace InfoUsuarios;
using InfoPersonal;
using InfoEmpresa;
using Ubicacion;


public class Usuarios
{

   public int Id
    {
        get;set;

    }

   public string? Nombre
    {
        get;set;
        
    }

   public string? Usuario
    {
        get;set;
        
    }

   public string? Email
    {
        get;set;
        
    }

    public DatosPersonales? Info
    {
        get; set;
    }

    public string? Telefono
    {
        get; set;
    }

    public string? SitioWeb
    {
        get; set;
    }

     public Empresa? InfoEmpresa
    {
        get; set;
    }

}
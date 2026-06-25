using System.Runtime.CompilerServices;
using System.Text.Json;
namespace ConsultasWeb;


public class ConsultasGenericas{

    private static readonly HttpClient cliente = new();

    public static async Task<T> getResponse<T>(string url)
    {
        HttpResponseMessage respuesta = await cliente.GetAsync(url);

        respuesta.EnsureSuccessStatusCode();

        string leerRespuesta = await respuesta.Content.ReadAsStringAsync();

        T ?lista = JsonSerializer.Deserialize<T>(leerRespuesta);

        
        return lista;

    }



}

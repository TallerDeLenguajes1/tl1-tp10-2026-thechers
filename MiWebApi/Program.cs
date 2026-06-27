using Contador;
using System.Text.Json;

string url = "https://api.agify.io/?name=meelad";

HttpClient cliente = new();

HttpResponseMessage respuesta = await cliente.GetAsync(url);

respuesta.EnsureSuccessStatusCode();

string respuestaTraducida = await respuesta.Content.ReadAsStringAsync();

var opciones = new JsonSerializerOptions {PropertyNameCaseInsensitive = true};

InfoContador nuevaPalabra = JsonSerializer.Deserialize<InfoContador>(respuestaTraducida, opciones);

Console.WriteLine(nuevaPalabra.Count);
Console.WriteLine(nuevaPalabra.Name);
Console.WriteLine(nuevaPalabra.Age);



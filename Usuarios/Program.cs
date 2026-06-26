using System.Text.Json;
using InfoUsuarios;


string url = "https://jsonplaceholder.typicode.com/users/";

HttpClient cliente = new();

HttpResponseMessage respuesta =  await cliente.GetAsync(url);

respuesta.EnsureSuccessStatusCode();

string leerRespuesta = await respuesta.Content.ReadAsStringAsync();

List<Usuarios> infoUsuarios = JsonSerializer.Deserialize<List<Usuarios>>(leerRespuesta);

for (int i = 0; i < 5; i++)
{
   Console.WriteLine($"Nombre usuario: {infoUsuarios[i].Nombre}\nCorreo: {infoUsuarios[i].Email}\n");
   Console.WriteLine($"Domicilio: {infoUsuarios[i].Info.Direccion},{infoUsuarios[i].Info.Suite},{infoUsuarios[i].Info.Ciudad}"); 
}

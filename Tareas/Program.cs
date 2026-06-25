using Tareas;
using ConsultasWeb;
using System.Text.Json;
using System.Text;

string url = "https://jsonplaceholder.typicode.com/todos/";

List<Tarea> tareas = await ConsultasGenericas.getResponse<List<Tarea>>(url);


/*foreach (var tarea in tareas)
{
    Console.WriteLine($"{tarea.UserId}, {tarea.Id}, {tarea.Title}, {tarea.Completed}");
}*/

foreach (var tarea in tareas)
{
    if (tarea.Completed == false)
    {
        Console.WriteLine($"{tarea.Title} {tarea.Completed}");
    }
}

foreach (var tarea in tareas)
{
    if (tarea.Completed == true)
    {
        Console.WriteLine($"{tarea.Title} {tarea.Completed}");
    }
}



string lista = JsonSerializer.Serialize(tareas);

File.WriteAllText("../tareas.json",lista);


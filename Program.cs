List<string> planViernes = new List<string>();

planViernes.Add("Ir al templo a las 7am");
planViernes.Add("Esperar en la puerta");
planViernes.Add("Ver a Raquel llegar");
planViernes.Add("Abrazarla");

Console.WriteLine("Plan para el viernes: ");
foreach (var tarea in planViernes)
{
    Console.WriteLine($"-{tarea}");
}
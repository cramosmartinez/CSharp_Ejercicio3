////Pedir el nombre de la semana al usuario y decirle si es fin de semana o no. En caso de error, indicarlo
Console.WriteLine("Ingrese el nombre de un día de la semana:");
string dia = Console.ReadLine().ToLower();
if (dia == "sabado" || dia == "domingo")
{
    Console.WriteLine("Es fin de semana.");
}
else if (dia == "lunes" || dia == "martes" || dia == "miercoles" || dia == "jueves" || dia == "viernes")
{
    Console.WriteLine("No es fin de semana.");
}
else
{
    Console.WriteLine("El día ingresado no es válido.");
}
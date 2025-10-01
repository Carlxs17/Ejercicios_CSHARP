string nombre;
int edad;

Console.WriteLine("Ingrese su nombre");
nombre = Console.ReadLine();
Console.WriteLine("Ingrese su edad");
edad = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Su nombre es {nombre} y su edad es {edad}");
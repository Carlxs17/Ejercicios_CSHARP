Console.WriteLine("Factorial de un numero cualquiera!");

Console.WriteLine("1 Para Recursividad");

Console.WriteLine("2 Para Iterativo");

int valor = 0;
valor = Convert.ToInt32(Console.ReadLine());

if (valor == 1)
{
    int n = 0;
    Console.WriteLine("Ingrese un valor");
    n = Convert.ToInt32(Console.ReadLine());

    int resultado = Factorial(n);
    Console.WriteLine($"El factorial de {n} es {resultado}");
    //Aqui se usa Recursividad
}
else if (valor == 2)
{
    int val = 0;
    Console.WriteLine("Ingrese un valor");
    val = Convert.ToInt32(Console.ReadLine());
    int resultado = 1;
    for (int i = 1; i <= val; i++)
    {
        resultado = resultado * i;
    }
    Console.WriteLine($"El factorial de {val} es : {resultado}");

}
else
{
    Console.WriteLine("Ingrese un valor correcto");
}



static int Factorial(int num)
{
    if (num == 1)
    {
        return 1;
    }
    else
    {
        return num * Factorial(num - 1);

    }

}
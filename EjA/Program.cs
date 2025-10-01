int val = 0;
Console.WriteLine("Ingrese un valor");
val = Convert.ToInt32(Console.ReadLine());

Contar(val);




static void Contar(int num)
{
    if (num == 0)
    {
        return;
    }
    else
    {
        Console.WriteLine(num);
        Contar(num - 1);
    }


}
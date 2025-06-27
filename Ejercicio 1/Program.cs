
int x;
string buff;
bool EsEntero;
int aux;
int invertido = 0;
do
{
    Console.WriteLine("Elegir un numero mayor a 0 para invertir:");
    buff = Console.ReadLine();
    EsEntero = int.TryParse(buff, out x);
    if (EsEntero)
    {
        Console.WriteLine($"El numero ingresado es : {x}");
    }
    else
    {
        Console.WriteLine("No se pudo convertir a numero lo ingresado\n");
        Console.WriteLine("Ingrese otro numero Entero mayor a 0.");
    }
}
while (!EsEntero || x <= 0);

while (x != 0)
{
    aux = x % 10;
    invertido = (invertido * 10) + aux;
    x = x / 10;
}
    Console.WriteLine(invertido);

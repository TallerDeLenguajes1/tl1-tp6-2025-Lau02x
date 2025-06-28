/*Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo*/
string texto;
int eleccion=0;
float num1=0;
float num2 = 0;
float resultado;
float numsolitario = 0;
int parteEntera = 0;
do
{
    do
    {

    Console.WriteLine("ELIJA un Numero:");
        texto = Console.ReadLine();
        if (!float.TryParse(texto, out numsolitario))
        {
            Console.WriteLine("La cadena es un texto, intentar de nuevo");
        }
    } while (!float.TryParse(texto, out numsolitario));

        parteEntera = (int) numsolitario;
        Console.WriteLine($"Valor Absoluto del Numero:{Math.Abs(numsolitario)}");
        Console.WriteLine($"El cuadrado del numero es: {Math.Pow(numsolitario,2)}");
        Console.WriteLine($"La raiz cuadrada del numero es: {Math.Sqrt(numsolitario)}");
        Console.WriteLine($"El seno del numero es: {Math.Sin(numsolitario)}");
        Console.WriteLine($"El coseno del numero es: {Math.Cos(numsolitario)}");
        Console.WriteLine($"La parte entera del numero float es: {parteEntera}");

        
    do
    {
        Console.WriteLine("---Menu---");
        Console.WriteLine("Elegir una operacion para realizar: \n 1:Sumar \n 2:Restar \n 3:Multiplicar\n4:Dividir\n5:Valor Absoluto\n6:Cuadrado\n7:Raiz Cuadrada\n8:Seno\n9:Coseno\n10:Parte entera de un float");
        texto = Console.ReadLine();
        eleccion = int.Parse(texto);
    } while (eleccion <= 0 || eleccion > 4);

    Console.WriteLine("Elegir primer numero :");
    texto = Console.ReadLine();
    num1 = float.Parse(texto);
    if (eleccion == 4)
    {
        do
        {
            Console.WriteLine("Elegir segundo numero distinto de 0 :");
            texto = Console.ReadLine();
            num2 = float.Parse(texto);
        } while (num2 == 0);
    }
    else
    {
        Console.WriteLine("Elegir segundo numero:");
        texto = Console.ReadLine();
        num2 = float.Parse(texto);
    }

    switch (eleccion)
    {

    }

    switch (eleccion)
    {
        case 1:
            resultado = num1 + num2;
            Console.WriteLine($"Suma entre {num1} y {num2} es : {resultado}");
            break;
        case 2:
            resultado = num1 - num2;
            Console.WriteLine($"resta entre {num1} y {num2} es: {resultado}");
            break;
        case 3:
            resultado = num1 * num2;
            Console.WriteLine($"multiplicacion entre {num1} y {num2} es: {resultado}");
            break;
        case 4:
            resultado = num1 / num2;
            Console.WriteLine($"division entre {num1} y {num2} es: {resultado}");
            break;

        default:
            break;
    }

    Console.WriteLine("Desea seguir operando? 1:Seguir, 0:salir");
    texto = Console.ReadLine();
    eleccion = int.Parse(texto);
} while (eleccion != 0);
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
Console.WriteLine("---Menu---");
Console.WriteLine("Elegir una operacion para realizar: \n 1:Sumar \n 2:Restar \n 3:Multiplicar\n4:Dividir");
texto =Console.ReadLine();
eleccion =int.Parse(texto);
Console.WriteLine("Elegir primer numero :");
texto = Console.ReadLine();
num1 = float.Parse(texto);
do
{
    Console.WriteLine("Elegir segundo numero distinto de 0 :");
    texto = Console.ReadLine();
    num2 = float.Parse(texto);
} while (eleccion == 0);

switch (eleccion)
{
    case 1:
        Console.WriteLine($"Suma entre {num1} y {num2}");
        resultado= num1 + num2;
        break;
    case 2: 
            Console.WriteLine($"resta entre {num1} y {num2}");
            resultado = num1 - num2;
            break;
    case 3: 
            Console.WriteLine($"multiplicar entre {num1} y {num2}");
            resultado = num1 * num2;
            break;            
    case 4: 
            Console.WriteLine($"division entre {num1} y {num2}");
            resultado = num1 / num2;
            break;
    default:
}
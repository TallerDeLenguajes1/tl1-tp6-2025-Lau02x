// See https://aka.ms/new-console-template for more information


string texto1;
string texto2;
string textoconcatenado;
Console.WriteLine("Dar una cadena de texto:");
texto1 =Console.ReadLine();
int longitud = texto1.Length;
Console.WriteLine("La longitud del texto es de: " + longitud);

Console.WriteLine("Dar otra cadena de texto para concatenar con la anterior:");
texto2 = Console.ReadLine();
textoconcatenado = string.Concat(texto1, texto2);
Console.WriteLine(textoconcatenado);
Console.WriteLine("Muestro la subcadena desde el indice 7 del texto concatenado : ");
Console.WriteLine(textoconcatenado.Substring(7));

foreach (var c in textoconcatenado)
{
    Console.WriteLine(c);
    
}
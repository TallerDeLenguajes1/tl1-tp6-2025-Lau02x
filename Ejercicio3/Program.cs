// See https://aka.ms/new-console-template for more information


string texto1;
string texto2;
string textoconcatenado;
int posicion;
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
Console.WriteLine("Buscar una palabra en el texto concatenado: ");
string buscar = Console.ReadLine();
posicion = textoconcatenado.IndexOf(buscar);
if (posicion >= 0)
{
    Console.WriteLine($"La palabra '{buscar}' se encuentra en la posicion {posicion}");

}
else
{
    Console.WriteLine($"La palabra '{buscar}' no se encuentra en el texto concatenado");
 }
Console.WriteLine("Escribo en mayuscula y minuscula la cadena concatenada: ");
Console.WriteLine(textoconcatenado.ToUpper());
Console.WriteLine(textoconcatenado.ToLower());
Console.WriteLine("Escribir una cadena separada por un separador que elija para mostrar sus palabras individuales:");
string textoSeparado = Console.ReadLine();
foreach (var c in textoSeparado.Split(';'))
{
    Console.WriteLine(c);
}


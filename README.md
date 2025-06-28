
# ¿String es una tipo por valor o un tipo por referencia?
-String es un tipo por referencias
# ¿Qué secuencias de escape tiene el tipo string?
- Nueva línea (salto de línea).
- \r: Retorno de carro.
- \t: Tabulación horizontal.
- \\: Barra invertida literal.
- \": Comilla doble literal.
- \': Comilla simple literal.
- \b: Retroceso (backspace).
- \f: Avance de página.
- \a: Alerta (campana).
- \v: Tabulación vertical.
- \0: Carácter nulo.
- \xHH: Carácter hexadecimal (donde HH son dos dígitos hexadecimales).
- \uHHHH: Carácter Unicode (donde HHHH son cuatro dígitos hexadecimales).
- @"": Cadena textual (evita el uso de secuencias de escape, excepto "" para la comilla doble). 
# ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
- En C#, los caracteres @ y $ se utilizan para modificar el comportamiento de las cadenas de texto, también conocidas como string literals. El carácter @ indica una cadena textual, mientras que el carácter $ indica interpolación de cadenas. Ambos pueden usarse juntos para crear cadenas textuales interpoladas. 

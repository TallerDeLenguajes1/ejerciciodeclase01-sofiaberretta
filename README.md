## Problema 01
Nombre del error encontrado: System.IndexOutOfRangeException

Mensaje: Index was outside the bounds of the array.

Este error se origina debido a que se intenta acceder a un elemento de un arreglo o de una colección con un índice que está fuera de los límites.

Para solucionar este error se agrega un try catch en el bucle for, entonces cuando intenta acceder a dicho indice del arreglo, sale un mensaje indicando el error.

## Problema 02
Nombre del error encontrado: System.OverflowException

Mensaje: Value was either too large or too small for an unsigned byte.

Este error se produce cuando una operación genera un resultado que desborda los límites del tipo de dato, en este caso un byte.

Para evitarlo se agrega un try catch interrumpiendo la operacion y mostrando el respectivo mensaje del error.

## Problema 03
Nombre del error encontrado: System.NullReferenceException

Mensaje: Object reference not set to an instance of an object.

Se indica cuando se intenta obtener acceso a un miembro en un tipo cuyo valor es null.

Como solucion se agrega un try catch en el momento en el que se imprime por pantalla los datos de los autos, para que en el caso que estos se encuentren vacios, imprima un mensaje de aviso.

## Problema 04
Nombre del error encontrado: System.FormatException

Mensaje: Index (zero based) must be greater than or equal to zero and less than the size of the argument list.

Se produce cuando el formato de un argumento no es válido o cuando una cadena de formato compuesto no tiene el formato correcto.

En este caso se debe a que al imprimir por consola los numeros, se le indica que debe escribir tres valores pero se le pasan solo dos como argumento. Se lo soluciona con un try catch mostrando el error.

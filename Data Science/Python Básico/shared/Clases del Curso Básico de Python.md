# Clases del Curso Básico de Python

# Python

Python es un lenguaje de programación **interpretado** cuya filosofía hace hincapié en la **legibilidad de su código**. Se trata de un lenguaje de programación **multiparadigma**, ya que soporta parcialmente la **orientación a objetos**, **programación imperativa** y, en menor medida, **programación funcional**. Es un lenguaje interpretado, **dinámico** y multiplataforma.

### ¿Qué es un algoritmo?

En matemáticas, lógica, **ciencias de la computación** y disciplinas relacionadas, un algoritmo es un **conjunto de instrucciones** o reglas definidas y **no-ambiguas**, **ordenadas** y **finitas** que permite, típicamente, **solucionar un problema**, realizar un cómputo, procesar datos y llevar a cabo otras tareas o **actividades**

## Manejo de la consola

- **CD**: CD (**Change Directory**) sirve para **mostrar el nombre** del directorio actual y, también, permite **cambiar de directorio**.

[Parámetros](Clases%20del%20Curso%20Ba%CC%81sico%20de%20Python%2070b5b28354fb439d82a74d63b5f09464/Para%CC%81metros%20e4ecbeaf6cff4e84802034dfdaeac144.csv)

- **MKDIR:** Para crear un directorio se puede emplear el comando **MD** (o **MKDIR**). Por ejemplo, para crear un directorio llamando **pruebas**, es posible escribir:

```powershell
mkdir pruebas
```

- **LS**: El comando ls es muy útil para **ver los archivos** y **directorios** que tenemos dentro del **directorio en el que estamos**.

```powershell
ls
```

- **Touch**: El comando touch de la **terminal** se usa principalmente para **crear archivos vacíos**

```powershell
touch pruebas.txt
```

## Operadores aritméticos

### Orden de precedencia

1. **Exponente**: `**`
2. **Negación**:`-`
3. **Multiplicación, División, División entera, Módulo**: `*`,`/`, `//`, `%`
4. **Suma, Resta**: `+`,`-`

## Variables

Una variable en  Python es una **ubicación de memoria reservada para almacenar valores**. En otras palabras, una **variable** en un programa de Python **proporciona datos a la computadora** para su **procesamiento**.

### **¿Qué es un tipo de dato?**

En programación, **un tipo de dato es el atributo que especifica al ordenador la clase de dato que tiene que manejar**, para saber qué valores puede tomar y qué operaciones realizar. Los tipos de datos primitivos o elementales más comunes en los lenguajes de programación son los siguientes:

- **Números enteros** (y con signo negativo)
- **Números en coma flotante** (decimales)
- **Caracteres** (alfanuméricos)
- **Cadenas de caracteres** (textos)
- **Estados lógicos** (booleanos)

## función input()

La función input() permite **obtener texto escrito** por teclado. Al llegar a la función, el programa se detiene **esperando** que se escriba algo y se pulse la tecla **Intro**, como muestra el siguiente ejemplo:

```python
print("¿Cómo se llama?")
nombre = input()
```

## función int()

 La función int() **convierte** el valor especificado en un **número entero.**

```python
>>> x = int(3.9)
3
```

## función str()

La función str() convierte el valor especificado en una cadena de caracteres.

```python
>>> x = str(3.9)
'3.9'
```

## Operadores lógicos y de comparación

Se utiliza un **operador lógico** para tomar una decisión basada en **múltiples condiciones**. Los **operadores lógicos** utilizados en **Python** son `and`, `or` y `not`.

[Operadores Lógicos](Clases%20del%20Curso%20Ba%CC%81sico%20de%20Python%2070b5b28354fb439d82a74d63b5f09464/Operadores%20Lo%CC%81gicos%202dc816d166fc42d282aa2245ecf7292e.csv)

Los **operadores de comparación** se utilizan, como su nombre indica, para **comparar dos o más valores**. El resultado de estos operadores siempre es `True` o `False`.

[Operadores de comparación](Clases%20del%20Curso%20Ba%CC%81sico%20de%20Python%2070b5b28354fb439d82a74d63b5f09464/Operadores%20de%20comparacio%CC%81n%201ec75a3ca27941c8a6426a4a1d079a2e.csv)

## Condicionales Python

### if EXPRESION:

La **sentencia condicional `if`** se usa para tomar **decisiones**, este evalúa básicamente una **operación lógica**, es decir una expresión que de como **resultado** `True` o `False`, y **ejecuta la pieza de código** siguiente siempre y cuando el **resultado sea verdadero**.

### elif EXPRESION:

La sentencia `elif`, significa, **De lo contrario Si** se cumple la **expresión condicional** se **ejecuta el bloque de sentencias seguidas**.

### else

La sentencia `else`, significa, **De lo contrario** se cumple **sin evaluar ninguna expresión** condicional y **ejecuta el bloque de sentencias seguidas**.

<aside>
✍️ Para comentar o descomentar las líneas de código que tengamos seleccionadas, tenemos la combinación de teclas `Ctrl-k-c`, para comentar, y `Ctrl-k-u`, para descomentar.

</aside>

## Python Functions

Una **función** es un **bloque de código** que solo se **ejecuta cuando se llama**. Puede pasar datos, conocidos como **parámetros**, a una función. Una función puede **devolver datos** como resultado.

```python
def sumar(a, b):
    resultado = a + b
    return resultado
```

### Métodos para variables de tipo texto (Cadena de caracteres)

- **`name.upper()`**: El método `.upper()` devuelve una cadena donde **todos los caracteres** están en **mayúsculas**. Los símbolos y números se ignoran.
- **`name.capitalize()`**: El método `.capitalize()` devuelve una cadena donde el **primer carácter** está en **mayúsculas**.
- `name.strip()`: El método `.strip()` **elimina los caracteres iniciales** (**espacios al principio**) y finales (**espacios al final**) (el espacio es el carácter inicial predeterminado para eliminar)
- `name.lower()`: El método `.lower()` devuelve una cadena donde **todos los caracteres** son **minúsculas**. Los símbolos y números se ignoran.
- `name.replace()`: El método `.replace()` **reemplaza** una **frase especificada** con otra **frase especificada**.
    - **Nota**: Todas las apariciones de la frase especificada serán reemplazadas, si no se especifica nada más.
    
    ```python
    string.replace("oldvalue", "newvalue", 10)
    ```
    

## Función len()

La **función** `len()` devuelve el **número de elementos** de un **objeto**. Cuando el objeto es una cadena, la función `len()` devuelve el **número de caracteres** de la **cadena**.

```python
>>> mylist = "Hello"
>>> x = len(mylist)
5
```

## Función slice()

La función `slice()` devuelve un **objeto slice**. Se utiliza para **determinar** la forma de **cortar una secuencia**. Puede especificar dónde **comenzar el corte** y **dónde terminar**. También puede **especificar el paso**.

```python
a = ("a", "b", "c", "d", "e", "f", "g", "h")
x = slice(2)
print(a[x])
```

# Constantes

Una constante es un **tipo de variable** la cual **no puede ser cambiada**. Eso es muy de ayuda pensar las constantes como **contenedores** que contienen **información** el cual **no puede ser cambiado después**.

### while

Con el ciclo `while` podemos ejecutar un **conjunto de declaraciones** siempre que una **condición sea verdadera**.

```python
i = 1
while i < 6:
  print(i)
  i += 1
```

### for

Un bucle `for` se utiliza para **iterar sobre una secuencia** (que es una lista, una tupla, un diccionario, un conjunto o una cadena). Con el ciclo `for` podemos **ejecutar un conjunto de declaraciones**, una vez para **cada elemento** de una lista, tupla, conjunto, etc.

```python
fruits = ["apple", "banana", "cherry"]
for x in fruits:
  print(x)
```

## Función range()

La función `range()` devuelve una **secuencia de números**, comenzando desde 0 de forma predeterminada, se incrementa en 1 (**de forma predeterminada**) y se detiene **antes de un número especificado**.

```python
x = range(6)
for n in x:
  print(n)
```

## Interrumpir los ciclos en programación

### Break

La **palabra clave** `break` se usa para **romper** un ciclo `for` o un ciclo `while`.

```python
for i in range(1, 9):
  if i > 3:
    break
  print(i)
```

### Continue

La palabra clave **continue** se usa para **finalizar la iteración** actual en un bucle `for` (o un bucle `while`) y continúa con la **siguiente iteración**.

```python
for i in range(1, 9):
  if i == 3:
    continue
  print(i)
```

# Estructuras de datos

## Listas

Las **listas** se utilizan para **almacenar varios elementos en una sola variable**. Las listas son uno de los 4 tipos de **datos integrados** en Python que se utilizan para **almacenar colecciones de datos**, los otros 3 son **Tuplas**, **Set** y **Diccionarios**, todos con **diferentes cualidades y usos**.

### Métodos para las listas

- `**list.append(elmnt)**`: El método `.append()` agrega un **elemento** al **final de la lista**.
- `**list.extend(iterable)**`: El método `.extend()` **agrega** los **elementos de lista especificados** (o **cualquier iterable**) al **final de la lista actual**.
- `**list.insert(pos, elmnt)**`: El método `.insert()` inserta el **valor especificado** en la **posición especificada**.
- **`list.remove(elmnt)`**: El método `.remove()` **elimina la primera aparición** del elemento con el **valor especificado**.
- **`list.pop(pos)`**: El método `.pop()` **elimina el elemento** en la **posición especificada**.
- **`list.clear()`**: El método `.clear()` **elimina todos** los **elementos de una lista**.
- **`list.index(elmnt)`**: El método `.index()` devuelve la **posición en la primera aparición** del **valor especificado**.
- **`list.count(value)`**: El método `.count()` devuelve el **número de elementos** con el **valor especificado**.
- **`list.sort(reverse=True|False, key=myFunc)`**: El método `.sort()` ordena la **lista de forma ascendente** por defecto (**Diferencia entre minúsculas y mayúsculas**). También puede **crear una función** para decidir los **criterios de clasificación**.
- **`list.reverse()`**: El método `.reverse()` **invierte el orden** de **clasificación de los elementos**.
- **`list.copy()`**: El método `.copy()` **devuelve una copia** de la **lista especificada**.

## Tuplas

A pesar de que las **tuplas** puedan **parecerse a las listas**, frecuentemente se utilizan en **distintas situaciones** y para **distintos propósitos**. Las tuplas son **immutable** y normalmente contienen una **secuencia heterogénea de elementos** que son accedidos al desempaquetar o **indizar**. Las listas **son mutable**, y sus elementos son **normalmente homogéneos** y se acceden **iterando a la lista**.

```python
thistuple = ("apple", "banana", "cherry")
print(thistuple)
```

## Diccionarios

Los **diccionarios** se encuentran a veces en otros lenguajes como «**memorias asociativas**» o «**arreglos asociativos**». A diferencia de las secuencias, que se indexan mediante un rango numérico, los diccionarios se **indexan con claves**, que pueden ser **cualquier tipo inmutable**; **las cadenas** y **números** siempre pueden ser claves. Las **tuplas pueden usarse como claves** si solamente contienen **cadenas, números o tuplas**; si una tupla contiene cualquier objeto **mutable directa o indirectamente**, **no puede usarse como clave**.

```python
thisdict = {
  "brand": "Ford",
  "model": "Mustang",
  "year": 1964
}
```

### Métodos para los diccionarios

- **`dictionary.keys()`**: El método `.keys()` devuelve un **objeto de vista**. El objeto de vista **contiene las claves del diccionario**, **como una lista**.

- dictionary.values(): El método `.values()` devuelve un **objeto de vista**. El objeto de vista **contiene los valores del diccionario**, **como una lista**.
- **`dictionary.items()`**: El método `.items()` devuelve un **objeto de vista**. El objeto de vista **contiene los pares clave-valor del diccionario**, como **tuplas** en **una lista**.
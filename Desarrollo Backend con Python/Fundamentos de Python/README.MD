# Fundamentos de Python

## 1. Resumen SM 🚀
* Herramientas del curso
En el curso vamos a usar la plataforma online llamada Replit que nos permite escribir código en línea sin tener que instalarlo en nuestra computadora.

Los pasos a seguir son:

1. Entrar y registrarse.
2. Hacemos clic en el botón de Create.
3. Seleccionamos el lenguaje de programación de nuestro proyecto.
4. Le ponemos un nombre a nuestro proyecto.
5. Hacemos clic en Create Repl y ya nos crea nuestro entorno de programación.


## 2. Tu primer programa
Dentro del entorno encontraremos los archivos con la extensión .py en donde se encuentra nuestro codigo de Python a ejecutar y también encontraremos 2 archivos: poetry.lock y pyproject.toml, en los cuales se encuentran las dependencias del proyecto.

En la consola se mostrará la salida o resultado de nuestro programa.
Para imprimir utilizamos el comando print:

~~~python
Imprimir un texto:
print(“Hola mundo!”)
Imprimir el calculo de operaciones matematicas:
print(2+20)
print(50-10)
print(3*2)
print(10/5)
~~~

Para agregar comentarios que permiten documentar nuestro programa podemos hacerlos de 2 formas:

Comentario de una sola línea, agregamos un # antes de la línea a comentar
~~~python
 # Este es una operación matemática
~~~

Comentario varias lineas, agregamos el comentario entre “”” ó ‘’’

~~~python
“”” comentario mas
Largo ”””

''' Otro comentario
largo''' 
~~~


## 3. Variables
Las variables son Espacios de memoria en donde se almacenan un tipo de dato y las cuales se identifican con un nombre, para entender mejor su concepto puede compararse con una caja que almacena un tipo de objetos y que esta marcada con un nombre relacionado a lo que contiene.

* Las variables en python se declaran así:

    * **nombre_variable = [dato o valor]**

* Las variables pueden ser declaradas, consultadas o modificadas a lo largo de nuestro programa.

    * Para recibir un dato del usuario podemos usar el comando

        ~~~python
        input(“texto a mostrar”)
        ~~~

## 4. Tipos de datos

### Tipos de datos primitivos
    Integers: números Enteros
    Floats: números de punto flotante (decimales)
    Strings: cadena de caracteres (texto)
    Boolean: boolenaos (Verdadero o Falso)
### Tipos de dato adicionales
    Datos en texto: str
    Datos numéricos: int, float, complex
    Datos en secuencia: list, tuple, range
    Datos de mapeo: dict
    Set Types: set, frozenset
    Datos booleanos: bool
    Datos binarios: bytes, bytearray, memoryview


## 5. Strings
Para declarer una variable tipo string podemos usar “ ” ó ‘ ’.

### String: Cadenas de texto.

~~~python
nombre_variable = “texto” # Cuando el texto tenga: ‘
nombre_variable = ‘texto’ # Cuando el texto tenga: “
~~~

### Podemos unir o concadenar varios String utilizando el operador +.

~~~python
nombre = ‘Pepito’
apellido = “ Perez”
nombre_completo = nombre + “ ” + apellido
~~~

### String con formato: Nos permite concatenar de manera fácil y legible nuestro texto con nuestras variables las cuales se colocan entre {}, hay dos formas de hacerlo, pero la segunda es mas legible.

~~~python
# Primera forma
nombre_variable = “Hola mi nombre es {} y mi apellido es {}”.format(variable_nombre, variable_apellido)
# Segunda forma
nombre_variable = f“Hola mi nombre es {variable_nombre} y mi apellido es {variable_apellido}”
~~~

## 6. Numbers
Las variables tipo numero pueden ser enteras(que no tienen decimales) o flotantes(que tienen decimales), y siempre se declaran sin estar encerradas entre comillas ya que de lo contrario serian tipo string.

### Int:
~~~python
lives = 3
print(type(lives))
~~~

### Float:
~~~python
temperature = 12.12
print(type(temperature))
~~~

* Las variables numericas nos permiten realizar cálculos matemáticos y obtener resultados, utilizando operadores matemáticos.
~~~python
lives = 12 + 15
~~~

* Podemos realizar operaciones con la misma variable y para esto tenemos 2 formas de hacerlo, la cual la segunda es la forma simplificada en la cual se utilizan operadores de asignacion.

~~~python
lives = lives - 1
lives -= 1
~~~

Python nos muestra en notación científica números cuyo valor es muy grande o muy pequeño.

~~~python
number = 4500000000000000000.1
number_b = 0.0000000000000001
~~~


## 7. Booleans
Los Booleanos son un tipo de dato que solo tiene 2 estados; True (verdadero) ó False (falso), y nos permiten saber si un objeto tiene o no un estado especifico.

### Booleans: En python los estados siempre se escriben iniciando en mayúscula.

~~~python
is_single = True
print(type(is_single))
is_single = False
print(is_single)
~~~

### Podremos invertir el estado utilizando el operador lógico not.

~~~python
is_single = not is_single
print(is_single)
~~~

## 8. Transformación de tipos
En python no se pueden hacer operaciones entre tipo de datos diferentes, por eso es importante transformarlos para que tengan el mismo tipo y así si se puedan operar.

~~~python
float([numero int ó string])
int([numero float ó string])
str([numero])
~~~

## 9. Operadores aritméticos

Existen 7 grupos de operadores en Python:

1. Operadores de asignación: =, +=, -=, *=, /=, %=, **=, //=

2. Operadores de comparación: ==, !=, >, <, >=, <=

3. Operadores lógicos: and, or, not

4. Operadores de identidad: is, is not

5. Operadores de pertenencia: in, not in

6. Operadores de bit: &, |, ^, ~, <<, >>

7. Operadores de membresía: . (punto), [] (corchetes), (), {} (llaves)


### Orden de calculo:
    P arentesis ()
    E xponenciación **
    M últiplicación *
    D ivisión / [Solo valor entero // , modulo %)
    A dición +
    S ustracción -


## 10. Operadores de comparación

Estos operadores devuelven tipos de datos <boole>

    ( > / < ) Mayor / Menor
    ( >= / <= ) Mayor o igual / Menor o igual
    ( == ) Igual
    ( != ) Diferente


### Ejemplos:

    ( 2 > 1 ) --> True
    ( 2 > 3 ) --> False
    (5 > 5 ) --> False
    (1 < 2) --> True
    ( 2 >= 1 ) --> True
    ( 2 >= 3 ) --> False
    (1 <= 2) --> True
    (5 >= 5 ) -> True
    (4 == 4) --> True
    (‘Apple’ == ‘Apple’) --> True
    (‘Apple’ == ‘apple’) --> False
    (4 == 4) --> False
    (‘Apple’ == ‘Apple’) --> False
    (‘Apple’ == ‘apple’) --> True


## 11. Comparación de números flotantes

    x=3.3
    y=1.1+2.2
    print(x)
    print(y)
    print(x==y)

    #Usando strings
    y_str=format(y,".2g")
    print("str= ",y_str)
    print(y_str==str(x))

    #Usando matematica
    print("*"*10)
    print(y,x)
    tolerance=0.00001
    print(abs(x-y)<tolerance)

## 12. Operadores lógicos: and y or
### Lógicos

* Los operadores lógicos son and (y) or (o) not (no) y sirven para comprobar si dos o más operandos son ciertos (True) o falsos (false) y nos devolverá como resultado True o False. Normalmente los solemos utilizar mucho en los condicionales para devolver un booleano comparando varios elementos.Lógica

### Otro operador importante

* En cambio el operador Not sirve para indicar el contrario de un booleano como True / False. Si colocamos un Not True estaríamos diciendo “No verdadero” y Not False “No falso”. En una condición si no es verdadero nos devolverá false y si no es false nos devolverá verdadero!

~~~python
“Not”
~~~

El operador “not” es unario, de negación por ende
solo dará True si su elemento
es False y viceversa.

~~~python
not True
not False	False
True
~~~

## 13. Operador lógico not

### Operadores de identidad en Python

~~~python
is
is not
~~~

### Operadores de membresía de Python

~~~python
in
not in
~~~

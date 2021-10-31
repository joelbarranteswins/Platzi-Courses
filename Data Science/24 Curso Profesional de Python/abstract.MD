## Curso Profesional de python

### Python es un **lenguaje interpretado**

lo que significa que tu código es transformado por el intérprete (máquina virtual de Python) a *bytecode* antes de ser ejecutado por un ordenador con *x* sistema operativo. El *bytecode*es un lenguaje de programación de más bajo nivel (si esto no te es claro, te recomiendo que vayas a tomar los cursos sobre [lenguajes y paradigmas de programación](https://platzi.com/clases/historia-programacion/) y el de [fundamentos de ing. de software](https://platzi.com/clases/ingenieria/).
(Básicamente desde que corres tu programa hasta que la PC lo ejecuta
hay una carrera de relevos de lenguajes o protocolos hasta llegar al
transistor y la señal eléctrica)

### Garbage collector

Recuerda que el *garbage collector*  toma los objetos y variables que no están en uso y los elimina.

### pycache

_pycache _ es el directorio (carpeta) que contiene el *bytecode* (el código intermedio) que crea Python para que lo pueda leer la máquina virtual.

Un **módulo** es cualquier archivo de Python. Generalmente, contiene código que puedes reutilizar.

#### Cómo organizar las carpetas de tus proyectos

<h5>Módulo</h5>
Un módulo es cualquier archivo de Python (o sea que termina con `.py`). Generalmente, contiene código que puedes reutilizar.

<h5>Paquete</h5>
Una carpeta que contiene módulos. Siempre posee el archivo `__init__.py`. (Se lee dunder init doy py).

| Paquetes |         |
| -------- | ------- |
| Módulo  | Módulo |
| Módulo  | Módulo |
| Módulo  | Módulo |

| exploracion_espacial |                    |
| -------------------- | ------------------ |
| `nave.py`          | `destino.py`     |
| `plataforma.py`    | `lanzamiento.py` |
| `tests.py`         | `validacion.py`  |

Estructura de proyecto:

* README -> Explica cómo funciona el proyecto
* .gitignore -> Cosas que no se subirán al repo
* venv -> entorno virtual de Python
* exploracion_espacial -> Paquete, dentro de él, los módulos
  * `__init__.py`
  * `nave.py`
  * `destino.py`
  * `plataforma.py`
  * `lanzamiento.py`
  * `tests.py`
  * `validacion.py`

Esta regla no está tallada en piedra. Depende del proyecto y el Framework que uses.

### ¿Qué son los tipados?

💻 Los tipados es una clasificación de los lenguajes de programación, tenemos cuatro tipos:

* Estático
* Dinámico
* Débil
* Fuerte

#### **Estático**

Detectan los errores en tiempo de compilación. No se ejecuta hasta corregir. Por ej, *Java*

#### **Dinámico**

Detectan el error en tiempo de ejecución. Nos dice el error cuando llega a la línea del código. Por ej, *Python*

#### **Strong**

Más severidad con los tipos de datos. Sumar un número + una letra arrojará error.

#### **Weak**

Menos severidad con los tipos de datos. Si
quiero sumar número y letra, las concatenaría como strings. Castea tipos
de datos automáticamente. Por ej, *PHP, javascript*

### **Tipado estático en Python**

.

Para hacer que Python sea de tipado estático es necesario agregar algo
de sintaxis adicional a lo aprendido, además, esta característica solo
se puede aplicar a partir de la versión 3.6.

```python
# De esta manera se declara una variable, se colocan los dos puntos (:), el tipo de dato y para finalizar se usa el signo igual para asignar el valor a la variable.

<variable> : <tipo_de_dato> = <valor_asignado>

a: int = 5
print(a)

b: str = "Hola"
print(b)

c: bool = True
print(c)
```

Del mismo modo se puede usar esta metodología de tipado en Python a
funciones adicionando el signo menos a continuación del signo mayor que
para determinar el tipo de dato. Ejemplo:

```python
def <nombre_func> ( <parametro1> : <tipo_de_dato>, <parametro2> : <tipo_de_dato> ) ->  <tipo_de_dato> :
	pass

def suma(a: int, b: int) -> int :
	return a + b

print(suma(1,2))

# 3
```

Existe una librería de fabrica que viene preinstalada con Python que se llama **typing,** que es de gran utilidad para trabajar con tipado con estructuras de datos entre la versión **3.6** y  **3.9** , entonces:

.

```python
from typing import Dict, List

positives: List [int] = [1,2,3,4,5]

users: Dict [str, int] = {
	"argentina": 1.
	"mexico": 34,
	"colombia": 45,
}

countries: List[Dict[str, str]] = [
	{
		"name" : "Argentina",
		"people" : "45000",
	},
	{
		"name" : "México",
		"people" : "9000000",
	},
	{
		"name" : "Colombia",
		"people" : "99999999999",
	}
]
```

```python
from typing import Tuple, Dict, List

CoordinatesType = List[Dict[str, Tuple[int, int]]]

coordinates: CoordinatesType = [
	{
		"coord1": (1,2),
		"coord2": (3,5)
	},
	{
		"coord1": (0,1),
		"coord2": (2,5)
	}
]
```

#### Modulo `mypy`

.

El modulo mypy se complementa con el modulo typing ya que permitirá mostrar los errores de tipado debil en Python.

### **Scope**

El scope es el alcance que tienen las variables. Depende de donde
declares o inicialices una variable para saber si tienes acceso. **Regla de oro:**

> *una variable solo esta disponible dentro de la region donde fue creada*

#### Local Scope

Es la región que corresponde el ámbito de una función, donde podremos
tener una o mas variables, las variables van a ser accesibles
únicamente en esta region y no serán visibles para otras regiones

#### Global Scope

Al escribir una o mas variables en esta region, estas podrán ser accesibles desde cualquier parte del código.

### Closures

#### **Nested functions** :

Las funciones anidadas son
simplemente funciones creadas dentro de otra función. Podemos hacer
return de una función creada dentro de otra función 😵 y luego guardar
esas funciones en variables que podemos utilizar.

```python
def main():
	a = 1
	def nested():
		print(a)
	return nested

my_func = main()
my_func()
# 1
```

* Eso anterior es un closure 🤯 y es básicamente cuando una variable de
  un scope superior es recordada por una función de scope inferior
  (aunque luego se elimine la de scope superior).
  ```python
  def main():
  	a = 1
  	def nested():
  		print(a)
  	return nested

  my_func = main()
  my_func()
  # 1
  del(main)
  my_func()
  # 1
  ```
* Reglas para encontrar un closure: 🔥
  * Debemos tener una nested function.
  * La nested function debe referenciar un valor de un scope superior.
  * La función que envuelve a la nested function debe retornarla también.
* Ejemplo de closures para crear funciones:
  ```python
  def make_multiplier(x):
  	def multiplier(n):
  		return x*n
  	return multiplier

  times10 = make_multiplier(10)
  times4 = make_multiplier(4)

  print(times10(3)) # 30
  print(times4(5)) #20
  print(times10(times4(2))) # 80
  ```
* Los closure aparecen en dos casos particulares: cuando tenemos una
  clase corta (con un solo método), los usamos para que sean elegantes. El
  segundo caso, es cuando usamos decoradores

### Decoradores

Un **decorador** es una función que recibe como
parámetro otra función, le añade cosas y retorna una función diferente.
Tienen la misma estructura que los Closures pero en vez de variables lo
que se envía es una función. Ejemplo:

```python
def decorador(func):
    def envoltura():
        print("Esto se añade a mi función original.")
        func()
    return envoltura

def saludo():
    print("¡Hola!")

saludo()
# Salida:
# ¡Hola!

saludo = decorador(saludo) # Se guarda la función decorada en la variable saludo
saludo()                   # La función saludo está ahora decorada
# Salida:
# Esto se añade a mi función original.
# ¡Hola!
```

Se puede hacer de manera mas sencilla, con  *azúcar sintáctica (sugar syntax)* :
Cuando tenemos un código que está embellecido para que nosotros lo
veamos de una manera más estática, ayudando a entender de manera mas
sencilla el código. De esta manera, tenemos el código anterior:

```python
def decorador(func):
    def envoltura():
        print("Esto se añade a mi función original.")
        func()
    return envoltura

def saludo():
    print("¡Hola!")
saludo = decorador(saludo) # Se guarda la función decorada en la variable saludo (se decora)

saludo()                   # La función saludo está ahora decorada 
```

```python
def decorador(func):
    def envoltura():
        print("Esto se añade a mi función original.")
        func()
    return envoltura

# De esta manera se decora la función saludo (equivale a saludo = decorador(saludo) de la última línea, quedando ahora en la línea inmediata superior ):
@decorador            
def saludo():
    print("¡Hola!")

saludo()                   # La función saludo está ahora decorada 
```

Esto permite ahorrar código al implementar características (decoradores) comunes a diferentes funciones:

```python

def decorator_upper(func):                  # Función decoradora
    def wrapper(text):                      # Función anidada
        return func(text).upper()           # Operación que realiza el decorado a la función (func), inserta el texto a la función original. Convierte todo a mayúsculas.
    return wrapper                          # Devuelve wapper como indica la regla de los Clousures

@decorator_upper                            # Decora la función message
def message(name):
    return f'{name}, recibiste un mensaje'  # Esto es lo que realiza la función message, previo a ser decorada.

@decorator_upper                            # Decora la función warning
def warning(name):
    return f'Usa solo mayúsculas {name}'  # Esto es lo que realiza la función warning, previo a ser decorada.

print(message("Cesar")) # Output: CESAR, RECIBISTE UN MENSAJE
print(warning("Cesar")) # Output: USA SOLO MAYÚSCULAS CESAR
```



### Estructuras de datos avanzadas

#### Iteradores

Antes de entender qué son los iteradores, primero debemos entender a los iterables.

Son todos aquellos objetos que podemos recorrer en un ciclo. Son
aquellas estructuras de datos divisibles en elementos únicos que yo
puedo recorrer en un ciclo.

Pero en Python las cosas no son así. Los iterables se convierten en iteradores.

Ejemplo:

```python
# Creando un iterador

my_list = [1,2,3,4,5]
my_iter = iter(my_list)

# Iterando un iterador

print(next(my_iter))

# Cuando no quedan datos, la excepción StopIteration es elevada
```

---

```python
# Creando un iterador

my_list = [1,2,3,4,5]
my_iter = iter(my_list)

# Iterando un iterador

while True: #ciclo infinito
  try:
    element = next(my_iter)
    print(element)
  except StopIteration:
    break
```

**Momento impactante:** El ciclo “for” dentro de Python, no existe. Es un while con StopIteration.

```python
my_list = [1,2,3,4,5]

for element in my_list:
  print(element)
```

---

`evenNumbers.py`:

```python
class EvenNumbers:
  """Clase que implementa un iterador de todos los números pares,
  o los números pares hasta un máximo
  """

  #* Constructor de la clase
  def __init__(self, max = None): #self hace referencia al objeto futuro que voy a crear con esta clase
    self.max = max


  # Método para tener elementos o atributos que voy a necesitar para que el iterador funcione
  def __iter__(self):
    self.num = 0 #Primer número par
    #* Convertir un iterable en un iterador
    return self

  # Método para tener la función "next" de Python
  def __next__(self):
    if not self.max or self.num <= self.max:
      result = self.num
      self.num += 2
      return result
    else:
      raise StopIteration
```

Ventajas de usar iteradores:

1. Nos ahorra recursos.
2. Ocupan poca memoria.



---

```

```

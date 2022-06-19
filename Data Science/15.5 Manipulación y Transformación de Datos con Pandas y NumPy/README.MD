# Curso Básico de Manipulación y Trasnformación de Datos con Pandas y Numpy

DIRECTORIO:

1. [Qué es NumPy?](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
2. [Qué es Pandas?](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
3. [NumPy Array](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
4. [Tipos de datos](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
5. [Dimensiones](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
    - [Agregar o eliminar dimensiones](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
6. [Creando Arrays](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
7. [Shape y reshape](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf) 
8. [Funciones principales de Numpy](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
9. [Copy](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
10. [Condicionales](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
11. [Operaciones](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)

PANDAS

1. [Series y DataFrames](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
2. [Abrir archivos con Pandas](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
3. [Filtros con Loc y Iloc](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
4. [Agregar o eliminar datos con Pandas](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
5. [Manejo de valores nulos](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
6. [Condicionales](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
7. [Funciones principales de Pandas](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
8. [Group By](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
9. [Combinar DataFrames](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
10. [Join](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)
11. [Pivot and melt](https://www.notion.so/Curso-B-sico-de-Manipulaci-n-y-Trasnformaci-n-de-Datos-con-Pandas-y-Numpy-3192e93dd15f42b2a179bc85bed36bbf)

### **NUMPY**

Numpy es una librería open source enfocada al cálculo matemático y menejo de Arrays.

- Muy veloz, más eficiente que python manejando listas
- Optimiza memoria
- Maneja distintos tipos de datos

```python
import numpy as np
```

### **PANDAS**

Pandas también es open source, y está enfocada en el análisis y manipulación de datos

- Fue creada sobre Numpy
- Poco código para manipular los datos
- Soporta múltiples formatos de archivos
- Acomoda los datos en una alineación inteligente.

```python
import pandas as pd
```

### **NUMPY ARRAY**

El array es el principal objeto de la librería. Representa datos de manera estructurada y se puede acceder a ellos a traves del indexado, a un dato específico o un grupo de muchos datos específicos.

```python
lista = [1, 2 , 3, 4, 5, 6, 7, 8, 9]
lista
	---> [1, 2, 3, 4, 5, 6, 7, 8, 9]

arr = np.array(lista)
type(arr)
	---> numpy.ndarray

matriz = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
matriz = np.array(matriz)
matriz
	---> array([[1, 2, 3],
       	[4, 5, 6],
       	[7, 8, 9]])

```

El indexado nos permite acceder a los elementos de los array y matricesLos elementos se emepiezan a contar desde 0.

```python
arr[0]
	---> 1

```

Es posible operar directamente con los elementos.

```python
arr[0] + arr[5]
	---> 7

```

En el caso de las matrices al indezar una posición se regresa el array de dicha posición.

```python
matriz[0]
	---> array([1, 2, 3])

```

Para seleccionar un solo elemento de la matriz se especifica la posición del elemento separada por comas.

```python
matriz[0, 2]
	---> 3

```

El slicing nos permite extraer varios datos, tiene un comienzo y un final.En este ejemplo se está extrayendo datos desde la posición 1 hasta la 5. [1:6].

```python
arr[1:6]
	---> array([2, 3, 4, 5, 6])

```

Si no se ingresa el valor de Start se toma el incio como la posición 0.

```python
arr[:6]
	---> array([1, 2, 3, 4, 5, 6])

```

En cambio si no se le da una posción de End se regresan todos los elementos hasta el final del array.

```python
arr[2:]
	---> array([3, 4, 5, 6, 7, 8, 9])

```

También se puede trabajar por pasos.En este ejemplo de 3 en 3.Regresa la posición 0, 0 + 3, 3 + 3 y como no hay posición 6 + 3, no se regrese nada.

```python
arr[::3]

	---> array([1, 4, 7])

```

Cuando se le asigna un valor negativo se regresan los valores comenzando desde la última posición del array.

```python
arr[-1]
	---> 9
arr[-3:]
	---> array([7, 8, 9])

```

Para el caso de las matrices sucede algo similar.  Para acceder a los valores a nivel de filas.

```python
matriz[1:]
	---> array([[4, 5, 6],
		       		[7, 8, 9]])

```

Para acceder a los valores a nivel de filas y columnas.

```python
matriz[1:, 0:2]
	---> array([[4, 5],
             [7, 8]])
```

### **TIPOS DE DATOS**

---

Los arrays de NumPy solo pueden contener un tipo de dato, ya que esto es lo que le confiere las ventajas de la optimización de memoria.

Podemos conocer el tipo de datos del array consultando la propiedad .dtype.

```
arr = np.array([1, 2, 3, 4])
arr.dtype
	---> dtype('int64')

```

Si queremos usar otro tipo de dato lo podemos definir en la declaración del array.

```
arr = np.array([1, 2, 3, 4], dtype = 'float64')
arr.dtype---> dtype('float64')

```

Ahora vemos que los valores están con punto decimal.

```
arr
	---> array([1., 2., 3., 4.])

```

Si ya se tiene el array definido se usa el método .astype() para convertir el tipo de dato.

```
arr = np.array([1, 2, 3, 4])
arr = arr.astype(np.float64)
arr---> array([1., 2., 3., 4.])

```

También se puede cambiar a tipo booleano recordando que los números diferentes de 0 se convierten en True.

```
arr = np.array([0, 1, 2, 3, 4])
arr = arr.astype(np.bool_)
arr
	--->array([False,True,True,True,True])

```

También podemos convertir los datos en tipo string.

```
arr = np.array([0, 1, 2, 3, 4])
arr = arr.astype(np.string_)
arr
	---> array([b'0', b'1', b'2', b'3', b'4'], dtype='|S21')

```

De igual forma se puede pasar de string a numero.

```
arr = np.array(['0', '1', '2', '3', '4'])
arr = arr.astype(np.int8)
arr---> array([0, 1, 2, 3, 4], dtype=int8)

```

Si un elemento no es de tipo número el método falla.

```
arr = np.array(['hola','0', '1', '2', '3', '4'])
arr = arr.astype(np.int8)
arr
---------------------------------------------------------------------------
ValueError                                Traceback (most recentcall last)
<ipython-input-30-b9bb95861c7b>in <module>()
      1 # DSi un elementono es de tipo número el método falla.
      2 arr = np.array(['hola','0', '1', '2', '3', '4'])
----> 3 arr = arr.astype(np.int8)
      4 arr

ValueError: invalid literalforint()with base 10: 'hola'
```

## DIMENSIONES

---

- scalar: dim = 0 Un solo dato o valor
- vector: dim = 1 Listas de Python
- matriz: dim = 2 Hoja de cálculo
- tensor: dim > 3 Series de tiempo o Imágenes

Declarando un escalar.

```python
scalar = np.array(42)
print(scalar) ----> 42
scalar.ndim ----> 0

```

Declarando un vector.

```python
vector = np.array([1, 2, 3])
print(vector) ----> [1 2 3]
vector.ndim ----> 1

```

Declarando una matriz.

```python
matriz = np.array([[1, 2, 3], [4, 5, 6]])
print(matriz)
matriz.ndim
---->[[1 2 3]
 	 	 [4 5 6]]
----> 2

```

Declarando un tensor.

```python
tensor = np.array([[[1, 2, 3], [4, 5, 6], [7, 8, 9], [10, 11, 12]],[[13, 13, 15], [16, 17, 18], [19, 20, 21], [22, 23, 24]]])
print(tensor)
tensor.ndim
----> [[[ 1  2  3]
  		[ 4  5  6]
  		[ 7  8  9]
  		[10 11 12]]

 			[[13 13 15]
  		[16 17 18]
 		 	[19 20 21]
 			[22 23 24]]]
----> 3

```

### Agregar o eliminar dimensiones

Se puede definir el número de dimensiones desde la declaración del array

```python
vector = np.array([1, 2, 3], ndmin = 10)
print(vector) ----> [[[[[[[[[[1 2 3]]]]]]]]]]
vector.ndim ----> 10

```

Se pueden expandir dimensiones a los array ya existentes.Axis = 0 hace refencia a las filas, mientras que axis = 1 a las columnas.

```python
expand = np.expand_dims(np.array([1, 2, 3]), axis = 0)
print(expand) ----> [[1 2 3]]
expand.ndim ----> 2

```

Remover/comprimir las dimensiones que no están siendo usadas.

```python
print(vector, vector.ndim) ----> [[[[[[[[[[1 2 3]]]]]]]]]] 10
vector_2 = np.squeeze(vector)
print(vector_2, vector_2.ndim) ----> [1 2 3] 1

```

## **CREANDO ARRAYS**

> 1 ✅ np.arange (Start,Ens,Steps) → es como el list( range(0,10)) pero como arrange
> 
> 
> 2 ✅ np.zeros(n)
> 
> 3 ✅ np.ones(n)
> 
> 4 ✅ np.linspace(Start, End, Cant n de Start a End)
> 
> 5 ✅ np.eye(n) ·· Matriz identidad
> 

***Arrays con numeros randoms***

> ☑️ np.random.rand(Columnas, Filas, mas dimensiones ) ·· Ambos con numeros randoms
> 
> 
> ☑️ np.random.randint(Start, End, Dimensiones) ·· N random entre Start y End y tupla dims
> 

## **SHAPE Y RESHAPE**

### Shape y Reshape

Forma ····*Como es la estructura del array····* y reforma del array

> ✅ arr_shape = np.random.randint(Start, End,(3,2)) #Randoms entre 1 y 10 en una matriz (n, n)✅ arr_shape.reshape(dim, dim)
> 

## 🧮**FUNCIONES PRINCIPALES DE NUMPY**

---

```python
arr = np.random.randint(1, 20, 10)
matriz = arr.reshape(2,5)
matriz
----> array([[18,  8,  3, 11,  1],
			       [15, 10, 13,  9, 15]])
arr
----> array([18,  8,  3, 11,  1, 15, 10, 13,  9, 15])
arr.max() ----> 18
matriz.max() ----> 18

```

Podemos regresar los máximos de cada fila o columna especificando el eje.

```python
matriz.max(1) ----> array([18, 15])
matriz.max(0) ---->array([18, 10, 13, 11, 15])

```

Tambien tenemos .argmax() que nos devuelve la posición del elemento

```python
arr.argmax() ----> 0
matriz.argmax(0) ----> array([0, 1, 1, 0, 1])

```

De forma análoga tenemos .min()

```python
arr.min() ----> 1
arr.argmin() ----> 4
matriz.min(0) ----> array([15,  8,  3,  9,  1])
matriz.argmin(1) ----> array([4, 3])

```

Podemos saber la diferencia de valor más bajo con el más alto.

```python
arr.ptp() # 18 - 1 ----> 17
matriz.ptp(0)  ----> array([ 3,  2, 10,  2, 14])

```

Para hacer análisis estádistico se tienen la siguientes funciones.

```python
Ordenar los elementos:
arr.sort() ----> array([1, 3, 8, 9,10, 11,13, 15,15,18])

```

Obtener un percentil:

```python
np.percentile(arr, 0) ----> 1.0

```

Mediana:

```python
np.median(arr) ----> 10.
```

Desviación estándar:

```python
np.std(arr) ----> 5.080354

```

Varianza:

```python
np.var(arr) ----> 25.81000

```

Promedio

```python
np.mean(arr) ----> 10.3

```

Lo mismo aplica para las matrices.

```python
np.median(matriz, 1) ----> array([ 8., 15.])

```

Se pueden unir dos arrays por medio de la concatenación

```python
a = np.array([[1,2], [3,4]])
b= np.array([5, 6])
np.concatenate((a,b), axis = 0)
----------------------------------------------------
ValueError                  Traceback (most recent call last)
<ipython-input-213-97c6fb2c6837> in <module>()
----> 1 np.concatenate((a,b), axis = 0)

<__array_function__ internals> in concatenate(*args, **kwargs)

ValueError: all the input arrays must have same number of dimensions, but the array at index 0 has 2 dimension(s) and the array at index 1 has 1 dimension(s)

```

El error anterior es debido a a tiene 2 dimensiones mientras que b tiene 1.

```python
print(a.ndim) ----> 2
b.ndim ----> 1
b = np.expand_dims(b, axis = 0)
np.concatenate((a,b), axis = 0)
----> array([[1, 2],
       [3, 4],
       [5, 6]])

```

De igual forma podemos agregarlo en el otro eje

```python
np.concatenate((a,b), axis = 1)
-----------------------------------------------
ValueError               Traceback (most recent call last)
<ipython-input-217-3ae7237876ab> in <module>()
      1 # De igual forma podemos agregarlo en el otro eje
----> 2 np.concatenate((a,b), axis = 1)

<__array_function__ internals> in concatenate(*args, **kwargs)

ValueError: all the input array dimensions for the concatenation axis must match exactly, but along dimension 0, the array at index 0 has size 2 and the array at index 1 has size 1

```

Como b es una fila y no una columna, no se puede concatenar a menos que se aplique la transpuesta.

```python
np.concatenate((a,b.T), axis = 1)
----> array([[1, 2, 5],
       [3, 4, 6]])
```

## **COPY**

⚠️ Cuando trabajamos con pedazos de un array padre y empezamos a modificar ese supuesto pedazo, estamos modificanto el array padre

> arr_copy = arr.copy()🚨Aca si tenemos un array que es una copia del padre y podemos modificarlo sin danar el original…⚠️ Siempre que quieras modificar un pedazo del array → COPY…
> 

## ✅**CONDICIONES**

---

Las condiciones nos permiten hacer consultas más específicas.

```python
arr = np.linspace(1,10,10, dtype = 'int8')
arr ----> array([ 1,  2,  3,  4,  5,  6,  7,  8,  9, 10], dtype=int8)

```

Regresa un array de booleanos donde la condiciones se cumple.

```python
indices_cond = arr > 5
indices_cond
----> array([False,False,False,False,False,True,True,True,True,True])

```

Regresa los valores para donde la condiciones True.

```python
arr[indices_cond] ----> array([ 6,  7,  8,  9, 10], dtype=int8)

```

Se pueden agregar múltiples condiciones.

```python
arr[(arr > 5) & (arr < 9)] ----> array([6, 7, 8], dtype=int8)

```

De igual forma modificar los valores que cumplan la condición.

```python
arr[arr > 5] = 99
arr ----> array([ 1,  2,  3,  4,  5, 99, 99, 99, 99, 99], dtype=int8)
```

## 🔣**OPERACIONES**

---

Existen diferentes operaciones que se pueden usar para los arrays de NumPy.

```python
lista = [1,2]
lista ----> [1, 2]

```

Una lista de Python entiende que quieres duplicar los datos. Cosa que no buscamos.

```python
lista * 2 ----> [1, 2, 1, 2]
arr = np.arange(0,10)
arr2 = arr.copy()
arr ----> array([0, 1, 2, 3, 4, 5, 6, 7, 8, 9])

```

Ahora multiplicamos por un escalar:

```python
arr * 2 ----> array([ 0,  2,  4,  6,  8, 10, 12, 14, 16, 18])

```

Operación suma de escalar:

```python
arr + 2 ----> array([ 2,  3,  4,  5,  6,  7,  8,  9, 10, 11])

```

División con un escalarComo en este caso la primera posición del array es 0, muestra un error pero no detiene el proceso.

```python
1/arr
/usr/local/lib/python3.7/dist-packages/ipykernel_launcher.py:1: RuntimeWarning: divide by zero encounteredin true_divide
  """Entry point for launching an IPython kernel.
array([       inf, 1.        , 0.5       , 0.33333333, 0.25      ,
       0.2       , 0.16666667, 0.14285714, 0.125     , 0.11111111])

```

Elevar a un escalar:

```python
arr**2 ----> array([ 0,  1,  4,  9, 16, 25, 36, 49, 64, 81])

```

Sumar dos arrays de igual dimensiones las hace elemento por elemento:

```python
arr + arr2 ----> array([ 0,  2,  4,  6,  8, 10, 12, 14, 16, 18])

```

Lo mismo aplica para matrices.

```python
matriz = arr.reshape(2,5)
matriz2 = matriz.copy()
matriz
----> array([[0, 1, 2, 3, 4],
      	 [5, 6, 7, 8, 9]])
matriz - matriz2
----> array([[0, 0, 0, 0, 0],
      	 [0, 0, 0, 0, 0]])

```

Una operación importante es la de punto por punto, aquí dos formas de hacerla:

```python
np.matmul(matriz, matriz2.T)
----> array([[ 30,  80],
      	 [ 80, 255]])
matriz @ matriz2.T
----> array([[ 30,  80],
       [ 80, 255]])
```

## SERIES

- Es un arreglo unidimensional indexado

```python
import pandasas pd

#definiendo una lista con indices especificos
psg_players = pd.Series(['Navas','Mbappe','Neymar','Messi'],
index=[1,7,10,30])
psg_players ----> 1      Navas
									7     Mbappe
									10    Neymar
									30     Messi
									dtype:object
```

- Permite hacer busqueda por indices

```python
psg_players[7]
-----> 'Neymar'

```

- Busqueda mediante Slicing

```python
psg_players[0:3]
-----> 0     Navas
			 1Mbappe
			 2Neymar
			 dtype: object

```

**Pandas**

- Similar a la estrucutra matricial. Arreglo de dos dimensiones

```python
dict = {'Jugador':['Navas','Mbappe','Neymar','Messi'],
 'Altura':[183.0, 170.0, 170.0, 163.0],
  'Goles':[2, 200, 150, 500]}
df_players = pd.DataFrame(dict)
----->   Jugador Altura Goles
			 0 Navas    183    2
			 1 Mbappe   170    200
			 2 Neymar   170    150
			 3 Messi    163    500

```

- Busqueda por indices. Columnas

```python
df_players.columns
------> Index(['Jugador', 'Altura', 'Goles'], dtype='object')

```

- Busqueda por indice.

```python
df_players.index
------> RangeIndex(start=0, stop=4, step=1)
```

## **ABRIR ARCHIVOS CON PANDAS**

- Leer un archivo CSV. Primero debemos cargarlo al sistema de archivo del Notebooks que estamos utilizando (Deepnote o Jupiter). Luego hacemos el llamado con la siguiente linea:

```python
import pandasas pd
df_books = pd.read_csv('ruta/nombre_archivo')
df_books -----> #muestra el archivo en formato DataFrame

```

- Si el .CSV esta separado por otro simbolo que no sea la coma, por ejemplo por punto y coma, podemos configurarlo para que el separador sea ;

```python
df_books = pd.read_csv('ruta/nombre_archivo', sep=';')
df_books ------> #muestra el archivo, separado por (;), en formato dataFrame

```

- Cambiar el encabezado del archivo por una de sus columnas

```python
df_books = pd.read_csv('ruta/nombre_archivo', sep=',', header=1)
df_books ------> #muestra el dataFrame con la primera columna como encabezado

df_books = pd.read_csv('ruta/nombre_archivo', sep=',', header=0)
df_books ------> #muestra el dataFrame con el encabezado que trae el archivo por defecto

```

- Sustituye los nombres del encabezado con una lista que contenga los nuevos nombres

```python
df_books = pd.read_csv('ruta/nombre_archivo', sep=',', header=0, names = ['title1', 'title2', 'titleN'])
df_books   -----> #muestra la dataFrame con los nuevos nombres de columnas dados

```

- Abrir un archivo json en formato dataFrame

```python
df_personajes = pd.read_json('ruta/nombre_archivo')
df_personajes -----> #muestra el archivo json en formato dataFrame

```

- Abrir un archivo json en formato de Series

```python
df_personajes = pd.read_json('ruta/nombre_archivo', typ='Series')
df_personajes ------> #muestra el archivo json en formato de Series
```

## **FILTROS CON LOC Y ILOC**

Permiten filtrar datos de manera mas específica. Loc filtra segun un label mientras que iloc lo hace mediante indices.

- Mostrar el dataFrame con loc

```python
import pandasas pd
df_books = pd.read_csv('bestsellers-with-categories.csv', sep=',', header=0)
df_books.loc[:] ----> #muestra todos los datos del dataFrame

```

- Mostrar un rango de filas tomando en cuenta el start y el end

```python
df_books.loc[0:4] ----> #muestra los datos de la fila 0 a la fila 4

```

- Filtrando por filas y columnas

```python
df_books.loc[0:4, ['Name', 'Author']]
----> #filtra los datosdela filaque vade 0 a 4 yde las columnas Name y Author

```

- Podemos modificar los valores de una columna especifica del dataFrame

```python
df_books.loc[:, ['Reviews']] * -1
----> #multiplica por -1 todos los valores de la columna Reviews

```

- Filtrar datos que cumplan una condición determinada

```python
df_books.loc[:, ['Author']] == 'JJ Smith'
----> #muestrala columna Authorcon Trueen los valores que cumplenla condiciony False para los quenola cumplen

```

- Mostrar el dataFrame con iloc

```python
df_books.iloc[:] --->#muestra todos los datosdel dataframe

```

- Filtra datos segun los indices de las filas y las columnas

```python
df_books.iloc[:4, 0:2] ---> #muestra los datos de las filas que van de 0 a 3 y las columnas con indices 0 y 1

```

- Tambien podemos buscar un dato especifico con iloc

```python
df_books.iloc[1,3] ---> #muestra el dato alojado en la fila 1 columna 3
```

## **AGREGAR O ELIMINAR DATOS DE PANDAS**

- Mostrar las primeras 5 filas del dataFrame

```python
import pandasas pd
import numpyas np

df_books = pd.read_csv('bestsellers-with-categories.csv', sep=',', header=0)
df_books.head() ---> #muestra las primeras 5 lineas del dataFrame

```

- Eliminar columnas de la salida pero no del dataFrame

```python
df_books.drop('Genre', axis=1).head()#axis 1 = columnas. axis 2 = filas
---->#elimina la columna Genre de la salida pero nodel dataFrame

```

- Eliminar una columna del dataFrame

```python
deldf_books['Price']
---->#eliminalacolumnaPricedeldataFrame
```

- Eliminar filas del dataFrame

```python
df_books.drop(0, axis=0)
----> #elimina la fila 0 del dataFrame

```

- Eliminar un conjunto de filas mediante una lista

```python
df_books.drop([0,1,2], axis=0)
---->#elimina las filas 0, 1 y 2del dataFrame

```

- Elimina un conjunto de filas mediante un rango

```python
df_books.drop(range(0,10), axis=0)
---->#eliminalasprimeras10filasdeldataFrame
```

- Agregar una nueva columna con valores Nan

```python
df_books['Nueva_columna'] = np.nan
---->#Crea una nueva columna con el nombre de Nueva_columna de valores Nan

```

- Mostrar el numero de filas(0) o columnas(1) que tiene un dataFrame

```python
df_books.shape[0]
---->#Muestra el numero de filas que posee el dataFrame

```

- Agregar valores a una nueva columna del dataFrame

```python
#Creamos una array con un numero de valores igual al numero de filasdel dataFrame
data = np.arange(0, df_books.shape[0])

#Creamos una nueva columna y agregamos los valores almacenados en el array
df_books['Rango'] = data
---->#Crea una nueva columna llamada Rango con los valoresdel array

```

- Para añadir filas se utiliza la funcion append de python añadiendo como parametro una lista, diccionario o añadiendo los valores manualmente

```python
df_books.append(df_books)
---->#DuplicalasfilasdeldataFrame
```

## **MANEJO DE VALORES NULOS**

- Creamos un dataFrame con algunos valores nulos

```python
import pandasas pd
import numpyas np

dict = {'Col1':[1,2,3,np.nan],
'Col2':[4, np.nan,6,7],
'Col3':['a','b','c',None]}

df = pd.DataFrame(dict)
	----> Col1 Col2 Col3
			0   1    4   a
			1   2nan  b
			2   3    6   c
			3nan   7None
```

- Identificar valores nulos en un dataFrame

```python
df.isnull()
---->    Col1   Col2   Col3
			0falsefalsefalse1falsetruefalse2falsefalsefalse3truefalsetrue
```

- Identificar valores nulos con un valor numerico

```python
df.isnull()*1
---->    Col1   Col2   Col3
			0   0      0       0
			1   0      1       0
			2   0      0       0
			3   1      0       1

```

- Sustituir los valores nulos por una cadena

```python
df.fillna('Missing')
---->    Col1   Col2   Col3
	    0  1.0    4.0     a
			1  2.0  Missing   b
			2  3.0    6.0     c
			3 Missing 7.0  Missing

```

- Sustituir valores nulos por una medida estadisticas realizada con los valores de las columnas

```python
df.fillna(df.mean())
---->    Col1   Col2   Col3
      0   1      4      a
			1   2      5.667  b
			2   3      6      c
			3   2      7     None

```

- Sustituir valores nulos por valores de interpolacion

```python
df.interpolate()
---->    Col1   Col2   Col3
      0   1      4      a
			1   2      5      b
			2   3      6      c
			3   3      7     None

```

- Eliminar valores nulos

```python
df.dropna()
---->    Col1   Col2   Col3
      0   1      4      a
			2   3      6      c

```

## **FILTRADO POR CONDICIONES**

Llamamos los datos de un archivo csv para manejarlos

```python
import pandasas pd
df_books = pd.read_csv('bestsellers-with-categories.csv', sep=',', header=0)
df_books.head(2) ---> #muestra los primeros dos registros del dataFrame

```

- Mostrar datos que sean mayores a cierto valor

```python
mayor2016 = df_books['Year'] > 2016
mayor2016
---> #muestra el dataFrame con valores booleanos.True para libros publicados desde el 2017

```

- Filtrar datos que sean mayores a cierto valor

```python
df_books[mayor2016]
---> #filtra los datos que cumplen con la condicion

```

- Tambien se puede colocar la condicion directamente como parametro

```python
df_books[df_books['Year'] > 2016]
---> #filtra los datos que cumplen con la condicion

```

- Mostrar los datos que sean igual a cierto valor

```python
genreFiction = df_books['Genre'] == 'Fiction'
genreFiction ---> #muestra el dataFrame con valores booleanos.True para libros de tipo Fiction

```

- filtrado con varias condiciones

```python
df_books[genreFiction & mayor2016]
---> #Filtra aquellos librosque seande tipo Fiction yque hayan sido publicado desde 2017

```

- Filtrado con negacion

```python
df_books[~mayor2016]
---> #Filtra aquellos libros publicado antes de 2017
```

### **FUNCIONES PRINCIPALES DE PANDAS** 🐼

> ✅ .head() → trae los primeros datos
> 
> 
> ✅ .info() → Columnas, indices, cuales noson nulos, tipo de dato que maneja
> 
> ✅ .describe() → Solo de las columnas numericas me arroja datos estadisticos [ media,max,miun,mediana,etc ]
> 
> ✅ .memory_usage() → memoria utilizada
> 
> ✅ .value_counts() → cuenta valores de una columna
> 
> ✅ .drop_duplicates() → elimina los valores repetidos
> 
> ✅ .sort_values( columna para ordenar ) → Se puede ordenar de forma descendiente con la bandera ascending=False
> 

## **GROUP BY**

Permite agrupar datos en funcion de los demas . Es decir, hacer el analisis del dataframe en funcion de una de las columnas.

- llamamos el dataFrame que vamos a manipular

```python
import pandasas pd
df_books = pd.read_csv('bestsellers-with-categories.csv', sep=',', header=0)
df_books.head(2) ---> #muestra las dos primeras lineas del dataFrame

```

- Agrupar por Author y mostrar el conteo de los datos de las demas columnas

```python
df_books.groupby('Author').count()
--->              Name    User Rating    Reviews    Price    Year   Genre
**Abraham Verghese    2         2             2         2       2       2
Adam Gasiewski      1         1             1         1       1       1
Adam Mansbach       1         1             1         1       1       1
Adir Levy           1         1             1         1       1       1**

```

- Agrupar por Author y mostrar la media de los datos de las demas columnas

```python
df_books.groupby('Author').median()
--->            User Rating    Reviews    Price    Year
**Abraham Verghese   4.6          4866       11      2010.5
Adam Gasiewski     4.4          3113       6       2017
Adam Mansbach      4.8          9568       9       2011
Adir Levy          4.8          8170       13      2019**

```

- La columna Author, en los casos anteriores, pasa a ser el indice. Podemos usar loc y acceder a un dato especifico del dataFrame. Agrupar por autor y mostrar la suma de los valores de las demas columnas para William Davis

```python
df_books.groupby('Author').sum().loc['William Davis']
--->
User Rating        8.8
Reviews        14994.0
Price             12.0
Year            4025.0
Name: William Davis, dtype: float64

```

- Abrupar por author y mostrar la suma de los valores de las demas columnas. Colocar los indices que el dataFrame trae por defecto

```python
df_books.groupby('Author').sum().reset_index()
--->              Author    User Rating    Reviews    Price    Year
0         Abraham Verghese      9.2         9732       22      4021
1         Adam Gasiewski        4.4         3113       6       2017
2         Adam Mansbach         4.8         9568       9       2011
3         Adir Levy             4.8         8170       13      2019

```

- La funcion agg() permite aplicar varias funciones al dataFrame una vez agrupado segun una columna especifica. Agrupar por Author y mostrar el minimo y maximo de las demas columnas

```python
df_books.groupby('Author').agg(['min','max'])
---> #muestra cada columna divididaendos: miny max. Estas contienen los valores maximoy minimo dela columna para cada Author

```

- Agrupar por Author, obtener el minimo y maximo de la columna Reviews y sumar los valores de la columna User Rating

```python
df_books.groupby('Author').agg({'Reviews':['min','max'], 'User Rating':'sum'})
--->                 Reviews min    Reviews max    User Rating
Abraham Verghese         4866           4866          9.2
Adam Gasiewski           3113           3113          4.4
Adam Mansbach            9568           9568          4.8
Adir Levy                8170           8170          4.8

```

- Agrupar por Author - Year y contar los valores de las demas columnas

```ruby
df_books.groupby(['Author','Year']).count()
--->                        Name    User Rating    Reviews    Price    Genre
('Abraham Verghese', 2010)   1           1            1         1        1
('Abraham Verghese', 2011)   1           1            1         1        1
('Adam Gasiewski', 2017)     1           1            1         1        1
('Adam Mansbach', 2011)      1           1            1         1        1
```

## **Combinando dataFrames**

Existen diferentes formas de fusionar dos dataFrames. Esto se hace a traves de la lógica de combinación como se muestra a continuacion

![https://static.platzi.com/media/user_upload/merge-join-bce1f2e4-f1af-4fdd-8b80-a3d8926d9444.jpg](https://static.platzi.com/media/user_upload/merge-join-bce1f2e4-f1af-4fdd-8b80-a3d8926d9444.jpg)

- **Left join**: da prioridad al dataFrame de la izquierda. Trae siempre los datos de la izquierda y las filas en comun con el dataFrame de la derecha.
- **Right join**: da prioridad al dataFrame de la derecha. Trae siempre los datos de la derecha y las filas en comun con el dataFrame de la izquierda.
- **Inner join**: Trae solamente aquellos datos que son común en ambos dataFrame
- **Outer join**: Trae los datos tanto del dataFrame de la izquierda como el de la derecha incluyendo los datos que comparten ambos.

![https://static.platzi.com/media/user_upload/merge-join-dataFrames-01b5dc63-99da-4987-a68e-4a536c5a81e9.jpg](https://static.platzi.com/media/user_upload/merge-join-dataFrames-01b5dc63-99da-4987-a68e-4a536c5a81e9.jpg)

- Concat - Axis 0: permite combinar dos dataframes a nivel de filas. Crecimiento vertical

![https://static.platzi.com/media/user_upload/concat-filas-eab75fcb-d6d4-4cbb-a2ce-e38ff7aef7b0.jpg](https://static.platzi.com/media/user_upload/concat-filas-eab75fcb-d6d4-4cbb-a2ce-e38ff7aef7b0.jpg)

- Concat - Axis 1: permite combinar dos dataframes a nivel de columnas. La organizacion por columnas no va a ser la misma para ambos dataFrames, por tanto, se crearan valores NaN para rellenar los espacios vacios. Crecimiento horizontal

![https://static.platzi.com/media/user_upload/concat-columnas-3b54ea2e-76ba-485b-b524-a452dc604146.jpg](https://static.platzi.com/media/user_upload/concat-columnas-3b54ea2e-76ba-485b-b524-a452dc604146.jpg)

## **JOIN**

El join funciona igual que las funciones anteriores, pero a nivel de índices. (index)

![Untitled](imgs/Untitled.png)

## **PIVOT AND MELT**

[https://www.youtube.com/watch?v=ZuTfB5NWOYE](https://www.youtube.com/watch?v=ZuTfB5NWOYE)
# Curso de Estructuras de datos no lineales con Python



Dentro de la estructura de datos no lineales se tiene:

- Arrays
- Nodes
- Linked Lists
- Stacks
- Queues

**Elementos de la programación en Python**

- Elementos lexicos: If, while , def , etc , docstring
- Convencionales: Variables , constante, nombre_funcion, nombreClase
- Estructuras Propias: Listas , tuplas , conjuntos o sets , diccionarios
- Funciones: Declaración y llamada , recursividad, anidados , hight order functions, lambdas o anonimas
- Manejo de excepciones y errores
- Manipulación de archivos

**TIPOS DE COLECCIONES**

- Colecciones: Estructura de datos
- Grupo de cero o mas elementos que pueden tratarse como una unidad conceptual

**Valores**

- Non-zero value : Algo positivo o negativo
- Cero: el mismo cero
- Null: Null o None significa nada
- Undefined: Cuando no esta definido que tipo de dato es

**Tipos**

- Dinamicas : Los que pueden modificarse
- Inmutables: Los que no pueden modificarse
- Lineales: Ordenadas por su posición; Solo el primer elemento no tiene predecesor

```python
D1 -> D2 -> D3 -> D4 ->D5
```

- Jerarquicas: Ordenadas como un árbol invertido. Solo el primer elementos no tiene predecesor . Padre e Hijos

```python
D1
\  \
D2 D3
    \
     D4
```

- Grafos: Cada dato puede tener varios predecesores y sucesores. Estos tambien se llaman vecinos

```python
D1 -- D2
  \  /
   D3
  / \
D4 -- D5
```

- Desordenadas: Como una bolsa de canicas
- Ordenadas: Imponen un orden con una regla.

**LISTAS**

- .append(”elemento”) : agrega elementos
- .sort() : ordena
- .pop(): eliminar elementos
- .insert(indice,elemento): se inserta en el indice dado
- .pop(i): Borra el indice dado
- .remove(”apple”): Borrar el elemento que su valor sea apple
- Es de uso proposito general
- Estructura de datos mas utilizada
- Tamaño dinámico
- De tipo secuencial
- Ordenable
- Mutables

**TUPLAS**

- Inmutables (No se pueden añadir o cambiar)
- Utiles para datos constantes
- Mas rapidas que las listas
- Tipo secuencial

```python
tuple1=()
tuple2=(1274,1275,1276)
tuple3='mulan','pucca','perey',
```

**CONJUNTOS/SETS**

- Almacenan objetos no duplicados
- De acceso rapido
- Aceptan operaciones logicas
- Son desordenados

```python
set1={3,5,9,3,9}
set2=set()
numbers=[1,2,3,4,5,6,1,2]
set3=set(numbers)
```

**DICCIONARIOS**

- Pares de llave / valor
- Arrays asociativos (hash maps)
- Son desordenados

```python
cats1={
	"mulan":2,
	"pucca":1.2,
	"percy":4,
}

cats2=dict([('mulan',2),('pucca',1.2)])

cats3=dict(mulan=2,pucca=1.2,percy=4)
```

**ARRAYS**

- Son un tipo de listas , pero las listas no son arrays
- Representación interna de una colección de información (Estructura de datos)
- Conceptos clave :
    - Elemento: Valor almacenado en las posiciones de array
    - Indice: Referencia a la posición del elemento
- Los arrays guardan en memoria la información de forma consecutiva con ciertas restrincciones
- Hay de distintas dimensiones : 1d, 2d, 3d
- Los arrays son restrictivos, ,no pueden:
    - Agregar posiciones
    - Remover posiciones
    - Modificar su tamaño
    - Su capacidad se define al crearse o declararse.
- Python tiene un modulo array que solo almacena números y caracteres
- Basado en listas
- Dos dimensiones como grids (estructura de datos con filas y columnas)

```python
"""
Code used for the 'Crear un array' class.

Array type class
Methods:
    1. Length
    2. String representation
    3. Membership
    4. Index.
    5. Replacement
"""

class Array(object):
    "Represents an array."

    def __init__(self, capacity, fill_value = None):
        """
        Args:
            capacity (int): static size of the array.
            fill_value (any, optional): value at each position. Defaults to None.
        """
        self.items = list()
        for i in range(capacity):
            self.items.append(fill_value)

    def __len__(self):
        """Returns capacity of the array."""
        return len(self.items)

    def __str__(self):
        """Returns string representation of the array"""
        return str(self.items)

    def __iter__(self):
        """Supports traversal with a for loop."""
        return iter(self.items)

    def __getitem__(self, index):
        """Subscrit operator for access at index."""
        return self.items[index]

    def __setitem__(self, index, new_item):
        """Subscript operator for replacement at index."""
        self.items[index] = new_item

"""
Code used in the shell to create an array
instance and methods.
"""

"""
from array import Array
menu = Array(5)
len(menu)
print(menu)
for i in range(len(menu)):
    menu[i] = i + 1
menu[0]
menu[2]
for item in menu:
    print(menu)

menu.__len__()
menu.__str__()
menu.__iter__()
menu.__getitem__(2)
menu.__setitem__(2, 100)
menu.__getitem__(2)
"""
```

arrays en 2d

```python
"""
Code used for the 'Crear un array de dos dimensiones' class.

Grid type class
Methods:
    1. Initialize
    2. Get height
    3. Get width
    4. Access item
    5. String representation
"""
from arrays import Array

class Grid(object):
    """Represents a two-dimensional array."""
    def __init__(self, rows, columns, fill_value = None):
        self.data = Array(rows)
        for row in range(rows):
            self.data[row] = Array(columns, fill_value)

    def get_height(self):
        "Returns the number of rows."
        return len(self.data)

    def get_width(self):
        """Returns the number of columns."""
        return len(self.data[0])

    def __getitem__(self, index):
        """Supports two-dimensional indexing with [row][column]."""
        return self.data[index]

    def __str__(self):
        """Returns a string representation of the grid."""
        result = ""

        for row in range(self.get_height()):
            for col in range(self.get_width()):
                result += str(self.data[row][col]) + " "

            result += "\n"

        return str(result)

'''
Code used in the shell to instance a grid

matrix = Grid(3, 3)
print(matrix)
for row in range(matrix.get_height()):
    for column in range(matrix.get_width()):
        matrix[row][column] = row * column

print(matrix)
matrix.get_height()
matrix.get_width()
matrix.__getitem__()
matrix.__getitem__(1)
matrix.__getitem__(2)[0]
matrix.__str__()
'''
```

**NODOS**

- Tambien conocidos como linked structures
- Consiste en nodos conectados a otros
- Lo mas comunes son sencillos o dobles
- No se accede por indice , sino por recorrido
    - DATA : Valor almacenado en nodos
    - NEXT: referencia al siguiente nodo
    - PREVIOUS: referencia al nodo anterior
    - HEAD: referencia al 1er nodo en la estructura
    - TAIL: referencia al último nodo
- En memoria están repartidos o esparcidos , diferente a los arrays que son contiguos o secuenciales
- Los nodos nos sirven para crear otras estructuras mas complejas (pilas, colas)
- Nos sirve para optimización

```python
class Node():
    def __init__(self,data,next=None):
        self.data=data
        self.next=next
```

**SINGLY LINKED LIST**

- Utiliza variables auxiliares para operar una lista de nodos

```python
from node import Node

class SinglyLinkedList:
    def __init__(self):
        self.tail=None
        self.size=0

    def append(self,data):
        node =Node(data)

        if self.tail == None:
            self.tail =node
        else:
            current=self.tail

            while current.next:
                current=current.next

            current.next=node

        self.size += 1
    
    def size(self):
        return str(self.size)

    def iter(self):
        current=self.tail

        while current:
            val=current.data
            current=current.next
            yield val

    def delete(self,data):
        current=self.tail
        previous=self.tail

        while current:
            if current.data == data:
                if current == self.tail:
                    self.tail=current.next
                else:
                    previous.next=current.next
                    self.size-=1
                    return current.data

            previous=current
            current=current.next

    def search(self,data):
        for node in self.iter():
            if data == node:
                print(f"Data {data} found!")

    def clear(self):
        self.tail=None
        self.head=None
        self.size=0
```

```python
"""
Code used for the class 'Nodos y singly linked list'.

All the code but the 'Node' class is written in the shell
for demonstrative purposes.

The node methods should be incorporated into the Node class.
"""

class Node(object):
    "Represents a single linked node."
    def __init__(self, data, next=None):
        self.data = data
        self.next = next

# Creating 3 differents nodes 
node1 = None
node2 = Node("A", None)
node3 = Node("B", node2)

# This causes an Atribute Error
# node1.next = node3

node1 = Node("C", node3)

# Creating a linked list
head = None
# Add five nodes to the beginning of the linked structure
for count in range(1, 3):
    head = Node(count, head)
# Print the contents of the structure

while head != None:
    print(head.data)
    head = head.next

""" Main linked lists operations """
# Traversal with 'probe' as aux. variable
probe = head

while probe != None:
    print(probe.data)
    probe = probe.next

# Search an item
probe = head
target_item = 2
while probe != None and target_item != probe.data:
    probe = probe.next

if probe != None:
    print(f"Target item {target_item} has been found")
else:
    print(f"Target item {target_item} is not in the linked list")

# Replacement
probe = head
target_item = 3
new_item = "Z"
while probe != None and target_item != probe.data:
    probe = probe.next

if probe != None:
    probe.data = new_item
    print(f"{new_item} replaced the old value in the node number {target_item}")
else:
    print(f"The target item {target_item} is not in the linked list")

# Insert new element at the beginning
head = Node("F", head)

# Insert at the end
new_node = Node("K")

if head is None:
    head = new_node
else:
    probe = head
    while probe.next != None:
        probe = probe.next

    probe.next = new_node

# Remove at the beginning
removed_item = head.data
head = head.next
print(removed_item)

# Remove at the end
removed_item = head.data

if head.next is None:
    head = None
else:
    probe = head

    while probe.next.next != None:
        probe = probe.next

    removed_item = probe.next.data
    probe.next = None

print(removed_item)

# Insert at any position
new_item = input("Enter the new item: ")
index = int(input("Enter the position to inser the new item: "))
if head is None or index < 0:
    head = Node("Py", head)
else:
    # Search for node at position index - 1 or the last position
    probe = head

    while index > 1 and probe.next != None:
        probe = probe.next
        index -= 1

    probe.next = Node(new_item, probe.next)

# Remove at any position
index = 3

if index <= 0 or head.next is None:
    removed_item = head.data
    head = head.next
    print(removed_item)
else:
    # Search for nod at position index - 1
    # or the next to last position
    probe = head

    while index > 1 and probe.next.next != None:
        probe = probe.next
        index -= 1

    removed_item = probe.next.data
    probe.next = probe.next.next
    print(removed_item)
```

**CIRCULAR LINKED LIST**

- El último nodo hace referencia al 1er nodo que se instancio

```python
"""
Code used for the class 'Circular Linked List'.
"""

class Node(object):
    "Represents a single linked node."
    def __init__(self, data, next=None):
        self.data = data
        self.next = next

index = 1
new_item = "ham"

head = Node(None, None)
head.next = head

# Search for node at position index - 1 or the last position
probe = head

while index > 0 and probe.next != head:
    probe = probe.next
    index -= 1

# Insert new node after node at position index - 1 or last position
probe.next = Node(new_item, probe.next)

print(probe.next.data)
```

**DOUBLE LINKED LIST**

- Apunta al siguiente nodo y al anterior nodo

```python
"""
Code used for the class 'Double Linked List'.
"""

class Node(object):
    def __init__(self, data, next=None):
        self.data = data
        self.next = next

class TwoWayNode(Node):
    def __init__(self, data, previous=None, next=None):
        Node.__init__(self, data, next)
        self.previous = previous

# Create a doubly linked list with one node
head = TwoWayNode(1)
tail = head

# Add four node to the end of the linked list
for data in range(2, 6):
    tail.next = TwoWayNode(data, tail)
    tail = tail.next

# Print the contents of the linked list in reverse order
probe = tail

while probe != None:
    print(probe.data)
    probe = probe.previous
```

**STACKS O PILAS**

- Colección Lineal
- Basados en arrays o linked list
- Basado en LIFO - Last in first Last in out

```python
"""
Code used for the class 'Crear un stack'.
"""

class Node:
    def __init__(self, data=None):
        self.data = data
        self.next = None

class Stack:
    def __init__(self):
        self.top = None
        self.size = 0

    def push(self, data):
        """ Appends an element on top. """
        node = Node(data)

        if self.top:
            node.next = self.top
            self.top = node
        else:
            self.top = node

        self.size += 1

    def pop(self):
        """ Removes and returns the element on top. """
        if self.top:
            data = self.top.data
            self.size -= 1

            if self.top.next:
                self.top = self.top.next
            else:
                self.top = None

            return data
        else:
            return "The stack is empty"

    def peek(self):
        if self.top:
            return self.top.data
        else:
            return "The stack is empty"

    def clear(self):
        while self.top:
            self.pop()
```

**QUEUES O COLAS**

- Se basa en FIFO con elementos de mayor menor prioridad - First in First Out
- Rear es el último elemento
- Front es el primer elemento
- Hay priority queues como por ejemplo en los hospitales por nivel de urgencia
- Operaciones como add(a), add(b) , añade a rear ; pop () eliminar del front

```python
class Queue:
    def __init__(self):
        self.inbound_stack = []
        self.outbound_stack = []

    def enqueue(self, data):
        self.inbound_stack.append(data)

    def dequeue(self):
        if not self.outbound_stack:
            while self.inbound_stack:
                self.outbound_stack.append(self.inbound_stack.pop())

        return self.outbound_stack.pop()

"""
x = Queue()
x.enqueue(5)
x.enqueue(6)
x.enqueue(7)
print(x.inbound_stack)
x.dequeue()
print(x.inbound_stack)
print(x.outbound_stack)
x.dequeue()
print(x.outbound_stack)
"""
```

**QUEUES BASADAS EN LISTAS**

```python
"""
Code used during the class 'Queues basadas en listas'.
"""

class ListQueue:
    def __init__(self):
        self.items = []
        self.size = 0

    def enqueue(self, data):
        self.items.insert(0, data)
        self.size += 1

    def dequeue(self):
        data = self.items.pop()
        self.size -= 1
        return data

    def traverse(self):
        total_items = self.size

        for item in total_items:
            print(self.items[item])

"""
Code used in the shell

x = ListQueue()
x.enqueue('eegs')
x.enqueue('ham')
x.enqueue('spam')
x.items

for i in range(x.size):
    print(x.items[i])

"""
```

**QUEUES BASDAS EN NODOS**

```python
"""
Code used during the class 'Queues basadas en nodos'.
"""
from double_node import Node

class Queue:
    def __init__(self):
        self.head = None
        self.tail = None
        self.count = 0

    def enqueue(self, data):
        new_node = Node(data, None, None)

        if self.head is None:
            self.head = new_node
            self.tail = self.head
        else:
            new_node.previous = self.tail
            self.tail.next = new_node
            self.tail = new_node

        self.count += 1

    def dequeue(self):
        current = self.head

        if self.count == 1:
            self.count -= 1
            self.head = None
            self.tail = None
        elif self.count > 1:
            self.head = self.head.next
            self.head.previous = None
            self.count -= 1

        return current.data

"""
Code used in the shell

x = Queue()

x.enqueue('eggs')
x.enqueue('ham')
x.enqueue('spam')
x.head.data
x.head.next.data
x.tail.data
x.count
x.dequeue()
x.head
"""
```

**RETO PLAYLIST MUSICAL**

```python
from random import randint
from node_based_queue import Queue
from time import sleep

class Track:
    def __init__(self, title=None):
        self.title = title
        self.length = randint(5, 6)

class MediaPlayerQueue(Queue):
    def __init__(self):
        super(MediaPlayerQueue, self).__init__()

    def add_track(self, track):
        self.enqueue(track)

    def play(self):
        print(f"count: {self.count}")
        while self.count > 0 and self.head is not None:
            current_track_node = self.dequeue()
            print(f"Now playing {current_track_node.data.title}.")

            sleep(current_track_node.data.length)

track1 = Track("white whistle")
track2 = Track("butter butter")
track3 = Track("Oh black star")
track4 = Track("Watch that chicken")
track5 = Track("Don't go")

""" print(track1.length)
print(track2.length)
print(track3.length) """

media_player = MediaPlayerQueue()

media_player.add_track(track1)
media_player.add_track(track2)
media_player.add_track(track3)
media_player.add_track(track4)
media_player.add_track(track5)
media_player.play()
```
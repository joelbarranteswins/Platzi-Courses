

## ¿Qué es una función?
Que es una funcion
Es como una maquina … ingresa el elemento x y sale el elemento y
Es una regla que asigna a cada elemento del conjunto A un elemento del conjunto B
Modelan nuestra realidad

Formas de representar una función:
* Verbalmente
Ejemplo: “El precio aumento en 2 dólares por cada kilómetro recorrido”
* Numéricamente
Puede ser con una tabla de valores donde tenemos un valor x y un valor f(x) que le corresponde
* Visualmente
La gráfica en un plano cartesiano, una forma muy común de comprobar si es una función de esta manera, es trazar una línea sobre la función y si pasa a tocar más de 1 punto, entonces no es una función.
* Algebraicamente
Ejemplo: función de la parábola f(x)=x^2


## Tipos de variables
* Variables cualitativas
Variables nominales: Se les asigna una cualidad (rojo, verde, azul, etc. en el caso de un LED)
Variables ordinales: Representan un orden. Por ejemplo, la altura de un objetos se puede clasificar como alto, medio o bajo
Variables binarias: Solo toman 2 valores, usualmente usadas para representar estados. (frío o caliente, uno o cero)

* Variables cuantitativas
Variables discretas: Representan un grupo de datos que son finitos y toman ciertos valores. Pueden verse como variables separadas por un “paso”. Por ejemplo, una persona puede tener 0,1,2,3 amigos pero no 3.5 amigos
Variables continuas: Sus valores pueden verse como infinitos al tomar cualquier valor dentro de los números reales en un rango establecido. Por ejemplo, la altura de una persona
Lo que se suele modelar para escribir funciones, se suele encontrar en el grupo de variables cuantitativas.

<img src="./img/variables.jpg">

## Dominio y rango de una función
* Dominio de una función
Son los valores que toma x y que están definidos en la función f(x)

* Rango de una función
Son los valores que puede regresar una función.

## Cómo leer las matemáticas: Conjuntos

Los diagramas de Venn son otra forma de representar un conjunto de manera gráfica. Los diagramas nos permiten comprender y analizar fácilmente los conjuntos.

* Al conjunto que no contiene elementos se le llama conjunto vació y se denota con el símbolo ϕ
observación: El conjunto que tenga solo el elemento 0 o el ϕ es no vacío.

* La unión de dos conjuntos A y B es el conjunto formado por todos los elementos de ambos conjuntos sin repetir ninguno y se representa así: A ∪ B = {x | x ∈ A ó x ∈ B}

* La intersección de dos conjuntos A y B son el conjunto de elementos que forman parte tanto de A como de B, es decir: A ∩ B = {x | x ∈ A y x ∈ B}

* La diferencia de dos conjuntos A y B, es un conjunto formado por todos los elementos de A que no están en B y se escribe así: A\B = A - B = {x ∈ A | x ∉ B}

* Dados dos conjuntos, el conjunto universal Ω que es el conjunto que incluye a todos los elementos y un conjunto A subconjunto de Ω. El complemento de A son todos aquellos elementos del conjunto universal que no pertenecen a A, es decir: A’ = {x ∈ Ω | x ∉ A}

* Según su número de elementos, los conjuntos se pueden clasificar como finitos o infinitos.
La cardinalidad de un conjunto A es la cantidad de elementos diferentes que tiene y se representa con |A|
Un conjunto es finito si se conoce su cardinalidad (podemos contar sus elementos) e infinito si se desconoce su cardinalidad (no podemos contar sus elementos).

<img src="./img/conjuntos.webp">

## Funciones algebraicas lineales

Una función lineal es una función polinómica de primer grado. Es decir, tiene la siguiente forma

$$f(x)=mx + b$$ donde $m$ y $b$  $\in R$. 

$m$ puede ser calculada por: $$m=\frac{y_{2}-y_{1}}{x_{2}-x_{1}}$$

y $b$ es el punto de corte con el eje $y$. Su dominio es $Dom_{f} = (-\infty, \infty)$. Su imagen es $Im_{f} = (-\infty, \infty)$

m es la pendiente de la función
n es la ordenada (en el origen) de la función
Para complementar, m se le conoce como pendiente de la recta y puede puede deducir la siguente ecuación:

~~~Latex
m = tan θ
~~~

Donde θ es el angulo formado con el eje x

## Funciones algebraicas polinómicas


Tiene la forma de $$P(x)=a_{n}x^{n} + a_{n-1}x^{n-1}+...+a_{2}x^{2}+a_{1}x + a_{1}$$

a una función que tiene esta forma se le llama polinomio de grado $n$. A los elementos $a$ los llamaremos coeficientes donde $a \in R$. 

**Por ejemplo:**

$$P(x)= 2x^{7} - x^{4} + 3x^{2} + 4$$

que es un polinomio de grado 7.


#### Funciones potencia

Hay unas funciones que son un caso particular de las funciones polinómicas que son las funciones potencia, las cuales tienen la forma:


$$f(x)= x^{a}, a \in R$$ 


**Por ejemplo:**

$$f(x)= x^{2}$$

El dominio de $f(x)=x^{2}$ es $Dom_{f} = (-\infty, \infty)$. Su imagen es $Im_{f} = [0, \infty)$

polinomios pares existe se abre como una u, y si es impar es como una s

## Funciones trascendentes

Son funciones que no pueden ser expresadas con polinomios. 

#### Funciones trigonométricas

Algunos ejemplos son las funciones $cos(x)$, $sen(x)$ y $tan(x)$
#### Función exponencial

Tienen la forma de $$f(x)=a^x$$ donde la base $a$ es una constante positiva. Un gran ejemplo de una función exponencial es usando la base como el número de euler:

$$f(x)=e^x$$


#### Función logaritmo

El logaritmo está definido por la **relación**:

$$log_{b}(x) = n \Longleftrightarrow x=b^n$$ 

donde: 



*   $b$ es la base.
*   $n$ es el exponente al que está elevado la base.
*   $x$ es el resultado de elevar la base $b$ al exponente $n$

**Ejemplo:**

Teniendo b=2 y n=8, entonces:

$$2^8=256$$

Por lo que $x=256$. Calculando el logaritmo base 2 de $x$ es:

$$log_{2}(256) = 8$$

# Función seccionada

funcion escalon de heavyside <br/>
Son funciones que tienen diferentes valores definidos por un intervalo. Por ejemplo la función escalón de Heaviside: 

$$H(x) = 
     \begin{cases}
        0, &\quad \text{para, } x < 0 \\
        1,  &\quad\text{para. } x \ge 0 \\
     \end{cases}
$$


## Funciones compuestas


<img src="./img/funcion_compuesta.jpg">

## ¿Cómo manipular funciones?

#### Desplazamientos verticales y horizontales

Siendo $c$ una constante mayor que cero, entonces la gráfica:

- $y=f(x)+c$ se desplaza $c$ unidades hacia arriba.
- $y=f(x)-c$ se desplaza $c$ unidades hacia abajo.
- $y=f(x-c)$ se desplaza $c$ unidades hacia la derecha.
- $y=f(x+c)$ se desplaza $c$ unidades hacia la izquierda.

#### Alargamientos y compresiones

Siendo $c$ una constante mayor que cero, entonces la gráfica:

- $y=c \cdot f(x)$ alarga la gráfica verticalmente en un factor de $c$.
- $y= \frac{1}{c} \cdot f(x)$ comprime la gráfica verticalmente en un factor de $c$.
- $y=f(c \cdot x)$ comprime la gráfica horizontelmente en un factor de $c$.
- $y= f(\frac{1}{c} \cdot x )$ alarga la gráfica horizontelmente en un factor de $c$.


#### Reflexiones

- $y=-f(x)$ refleja la gráfica respecto al eje x.
- $y=f(-x)$ refleja la gráfica respecto al eje y.
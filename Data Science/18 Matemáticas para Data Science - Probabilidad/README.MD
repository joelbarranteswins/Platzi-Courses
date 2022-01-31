

# Matematicas para data science: Probabilidad

## ¿Qué es la probabilidad?

* **La probabilidad** es una creencia que tenemos sobre la ocurrencia de eventos elementales.
¿En qué casos usamos la probabilidad?
Intuitivamente, hacemos estimaciones de la probabilidad de que algo ocurra o no, al desconocimiento
que tenemos sobre la información relevante de un evento lo llamamos incertidumbre.
El azar en estos términos no existe, representa la ausencia del conocimiento de todas
las variables que componen un sistema.
otras palabras, la probabilidad es un lenguaje que nos permite cuantificar la incertidumbre

AXIOMAS:
Es un conjunto de sentencias que no son derivables de algo más fundamental. Las damos por verdad
y no requieren demostración.

“A veces se compara a los axiomas con semillas, porque de ellas surge toda la teoría”
Axiomas
AXIOMAS DE PROBABILIDAD :

La probabilidad está dada por el número de casos de éxito sobre la cantidad total(teórica) de casos.

P = #-Casos de éxito/ # Casos-totales.

Suceso elemental: Es una única ocurrencia, “Solo tienes una cara de la moneda como resultado”

Sucesos: Son las posibilidades que tenemos en el sistema. Está compuesto de sucesos elementales,
por ejemplo, “El resultado de lanzar un dado es par”, hay tres sucesos (2,4,6) que componen este enunciado.

De la interpretación del axioma anterior divergen dos escuelas de pensamiento. Frecuentista y Bayesiana

Ejemplo: “Solo tengo dos posibles resultados al lanzar una moneda, 50% de probabilidad para cada cara
, (1/2 y 1/2), si lanzo la moneda n veces, la moneda no cae la mitad de las veces en una cara, y luego la otra”

Esta equiprobabilidad de ocurrencia en un espacio muestral ocurre bajo el supuesto de que
la proporción de exitos/totales tiende a un valor p. En otras palabras, solo lanzando la moneda
infinitas veces podemos advertir que el valor de la probabilidad es cercano a (1/2 o 50%).
Escuela frecuentista

“Toda variable aleatoria viene descrita por el espaci muestral que contiene todos los posibles sucesos
de ese problema aleatorio.”

La probabilidad que se asigna como un valor a cada posible suceso tiene varias propiedades por cumplirse

PROPIEDADES AXIOMAS:

0 <= P <= 1
Certeza: P = 1
Imposibilidad P = 0
Disyunción P(AuB) = P(A) +P(B)
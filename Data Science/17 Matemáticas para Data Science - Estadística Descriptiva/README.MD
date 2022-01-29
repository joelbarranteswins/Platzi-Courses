
## 1. Estadística descriptiva vs. inferencial

Estadística descriptiva vs. inferencial
Es importante entender la diferencia entre las dos principales ramas de la estadística en el area de las matemáticas:

Estadística descriptiva: Se trata de resumir información de manera cuantitativa para entender de forma sencilla y concreta sobre algún determinado asunto
Estadística inferencia: Se basa en realizar inferencias, deducir que podría pasar en el futuro en base a lo datos que tenemos acceso en la actualidad
¿Puede mentir la estadística?

La estadística descriptiva tiene un problema al momento de definir que métrica es la que nos va a brindar la mayor relevancia para nuestro estudio.

El resultado podría estar sesgado a nuestro criterio personal, mostrando mayor interés a un cierto parámetro. dejando de lado a otro que también podría ser relevante. Mostramos solo una cara de la moneda.
No existen definiciones objetivas en estadística, sin embargo sobre estas definiciones podemos realizar cálculos exactos lo cual es un problema
Los diferentes estadísticos descriptivos dan nociones diferentes sobre los mismos datos.
¿Por que aprender estadística?

A pesar de los problemas que pueda presentar es muy importante entender que la estadística nos puede ayudar a:

Resumir grandes cantidades de información
tomar mejores decisiones
responder preguntas con relevancia social
reconocer patrones en los datos
descubrir a quien usan estas herramientas con fines nefastos

<img src="./img/estadistica.png">


## 2. Flujo de trabajo en data science

Puede existir profesiones que se enfoquen mas a cada una de fases, no existe un perfil de data science que se encargue a todo el flujo de trabajo.

¿En que partes del flujo de trabajo se necesita de estadística?

Todos las partes del flujo requiere del conocimiento en ciertas ramas de la estadística. La estadística descriptiva se va a emplear más en los dos primeros bloques de trabajo.

Ingesta de datos y Validación : Se encarga de todo el procesamiento de ETL (Extract Transform Load) obtener los datos, limpiarlos y estructurarlos, crear pipelines de análisis automatizado, es decir que transformaciones vamos a realizar a los datos para que estén listos para el caso especifico de estudio que vamos a realizar.

Preparación y entrenamiento del modelo: En este bloque se va a realizar un análisis exploratorio de los datos con estadística descriptiva, entender correlaciones y realizar posibles reducciones de datos.

Evaluar el modelo, Producción e Interacción: esta parte del flujo se basa mas en la estadística inferencial.

<img src="./img/flujo_de_trabajo.jpg">

<img src="./img/secuencia_de_datos.jpg">

**El flujo de trabajo en Data Science tiene 8 pasos:**

1. Data ingestion.
2. Data visualization.
3. Data preparation.
4. Model training .
5. Model evaluation.
6. Model validation.
7. Model serving.
8. En user interface.

No existe un solo perfil de científico de datos que se encargada de todo el flujo.
Los roles son:

* Ingeniero de datos
* Analista de datos
* Científico de datos genérico
* Ingeniero de Machine Learning
* Científico investigador

Todos los roles necesitan saber estadística en las fases que les corresponde desarrollar en el flujo.
 del curso
¿Cuál es diferenciador de este curso?
Sabemos y tenemos bien claro que la estadística descriptiva es súper común, pero el diferenciador más grande de este curso es que estamos contextualizando la estadística descriptiva específicamente para Ciencia de Datos. No solo vamos a entender las fórmulas matemáticas si no el contexto de la estadística para descubrir todas las caras que tiene.

¿Cuáles serán los puntos específicos que vamos a tratar en este curso?

* **Primera parte del curso:** Vamos a abordar cuales son los elementos de estadística la descriptiva para la ingesta y el procesamiento de los datos.


* **Segunda parte del curso:** Vamos a ver análisis exploratorio de los datos, identificar correlaciones de los datos, abordaremos si a partir de eso podemos reducir el conjunto de datos que necesitamos para un modelo, por ejemplo. Entonces, el objetivo es abordar los estadísticos para exploración y analítica.


## 3. Medidas de tendencia central

Son medidas que nos ayudan a resumir una gran cantidad de información en un solo numero

* **Media:** Es el promedio de todos los datos, puede ser susceptible a valores atípicos
* **Mediana:** es el dato central es decir tiene la misa cantidad de datos a su izquierda y derecha, no es lo mismo que la media
* **Moda:** es el dato que mas se repite, la moda no aplica para datos numéricos continuos

#### 4. Diagrama de frecuencia
Es la representación grafica asociada a la tabla de frecuencia, normalmente todos los estadísticos descriptivos se pueden representar en términos de esta distribución

<center>
<img src="./img/diagrama_de_frecuencias.jpg">
</center>

* la media es suceptible a valores atipicos
* la moda no se aplica a datos numericos continuos

## 5. Metáfora de Bill Gates en un bar

**Media aritmética (promedio)**
Dados los n números la media aritmética se define como:

<center><img src="./img/media.jpg"></center>

**Mediana**
formulas matematicas de la mediana
<center><img src="./img/mediana.jpg"></center>


**Resumen de la metafora de BIll Gates:**

* Esta metáfora nos muestra que al tener valores atípicos nuestra media se vera sesgada o desviada.

<center><img src="./img/metafora_de_bill_gates.jpg"></center>

* La mediana será un mejor valor para manejar un conjunto de datos con valores atípicos.

<center><img src="./img/metafora_de_bill_gates_2.jpg"></center>

Por esto hablar del ingreso per cápita de un país es equivocado cuando hay una distribución de riqueza desigual.

## Medidas de tendencia central en Python
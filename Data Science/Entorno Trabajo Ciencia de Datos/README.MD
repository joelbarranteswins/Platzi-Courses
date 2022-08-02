# 🐍 Notas del Curso de Entorno de Trabajo para Ciencia de Datos

Introducción a las notebooks.
¿En qué lugares programar para ciencia de datos?

Aprenderemos sobre Jupyter Notebooks, herramientas elementales, ambientes virtuales con Conda 🐍.
Podemos programar en varios lugares: Navegador, de manera local, en un servidor, en el celular 🤯.
Puedes hacer esto en distintos sistemas operativos, en cualquiera está bien, pero por lo general se prefiere en un OS basado en Linux o Unix (cómo Ubunto o MacOS). Si prefieres Windows, puedes usar WSL 😄.
Google Colab, Deepnote, VSCode, Jupyter Notebooks, etc… 🧠. Todas estas herramientas comparten una cosa: los notebooks, que hacen el proceso más dinámico!.
En 2001, el Físico colombiano Fernando Pérez comenzó a trabajar en el desarrollo IPython 👀. De aquí siguió Jupyter Notebook 🗒️. ¡Es una herramienta fundamental! Se pueden entender como reportes ejectuables.
Notebooks vs Scripts:
Ambos son útiles.
Tienen diferencias en organización: En un script se ve el código sin interrupciones.
    Experimentación y prototipado.
    Tienen objetivo diferente!.

## Google Colab: Primeros pasos.

Es una herramienta basada en la nube que te permite trabajar en notebooks, y se guardan en tu cuenta de Google Drive 😃.

Nube vs local: Ambas son útiles, pero se diferencian en la configuración de entornos, ya que en la nube ya están precargadas, y de local tienes que configurarlo manualmente. También es diferente el tiempo de ejecución y la escalabilidad: la nube tiene más poder porque puedes rentarlo!. 💸

Google Colab: Servicio en la nube basado en Jupyter Notebooks, no requiere configuración y tiene un trabajo a nivel de archivo (el notebook es la base). Tiene uso de gratuito de GPUs y TPUs para correr modelos grandes. ☁️

Puedes acceder a Google Colab desde tu drive o desde el navegador.

Para aprender Markdown.

Markdown Guide

Las variables son persistentes (se conservan) entre celdas de código!. 🔥

Para llamar a la línea de comandos, debemos usar primero un signo de admiración ! y luego un comando válido, por ejemplo !pwd o !pip install session-info.

## Google Colab: Ciencia de datos.

Google Colab incluye varias herramientas:

Podemos subir archivos a Colab para trabajar con ellos (también tienen datos de muestra) 🔢. Dándole click podemos previsualizar e incluso filtrar la tabla que hayamos subido.
Podemos montar nuestro Google Drive en nuestro Notebook, con lo que podremos trabajar con datos que estén en nuestro Drive. 🤓 Es lo más recomendable ya que los archivos no se eliminan al terminar la sesión.
Ya incluye multiples librerías (las mas usadas) como Matplotlib, Numpu, Pandas, Scipy, Seaborn, etc. 💫
Google Colaboratory tiene code snipets, para que puedas utilizarlo y agilizar tu trabajo 🤯.
Para abrir la paleta de comandos usamos Ctrl + shift + p. Es útil conocer los shortcuts más útiles para ser más ágil.



## Google Colab: ciencia de datos
Puedes cargar archivos a tu notebook desde tu computadora, pero se borrarán una vez cierres tu notebook. También puedes vincular tu google drive para que tome los archivos desde ahí y de esta forma conservarlos.

Colab está enfocado a trabajar con Python (también puede usar otros lenguajes) y ya trae librerías de ciencia de datos precargadas como:

~~~~
matplotlib: Generación de gráficos a partir de listas o arrays.

numpy: Cómputo científico para la manipulación de vectores.

pandas: Manipulación y análisis de datos de tablas y series temporales.

scipy: Herramientas y algoritmos matemáticos.

seaborn: Visualización de datos estadísticos.
~~~~

Colab también tiene fragmentos de código (parecido a la herramienta para insertar funciones de Excel) que te facilita la programación.
Con ctrl + shift +p abres la paleta de comandos, si escribes shortcuts o atajos de teclado te mostrará una lista de todos los atajos que puedes ejecutar en Colab.


Otra forma para acceder a los archivos en Google Drive

Paso 1
~~~~
from google.colab import drive
drive.mount('/content/drive/')
~~~~
Accedemos al link que nos da como respuesta al ejecutar las dos líneas de código de arriba y le damos permiso de acceso a nuestra cuenta de Drive.

Paso 2
~~~~
%cd '/content/drive/My Drive/Carpeta_donde_se_encuentra_el_archivo/'
!ls
~~~~
Con %cd accedemos a la carpeta donde tenemos el archivo con el que vamos a trabajar
con !ls nos aseguramos que estamos en la carpeta correcta

Paso 3
~~~~
import pandas as pd
df = pd.read_csv('iris.csv')
~~~~
Por último, importamos pandas (librería para leer archivos .csv) y cargamos el archivo como data frame.


## Utilizar Deepnote.

Deepnote es un servicio en la nube basado en Jupyter Notebooks. No requiere configuración y tiene un trabajo a nivel de proyecto. Tiene colaboración en tiempo real, integración con múltiples Apps y tiene acceso a una terminal o línea de comandos integrada 😎.

Tiene también variables de entorno y permite publicar proyectos (para construir portafolio). 🎉

Podemos correr y agregar lo mismo que en Colab, pero además podemos subir archivos que se quedan siempre en el proyecto.

Permite previsualizar los archivos CSV de manera muy bonita 😄.
Parte de lo poderoso de Deepnote es que podemos integrar muchas cosas 🔥.
No solo podemos agregar celdas de código y de texto, si no que en la opción de Bloque vienen muchos más tipos, como input, chart, dataframe sql, etc 🤯. Puede crear gráficas de manera automática sin código!
Para acceder a los atajos de teclado usamos Ctrl + i.
También es importante resaltar que tenemos una terminal integrada 🤖.


## Instalar VSCode

Editores de código: Enfocados a multiples lenguajes. Se pueden potencial con extensiones o plugins. Por lo general son gratuitos. Mejor este 😄. Tenemos Pycharm VSCode, Atom, etc.

IDE (entornos de desarrollo integrado): Enfocado a un solo lenguaje y seguimiento a un solo proyecto. Por lo general son de pago 💸

Visual Studio Code - Code Editing. Redefined

## Agregar extensiones para VSCode.

Hay muchas extensiones para VSCode que hacen trabajar con datos más cómodo. ☁️
Se pueden instalar todas las extensiones directamente desde VSCode 😄.
Es recomendable activar la sincronización automática en la nube, para que siempre puedas tener tu entorno de trabajo en cualquier lugar. Lo puedes contectar con tu cuenta de GitHub 🤖
Hay extension para Python que incluye muchas funcionalidades 🔥.
MagicPython sirve mucho para darle formato a Python y que sea más legible.
Las extensiones de Icon sirven para diferenciar tipos de archivos. 📁
Rainbow Brackets sirve para cambiar los colores de los paréntesis y no tener errores 🌈.
Remote Development te descarga múltiples extensiones que te sirven trabajar de manera remota. 🌎


## Uso de VSCode notebooks.

Esto es un nuevo estilo de Notebook, integrado dentro de VSCode 🤯.
Puedes abrir VSCode en una carpeta específica para ver todos los archivos dentro (y solo esos). Menos distracción que tener todo abierto con WSL. 😆
Podemos correr los archivos .py directamente en la terminal dando click en ▶️.
Con las extensiones que instalamos, podemos darle formato de manera automática a nuestro código 🐍.
Dentro de los Jupyter Notebook en VSCode podemos usar todas estas extensiones 💕. La extensión de los Notebooks es .ipynb. Podemos exportar los notebooks a texto plano!.

## ¿Qué son los ambientes virtuales?

En la vida real, no vas a trabajar en un solo trabajo, si no en varios, y cada uno tendrá diferentes dependencias y requerimientos 🤔.
Cuando se actualizan o se cambia la configuración de las dependencias de un ambiente que tiene varios proyectos asociados puede haber errores 🛑.
Para poder separar proyectos, lo que hacemos es crear ambientes virtuales diferentes para cada proyecto. 🧠 Entonces la configuración y actualizaciones son para cada proyecto.
Ambiente virtual: Proyecto que puede tener sus propias dependencias, independientemente de las dependencias que tengan los demás proyectos (Scott Robinson y la gente de Real Python).

## Instalar Conda a través de la terminal.

Conda: Programa diseñado para gestión de paquetes, dependencias y entorno para cualquier lenguaje: Python, R, Ruby, Lua, Scala, Java, JavaScript, etc. Además, es multiplataforma. 🖥️

Para instalar conda debes instalar anaconda (versión completa, metapaquete de ciencia de datos) o miniconda (versión mínima). 🐍

Para instalar conda:

Anaconda | Individual Edition

O bien hacer wget -0 anaconda.sh https://repo.anaconda.com/archive/Anaconda3-2021.05-Linux-x86_64.sh.

Para instalar hacemos bash anaconda.sh. 🐍

Para abrir notebooks usamos jupyter-notebooko bien jupyterlab. Los notebooks que creas ahí también los puedes abrir en VSCode.

Para abrir VSCode en la carpeta en el que te encuentras, usas code ..

## Conda: crear y actualizar ambientes.

Conda tiene por defecto el ambiente base 😄
conda env list para ver todos tus ambientes existentes.
conda create --name <nombre de ambiente> <paquete1>=<version1> <paquete2>=<version2> para crear un ambiente nuevo. 👀 Si no se especifica la versión, se toma la mas reciente.
conda activate <nombre de ambiente> para activar un ambiente.
conda deactivate para desactivar el ambiente actual.
conda list muestra todos los paquetes (y sus versiones) en tu ambiente. Para filtrar resultados (en ambientes grandes) conda list pandas.
conda update <paquete> para actualizar la versión mas reciente de un paquete.
conda install <paquete>=<version> para poner un paquete en una versión específica.

Para clonar un ambiente:
~~~~
conda --name [nuevo ambiente] --copy --clone [ambiente]
~~~~



## Conda: abrir VSCode Notebooks con tu ambiente creado

solo se debe cambair el kernel


## Conda: Eliminar ambientes y librerías.

conda remove <paquete> para desinstalar un paquete en particular. 🗞️
conda env remove <nombre de ambiente> para eliminar un ambiente completo 👀.
No se puede eliminar el ambiente en el que te encuentras 🤔. Necesitas desactivarlo primero.


## Conda: Comandos avanzados.

Para buscar paquetes:
Anaconda.org
Podemos encontrar algún paquete que necesitemos en un channel como conda-forge. 😯
conda install --channel <nombre del canal> <paquete> Para instalar un paquete especificando el channel de donde buscarlo.
conda list --revision para listar las revisiones (modificaciones) de tu ambiente; con esto puedes volver en el tiempo a un estado pasado de tu ambiente virtual.
conda install --revision <falg> para regresar a un estado pasado de tu ambiente. 🌲
conda env export --no-build Para compartir nuestro ambiente de conda y que otras personas puedan tener exactamente el mismo ambiente que tú.
Con conda env export --from-history --file <archivo>.yml para compartir únicamente los paquetes que hayamos especificado explícitamente. 🔍. Esta es la mejor manera!
Para instalar un ambiente del cual recibimos un archivo .yml hacemos conda env create --file <archivo>.yml 🤯


### Comandos avanzados:

Crear ambiente virtual

 conda create --name [nombre_paquete] [paquetes]

Instalar paquete que no esta disponible en el canal principal de conda:

 conda install -c [nombre_canal] [nombre_paquete] 

Enlistar las revisiones del estado del ambiente virtual:

 conda list --revision

Volver al estado de una revisión anterior:

 conda install --revision [nombre_revision]

Crear una descripción del ambiente con todas sus dependencia para compartir:

 conda env export  --no-builds

Crear una descripción del ambiente solo con los paquetes agregados manualmente (tiene la ventaja que permite mayor compatibilidad multiplataforma, daod que conda se encarga de instalar las dependencias especificas para los paquetes en el SO):

conda env export --from-history

Crear un archivo con la descripción(suele ser común en este tipo de archivos el formato .yml):

conda env export --from-history --file nombre_archivo.yml

Instalar ambiente virtual desde archivo:

conda env create --file nombre_archivo.yml

Espero pueda ser de utilidad para todos!


## Acelerar la creación de ambientes virtuales con Mamba.

Mamba es una re-implementación de Conda (en C++) para la creación de ambientes virtuales. 🤖 Lo hace en paralelo, e incluye multiples optimizaciones que lo hacen más rápido.
Mamba funciona de la misma manera que conda en la línea de comandos. 🤔
conda install --channel conda-forge mamba para instalarlo.
Anaconda es muy tardado en multiples ocasiones (ya que es muy pesado). 😢


## Bonus: Divide y vencerás.

En proyectos grandes, es complicado mantener un ambiente virtual. 😵
Divide y vencerás es partir un problema difícil en partes pequeñas. Cada paquete se desarrolla a su propio ritmo (no siempre preocupándose de la compatibilidad con otros módulos). 🤯
Hay tres tipos de paquetes: Externos, Modelo y de Comunicación. Entonces podemos crear en multiples ambientes en un solo proyecto. 👀 Para esto, creamos una carpeta llamada envs y creamos tres documentos: external.yml, model.yml y comunicacion.yml.
Snakemake es un paquete que implementa muy bien este concepto. Es un motor de workflows 👀. Cada paso lo ejecuta con un ambiente específico.

[](https://snakemake.readthedocs.io/en/stable/)
[](https://platzi.com/blog/como-personalizar-tu-terminal/)
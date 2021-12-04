# Clases del Curso de Introducción a la Terminal y Línea de Comandos

## Comandos Basicos de la terminal:

Listar archivos:

    ls

Listar archivos para ver su peso de una manera mas mas legible

    ls -lh

Listar archivos ocultos:

    ls -a

Identificar la ruta en la que estamos en nuestro sistema:

    pwd

Movernos entre directorios:

    cd

Crear un directorio:

    mkdir

Copiar un archivo:

    cp

Borrar un archivo:

    rm

Mover un archivo:

    mv

Borrar un directorio:

    rmdir

Limpiar la terminal

    clear

## Anatomía de un CLI o Command Line Interface

Definición

    Un comando es una acción escrita, generalmente, a través de una terminal y emulada por una shell para ser ejecutada por nuestro sistema operativo.


Comandos de la clase

    pwd o print working directory. Comando para encontrar el ruta actual de trabajo de manera absoluta o desde el directorio /
    cd o change directory. Comando para navegar entre directorios requiriendo, dependiendo, del directorio o ruta a navegar.
    Hay varios shortcuts para navegar rápidamente:
        cd .. para mover a un directorio inmediato anterior
        cd para ir al directorio home
        cd - para mover a un directorio previo
    ls. Comando para ver el contenido de un directorio. Por defecto, se mostrará el contenido del directorio actual.
    Algunas opciones son:
        ls -R listar archivos de sub-directorios
        ls -al listar archivos ocultos y de manera detallada
    file . Comando para reconocer el tipo descriptivo del archivo

## Manipulando archivos y directorios.

    Todo lo que hacemos normalmente en una interfaz gráfica, lo podemos hacer en la terminal 👀.
    ls: Algunas variantes:
        ls -la: Nos muestra todo, incluso los ocultos.
        ls -lS: Los ordena por tamaño.
        ls -lr: Los muestra en reversa.
    tree: Nos muestra todo, lo que hay dentro de cada carpeta, en forma de arbol 🌲. Podemos elegir el nivel de profundidad con tree -L <numero de niveles>
    mkdir <nombre de directorio>: Para crear un directorio nuevo 📁. No es buena idea en general poner espacios en el nombre de los directorios. Si lo quieres hacer, usa comillas "Nombre con espacios".
    touch <nombre de archivo>: Para crear archivos vacíos. Puedes crear varios con un solo comando 📄.
    cp <archivo a copiar> <nuevo archivo>: Para copiar un archivo. Si no se pone una ruta en el nombre del nuevo, se va a copiar en el directorio donde estés 🖨️.
    mv <archivo> <archivo con nueva ruta>: Para mover archivos a otra ruta. También te sirve para renombrarlos 💫, funciona con directorios y con archivos.
    rm <archivo>: Elimina archivos. Hay una opción muy útil que es rm -i <archivo>(interactivo) que te pregunta explícitamente si en verdad si quiere borrarlo 😟. Funciona de manera directa para directorios vacíos, pero si hay archivos dentro, debes usar la opción recursiva rm -r <directorio>, que lo que hace es ir borrando todo lo que hay dentro y al final borra el directorio 🔫. Te va preguntando por cada cosa.
    Ojo: Lo que borras desde la terminal se borra para siempre 😟.

### ¿Y para qué me sirve correrlo como interactivo?

    Si te preguntaste esto es porque seguramente aún no te has dado cuenta de lo peligroso que es eliminar algo. Cuando tú eliminas algo desde la terminal, este archivo/carpeta se elimina… PARA SIEMPRE *chan, chan chan*.
    .
    Con esto me refiero a que ese archivo que eliminaste NO se va a mover al basurero, sino que directamente se va a eliminar, y la única forma de recuerarlo podría ser con algún programa que lea sector por sector de tu disco duro.
    .
    He visto por ahí cuando alguien pregunta por cómo eliminar una carpeta, el comando que más comparten es rm -rf carpeta sin saber exactamente qué es lo que hace, ahora ya saben que poner esa “f” como parámetro es muy peligroso. Con poner “r” basta, esto porque el borrado es recursivo básicamente recorrerá cada subcarperta/archivo y las irá borrando uno por uno.
    .

### DANGER ZONE

    .
    Ahora quiero explicarte por qué este comando es peligroso, tanto que puedes llegar a eliminar tu sistema operativo, NO CORRAS ESTE COMANDO POR NADA DEL MUNDO.
    .
    Imagina que quieres eliminar alguna carpeta de tu computadora usando la terminal, y por alguna razón decides usar una ruta absoluta:

    rm -rf / home/tuUsuario/carpetaAEliminar/

    Todo bien… ¿verdad? Bien, si ejecutaras este comando todo tu sistema operativo desaparecería, ¿por qué? quiero que te fijes cómo entre el / y la palabra home hay un espacio… ¿recuerdas qué significaba esa /? Ya lo vimos 👀… Así es, la carpeta raíz, la carpeta donde vive todo tu sistema operativo, y le estás diciendo que la elimine a la fuerza, ese espacio indica que la a eliminar dos carpetas, primero eliminará / y luego eliminará home/tuUsuario/carpetaAEliminar/.
    .
    El comando correcto que deberíamos usar es:

    rm -rf /home/tuUsuario/carpetaAEliminar/


## Explorando el contenido de nuestro archivos.

    Podemos explorar el contenido de archivos sin la necesidad de abrirlos, desde la terminal 🧐. Esto para archivos de texto.
    head <documento de texto>: Nos muestra las primeras 10 líneas de un archivo de texto. Para especificar el número de líneas head -n <numero de lineas> <archivo>
    cat <documento>: ver todo el contenido
    tail <documento>: Nos muestra las últimas 10 líneas.
    less <archivo>: Este es muy cool, es muy interactivo, nos permite hacer scroll, y nos permite hacer búsquedas haciendo /<palabra a buscar>. Para salir presionamos q 🔍.
    xdg-open <archivo>: Para abrir un archivo desde la terminal. Usa las aplicaciones predeterminadas. Esto para linux, para mac, es open. Esto crea un proceso en la terminal que no nos dejará hacer nada mas. Para terminar el proceso ctrl+c.
    nautilus nos permite abrir el explorador de archivos en una posición dada (en linux) 📁.

## Un comando puede ser 4 cosas:

    Un programa ejecutable: que se compilo en algun lenguaje de programación y se puede ejecutar

    Un comando de utilidad de la shell.

    Una función de shell
 
    Un alias

Comandos

    type nos permite saber que clase es un comando. Por ejemplo type cd (es una funcion de shell), ls (es un alias)

    Para crear un alias: alias ‘nombreDelAlias’ = ‘comandoQueInvoca’. Por ejemploalias l=”ls -lh”. Temporales, por el momento.

    Con –help o help, puedes tener una ayuda sobre los comandos.

    man ‘comando’ : hace referencia al manual de usuario de un comando, otro similar es informático

    whatis ‘comando’ : nos da una descripcion muy corta de que hace ese comando. Pero no funciona con todos.

## Wildcards

    Son una serie de caracteres especiales que nos permiten realizar búsquedas muy avanzadas utilizando ls 🔍. Puedes utilizar wildcards con otros comandos que realicen manipulación de archivos como mv, cp o rm 💫. También se conocen como comodines.
    ls *<texto>: Nos muestra todos los archivos que tengan en su nombre dicho texto al final. Si haces ls <texto>* lo busca al final. El asterisco significa cualquier string.
    ls <text>? El signo de interrogación sustituye a cualquier carácter, por ejemplo, buscamos todos los archivos que tengan una palabra y un número dado de caracteres después. El signo de interrogación significa cualquier carácter.
    ls [[:upper:]]* Para filtrar cosas que inicien que una mayúscula; esto busca también dentro de los directorios.
    ls [[:lower:]]* Lo mismo pero con minúsculas.
    ls -d Se muestran solo directorios.
    ls [ad]* Todo lo que inicie con a o con b





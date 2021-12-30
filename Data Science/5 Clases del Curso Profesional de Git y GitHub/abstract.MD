# Curso Profesional de Git y GitHub


## ¿Por qué usar un sistema de control de versiones como Git?

Un sistema de control de versiones como Git nos ayuda a guardar el historial de cambios y crecimiento de los archivos de nuestro proyecto.

En realidad, los cambios y diferencias entre las versiones de nuestros proyectos pueden tener similitudes, algunas veces los cambios pueden ser solo una palabra o una parte específica de un archivo específico. Git está optimizado para guardar todos estos cambios de forma atómica e incremental, o sea, aplicando cambios sobre los últimos cambios, estos sobre los cambios anteriores y así hasta el inicio de nuestro proyecto.



* **git init**: El comando para iniciar nuestro repositorio, o sea, indicarle a Git que queremos usar su sistema de control de versiones en nuestro proyecto

* **git add <nombre_archivo>** : El comando para que nuestro repositorio sepa de la existencia de un archivo o sus últimos cambios. 
Este comando no almacena las actualizaciones de forma definitiva, solo las guarda en algo que conocemos como “Staging Area” (no te preocupes, lo entenderemos más adelante).

* **git commit** : El comando para almacenar definitivamente todos los cambios que por ahora viven en el staging area. ambién podemos guardar un mensaje para recordar muy bien qué cambios hicimos en este commit con el argumento ==-m "Mensaje del commit"==

* **git add .** : Es un comando que nos permite agregar al repositorio todos los archivos a los cuales se le haya hecho algún cambio.

* **git status** : Permite ver el estado de la base de datos. Por ejemplo, podemos ver si hay algunos cambios que no se han guardado en el repositorio, y si no hay nada nos dirá que todo esta bien.

* **git show**: Mostrara todos los cambios que hemos hecho, esto incluye las líneas que hemos cambiado, cuando y quien hizo dicho cambios.

* **git log** <nombre_archivo>: Muestra todo el historial del archivo.

* **git push** : si queremos mandar nuestros commits a un servidor remoto, un lugar donde todos podamos conectar nuestros proyectos

* **git push origin <nombre_rama>** : Sube la rama “nombre_rama” al servidor remoto.

* **git fetch** : Descarga los cambios realizados en el repositorio remoto.

* **git merge <nombre_rama>** : Impacta en la rama en la que te encuentras parado, los cambios realizados en la rama “nombre_rama”.

* **git pull** : Unifica los comandos fetch y merge en un único comando.

* **git checkout -b <nombre_rama_nueva>** : Crea una rama a partir de la que te encuentres parado con el nombre “nombre_rama_nueva”, y luego salta sobre la rama nueva, por lo que quedas parado en esta última.

* **git checkout -t origin/<nombre_rama>** : Si existe una rama remota de nombre “nombre_rama”, al ejecutar este comando se crea una rama local con el nombre “nombre_rama” para hacer un seguimiento de la rama remota con el mismo nombre.

* **git branch** : Lista todas las ramas locales.

* **git branch -a** :Lista todas las ramas locales y remotas.

* **git branch -d <nombre_rama>** : Elimina la rama local con el nombre “nombre_rama”.

* **git push origin <nombre_rama>** : Commitea los cambios desde el branch local origin al branch “nombre_rama”.

* **git remote prune origin** : Actualiza tu repositorio remoto en caso que algún otro desarrollador haya eliminado alguna rama remota.

* **git reset --hard HEAD** : Elimina los cambios realizados que aún no se hayan hecho commit.

* **git revert <hash_commit>** : Revierte el commit realizado, identificado por el “hash_commit”.


## Instalando Git y GitBash en Windows
Windows y Linux tienen comandos diferentes, graban el enter de formas diferentes y tienen muchas otras diferencias. Cuando instales Git Bash en Windows debes elegir si prefieres trabajar con la forma de Windows o la forma de UNIX (Linux y Mac) .

Ten en cuenta que, normalmente, los entornos de desarrollo profesionales tienen personas que usan sistemas operativos diferentes. Esto significa que, si todos podemos usar los mismos comandos, el trabajo resultará más fácil para todos en el equipo.

Los comandos de UNIX son los más comunes entre los equipos de desarrollo. Así que, a menos que trabajes con tecnologías nativas de Microsoft (por ejemplo, .NET), la recomendación es que elijas la opción de la terminal tipo UNIX para obtener una mejor compatibilidad con todo tu equipo.

## Instalando Git en Linux

Cada distribución de Linux tiene un comando especial para instalar herramientas y actualizar el sistema.

En las distribuciones derivadas de Debian (como Ubuntu) el comando especial es apt-get, en Red Hat es yum y en ArchLinux es pacman. Cada distribución tiene su comando especial y debes averiguar cómo funciona para poder instalar Git.

Antes de hacer la instalación, debemos hacer una actualización del sistema. En nuestro caso, los comandos para hacerlo son sudo apt-get update y sudo apt-get upgrade.

Con el sistema actualizado, ahora sí podemos instalar Git y, en este caso, el comando para hacerlo es sudo apt-get install git. También puedes verificar que Git fue instalado correctamente con el comando git --version


## Editores de código, archivos binarios y de texto plano


Un editor de código es una herramienta que nos brinda muchas ayudas para escribir código, algo así como un bloc de notas muy avanzado. Los editores más populares son VSCode, Sublime Text y Atom, pero no necesariamente debes usar alguno de estos para continuar con el curso.

Tipos de archivos y sus diferencias:

    Archivos de Texto (.txt): Texto plano normal y sin nada especial. Lo vemos igual sin importar dónde lo abramos, ya sea con el bloc de notas o con editores de texto avanzados.
    Archivos RTF (.rtf): Podemos guardar texto con diferentes tamaños, estilos y colores. Pero si lo abrimos desde un editor de código, vamos a ver que es mucho más complejo que solo el texto plano. Esto es porque debe guardar todos los estilos del texto y, para esto, usa un código especial un poco difícil de entender y muy diferente a los textos con estilos especiales al que estamos acostumbrados.
    Archivos de Word (.docx): Podemos guardar imágenes y texto con diferentes tamaños, estilos o colores. Al abrirlo desde un editor de código podemos ver que es código binario, muy difícil de entender y muy diferente al texto al que estamos acostumbrados. Esto es porque Word está optimizado para entender este código especial y representarlo gráficamente.

Recuerda que debes habilitar la opción de ver la extensión de los archivos, de lo contrario, solo podrás ver su nombre. La forma de hacerlo en Windows es Vista > Mostrar u ocultar > Extensiones de nombre de archivo.




## Introducción a la terminal y línea de comandos


Diferencias entre la estructura de archivos de Windows, Mac o Linux.

    La ruta principal en Windows es C:\, en UNIX es solo /.
    Windows no hace diferencia entre mayúsculas y minúsculas pero UNIX sí.

Recuerda que GitBash usa la ruta /c para dirigirse a C:\ (o /d para dirigirse a D:\) en Windows. Por lo tanto, la ruta del usuario con el que estás trabajando es /c/Users/Nombre de tu usuario

Comandos básicos en la terminal:

    pwd: Nos muestra la ruta de carpetas en la que te encuentras ahora mismo.
    mkdir: Nos permite crear carpetas (por ejemplo, mkdir Carpeta-Importante).
    touch: Nos permite crear archivos (por ejemplo, touch archivo.txt).
    rm: Nos permite borrar un archivo o carpeta (por ejemplo, rm archivo.txt). Mucho cuidado con este comando, puedes borrar todo tu disco duro.
    cat: Ver el contenido de un archivo (por ejemplo, cat nombre-archivo.txt).
    ls: Nos permite cambiar ver los archivos de la carpeta donde estamos ahora mismo. Podemos usar uno o más argumentos para ver más información sobre estos archivos (los argumentos pueden ser -- + el nombre del argumento o - + una sola letra o shortcut por cada argumento).
    - ls -a: Mostrar todos los archivos, incluso los ocultos.
    - ls -l: Ver todos los archivos como una lista.
    cd: Nos permite navegar entre carpetas.
    - cd /: Ir a la ruta principal:
    - cd o cd ~: Ir a la ruta de tu usuario
    - cd carpeta/subcarpeta: Navegar a una ruta dentro de la carpeta donde estamos ahora mismo.
    - cd .. (cd + dos puntos): Regresar una carpeta hacia atrás.
    - Si quieres referirte al directorio en el que te encuentras ahora mismo puedes usar cd . (cd + un punto).
    history: Ver los últimos comandos que ejecutamos y un número especial con el que podemos repetir su ejecución.
    ! + número: Ejecutar algún comando con el número que nos muestra el comando history (por ejemplo, !72).
    clear: Para limpiar la terminal. También podemos usar los atajos de teclado Ctrl + L o Command + L.

Todos estos comandos tiene una función de autocompletado, o sea, puedes escribir la primera parte y presionar la tecla Tab para que la terminal nos muestre todas las posibles carpetas o comandos que podemos ejecutar. Si presionas la tecla Arriba puedes ver el último comando que ejecutamos.

Recuerda que podemos descubrir todos los argumentos de un comando con el argumento --help (por ejemplo, cat --help).
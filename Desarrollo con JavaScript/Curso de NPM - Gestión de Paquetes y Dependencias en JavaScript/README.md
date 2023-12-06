




## 1. Gestión de dependencias

### Historia

* 995 Nacimiento de JS --> Uno de los lenguajes mas populares con miles de aplicaciones y grandes empresas apostando por este recurso

* 2009 Nace Node.js --> Un entorno en tiempo de ejecucion multiplataforma.

* 2009 NPM (Node Package Manager) --> Gestor de paquetes por defecto para Node.js

### ¿Qué son los gestores de dependencias? 
Organizan, administran y tienen una serie de herramientas las cuales podemos aprovehar en nuestros proyectos y ser mucho mas agiles en la creación de nuestras aplicaciones.

### Paquetes y modulos 
Van a ser instalados y utlizados segun sea el caso. Podemos tener paquetes que funcionan solamente de lado de node asi como tambien de lado de la arquitectura web.

### Herramientas que tenemos al instalar Node.js

    Repositorio onlines --> Podemos publicar paquetes que sean mejoras y/o ayudas para la construccion de aplicaciones.

    Command Line Client (CLI) --> Cliente que nos ayuda a trabajar de manera correcta con comandos


## 2. Instalación de NPM 

### en Windows

1. Link para la Instalación https://nodejs.org/es/

2. Validar las versiones con los siguientes comandos en la terminal

3. node -v

4. npm -v


### en Linux

1. Agregamos repositorio:

> sudo apt update
> sudo apt install curl dirmngr apt-transport-https lsb-release ca-certificates vim
> curl -sL https://deb.nodesource.com/setup_20.x | sudo -E bash -

2. Instalamos el último Node.js

> sudo apt install nodejs
> sudo apt install gcc g++ make

3. Confirmamos verisón

> node -v
> npm -v


## 3. Primeros pasos en NPM


Pasos de la clase:

* Crear espacio de trabajo
> mkdir npm 
> cd npm

* crear base del proyecto 
> npm init

* Tambien se puede utilizar para generar el archivo package.json
> npm init -y 

* se genera el siguiente json una vez creado el proyecto
~~~json
{
  "name": "npm-init",
  "version": "1.0.0",
  "description": "",
  "main": "index.js",
  "scripts": {
    "test": "echo \"Error: no test specified\" && exit 1"
  },
  "keywords": [
    "javascript.",
    "angular",
    "node"
  ],
  "author": "joel barrantes <joelbarrantespalacios@gmail.com>",
  "license": "MIT"
}
~~~


## 4. Instalación de dependencias

Instalar cualquier sependencia

> npm install moment

dependencia que solo va a ser utilizada en el entorno de desarollo
> npm install eslint --save-dev
> npm install eslint -D

dependencia para ser llevada a produccion.
> npm install react --save
> npm install react -S

Paquetes Globales

> npm install -g

Ver lista de los paquetes

> npm list

Ver lista de paquetes globlales

> npm list -g


## 5. Instalación de dependencias de versiones específicas

Instalar una dependencia opcional
> npm install package-name -o

Se pueden generar conflictos cuando se tienen paquetes que usan la misma dependencia pero en versiones diferentes. Para evitar esto se puede simular una instalación:
Con esto se simula la instalación pero sin agregar ningún paquete, si no hay ningún conflicto se procede a instalar de la manera convencional.

> npm install package-name —dry-run. 

Instalar la versión especifica de un paquete. 
> npm install package-name@0.15.0

Si luego se quiere instalar la versión más reciente se usa 
> npm install package-name@latest
    
Instala las dependencias que estén dentro de un package.json.
> npm install


## 6. Comandos en NPM (Scripts)

comando que correr los script en package.json
> npm run <script-name>

tambien funciona
> npm <script-name>


son lo mismo 
> npm run start
> npm start 


Sin embargo, dentro de node exite npm(node package management) y npx(node package execute)


Al crear la app de react 
> npx create-react-app react-npm 


## 7. Actualización de dependencias


Instala las dependencias que estén dentro de un package.json. por ejemplo al clonar un proyecto.
> npm install


Nos muestra las nuevas versiones disponibles de las dependencias y con la que contamos actualmente
> npm outdate

    
Instalar la versión mas reciente de la dependencia
> npm install name_package@latest


## 8. Seguridad y solución de problemas

Muchas veces algunas dependencias pueden llegar a comprometer nuestro proyecto y podemos verlos al momento de hacer el npm install, y nos muestra el tipo de vulnerabilidad:

* Moderates: pueden dejarse pasar, pues no tendrán mayor efecto.
* High: podemos considerarlas, esto puede volverse crítico.
* Critical: son las que si o si hay que reparar.


para ver las vulnerabilidades
> npm audit

mostrará la información de forma mas detallada en un formato json para analizarla mejor.
> npm audit --json

para reparar dependencias.
> npm audit fix 

para forzar implementar la reparación de las demás vulnerabilidades y por fin ser reparadas.
> npm audit fix --force

se usa para actualizar los paquetes a su última versión para que no esté causando vulnerabilidades.
> npm install nombre@latest


## 9. Eliminación de dependencias y Package lock

Elimina todo lo necesario que tiene esta dependencia.

> npm uninstall nombre-dependencia 

También podemos ir a nuestro proyecto en VSC y eliminarla dentro del listado de package.json, posterior a eliminarlo, lo que haremos será eliminar todas las dependencias y volver a instalar todas las que están en el package.json con los siguientes comandos:

limpiar dependencias
> rm -rf node_modules
> npm install

Para poder preparar nuestro proyecto y subirlo a producción, crea una carpeta bin
> npm run build 

activa el comando con más detalle e información de los archivos que creó.
> npm run build –-dd 

mostrará información como librerías deprecadas y paquetes que tenemos instalados en el proyecto, así como sincronizar el package.json con el package.lock.json
> npm ci 


### Package.lock.json

package-lock.json sencillamente evita este comportamiento general de actualizar versiones minor o fix de modo que cuando alguien clona nuestro repositorio y ejecuta npm install en su equipo, npm examinará package-lock.json e instalará la versión exacta de los paquete que nosotros habíamos instalado, ignorando así los ^ y ~ de package.json.

* Contiene toda la información necesaria de cada uno de los elementos del proyecto, dependencias, dependencias de desarrollo, etc. Puede ser rápido para identificar los elementos que requiere e instalarlos. (ideal no tocar)

    


## 10. Crear un paquete   


1. Crear un repositorio

2. Verificar que el nombre del repositorio sea igual al nombre que tendrá en npm
Verificar que el nombre no esta en npm (https://www.npmjs.com/) y que no hayan dependencias que hagan lo mismo que nosotros estamos a punto de publicar.

3. Clonar el repositorio en mi local

4. En el proyecto crearemos un archivo index.js (dentro de src) que tendrá la lógica del proyecto.

~~~js
const messages = [
  "This is where it all begins...",
  "Commit committed",
  "Version control is awful",
  "COMMIT ALL THE FILES!",
  "The same thing we do every night, Pinky - try to take over the world!",
  "Lock S-foils in attack position",
  "This commit is a lie",
  "I'll explain when you're older!",
  "Here be Dragons",
  "Reinventing the wheel. Again.",
  "This is not the commit message you are looking for",
  "Batman! (this commit has no parents)",
];

const funnyCommit = () => {
  const message = messages[Math.floor(Math.random() * messages.length)];
  console.log(`\x1b[34m${message}\x1b[89m`);
}

module.exports = {
  funnyCommit
};
~~~

5. Se crea una carpeta bin y dentro de ella el archivo global.js

~~~js
#!/usr/bin/env node
let random = require('../src/index.js');

random.funnyCommit();
~~~

6. Dentro del archivo package.json añadir

~~~json
"homepage": "https://github.com/gndx/random-str-msg#readme",
"bin": {
  "random-str-msg": "./bin/global.js"
},
"preferGlobal": true,
"dependencies": {
  "g": "^2.0.1"
}
~~~


## 11. Publicar un paquete


Crea un enlace simbólico, para reconocer a este paquete dentro del listado de paquetes de npm, sin publicarlo todavía pero si verificar que cumple todo lo requerido:

> npm link

Para probarlo se deben seguir los siguientes pasos

1. para saber exactamente donde se encuentra la ruta de nuestra dependencia.
> pwd

2. Simulará la instalación de la dependencia en nuestro local
> npm install g ruta-de-la-dependencia(pwd) 

3. Luego ya podemos correr nuestro programa en consola:
> random-str-msg

4. Ya verificado seguir con la creación de la cuenta y :
Añadimos los datos que nos pide la consola ...
> npm adduser

5. publica el paquete 🙌🏻
> npm publish

6. Se busca en npm la dependencia en npmjs.com y se verifica que este subida


## 12. Versionado de paquetes y paquetes privados

El versionado semántico está conformado por tres valores:

    Major: el valor que muestra la versión que contiene los cambios importantes del paquete
    Minor: el valor que muestra la versión que contiene los cambios en funcionalidades, pero no representan un cambio significativo
    Patch: el valor que muestra la versión que contiene cambios rápidos para solucionar problemas de seguridad o bugs

```bash
Aumenta una version path (1.0.0) -> (1.0.1)

$ npm version patch
Aumenta una version minor (1.0.0) -> (1.1.0)

$ npm version minor
Aumenta una version major (1.0.0) -> (2.0.0)

$ npm version major
Aumenta una version específica (1.0.0) -> (3.1.1)

$ npm version 
```


1. Se recomienda tener buen estructurado el archivo README.md para tener un mejor control de los cambios que se realizan al proyecto.  
Si cambiamos elementos del paquete, bien sea en la lógica, en los datos, etc, lo recomendable es tener varias versiones de la publicación del paquete.  
Una vez hecho un cambio, se debe actualizar a git con:

> git add .
> git commit -m “mensaje-del-cambio”

 
2. Se agrega la nueva versión, por ejemplo si tenemos la versión 0.0.0 se puede actualizar a:

> npm version 1.1.0

 

3. Se vuelve a publicar pero con la nueva versión:

> npm publish

 
4. Se revisa en la página de npm para ver los cambios de la versión.  

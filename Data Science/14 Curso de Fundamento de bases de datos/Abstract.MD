El almacenamiento en la nube tiene un gran pro comparada con los
otros métodos de almacenamiento ya que es accesible desde cualquier
parte del mundo. Además es centralizada y puede ser usada por varias
personas al mismo tiempo.

Las bases de datos entran cuando hacemos la transición a medios digitales.

**Tipos de bases de datos:**

**Relacionales:** En la industria hay varias compañías dedicadas a ser manejadoras de bases de datos relacionales como  **SQL Server, Oracle, MariaDB** , entre otras.

**No relacionales:** Todavía están avanzando y existen ejemplos muy distintos como  **cassandra, elasticsearch, neo4j, MongoDB** , entre otras.

**Servicios:**

* Auto administrados: Es la base de datos que instalas tú y te encargas de actualizaciones, mantenimiento, etc.
* Administrados: Servicios que ofrecen las nubes modernas como Azure y no debes preocuparte por mantenimiento o actualizaciones.



**Bases de datos relacionales (RBD)**

---

Es importante que sea fácil de guardar y extraer, anteriormente se
usaban bases de datos basadas en archivos, el cuál era texto plano fácil
de guardar, pero difícil de extraer, por esto se inventaron las bases
de datos relacionales. En 1990 Codd se preocupó porque los sistemas de
gestión de bases de datos (SGBD) que decían ser relacionales, no lo
eran. En la práctica es difícil cumplir las 12 pero, un SGBD es más
relacional cuantas más reglas cumpla

---

---

**Las Reglas y mandamientos de Edgar Frank Ted Codd**

* **Regla 0:	Regla de fundación.**

  a)	Cualquier sistema que se proclame como relacional, debe ser capaz de
  gestionar sus bases de datos enteramente mediante sus capacidades
  relacionales.
* **Regla 1:	Regla de la información.**

  a)	Todos los datos deben estar almacenados en las tablas

  b)	Esas tablas deben cumplir las premisas del modelo relacional

  c)	No puede haber información a la que accedemos por otra vía
* **Regla 2:	Regla del acceso garantizado.**

  a)	Cualquier dato es accesible sabiendo la clave de su fila y el nombre de su columna o atributo

  b)	Si a un dato no podemos acceder de esta forma, no estamos usando un modelo relacional
* **Regla 3:	Regla del tratamiento sistemático de valores nulos.**

  a)	Esos valores pueden dar significado a la columna que los contiene

  b)	El SGBD debe tener la capacidad de manejar valores nulos

  c)	El SGBD reconocerá este valor diferenciándolo de cualquier otro

  d)	El SGBD deberá aplicársele la lógica apropiada

  e)	Es un valor independiente del tipo de datos de la columna
* **Regla 4:	Catálogo dinámico en línea basado en el modelo relacional.**

  a)	El catálogo en línea es el diccionario de datos

  b)	El diccionario de datos se debe de poder consultar usando las mismas técnicas que para los datos

  c)	Los metadatos, por tanto, se organizan también en tablas relacionales

  d)	Si SELECT es una instrucción que consulta datos, también será la que consulta los metadatos
* **Regla 5:	Regla comprensiva del sublenguaje de los datos completo.**

  a)	Al menos tiene que existir un lenguaje capaz de hacer todas las funciones del SGBD

  b)	No puede haber funciones fuera de ese lenguaje

  c)	Puede haber otros lenguajes en el SGBD para hacer ciertas tareas

  d)	Pero esas tareas también se deben poder hacer con el “lenguaje completo”
* **Regla 6:	Regla de actualización de vistas.**

  a)	Las vistas tienen que mostrar información actualizada

  b)	No puede haber diferencias entre los datos de las vistas y los datos de las tablas base
* **Regla 7:	Alto nivel de inserción, actualización, y cancelación.**

  a)	La idea es que el lenguaje que maneja la base de datos sea muy humano

  b)	Eso implica que las operaciones del lenguaje de manipulación de los datos (DML) trabajen con conjuntos de filas a la vez

  c)	Para modificar, eliminar o añadir datos, no hará falta programar de
  la forma en la que lo hacen los lenguajes de tercera generación como C o
  Java
* **Regla 8:	Independencia física de los datos.**

  a)	Cambios en la física de la BD no afecta a las aplicaciones ni a los esquemas lógicos

  b)	El acceso a las tablas (elemento lógico) no cambia porque la física de la base de datos cambie
* **Regla 9:	Independencias lógicas de los datos.**

  a)	Cambios en el esquema lógico (tablas) de la BD no afectan al resto de esquemas

  b)	Si cambiamos nombres de tabla, o de columna o modificamos información
  de las filas, las aplicaciones (esquema externo) no se ven afectadas

  c)	Es más difícil de conseguir
* **Regla 10:	Independencia de la integridad.**

  a)	Las reglas de integridad (restricciones) deben de ser gestionadas y almacenadas por el SGBD
* **Regla 11:	Independencia de la distribución.**

  a)	Que la base de datos se almacene o gestione de forma distribuida en
  varios servidores, no afecta al uso de esta ni a la programación de las
  aplicaciones de usuario

  b)	El esquema lógico es el mismo independientemente de si la BD es distribuida o no
* **Regla 12:	La regla de la no subversión.**

  a)	La base de datos no permitirá que exista un lenguaje o forma de acceso, que permita saltarse las reglas anteriores

# Ética y Manejo de Datos para Data Science e Inteligencia Artificial

## ¿Qué son los datos personales?

Información que permite identificar a una persona de manera directa o indirecta.
Algunos ejemplos.

    Edad
    Teléfono
    Domicilio
    Correo Electrónico
    Documento nacional de identidad (INE en México)
    Número de seguridad social
    Ingresos
    Fecha de nacimiento

Se pueden clasificar por jerarquía de riesgo(importancia:

    Datos personales ordinarios ⇒ Nombre, dirección, finanzas personales, etc.
    Datos personales sensibles ⇒ Origen étnico, opiniones políticas y religiosas, orientación sexual.
    Datos especiales ⇒ Genéticos, biométricos y de salud (Vienen de fuentes no convencionales.

¿Qué datos no son personales?

    Los datos anónimos (información anonimizada)
    Los datos de personas jurídicas (instituciones)
    Información que no permita identificar a la persona.

Los datos biométricos

Se consideran datos personales ⇒ Permiten identificar a una persona
Ejemplos:

    Reconocimiento facial
    Reconocimiento por retina
    Reconocimiento vascular
    Reconocimiento por firma
    Reconocimiento de escritura
    Acceso por voz
    Reconocimiento de escritura de teclado

Clasificación de los datos biométricos

Por naturaleza

    Universal
    único (un análisis clínico)
    Permanente (huella digital)

Por característica

    Rasgos del orden físico o de su fisiología
    Rasgos de comportamiento o su personalidad (Se sacan a partir de múltiples interacciones)

 revisando la legislación de algunos países sobre la protección de datos y obtuve esta información:

    Ley de protección de datos personales (Ley 29733 -Perú). .
    Ley de protección a la vida privada (Ley N°19.628 - Chile).
    Ley de protección de datos (Ley 1581 - Colombia)
    Ley de protección de datos personales en posesión de sujetos obligados (México)
    Ley de Protección de Datos Personales (Ley 25326 - Argentina)
    Ley Orgánica de Protección de Datos de Ecuador
    Ley de Protección de datos personales y acción de habeas data (Ley 18331 - Uruguay)
    Ley de Protección de los datos personales (Ley 25.326 - Paraguay)
    Venezuela no posee legislación específica en materia de protección de datos

## Escándalos históricos de uso de información

La fuga de datos es un problema que se ha acentuado en los últimos años, debido a las vulnerabilidades existentes en algunos sistemas y empresas responsables de custodiar la información de sus clientes.

Sin embargo, este no es un problema nuevo. A lo largo de la historia existen experiencias importantes sobre esta situación. Estos escándalos históricos han servido como contexto para impulsar estrategias de protección de datos.
Fuga de datos en Holanda 1940

En el año 1940, en plena Segunda Guerra Mundial, el 1.5% de la población de Holanda era judía. Esta información fue recopilada mediante un censo y permanecía en los centros del país. El referido censo incluía información relacionada con nombres, apellidos, direcciones y origen de las personas.

Los nazis se apoderaron de las bases de datos de este censo y pudieron saber quiénes de la población eran de origen judío. Aunque esta población judía había permanecido por muchos años en Holanda, y habían adoptado las tradiciones y costumbres de la población holandesa, no fue impedimento para que los nazis cometieran el asesinato del 75% de la población judía que residía en Holanda.

Este fue un caso claro en el que la fuga de información conllevó a un delito. A partir de este acontecimiento histórico se empezó a poner especial relevancia a la recolección y custodia de la información.

El caso de Holanda y los sucesos más recientes sobre la fuga de datos dan contexto a los temas éticos sobre el tratamiento de la información.
Otros casos de fuga de datos

Otro ejemplo más reciente es el caso de la fuga de información que experimentó el Instituto Nacional Electoral (INE) de México en el año 2016.

Los datos personales que poseía el INE aparecieron en un repositorio S3 abierto de Amazon. Contenía nombres, apellidos y direcciones de la población mexicana. Esto no solamente sucedió en México, también ha ocurrido en Ecuador e India.

Otros casos han sucedido en países de Asia, sin dejar de mencionar fugas de datos vinculadas al sector privado, como, por ejemplo, los eventos que afectaron a:

    3 mil millones de usuarios de Yahoo
    500 millones de clientes de Marriott
    533 millones de clientes de Facebook

Todos estos eventos ponen en riesgo la confidencialidad de las personas.
Reto

Investiga sobre otros ejemplos donde la privacidad ha estado en riesgo, ya sea del sector público o del sector privado.

## Interés creciente por la información

Los puntos son los siguientes.

    Recolectar info es cada vez más barato
    Las empresas encuentran valor en entender a los usuarios (Ayuda a predecir y entender)
    Se puede recolectar información categórica o numérica de forma fácil.

A raíz de los puntos anteriores

    Se debe regular dicha recolección y en algunos lugares ya hay normativas.
    Algunas empresas compran bases de datos, pero esto comienza a ser cada vez penado por la ley.

## Bias y GIGO en datos

### Bias

Tiene que ver con la recolección de datos de forma errónea de una muestra en donde no se representa a la totalidad de la población.

En algunos casos como el reconocimiento facial suele haber sesgos en donde no se toman en cuenta todas las personas y sus distintos rasgos.

### GIGO (Garbage in / Garbage out)

Si metemos basura en nuestros análisis la conclusión no será buena y por tanto no obtendremos los resultados esperados. (Debe haber calidad en los datos y estos deben ser de valor según los requerimientos del proyecto/negocio)

## Advertencias de uso en marketing

Se puede crear publicidad personalizada pero debe considerarse lo siguiente en cuanto lo que respecta advertencias… (Es necesario usar la data con responsabilidad y ética)

    Evitar Sesgos discriminatorios ⇒ Como evitar trato distinto dependiendo del tipo de usuarios en caso de no ser realmente necesario.
    Evitar la manipulación de precios ⇒ Suele suceder cuando las empresas conocen datos sobre el poder adquisitivo del cliente.
    Evitar la manipulación de campañas políticas.
    Evitar fomentar conductas violentas, adictivas o ataques emocionales

## Advertencias de uso en campañas políticas

Desde hace algunos años los gobiernos comenzaron a tener interés en los datos poblacionales con la idea de poder predecir qué partido va a ganar, expectativas de los votantes, cómo medirlo, en qué lugares se inclinan por determinado partido, cómo es la distribución demográfica por edades, etc.

El uso de los datos poblacionales ha tenido un impacto impresionante en todas las áreas del conocimiento. Esta recolección proviene de diferentes fuentes y al ser concentradas y manipuladas por una entidad puede lograr un sinfín de resultados con ellos. Por su puesto, las organizaciones políticas no han desaprovechado las bondades que ofrece el Big Data.

Algunas organizaciones políticas han contratado servicios para poder llegar a un paso más allá en el manejo de los datos. Una empresa que hace investigación de recursos políticos y también predicción política es Cambridge Analytica.
El panorama actual

Actualmente, ya no existe bajo los mismos términos que sucedía en el pasado, ya que cometieron actos que en su momento no eran delitos, porque no había disposiciones legales que calificaran sus servicios como tales en términos legales, pero actualmente si han penalizado ese tipo de servicios.

Cambridge Analytica ofrecía servicios para negocios y también para campañas de partidos políticos, con el fin de predecir resultados electorales, pero, también, usando estrategias para influir y manipular a la población para votar o inclinar sus preferencias hacia un determinado partido político.

La contratación de este servicio ahora es ilegal, pero en aquel momento no estaban sentadas las bases para considerar esta actividad al margen de ley.

**Mecanismos de recolección de datos:**

Uno de los mecanismos utilizados por estas empresas para predecir resultados es con el uso de datos propios y datos externos recolectados a través de las encuestas. Preferiblemente, se recolectan datos de las redes sociales, como por ejemplo Facebook, que es la red donde más personas están compartiendo sus preferencias políticas.

También se usa la ciencia del comportamiento que ayuda a predecir los comportamientos sociales, así como la utilización de modelos predictivos.

En líneas generales, Cambridge Analytica identificaba a personas que podían ser vulnerables o personas que todavía no tenían una conciencia política definida o una preferencia política determinada. A través de anuncios se manipulaba la información para que votaran por el candidato que estaba contratando sus servicios.

Este tipo de estrategia electoral fue revelada en la campaña de Donald Trump en Estados Unidos y se menciona que el PRI en México también haya hecho contratación de este servicio con Cambridge Analytica.
Reto

Reflexiona y aporta alguna solución a este problema que se acaba de comentar sobre la manipulación de campañas políticas.

## Reglamentos

Existen reglamentos para penalizar y para regular el uso de datos, así como el almacenaje y procesamiento de información. Si en algún momento estás trabajando con datos, vas a tener que estudiar a profundidad sobre este tipo de normativas para hacer un uso adecuado de estos.

Cada vez están apareciendo más instrumentos normativos para reglamentar el utilización de datos y privacidad de la información. A continuación, veamos dos de estas normas.

La Ley Federal de Protección de Datos Personales en Posesión de Particulares

El primer reglamento que vamos a comentar es la Ley Federal de Protección de Datos Personales en Posesión de Particulares que existe en México. Esta ley penaliza a aquellas empresas que no estén haciendo el uso adecuado de los datos de particulares. Recuerda que los datos personales son aquellos que nos ayudan a identificar a una persona, ya sea de manera directa o indirecta.

Las empresas tienen que justificar las razones por las cuales están recolectando esa información y se encuentran obligadas a hacer un uso adecuado, así como usarla solo en caso de que sea imprescindible.

Además, esta ley obliga a las empresas a dar un uso ético de la información y garantizar que todos los datos estén preservados. Es decir, regula su uso y exige que no puedan tener fugas de información.

Finalmente, es importante destacar que esta ley también sanciona la compra y venta de bases de datos de usuarios.

### Reglamento General de Protección de Datos (GDPR)

La ley general más reciente vigente en Europa es la GDPR que significa General Data Protection Regulation que tiene por objeto regular el uso de datos de los ciudadanos europeos.

Esta ley la están aplicando en otros países, porque su fundamento es que tanto los ciudadanos de la Unión Europea como los de la Unión Económica Europea puedan exigir la protección de su información. Esto aun cuando no estén en su país de origen, porque esta ley obliga a que fuera de la región permanezca protegida la información de sus ciudadanos.

Este reglamento pretende instrumentar mecanismos legales para proteger a los ciudadanos sobre sus datos, así como simplificar el entorno regulatorio.

Igualmente, este reglamento aplica para cualquier empresa del mundo que procese datos de personas residentes en la Unión Europea.

## Ética y deep learning: vehículos autónomos

Los vehículos autónomos son automóviles capaces de imitar las capacidades de los seres humanos de conducir. Su tecnología está diseñada para hacer un reconocimiento de las imágenes que capta de su entorno a través técnicas complejas, sistemas de posicionamiento y visión computarizada. De esa manera el vehículo tiene dos órdenes: seguir avanzando o detener la marcha.

Esta innovación existe gracias al esfuerzo de grandes empresas como por ejemplo Tesla. Sin embargo, todavía no la vemos en las calles aun cuando muchas empresas ya están apostando por esta tecnología.

Los principales obstáculos que ha enfrentado esta tecnología es el referido a dilemas éticos que se fundamentan en la posibilidad de que su código sufra algún daño o que sea corrompido.
Cómo funcionan los vehículos autónomos

Estos vehículos poseen un código binario que toma acciones en función de continuar la marcha o detenerse. El temor a cualquier daño en su código, ataques cibernéticos o cualquier funcionamiento irregular ha detenido la puesta de vehículos autónomos en las calles.

No obstante, los datos demuestran que esta tecnología es más segura que la capacidad humana para conducir autos.

Las posibilidades de que una persona infrinja la ley, experimente reacciones emocionales y cualquier efecto que podemos tener como seres humanos son más propensos a causar accidentes automovilísticos que los autos inteligentes. Pero, persisten dilemas éticos que han impedido disfrutar de esta tecnología.
Reto

¿Qué opinas sobre la no disposición de esta tecnología en las calles?, ¿crees que ya estamos preparados?

## Ética y deep learning: reconocimiento facial

El reconocimiento facial se refiere al reconocimiento o identificación de la identidad de una persona mediante su rostro basada en datos biométricos. Estos datos son del rostro completo o de una imagen parcial del rostro como la retina del ojo.

Esta tecnología se apoya en el reconocimiento de vectores que identifican los rasgos de una persona. Este tipo de tecnología se desarrolló con el objetivo de acceder a espacios físicos con más comodidad, por ejemplo, gimnasios, a tu espacio de trabajo, universidades u otro sitio, con la idea de que no tengas que portar un gafete ni ningún otro identificador para tener acceso a estos lugares.

Sin duda esta tecnología tiene sus beneficios, sin embargo, debes detenerte a pensar que estás ofreciendo datos biométricos únicos de tu rostro y un mal uso de esta información puede significar una vulnerabilidad a tus datos sin dejar de mencionar los riesgos de una fuga de información.

Como usuario tienes el derecho de decidir a quién otorgarle tus datos biométricos. Por ejemplo, debes tener la opción de decidir si prefieres llevar tu gafete u otro instrumento de identificación para tener acceso a los partes donde te lo exijan. Es una decisión totalmente personal, de tal manera que puedas determinar a quién otorgarlo y a quiénes no.

También es importante que los expertos en tecnología cuando hagan un desarrollo tienen que reflexionar desde el punto de vista del usuario y evaluar si es ético solicitar este tipo de datos, si en realidad se justifica y especialmente cómo vas a proteger esta información.

Ejemplos de reconocimiento facial

Cada vez existen más aplicaciones móviles que funcionan a partir del reconocimiento facial, lo cual está supliendo la acción de escribir una contraseña; sin embargo, debes pensar a qué empresa se lo estás otorgando.

Probablemente, para el caso del acceso a tu móvil no sientas que haya mayores implicaciones; pero, cuando se trata de una aplicación bancaria donde los datos son muy sensibles y que probablemente no accedas todos los días, te puedes plantear la idea de reconsiderar esta modalidad del reconocimiento facial.

En algunos países como México se están introduciendo leyes para garantizar y proteger el uso de estos datos biométricos.

También se están planteando los modelos híbridos en el que solamente haces la validación final, de manera que tú otorgas el reconocimiento facial, pero en una fase previa utilizas la modalidad de contraseñas.

Reto

¿Qué opinas de la tecnología de reconocimiento facial?, ¿crees que está ayudando?, ¿te sientes vulnerable o sientes que tu seguridad está en riesgo?, ¿a qué tipo de empresas le otorgarías el acceso y a cuáles no?

## Ética con datos en la pandemia

Otro dilema ético relacionado con los datos es probablemente el que se originó con la pandemia covid-19. Esta crisis sanitaria significó un reto para todos los recolectores de datos, los gobiernos y los ciudadanos.

### Estrategias restrictivas

Algunos gobiernos han actuado de una manera más restrictiva y otros han actuado de una manera más abierta.

    Restricción del acceso entre países y visitas intermunicipales
    Exigencia de vacunas y pruebas de antígenos
    Controles a partir de bases de datos del aforo limitado de sitios públicos
    Políticas de cuarentena forzosa (algunas más estrictas que otras)
    Cuarentena forzosa (en algunos casos más estrictas que otros)

Proceso de detección covid-19 en España

En el caso de España, por ejemplo, en el momento cuando una persona era diagnosticada con covid-19 tenía que llamar a un teléfono público y notificar sobre su infección.

    Se realizaba un rastreo a las personas de las personas con las que el enfermo había estado en contacto
    Se monitoreaba su caso durante una cuarentena forzosa
    Aleatoriamente, recibía llamadas para saber cómo se sentía y para determinar si estaba respetando el aislamiento en su casa

La pandemia ha sido un reto para todos y todas y no hay todavía un establecimiento nacional o internacional que haya fijado pautas para la recolección de datos. A nivel mundial cada país tiene sus propios mecanismos y políticas para enfrentar la pandemia.
Reto

¿Qué opinas de los países que han sido más o menos restrictivos? ¿con cuál te sientes más seguro? ¿crees que este tipo de iniciativas ayudan a que el ciudadano esté más protegido o lo usan más bien los gobiernos como herramienta de control?

## Ética en las relaciones interpersonales

En la actualidad las relaciones interpersonales han experimentado un cambio muy importante, ahora tenemos las redes sociales, podemos hablar con nuestro equipo de trabajo de manera virtual, usamos diversas aplicaciones para este fin.

Especialmente después de la pandemia de covid-19 nos hemos acostumbrado a utilizar dispositivos como Zoom u otro tipo de aplicaciones que facilitan la comunicación de manera virtual.
Ventajas y desventajas de la comunicación virtual

Sin embargo, si bien es importante reconocer las ventajas de las comunicaciones virtuales,

**Ventajas**
Permiten que la comunicación prevalezca
Tiene features tecnológicas modernas para conectarse

**Desventajas**
Existe un riesgo de gran exposición de datos y de clonación de identidad
Generan escándalos de fuga de información

Por todas las razones explicadas, los desarrolladores y desarrolladoras de tecnología siempre deben brindar un espacio seguro y garantizar que las comunicaciones se efectúen con los menores riesgos posibles.
El dilema de otorgar permisos

Ahora es pertinente hablar sobre la importancia de decidir si le otorgamos los permisos de acceso a los micrófonos de nuestros móviles a redes sociales como Instagram o Facebook, ya que mientras tengan dominio sobre los micrófonos también pueden tener acceso a lo que hablamos.

Finalmente, vamos a hablar sobre un tema que se ha empezado a discutir recientemente relacionado con las redes sociales después de la vida.

Cuando una persona fallece deja su huella digital, deja el rastro de toda la información que tenía en vida en sus redes sociales Twitter, Instagram, TikTok, etcétera. Ahora puedes decidir qué hacer con estas redes sociales.

Las redes sociales ofrecen la posibilidad de seleccionar a un heredero para que sea la persona responsable de tomar la decisión sobre eliminar tus redes o mantenerlas después de la vida, para no dejar una huella abierta dentro del espacio digital.

En el espacio de privacidad de tus redes sociales ya puedes tomar esta decisión y designar una persona responsable del manejo de tus datos.
Reto

¿Con qué cosas te sientes cómodo o cómoda en las relaciones interpersonales? ¿cuál crees que es la línea entre esta interacción virtual o interacción presencial? ¿En qué espacios te gustaría disponer de más virtualidad y en cuáles te gustaría preservar el esquema anterior?

## Ética y Procesamiento de Lenguaje Natural (NLP)

El procesamiento del lenguaje natural, en inglés NLP o Natural Language Processing, es la interacción entre las computadoras y el lenguaje humano a partir de lenguas naturales. Probablemente estás enterado de que muchas páginas web poseen un chatbot que permite la interacción de los usuarios con esa página.

El usuario formula preguntas y el chatbot dará una respuesta. Esta es una máquina reprogramada a partir de las preguntas y respuestas más frecuentes. Esta alternativa ofrece la posibilidad de que no tengas límite horario para establecer comunicación con las empresas.

La mayoría de esta tecnología ha sido desarrollada en inglés, lo cual ofrece posibilidades para desarrolladores y contribuidores en otras lenguas naturales.
Reto de Alibaba, Standford y Microsoft

Microsoft, Alibaba y la Universidad de Stanford fueron protagonistas de un reto donde el modelo de sus algoritmos competía con los estudiantes de la universidad, ya que esas empresas consideraban que su algoritmo iba a superar la comprensión lectora que tenían los estudiantes.

El resultado de este reto fue que efectivamente el algoritmo de inteligencia basada en Natural Language Processing ganó la comprensión lectora de esta universidad de prestigio.

Este experimento dio lugar a un dilema ético porque puso en especial relevancia esta capacidad de la máquina frente a los humanos.

Sin embargo, todavía hay partes en las que el ser humano tiene una gran ventaja sobre las máquinas, como por ejemplo la parte de la identidad y las emociones. Todavía no se ha logrado que los chatbot tengan una identidad y que se identifiquen con la marca.

Hasta los momentos ha resultado imposible que una máquina se identifique con las emociones de una persona. Es incapaz de priorizar reacciones ante manifestaciones de frustración, felicidad o enojo. Tampoco pueden adaptar sus respuestas al tipo de usuario.
Qué es la tecnología GPT-3

La tecnología GPT-3 es un lenguaje autorregresivo que emplea el aprendizaje profundo (deep learning) para producir textos que simulan la redacción humana. Esta tecnología toma datos de un histórico y a partir de estos desarrolla un aprendizaje profundo o deep learning para entender lo que dicen los textos que se encuentran en la red.

También plantea un tipo de modelo con un dilema sobre si la máquina estaría mejorando la inteligencia y capacidades humanas. Por ejemplo, podríamos poner a competir este lenguaje con el conocimiento de un notario, así si alguien pide una escritura esta aparezca de una manera automatizada. También podría reemplazar la labor de un médico al poder responder con base a toda la información que ha leído en la infinidad de documentos médicos disponibles en la red.

Es importante tener en cuenta que en internet hay mucha información falsa y este algoritmo tiene como reto empezar a identificar y clasificar qué informaciones son válidas y cuáles son falsas.
Reto

¿Crees que el NLP puede alcanzar el conocimiento y sensibilidad de los humanos? 

## ¿Qué son las políticas públicas?

Las políticas públicas son acciones de la administración pública que tienen como objetivo satisfacer las necesidades o demandas de una comunidad o colectivo.

Manuel Tamayo de la Universidad Complutense de Madrid señala que “Las políticas públicas son el conjunto de objetivos, decisiones y acciones que lleva a cabo un gobierno para solucionar los problemas que en un momento determinado los ciudadanos y el propio gobierno consideran prioritarios”.
Objetivos de las políticas públicas

Las políticas públicas persiguen varios objetivos, los cuales podemos resumir básicamente en los siguientes:

    Atender desde el Estado los problemas de los ciudadanos.

    Implementar a partir de normas, instituciones, prestaciones y servicios. Esto involucra toda acción para reparar una calle, creación de alumbrado, etc.

    Ayudar a alcanzar principios éticos y a crear igualdad en las sociedades.

Tipos de políticas públicas

Las políticas públicas pueden ser clasificadas en varias tipologías que conocerás a continuación.
Política institucional

Esta autoridad puede ser a nivel nacional, regional, municipal, local. Tenemos el caso de la pandemia de Covid-19 donde diferentes niveles de gobierno implementaron acciones para contrarrestar los efectos generados por esta enfermedad.
Política según el sector

Estos sectores pueden ser en el ámbito médico, medio ambiente, educación, seguridad, etc.
Política según los destinatarios

Se refiere a un tipo de política pública para personas con discapacidad, juventud, adultos mayores, etc.
Política según la elaboración

La elaboración puede depender exclusivamente por parte del Gobierno o puede haber participación de la ciudadanía.
Política según la planificación

Algunas políticas públicas se hacen de manera reactiva, es decir, para resolver un problema, implica la reacción a una situación, por ejemplo la pandemia. La otra opción es actuar de manera preventiva para evitar que suceda un problema o, por lo menos, evitar que el problema llegue a niveles mayores, por ejemplo, desarrollar campañas preventivas contra enfermedades.
Reto

¿Qué políticas públicas has visto que se hayan desarrollado en tu ciudad, país o tu localidad?

## Datos y prevención de crímenes

Data for Good se refiere a todo lo que involucra datos abiertos. Estos son los que se comparten con la comunidad y expertos como tú pueden empezar a procesarlos para predecir eventos.

Los datos tienen dos caras pues:

    Nos encontramos los dilemas éticos que se derivan de su recolección y uso
    Es indiscutible que los datos también pueden crear oportunidades y grandes beneficios para la sociedad.

Uso de datos con fines sociales

Existe la importancia de los datos con fines sociales, lo cual inevitablemente está vinculado con las políticas públicas; por ejemplo, algo que se ha estado explorando mucho es el desarrollo de políticas y estrategias de prevención de crímenes a partir de la información.

El uso de cámaras de seguridad en los espacios públicos permite recoger información valiosa para combatir los índices de criminalidad. Esta sería una acción de tipo reactiva porque sucedido un crimen se acude a los registros de video para investigar contra qué tipo de persona se cometió el delito, a qué hora, qué tipo de crimen sucedió, coordenadas del sitio, etc.

Con esta información se crea un mapa de calor para determinar los horarios críticos, cómo es la distribución de crímenes de una ciudad y también la tipología de los crímenes, solo por mencionar algunos de los beneficios.

Si en sitios específicos se presenta una alta criminalidad y no hay cámaras, entonces como parte de política pública se puede ordenar la instalación de equipos de video para capturar imágenes apropiadas para combatir el problema. En cambio, si se toman decisiones para prevenir la comisión de actos delictivos en función a los datos, nos encontramos entonces ante políticas de tipo preventivo.
Reto

¿Qué otros ejemplos se te ocurren para la prevención de crímenes?

## Datos y salud

El uso adecuado de los datos en cualquier área representa grandes oportunidades. El campo de la salud no es diferente, porque la información puede ayudar a predecir eventos que representan oportunidades importantes para la sociedad.
Ejemplo de uso de datos y salud

El Apple Watch es un buen ejemplo para resaltar la importancia de los datos en el ámbito de la salud. Este instrumento hace un monitoreo permanente de la frecuencia cardíaca de su usuario.
Características del Apple Watch

Existen muchos testimonios de personas que manifiestan que este reloj les salvó la vida, pues:

    Conserva en memoria un histórico de datos que permite emitir alertas con estados clínicos diferentes
    Puede salvar la vida de las personas al detectar a tiempo anomalías
    Envía notificaciones a contactos de emergencia

Adicionalmente, conserva en memoria un histórico de datos que permite emitir alertas cuando la persona que lo lleva presenta cualquier cuadro clínico diferente a los parámetros normales.

Otro ejemplo es el relacionado con las investigaciones para la predicción del cáncer y otras enfermedades. La recolección de datos en las diferentes fases de una enfermedad permite analizar su evolución y llevar registros confiables que ayudan a definir la etapa en la que se encuentra un caso específico para tomar acción.

Gracias a la recolección de datos se sabe con meridiana certeza cómo evoluciona una enfermedad, posible curso que puede tomar, tasa de éxito de determinados tratamientos, índices de mortalidad, tiempo promedio de incubación, desarrollo y muerte de un virus, entre otros beneficios.
Reto

Piensa en otro ejemplo de prevención de una enfermedad o de algún accidente que conozcas o que hayas escuchado gracias a la contribución de los datos

## Datos y movilidad

Otro ejemplo sobre Data for Good o datos para el bien son los usos que se le pueden dar a la movilidad desde una ciudad. Es increíble cómo la red de transporte de una ciudad cuenta con tecnologías que tal vez ni conocías.
Ejemplos de vehículos

El sistema de transporte en una ciudad en cualquier lugar del mundo puede dividirse en dos tipos de vehículos:

    Vehículos motorizados
    Vehículos libres (bicicletas, scooters, patines, motocicletas)

Un caso muy interesante y verás a continuación es la ECOBICI.
Sistema de ECOBICI

Muchas ciudades incluyen sistemas de bicis públicas, como por ejemplo el caso de ECOBICI en Ciudad de México y Buenos Aires.

ECOBICI es el sistema de bicicletas públicas de la Ciudad de México que ha integrado a la bicicleta como parte esencial de la movilidad, dirigido a los habitantes de la capital, de sus alrededores y a los turistas.

También cuenta con su propia aplicación oficial del sistema de Transporte Individual de la CDMX, que además de permitir consultar la disponibilidad de estaciones y bicicletas en tiempo real
Funciones que ofrece la ECOBICI

Conoce algunas funciones que ofrece la ECOBICI en México:

    Trazan rutas de viaje.
    Permiten consultar el mapa con todas las ciclo-estaciones del sistema.
    Muestran el mapa de ciclovías de la Ciudad de México, así como de las estaciones de Metro
    Generan reportes de incidencias sobre bicicletas, estaciones y/o el servicio.
    Permiten consultar el histórico de usos a través de una cuenta de usuario.

La aplicación utiliza servicios de localización en segundo plano para guardar las rutas. También este tipo de empresas facilitan la movilidad y también recolectan información porque toda bici está conectada a radar que suministra información detallada de su geolocalización.

Los datos recolectados ayudan a determinar el flujo de la ciudad y concentración de bicicletas, lo cual contribuye a la creación de políticas públicas. Además, aporta información sobre las calles que no poseen ciclovías o donde suceden mayor cantidad de accidentes, etc.
Qué son las ciudades inteligentes

Las ciudades inteligentes o smart cities son lugares más sustentables y ecológicos que emplean los datos para el desarrollo de tecnologías en beneficio de los ciudadanos.

Según la Comisión Económica para Europa de Naciones Unidas (UNECE), la definición de ciudad inteligente incluye además elementos como la alta difusión de conectividad en los hogares y wifi en los espacios públicos, una infraestructura inteligente, medidores de electricidad inteligentes, información abierta y un gobierno electrónico.
Características de las smart cities

Quizás alguna vez has visitado una ciudad inteligente y sostenible, pues estos lugares suelen compartir las siguientes características:

    Cuenta con redes inteligentes de transporte urbano, instalaciones mejoradas para el suministro de agua y la eliminación de la basura
    Goza de un órgano administrativo para que la ciudad sea más interactiva y receptiva
    Utiliza las tecnologías de la información y la comunicación (TIC) para mejorar la calidad de la vida de los y las habitantes, la eficiencia y la competitividad.

Principales smart cities del mundo

Estas principales ciudades tienen registros de los datos de seguridad, movilidad, medio ambiente, etc. de manera pública y permiten al ciudadano que los exploten y analicen.

Principales ciudades inteligentes del mundo

Singapur

París

Tokio

Seúl

Toronto

Hong Kong

Ámsterdan

Londres

Chicago

Nueva York

También pueden hacer un monitoreo en tiempo real del tráfico y uso de los semáforos.
La segregación que causa la tecnología

La utilización de datos contribuye sustancialmente a gestionar de forma eficiente la movilidad en las ciudades; pero, también da origen a dilemas éticos.

En el caso de la movilidad, muchas zonas pueden llegar a ser potencialmente discriminadas social y económicamente porque plataformas como Google Maps o Waze no las priorizan dentro de sus mapas al dirigir a las y los usuarios por vías principales consideradas como “más seguras”

## Datos y educación

Las escuelas online como Platzi realizan el monitoreo y evaluación de datos para conocer a las personas y hacer recomendaciones en función de esta información.

En el caso de que una persona reciba una sugerencia, esta es el resultado de algoritmos de recomendación que han recolectado información sobre los comportamiento de estudiantes.
Información valiosa desde los datos

En este punto quizás te preguntas ¿cuál es la información más importante que busca Platzi al estudiar a sus estudiantes?

Pues funciona para detectar:

    Cuáles son los gustos de estudiantes
    Qué tipos de cursos han finalizado y cuáles no
    A qué escuela pertenece el/la estudiante
    Cuáles son los cursos más exitosos

A partir de este tipo de trayectorias se hace una predicción específica, ya que Platzi tiene un equipo de personas que desarrollan esta tecnología internamente y a partir de su habilidad y conocimiento pueden crear algoritmos que faciliten tu experiencia.
Beneficios de los datos

El uso de estos datos permite el acceso al mundo laboral de una manera más digital. El posicionamiento de los diplomas en las redes sociales como LinkedIn, o cualquier otra red social, facilita que las empresas y los contratadores puedan ubicar con mayor facilidad a personas que cumplan con ciertas habilidades y conocimientos.

## Datos y medio ambiente

El uso de datos para el bien (data for good) tiene una gran importancia en el caso del medio ambiente. Los datos permiten mostrar información valiosa para la toma de decisiones en materia ambiental.

Por ejemplo, la polución en el aire se puede medir a partir de detectores y sensores que emiten alertas públicas y los gobiernos se ocupan de hacerlas llegar a la ciudadanía.
Otros ejemplos de uso de datos en el medio ambiente

Dispositivos como el Apple Watch nos pueden notificar cuál es el estado del aire en determinados días y horas con el objetivo de saber si es saludable salir a la calle o no, incluso para decidir si es adecuado hacer ejercicio al aire libre o no. Como puedes observar son decisiones reactivas porque el problema de la contaminación ya ha sucedido y solo queda tomar acciones para responder a las condiciones ambientales.

Desde el punto de vista preventivo, los datos en el ámbito ambiental se da, por ejemplo, cuando sobrevolamos un dron sobre cultivos para evaluar a partir de las imágenes la calidad de estos y, en función de esta información, tomar decisiones para anticiparse a posibles problemas.

Otro ejemplo es la recolección de información para determinar las condiciones del subsuelo, frutos y hojas de los cultivos para prevenir enfermedades o evitar el uso inadecuado de fertilizantes, entre otros.
Reto

¿Qué otras aplicaciones de mejora al medio ambiente podrían lograrse con datos e inteligencia artificial? Escribe tu respuesta en tu guía de retos.

1. En el modelo cliente-servidor, selecciona la opción con todas las tecnologías que encontramos regularmente en el lado del cliente en una página web.

> JavaScript, HTML y CSS

2. En el modelo cliente-servidor, elige cuál de estos ejemplos representa el rol apropiado de servidor (es decir, se ejecuta inicialmente desde el servidor).

> Un programa en PHP renderiza HTML usando información de una base de datos.

3. ¿Por qué se refiere a algunos sistemas como sistemas "monolíticos"?

> Se representan en una sola pieza de arquitectura, usando múltiples tecnologías y hasta diferentes lenguajes de programación, pero se ejecutan en un solo servidor remoto.

4. ¿Cuál de los siguientes ejemplos es característico de un sistema distribuido y verdadero para TODOS los sistemas distribuidos?

> Cada componente puede representarse como un nodo en una red y pueden comunicarse entre sí utilizando protocolos como, por ejemplo, HTTP, RTCP, TCP/IP.

5. Selecciona de las siguientes opciones cuál sería ideal para implementar un patrón de "Publish-Subscribe" basado en la nube.

> AWS SNS.

6. ¿Por qué para desarrollar un sistema de backend podemos decir que tenemos la capacidad de usar casi cualquier tecnología que des eemos?

> Al tener la capacidad de ser distribuidos podemos utilizar una diversa cantidad de tecnologías y servicios, incluso basados en la nube, como piezas para su desarrollo.

7. Los componentes en sistema en backend pueden comunicarse por medio de APIs. Considerando lo anterior, ¿cuál de las siguientes opciones es FALSA?

> Las APIs solo pueden usarse por medio del protocolo HTTP o HTTPS.

8. En el contexto de Arquitectura de Software y sistemas en backend, selecciona la opción que mejor describe a un "documento de diseño".

> Un documento que pretende solucionar problemas impuestos por ciertos casos de uso, generalmente requerimientos de negocio. Establece un objetivo claro del problema a resolver y detalla elementos técnicos sean a alto o bajo nivel, tales como arquitectura, plan de implementación y modelado de datos, con tal de ofrecer solución a los problemas.

9. ¿Para qué sirve un diagrama de secuencias?

> Sirve para demostrar cómo interactúan diferentes elementos en un proceso o que son parte de un mismo sistema.

10. Selecciona cuál de las siguientes afirmaciones es FALSA.

> Los documentos de diseño tienen un formato estandarizado en la industria que siempre deben realizarse siguiendo los mismos lineamientos.

11. El concepto "Code Complete" se refiere a:

> Cuando el desarrollo ya realizado satisface todos los requerimientos de negocio y no es necesario escribir más código fuente.

12. ¿Cuál de las siguientes es una práctica generalizada y altamente recomendada al elaborar documentos de diseño?

> Tener un "design review" en donde otras personas puedan ofrecer retroalimentación con tal de mejorar el diseño actual.

13. ¿Por qué es valioso incluir información acerca de los "límites" de un diseño arquitectónico de software?

> Conocer los límites del sistema nos brinda información valiosa acerca de cómo el mismo puede escalar, así como puede servir de referencia para los casos de uso que se desean soportar.

14. Antes de comenzar el desarrollo, ¿cual de éstas es la mejor idea para incluir en un documento de diseño para asegurarnos que estamos tomando las mejores decisiones?

> Incluir además de la solución propuesta, por lo menos, una alternativa.

15. ¿Cuál de las siguientes afirmaciones es FALSA considerando un proceso de integración continua que se encuentra en la rama principal -usualmente conocida como "master" (o también "main")?

> El código que ha logrado integrarse a la rama master es el código que se ejecuta cuando el usuario final usa el sistema.

16. Se tiene un sistema distribuido cuyo backend responde a millones de usuarios en Europa, Asia y América. Se planea liberar una nueva funcionalidad en el sistema y la empresa quiere activar está habilidad de manera progresiva para que, en el caso de existir un error, pueda detectarse antes de que la funcionalidad sea desplegada en todo el planeta. ¿Cómo podría desarrollarse un pipeline que contemple estas precauciones? Asuma que el código actual con está funcionalidad ya ha pasado las pruebas de desarrollo y está en la rama master listo para enviarse a producción.

> Se puede diseñar un pipeline que separe el ambiente de "producción" en múltiples etapas como "prod-Asia1, prod-Asia2, prod-EU1, prod-EU2, prod-Amer1, prod-Amer2, prod-Amer3" y desplegar el código a ritmo de una región cada 2 dias, de manera que si ocurre algún problema, puede detenerse el despliegue antes de llegar a todas las regiones.

17. ¿Cuál de las siguientes opciones es un ejemplo de "escalabilidad vertical"?

> Se tiene un clúster de 100 VMs de bases de datos, cada VM cuenta con 2 cores y 500 GB en memoria. Se incrementa la memoria y los cores de esas 100 VMs a 4 cores y 1TB.

18. ¿Cuál de las siguientes opciones es un ejemplo de "escalabilidad horizontal"?

> Se tiene un clúster de 100 VMs de bases de datos, cada VM cuenta con 2 cores y 500 GB en memoria. Se incrementa la cantidad de VMs a 200.

19. ¿Cuáles de estas prácticas es característica al usar TDD?

> Escribir tests primero antes de escribir el código que satisface dichas pruebas.

20. En el contexto de Arquitectura de Software y sistemas en backend, ¿cuál de las siguientes opciones es característica de una "entidad"?

> Es un objeto cuya implementación satisface una regla o requerimiento de negocio.

21. Considere un sistema que permite a un usuario leer artículos de noticias. El sistema sirve principalmente a usuarios en Suramérica y, normalmente, cuando utilizan el sistema, cada usuario solo necesita enviar una cantidad mínima de peticiones HTTP por segundo a la API principal desde su navegador web durante un periodo aproximado de 5 segundos para descargar contenido y renderizar la vista en la UI. ¿Cuál de los siguientes es un ejemplo de throttling?

> El usuario extrae un token de autenticación y lo utiliza para descargar aún más contenido usando un script el cual envía 100 peticiones por segundo. Sin embargo, para sorpresa del usuario, un gran porcentaje de las peticiones fallan consistentemente con un error ya que aparentemente el servidor no está procesando la mayoría de las peticiones.

22. ¿Cuál puede ser una consecuencia de no implementar un backoff exponencial en clientes HTTP que realizan peticiones a una API determinada?

> Si el backoff no se implementa de manera exponencial, la API puede consecuentemente experimentar incrementos en tráfico exponencial por medio de peticiones a la misma API y colapsar.

23. Para una API que requiere autenticación y se le provee un token a través del Header "Authorization", ¿cuál de las siguientes afirmaciones es más PROBABLE? (Considera que las respuestas incorrectas son técnicamente posibles, pero poco probables). Las peticiones son realizadas por el cliente usando HTTPS y se sabe que el sistema utiliza RSA-2048 para establecer conexiones seguras.

> Asumiendo que el token fuese interceptado por un delincuente informático, este puede utilizarlo para suplantar la identidad del usuario sin que el backend de la API se de cuenta.

24. ¿Cuál de las siguientes afirmaciones es verdadera en cuanto a bases de datos?

> Es posible crear una base de datos que solamente se utilice para realizar operaciones de escritura, replicar dicha base en un clúster de decenas de bases de datos que solo se utilicen para lectura y con ello lograr menor latencia para tráfico que corresponda a miles de usuarios concurrentes que consulten información.

25. ¿Cuál de estas herramientas puede utilizarse para disminuir la latencia pero sacrificando consistencia?

> Caché.

26. Supón un sistema que tiene la capacidad de obtener -con una sola petición a un proveedor externo- información sobre el clima en una ciudad determinada y hace esta petición una vez cada hora. Al hacerlo, en caso de detectar cambios de más de 3 grados en la temperatura, comunica esta información a 3 servicios que publicarán este cambio en 3 plataformas diferentes, una por correo, otra por redes sociales y otra por mensaje de texto al celular. Adicionalmente, el sistema permite a terceros consumir estas notificaciones de cambios para usar la información para sus propios propósitos. ¿Cuál de estos conceptos describe mejor este escenario? Nótese que las notificaciones de cambio se envían de manera inmediata y simultánea a todos los recipientes y en caso de no recibir la notificación (por ejemplo, por causa de la red), puede considerarse que está se perderá y nunca llegará al destinatario.

> Publisher-Subscriber.
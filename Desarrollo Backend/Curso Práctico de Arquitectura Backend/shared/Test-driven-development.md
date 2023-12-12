# TDD: Estrategias realizar desarrollo orientado a pruebas

## Premisa y meta
Seguramente al ser un desarrollador con experiencia, haz escuchado el termino "TDD"(Test Driven Development por sus siglas en ingl�s).
Realmente es un tema muy interesante que es sencillo de investigar, basta con poco tiempo de busqueda en internet para encontrar diversas recomendaciones de como aplicarlo.
Este �rticulo parte con la siguiente premisa.
En cuanto a "buenas pr�cticas" de como realizar TDD se refiere, podr�amos encontrar diferentes formas de hacerlo, y a veces podr�amos no estar de acuerdo, y esto se debe a que al final de cuentas,
cuando a testing se refiere, todos podemos tener una opini�n distinta, y este articulo es eso, una opini�n.
Pero algo se tiene en com�n cuando encontramos los mejores tests. Y es que en la situaci�n que lo encontramos, de alguna manera, tiene sentido.
Este articulo es una opini�n mas, que pretende compartir algunas estrategias que podemos usar para escribir tests, orientado a desarrolladores de software.

## Introducci�n: �Qu� es un "test"?

Antes de entender como hacer TDD, tenemos que tener bien claro que es un Test, en el contexto del desarrollo de software.
Y para eso vale la pena preguntarnos, �cual es el objetivo del desarrollo de software en si?
Regularmente... tiende a ser "solucionar un problema", y para aquellos que desarrollamos software como trabajo remunerado, generalmente
esos problemas son del "cliente" (cliente en este contexto es lo mismo una empresa para la que trabajamos, un equipo de desarrollo que depende de nuestros desarrollos, o literalmente tu cliente si eres un freelancer, practicamente quien hara uso, consumira, tu software), con esto en consideraci�n, no olvidemos lo que un cliente tiene(este conciente o no de ello), requerimientos de negocio.

Entonces, �que tiene que ver todo esto con un la definici�n de "test"?
Un "Test", lo consideraremos entonces como aquel proceso el cual confirma que los requerimientos de negocio han sido satifechos.
Pero cuidado, 
Nota: Los requerimientos de negocio pueden ser explicitos, o implicitos. Por ejemplo. El "Cliente" puede explicitamente comunicar que el software X debe hacer la tarea A. Asi mismo el "cliente" podra no tener idea que el software que se desarrolla para el, recibira mas de 1000 peticiones por segundo en la hora con trafico pico en un dia determinado, y aunque no nos lo "pida" explicitamente, cuando eso suceda, se espera que el software siga funcionando. Desde cierto, es un requerimiento, y tambien se puede probar.

## �Que tipos de "test" ex�sten?

Seguro que muchisimo mas de los que un servidor puede memorizar, pero generalmente podemos categorizarlos en una escala con 2 extremos. Estas son:

- Tests unitarios: Tests que prueban una funci�n de manera at�mica. En este extremo, un tests prueba en "teor�a"(comentame por favor que encuentras en la pr�ctica) una sola cosa a la v�z. Un ejemplo de este tipo de test, es cuando creamos una funci�n est�tica que suma unicamente numeros "naturales", un solo test puede ser sumar dos numeros "naturales", otro test diferente, puede ser que la funci�n lanza un error si se le da un numero que no esta dentro de la defici�n de numero "natural". Cada uno de estos dos tests seria un test at�mico diferente, unitario, y prueban una sola cosa.
Algunas de las **caracter�sticas que encontramos comunmente en un buen test unitario** es que son mas f�ciles de automatizar, de involucrar en nuestro pipeline cuando implementamos continuous integration, y son mas rapidos de escribir, entender y tambi�n de ejecutar(por ejemplo la ejecuci�n del test de sumar 2 numeros tomar� milisegundos).

- Tests End to End: Al contrario de un test unitario, un test que se acerca mas al "End to End", no prueba una sola cosa, si no prueba un sistema completo de inicio a fin(por ello el nombre End to End). Esto quiere decir que un solo test involucrar� a un sistema completo, incluyendo sus componentes. Por ejemplo, si tenemos una aplicaci�n que se asemeje a una red social popular, un unico test puede involucrar pasos como los siguientes:
*Desde la UI en un navegador Web X. 1. Abrir la p�gina principal, registrar una cuenta(y toda la validaci�n que eso conlleva), hacer login, mandar un post, a�adir contactos, hacer login como los contactos, validar que se puede ver el post publicado anteriormente, cambiar la profile pic, validar que todos lo pueden ver, hacer un post, quitar el post, validar que en menos de X segundos los contactos que originalmente podian ver el post ya no pueden verlo...etc...etc...etc*
Espero que con el ejemplo anterior se entienda el punto. Pero por supuesto los Test verdaderamente "End to End" en el contexto purista de la palabra, son muy dificiles de escribir, considerar todos los casos de uso, y sobretodo automatizar. Por lo que es mas com�n que estemos en un lugar "en medio" de estos dos extremos, y probar solo ciertas integraciones entre los componentes de un sistema dependiendo de cada situaci�n (�Alguna vez escuchaste el termino test de integraci�n?). 
Nota: Tests de.. "integraci�n", "UI", incluso "Performance" pudieran ser desde cierto punto de vista, tests de "integraci�n" en cierto grado, ya que estan probando el sistema en si, el cual funciona gracias a como sus componentes estan "integrados" entre si.

## �Como aplicar entonces TDD de forma pr�ctica?
Ahora s�, me ahorrare el "template" de "Escribe tests primero y luego el c�digo", eso es muy f�cil encontrarlo y hay personas muchisimo m�s experimentadas que un servidor para brindar esa informaci�n.
Sin embargo, los consejos pr�cticos, repito. En la opini�n de su servidor. Estos consejos personalmente me han traido "paz mental" al desarrollar software, y espero que alguno de estos consejos, te traiga esa paz mental a t� tambien.

### Definir bien el requerimiento de negocio antes de hacer un plan de testing 
Recordando a nuestro "cliente" del que hablamos antes. Primero tenemos que entender que nos estan pidiendo de manera explicita, y que se espera de manera implicita.
Si entiendes tu producto, si entiendes el negocio, si entiendes, puedes probarlo.
Ya que se entiende esto, un plan de testing puede enlistar tantos casos de uso como sea posible, tanto los "obvios" como los que no lo son tanto, y estos son los que eventualmente consideraremos en los tests.

Como ejercicio, plantea todos los casos de uso posibles para los servicios en el sistema de Camera Reviews de este curso.
Como ejemplo, estos son algunos que pudiera imaginarme en un sistema de una "red social" (No estrictamente unitarios, end to end, o en puntos medios).
- En el contexto de un "Post" en una red social.
    * Cuando se publica un post, solo los contactos que me siguen seran notificados.
    * Cuando se publica un post e inmediatamente despues de que el post se propago a todos los datacenters en el mundo, se elimina. Transcurridos un maximo de 10 segundos, ning�n contacto deber� ser capaz de visualizar el post eliminado (considerar que el post).
- En el contexto de "grupos" en una red social.
    * Cuando se a�ade un usuario nuevo a un grupo, solicitar la autorizaci�n del creador original del grupo si el 5% o mas de los usuarios ya en el grupo tienen bloqueado al usuario que se intenta a�adir.
    * No se puede a�adir usuarios a grupos en donde se encuentren menores de edad, si el usuario tiene un "strike" o se ha detectado que publica contenido no apto para menores de edad con una frecuencia determinada.
    * En caso de que simultaneamente se a�ade el usuario A a un grupo, se envian notificaciones a los integrantes, pero al mismo tiempo el usuario A elimina su cuenta. El sistema debe de recuperarse automaticamente en un m�ximo de 2 minutos, cancelando todas las notificaciones enviadas y eliminandolo automaticamente del grupo al que se a�adio.  

### Estructurando y escribiendo un Test
Si bien somos libres de elegir la estructura que deseemos, una forma efectiva que puede ayudar a tener una mejor legibilidad. Es la siguiente:
1. Realizar el Setup: Preparar todas las variables o valores que necesitemos en nuestro test, antes de ejecutar el caso de uso que queremos probar.
2. Realizar la ejecuci�n del caso de uso.
3. Realizar la validaci�n de lo que esperamos (Y esto incluye tambi�n lo que NO esperamos).

Ej. en contexto de la red social. Este test pudiera abstraer la interaccion entre multiples componentes de un sistema
Como lo puede ser desde el registro de una cuenta, hacer un login, y enviar peticiones autenticadas a diferentes APIs.
Este ejemplo puede considerarse un test de integracion, pero los principios pueden aplicarse a cualquier tipo de test.
Tambien se asume el uso de "helper functions" para mejorar la legibilidad del test en si.
```
// Este test asume desde un cliente(por ejemplo App Android) se puede publicar un post como un usuario normal
// pero este no debera ser visible al ser consultado por otro usuario si el usuario original elimina su cuenta.
public void SocialNetwork_UserPublishesPost_ThenUserIsRemoved_ExpectPostToBeRemoved()
{
    // Setup - puedes usar comentarios asi para indicar que estas haciendo el "setup" del test
    var postAuthorUserId = await createUserAndGetId(); // esto puede ser una funcion privada, crea un usuario y regresa el Id
    var contactUserId = await createUserAndGetId();
    // para que pueda ver el post, se debe tener al usuario entre contactos
    await establishUserContactAsFriend(postAuthorUserId, contactUserId);

    // Execute - dado el setup, el codigo a continuacion debe representar lo que el test dice que prueba.
    // Para mejor legibilidad, esto deberia hacer sentido con el nombre del test.
    var responseCreatePost = await createAndPublishPostFromUser("hello world", postAuthorUserId);
    var responseGetPostBeforeRemoval = await GetPost(
        responseCreatePost.GetPostId(),
        userRequestingPost = contactUserId);
    var responseDeleteAccount = await DeleteUserAccount(postAuthorUserId);
    var responseGetPostAfterRemoval = await GetPost(
        responseCreatePost.GetPostId(responseCreatePost.GetPostId()),
        userRequestingPost = contactUserId);

    // Validar resultados esperados (o no esperados)
    Assert.IsTrue(postAuthorUserId == responseCreatePost.GetAuthorId());
    Assert.IsTrue(responseGetPostBeforeRemoval.StatusCode == "OK");
    Assert.IsTrue(responseGetPostBeforeRemoval.GetPostId() == responseCreatePost.GetPostId());
    Assert.IsTrue(responseGetPostAfterRemoval.StatusCode == "Not Found");
}
```

Nota: El uso de "helper functions" es a discrecion del desarrollador, el abuso y uso inadecuado puede resultar en aumento de la complejidad al momento de crear un proyecto
con una suite de tests. La mejor forma de encontrar un buen balance, es con practica.

Nota: Investiga lo que es el "code coverage", es un excelente indicador para saber si hemos cubierto todas las rutas posibles en nuestro codebase. Aunque de vez en cuando podemos encontrarnos con proyectos que no cubren un % alto de su codebase en las pruebas, podemos hacer mejoras incrementales, si cada cambio nuevo, cada pull request, cada contribucion, esta probada al 100%. Esto mejorara el code coverage del proyecto de manera incremental, y sera un gran beneficio al largo plazo.

La ventaja de utilizar esta estructura y metodo para planear tests, es que eventualmente cuando la implementacion este lista, los tests sean ejecutados, y veamos que todo esta bien.
Sabremos que neustro sistema se comporta como deberia. Si cubrimos todos los casos de uso en tests, aquellos requerimientos para el cliente estaran automaticamente satisfechos, pero es extremadamente importante siempre poder entender que es lo se esta probando.

Ahora que ya hemos puesto un ejemplo que aplica las previas recomendaciones, te invito a tomar lo que te pueda servir y aplicarlo en tu proyectos.
Tambien vale la pena tener en mente que estos en conjunto con otras estrategias, podrian ayudarte a tener un mejor set de pruebas.
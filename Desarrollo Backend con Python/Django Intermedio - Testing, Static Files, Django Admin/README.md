# Curso de Django Intermedio: Testing, Static Files, Django Admin 

En este segundo curso de la saga de Django analizarás los conceptos fundamentales sobre el Testing. Mejorarás el administrador de Django con nuevos atributos, implementarás archivos estáticos en tu proyecto, y llegarás a la primera versión para presentar al público de la aplicación que trabajamos en la saga. Todo esto de la mano de tu profesor Facundo García Martoni.

- Conocer el significado y las ventajas de hacer tests.
- Escribir tus primeros tests en Django.
- Agregar archivos CSS e imágenes a tu proyecto.
- Personalizar el administrador de datos a tu gusto.


**Este curso tiene como base el curso DjangoBasico donde se explica cómo se creó el proyecto ue trata sobre una app de votos**

## Testing

>TDD o Test-Driven Development (desarrollo dirigido por tests) es una práctica de programación que consiste en escribir primero las pruebas (generalmente unitarias), después escribir el código fuente que pase la prueba satisfactoriamente y, por último, refactorizar el código escrito.

### ¿Qué son los tests?

Los tests son funciones que nos ayudan a que nuestro código opere correctamente.

Generalmente se testean modelos o vistas

### ¿Por qué debería hacer tests?

Porque me permite evitar errores futuros a través de funciones que trabajan sobre las funciones principales de mi código.

- Nos permite ver errores que a simple vista no hubiéramos visto.
- Nos hace ver más profesionales.
- Permite trabajar en equipo.


### Primer test en nuestro proyecto

~~~bash
python3 manage.py shell
~~~
~~~py
import datetime

from django.test import TestCase
from django.utils import timezone

from .models import Question

# Create your tests here
class QuestionModelTests(TestCase):

    def test_was_publish_recently_with_future_questions(self):
        """was_published_recently returns False for question whose pub_date is in the future"""
        time = timezone.now() + datetime.timedelta(days=30)
        future_question = Question(
            question_text="¿Quien es el mejor Couse Director de platzi?", pub_date=time)
        self.assertIs(future_question.was_published_recently(), False)
~~~
En la función del test definimos el código que se debe ejecutar para hacer la prueba, en este caso está comprendido en la sentencia `def`, para hacer la comprobación usamos el método `self.assertIs({tu resultado},{lo que esperas})`

Luego, corremos la prueba con `python3 manage.py test polls`

Podemos observar que el test falla, debemos corregir la función:
*En el archivo `models.py`*

~~~py
def was_published_recently(self):
    return timezone.now() >= self.pub_date >= timezone.now() - datetime.timedelta(days=1)
~~~
Ahora, ya tenemos el test funcionando correctamente.

### Pasos a seguir para los test

1. Identificamos un problema.
2. Creamos un test. (crear un test que haga fallar)
3. Corremos el test. (esto es hacer que falle el test)
4. Arreglamos el problema.
5. Corremos el test.

Como ejercicio elaboramos una prueba para preguntas actuales, este es el resultado:
~~~py
    def test_was_publish_recently_with_present_questions(self):
        """was_published_recently returns Ture for a quiestion whose pub_date
            is in the present
        """
        time = timezone.now()
        present_question = Question(
            question_text="¿Quien es el mejor Couse Director de platzi?", pub_date=time)
        self.assertIs(present_question.was_published_recently(), True)
~~~

reto:

~~~python
import datetime
from django.test import TestCase
from django.utils import timezone
from .models import Question
# we can test Models or Views


class QuestionModelTests(TestCase):
    def setUp(self) -> None:
        self.question = Question(
            question_text="¿quien es el mejor Course Director de platzi?")

    def test_was_published_recently_with_future_questions(self):
        time = timezone.now() + datetime.timedelta(days=30)
        self.question.pub_date = time
        self.assertIs(self.question.was_published_recently(), False)

    def test_was_published_recently_with_present_questions(self):
        time = timezone.now() - datetime.timedelta(hours=1)
        self.question.pub_date = time
        self.assertIs(self.question.was_published_recently(), True)

    def test_was_published_recently_with_past_questions(self):
        time = timezone.now() - datetime.timedelta(days=1, seconds=1)
        self.question.pub_date = time
        self.assertIs(self.question.was_published_recently(), False)
~~~

### Testing de views

Una ejercicio para hacer testing de una view es por ejemplo revisar si hay o no preguntas. Para esto, se crea una clase que testea a las vistas y al modelo y luego se crea un método para el caso específico:
*En el archivo `tests.py`*
~~~py
class QuestionIndexViewTest(TestCase):
    def test_no_questions(self):
        """If no question exist, an appropiate message is displayed"""
        # estoy haciendo una peticion get http y se guarda en response
        response = self.client.get(reverse("polls:index"))
        self.assertEqual(response.status_code, 200)
        self.assertContains(response, "No polls are available.")
        self.assertQuerysetEqual(response.context["latest_question_list"], [])
~~~
Estos test funcionan porque al momento de ejecutar el comando se crea una base de datos de cero, por lo que las pruebas no se corren sobre la base de datos ya creada. Esta después se elimina automáticamente.

En los test es válido incumplir la filosofía dont repeat yourself porque se están haciendo pruebas, no desarrollando código

### Creando más tests para IndexView

1. primero crearemos una funcion que crea preguntas con parametro de dias:

    ~~~python
    def create_question(question_text, days):
        time = timezone.now() + datetime.timedelta(days=days)
        return Question.objects.create(question_text=question_text, pub_date=time)
    ~~~

2. Tests creados para probar futuras y pasadas preguntas dentro de la misma clase, en la vista index son:

~~~python
class QuestionIndexViewTests(TestCase):
    def test_no_questions(self):
        """If no questions exist, an appropriate message is displayed."""
        response = self.client.get(reverse('polls:index'))
        self.assertEqual(response.status_code, 200)
        self.assertContains(response, "No polls are available")
        self.assertQuerysetEqual(response.context["latest_question_list"], [])

    def test_future_question(self):
        """
        Question with a pub_date in the future will not be published 
        """
        create_question("Future Question", days=30)
        response = self.client.get(reverse('polls:index'))
        self.assertContains(response, "No polls are available")
        self.assertQuerysetEqual(response.context["latest_question_list"], [])

    def test_past_questions(self):
        """
        Question with a pub_date in the past will be published 
        """
        question = create_question("Past Question", days=-30)
        response = self.client.get(reverse("polls:index"))
        self.assertContains(response, "Past Question")
        self.assertQuerysetEqual(
            response.context["latest_question_list"], [question])  # type: ignore
~~~

### Ajustando detalles en los tests para IndexView

1. crearemos 2 test mas para verificar que las preguntas no se muestran cuando hacemos una consulta.

    ~~~python
    class QuestionIndexViewTests(TestCase):
        ...

        def test_future_question_and_past_question(self):
            """
            Even if both past and future questions exist, only past questions are displayed.
            """
            past_question = create_question("Past Question", days=-30)
            future_question = create_question("Future Question", days=30)
            response = self.client.get(reverse("polls:index"))
            self.assertContains(response, "Past Question")
            self.assertQuerysetEqual(
                response.context["latest_question_list"], [past_question])

        def test_two_past_questions(self):
            """
            The questions index page may display multiple questions.
            """
            question1 = create_question("Past Question 1", days=-30)
            question2 = create_question("Past Question 2", days=-40)
            response = self.client.get(reverse("polls:index"))
            self.assertContains(response, "Past Question 1")
            self.assertContains(response, "Past Question 2")
            self.assertQuerysetEqual(
                response.context["latest_question_list"], [question1, question2])

    ~~~


* **Reto: crear un test con 2 preguntas futuras**
    ~~~python
    class QuestionIndexViewTests(TestCase):
        ...

        def test_two_future_questions(self):
            """
            The questions index page may display multiple questions.
            """
            question1 = create_question("Future Question 1", days=30)
            question2 = create_question("Future Question 2", days=40)
            response = self.client.get(reverse("polls:index"))
            self.assertContains(response, "No polls are available")
            self.assertQuerysetEqual(
                response.context["latest_question_list"], [])
    ~~~


### Creando tests para DetailView

1. crear dos test para preguntas si las preguntas futuras o pasadas se representan, las preguntas futuras no deberian mostrarse pero si las pasadas:

~~~python
class QuestionDetailViewTest(TestCase):
    def test_future_question(self):
        """
        The detail view of a question with a pub_date in the future returns a 404 not found.
        """
        future_question = create_question("Future Question", days=30)
        url = reverse("polls:detail", args=(future_question.id,))
        response = self.client.get(url)
        self.assertEqual(response.status_code, 404)

    def test_past_question(self):
        """
        The detail view of a question with a pub_date in the past
        display the question's text.
        """
        past_question = create_question("Past Question", days=-30)
        url = reverse("polls:detail", args=(past_question.id,))
        response = self.client.get(url)
        self.assertContains(response, past_question.question_text)
~~~

* **Reto:**


## Static Files

### que son los static files?

* En Django, los archivos estáticos son archivos que no cambian con frecuencia y que se utilizan para complementar la funcionalidad de una página web, como imágenes, hojas de estilo CSS, scripts JavaScript y otros recursos multimedia. Estos archivos están destinados a ser servidos por el servidor web directamente al navegador, sin ser procesados por Django.

### Agregando estilos a nuestro proyecto

* en el archivo index.html agregaremos el siguiente codigo y el resultado sera el siguiente:

    ~~~python
    {% load static %}
    <link rel="stylesheet" href="{% static 'polls/style.css' %}">

    {% if latest_question_list %}
        <ul>
            {% for question in latest_question_list %}
                <li><a href="{% url 'polls:detail' question.id %}">{{ question.question_text }}</a></li>
            {% endfor %}
        </ul>
    {% else %}
        <p>No polls are available.</p>
    {% endif %}
    ~~~

* luego creamos los siguiente subdirectorios sucesivos en la carpeta polls -> "/static/polls" y alli creamos el archivo style.css con el siguiente codigo:

~~~css
li a {
    color: green;
}
~~~
 esto que el texto de las preguntas sean de color verde

### Añadiendo una imagen de fondo

* agregaremos el siguiente codigo para tener un fondo negro cuando veamos las preguntas

~~~css
li a {
    color: green;
    
}

body {
    background-color: black;
}
~~~


## Django Admin

### Mejorando el Admin: Questions

* Un feature interesante en el administrador de django puede ser el poder crear una pregunta e inmediatamente las respuestas.
El administrador puede ser editado en el archivo `admin.py` de cada aplicación, en este caso, para lograr lo requerido se crea una clase que funciona como modelo de visualización.
**En el archivo `admin.py` de polls**


    ~~~py
    from django.contrib import admin

    # Register your models here.
    from .models import Question, Choice

    # clase para listar nuevas respuestas
    class ChoiceInLine(admin.StackedInline):
        model = Choice
        extra = 3


    class QuestionAdmin(admin.ModelAdmin):
        fields = ["pub_date", "question_text"]
        inlines = [ChoiceInLine] # se agrega la clase antes creada


    admin.site.register(Question, QuestionAdmin) # los argumentos recibidos son 
    # el modelo de db y el modelo de vista
    ~~~


### Mejorando el Admin: Change List

* También se pueden agregar filtros, campos de búsqueda y columnas adicionales para facilitar la navegación entre los datos:


    **En el archivo `admin.py` de polls**
    ~~~py
    class QuestionAdmin(admin.ModelAdmin):
        fields = ["pub_date", "question_text"]
        inlines = [ChoiceInLine]
        # columnas adicionales
        list_display = ("question_text", "pub_date", "was_published_recently") 
        list_filter = ["pub_date"]  # filtros
        search_fields = ["question_text"]   # campos de busqueda
    ~~~




# Helpful tips

## Correr servidor de desarrollo

`python3 manage.py runserver`






# Helpful Links

- [.gitignore](https://www.toptal.com/developers/gitignore)

- [Basic writing and formatting syntax](https://docs.github.com/es/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax)

- [Django documentation](https://docs.djangoproject.com/en/3.2/)

- [CSS Tools: Reset CSS](https://meyerweb.com/eric/tools/css/reset/)


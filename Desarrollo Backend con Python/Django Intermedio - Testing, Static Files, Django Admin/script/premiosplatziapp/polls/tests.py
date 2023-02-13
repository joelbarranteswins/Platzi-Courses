import datetime
import pytest
from django.test import TestCase
from django.urls import reverse
from django.utils import timezone
from .models import Question, Choice, QuestionWithOutChoicesException
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


def create_question(question_text, days):
    time = timezone.now() + datetime.timedelta(days=days)
    return Question.objects.create(question_text=question_text, pub_date=time)


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


class QuestionDetailViewTest(TestCase):
    def test_future_question(self):
        """
        The detail view of a question with a pub_date in the future returns a 404 not found.
        """
        future_question = create_question(
            question_text="Future Question", days=30)
        url = reverse("polls:detail", args=(future_question.id,))
        response = self.client.get(url)
        self.assertEqual(response.status_code, 404)

    def test_past_question(self):
        """
        The detail view of a question with a pub_date in the past
        display the question's text.
        """
        past_question = create_question(
            question_text="Past Question", days=-30)
        url = reverse("polls:detail", args=(past_question.id,))
        response = self.client.get(url)
        self.assertContains(response, past_question.question_text)

    def test_present_question(self):
        """
        The detail view of a question with a pub_date in the present
        display the question's text.
        """
        present_question = create_question(
            question_text="Present Question", days=0)
        url = reverse("polls:detail", args=(present_question.id,))
        response = self.client.get(url)
        self.assertContains(response, present_question.question_text)


class QuestionResultViewTest(TestCase):
    def test_question_without_choices(self):
        """
        The result view of a question without choices
        """
        question = create_question(
            question_text="Question without choices",  days=0)

        with self.assertRaises(QuestionWithOutChoicesException):
            question.get_choices()

    def test_question_must_have_at_least_two_choices(self):
        """
        The result view of a question with one choice
        """
        question = create_question(
            question_text="Question with one choice",  days=0)
        question.choice_set.create(choice_text="Choice 1", votes=0)

        with self.assertRaises(QuestionWithOutChoicesException):
            question.get_choices()

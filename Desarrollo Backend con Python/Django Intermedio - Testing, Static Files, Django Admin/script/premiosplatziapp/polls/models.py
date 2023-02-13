from typing import Optional
from django.utils import timezone
from datetime import timedelta
from django.db import models


class Question(models.Model):
    id = models.AutoField(primary_key=True)
    question_text = models.CharField(max_length=200)
    pub_date = models.DateTimeField('date published')

    def __str__(self):
        return self.question_text

    def was_published_recently(self):
        return timezone.now() >= self.pub_date >= timezone.now() - timedelta(days=1)

    def create_choice(self, choice_text: str):
        choice = Choice(question=self, choice_text=choice_text, votes=0)
        choice.save()
        return choice

    def get_choices(self):
        if self.choice_set.all().count() >= 2:
            return self.choice_set.all()
        elif self.choice_set.all().count() == 1:
            raise QuestionWithOutChoicesException(
                "Question doesn't have enough choices")
        else:
            raise QuestionWithOutChoicesException(
                "Question doesn't have any choices")


class Choice(models.Model):
    id = models.AutoField(primary_key=True)
    question = models.ForeignKey(Question, on_delete=models.CASCADE)
    choice_text = models.CharField(max_length=200)
    votes = models.IntegerField(default=0)

    def __str__(self):
        return self.choice_text


class QuestionWithOutChoicesException(Exception):
    def __init__(self, message: Optional[str] = None):
        self.message = message
        super().__init__(self.message)

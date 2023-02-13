from django.contrib import admin

from polls.models import Choice, Question


class ChoiceInline(admin.TabularInline):
    model = Choice
    extra = 3


class QuestinAdmin(admin.ModelAdmin):
    fields = ['pub_date', 'question_text']
    inlines = [ChoiceInline]
    list_display = ('question_text', 'pub_date', 'was_published_recently',)
    list_filter = ['pub_date']
    search_fields = ['question_text']


admin.site.register(Question, QuestinAdmin)

from django.contrib import admin
from posts.models import Post

@admin.register(Post)
class PostAdmin(admin.ModelAdmin):
  list_display = ('pk', 'user', 'photo', 'created', 'modified')
  list_display_links = ('pk', 'user')
  list_filter = (
    'created',
    'modified'
  )
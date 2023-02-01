from random import randint
from time import sleep


class Node(object):
    def __init__(self, data=None, next=None, previous=None):
        self.data = data
        self.next = next
        self.previous = previous


class Queue:
    def __init__(self):
        self.head = None
        self.tail = None
        self.count = 0

    def enqueue(self, data):
        new_node = Node(data, None, None)

        if self.head is None:
            self.head = new_node
            self.tail = self.head
        else:
            new_node.previous = self.tail
            self.tail.next = new_node  # self.head
            self.tail = new_node

        self.count += 1

    def dequeue(self):
        current = self.head

        if self.count == 1:
            self.count -= 1
            self.head = None
            self.tail = None
        elif self.count > 1:
            self.head = self.head.next
            self.head.previous = None
            self.count -= 1

        return current


class Track:
    def __init__(self, title=None):
        self.title = title
        self.length = randint(5, 6)


class MediaPlayerQueue(Queue):
    def __init__(self):
        super(MediaPlayerQueue, self).__init__()

    def add_track(self, track):
        self.enqueue(track)

    def play(self):
        print(f"count: {self.count}")
        while self.count > 0 and self.head is not None:
            current_track_node = self.dequeue()
            print(f"Now playing {current_track_node.data.title}.")

            sleep(current_track_node.data.length)


if __name__ == "__main__":
    track1 = Track("white whistle")
    track2 = Track("butter butter")
    track3 = Track("Oh black star")
    track4 = Track("Watch that chicken")
    track5 = Track("Don't go")

    print(track1.length)
    print(track2.length)
    print(track3.length)

    media_player = MediaPlayerQueue()

    media_player.add_track(track1)
    media_player.add_track(track2)
    media_player.add_track(track3)
    media_player.add_track(track4)
    media_player.add_track(track5)
    media_player.play()

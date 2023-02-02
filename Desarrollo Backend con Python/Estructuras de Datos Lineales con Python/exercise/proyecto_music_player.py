import random
import winsound
from tqdm import tqdm
from random import randint
import time
from time import sleep

from typing import Any, Optional


class Node(object):
    def __init__(self, data=None, next=None, previous=None):
        self.__data: Any = data
        self.__next: Optional[Node] = next
        self.__previous: Optional[Node] = previous

    @property
    def data(self):
        return self.__data

    @property
    def next(self):
        return self.__next

    @next.setter
    def next(self, next):
        self.__next = next

    @property
    def previous(self):
        return self.__previous

    @previous.setter
    def previous(self, previous):
        self.__previous = previous


class Queue:
    def __init__(self):
        self.head: Optional[Node] = None
        self.tail: Optional[Node] = None
        self.count = 0

    def __repr__(self) -> str:
        list_items = list(self.__iter__())

        if list_items.count == 0:
            return 'Empty Queue'
        elif list_items.count == 1:
            return ' -> '.join(str(item) for item in list_items) + "\n↑__|"
        else:
            underscore = "________" * (self.count - 1)
            return ' -> '.join(str(item) for item in list_items) + f"\n↑_{underscore}|"

    def __iter__(self):
        current = self.head
        while current.next is not self.head:
            value = current.data
            yield value
            current = current.next
        yield current.data

    def enqueue(self, data):
        new_node = Node(data, None, None)

        if self.head is None:
            self.head = new_node
            self.tail = self.head
            self.head.next = self.tail
            self.tail.previous = self.head
        elif self.head == self.tail and self.head is not None:
            new_node.previous = self.tail
            new_node.next = self.head
            self.tail = new_node
            self.head.next = self.tail
        else:
            new_node.previous = self.tail
            self.tail.next = new_node
            self.tail = new_node
            self.tail.next = self.head

        self.count += 1

    def clear(self):
        self.head = None
        self.tail = None
        self.count = 0

    def dequeue(self):
        current = self.head

        if self.count == 0:
            return 'Empty Queue'

        elif self.count == 1:
            self.count -= 1
            self.head = None
            self.tail = None

        elif self.count > 1:
            self.head = self.head.next
            self.tail.next = self.head
            self.head.previous = self.tail
            self.count -= 1

        return current.data

    def peek(self):
        if self.head is not None:
            return self.head.data
        else:
            return None

    def remove(self, data):
        if self.count == 0:
            return "Empty Queue"

        node_list = []
        for node in self.__iter__():
            node_list.append(node)

        if data not in node_list:
            return "Not Found"
        else:
            node_list.remove(data)
            self.clear()
            for node in node_list:
                self.enqueue(node)
            return "Removed"


class Track:
    def __init__(self, title=None):
        self.title = title
        self.time = randint(2, 15)


class MediaPlayerQueue(Queue):
    def __init__(self):
        super(MediaPlayerQueue, self).__init__()

    def add_track(self, track):
        self.enqueue(track)

    def remove_track(self, track):
        self.remove(track)

    def get_track_list(self):
        return list(track.title for track in self.__iter__())

    def play(self):
        if self.head is None:
            return "Empty Playlist"

        print(f"count: {self.count}")
        current = self.head
        while self.count > 0 and self.head is not None:
            current_track_node = self.dequeue()
            print(f"Now playing - {current_track_node.title}.")
            winsound.PlaySound("SystemExit", winsound.SND_ALIAS)
            for i in tqdm(range(current_track_node.time), desc="Loading..."):
                time.sleep(1)
            print("Next music...")

    def next(self):
        print(f"count: {self.count}")
        if self.count > 0 and self.head is not None:
            current_track_node = self.dequeue()
            print("Next music...")
            play()

    def shuffle(self):
        """Shuffle the queue base on nodes"""
        if self.count == 0:
            return "Empty Queue"

        node_list = []
        for node in self.__iter__():
            node_list.append(node)

        self.clear()

        random.shuffle(node_list)
        for node in node_list:
            self.enqueue(node)

        return "Shuffled!"


if __name__ == "__main__":
    track1 = Track("white whistle")
    track2 = Track("butter butter")
    track3 = Track("Oh black star")
    track4 = Track("Watch that chicken")
    track5 = Track("Don't go")

    print(track1.time)
    print(track2.time)
    print(track3.time)

    media_player = MediaPlayerQueue()

    media_player.add_track(track1)
    media_player.add_track(track2)
    media_player.add_track(track3)
    media_player.add_track(track4)
    media_player.add_track(track5)

    print(media_player.get_track_list())
    media_player.remove_track(track4)
    print(media_player.get_track_list())

    media_player.shuffle()
    print(media_player.get_track_list())
    print(media_player.count)
    media_player.play()

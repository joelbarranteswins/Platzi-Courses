"""
Code used during the class 'Queues basadas en nodos'.
"""

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
        list_items = list(self.iter())

        if list_items.count == 0:
            return 'Empty Queue'
        elif list_items.count == 1:
            return ' -> '.join(str(item) for item in list_items) + "\n↑__|"
        else:
            underscore = "________" * (self.count - 1)
            return ' -> '.join(str(item) for item in list_items) + f"\n↑_{underscore}|"

    def iter(self):
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


if __name__ == "__main__":
    x = Queue()

    x.enqueue('eggs')
    x.enqueue('ham')
    x.enqueue('spam')
    x.enqueue('slice')

    print(x.head.data)
    print(x.head.next.data)

    print(x.tail.data)
    print(x.tail.next.data)

    print(x.count)

    print(x)

    print(x.dequeue())
    print(x)
    print(x.count)

"""
Code used for the class 'Circular Linked List'.
"""

from typing import Any, Optional


class Node(object):
    "Represents a single linked node."

    def __init__(self, data, next=None):
        self.data = data
        self.next = next


class CicularLinkedList:

    __head: Optional[Node] = None
    __size: int = 0

    def __init__(self, *items):
        "Initializes the circular linked list."
        self.__head = None
        self.__size = 0

        for item in items:
            self.append(item)

    def __repr__(self) -> str:
        list_items = list(self.__iter__())
        return ' -> '.join(str(item) for item in list_items)

    def __iter__(self):
        current = self.__head
        while current.next != self.__head:
            value = current.data
            current = current.next
            yield value

        yield current

    def __len__(self) -> int:
        return self.__size

    def __str__(self) -> str:
        list_items = list(self.__iter__())
        return ' -> '.join(str(item) for item in list_items)

    @property
    def size(self) -> int:
        "Returns the size of the circular linked list."
        return self.__size

    def append(self, item: Any) -> None:
        "Appends an item to the end of the list. Time complexity: O(n)"

        if self.__head is None:
            self.__head = Node(item)
            self.__head.next = self.__head
        else:
            current = self.__head
            while current.next != self.__head:
                current = current.next
            current.next = Node(item)
            current.next.next = self.__head

        self.__size += 1

    def iternodes(self):
        "Iterates through the circular linked list."

        current = self.__head
        while current.next != self.__head:
            yield current
            current = current.next

        yield current


if __name__ == '__main__':
    cll = CicularLinkedList(1, 2, 3)
    print(cll)

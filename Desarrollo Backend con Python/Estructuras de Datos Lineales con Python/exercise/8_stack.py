"""
Code used for the class 'Crear un stack'.
"""

from typing import Optional


class Node:
    def __init__(self, data=None):
        self.data = data
        self.next = None


class Stack:
    def __init__(self):
        self.top: Optional[Node] = None
        self.size: int = 0

    def __repr__(self) -> str:
        node = self.top
        nodes = []
        while node is not None:
            nodes.append(node.data)
            node = node.next
        nodes.append("None")
        return " -> ".join(nodes)

    def push(self, data):
        " Appends an element on top. "
        node = Node(data)

        if self.top is not None:
            node.next = self.top
            self.top = node
        else:
            self.top = node

        self.size += 1

    def pop(self):
        """ Removes and returns the element on top. """
        if self.top:
            data = self.top.data
            self.size -= 1

            if self.top.next is not None:
                self.top = self.top.next
            else:
                self.top = None

            return data
        else:
            return "The stack is empty"

    def peek(self):
        "Get element on top."
        if self.top is not None:
            return self.top.data
        else:
            return "The stack is empty"

    def search(self, data):
        "Search for an element in the stack."
        node = self.top
        while node is not None:
            if node.data == data:
                return True
            node = node.next
        return False

    def clear(self):
        while self.top:
            self.pop()


if __name__ == "__main__":
    food = Stack()
    food.push("egg")
    food.push("ham")
    food.push("spam")
    print(food)
    print(food.peek())
    food.pop()
    print(food.peek())

    print(food.search("egg"))

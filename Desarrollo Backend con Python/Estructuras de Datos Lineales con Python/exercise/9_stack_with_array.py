"""
Code used for the class 'Crear un stack'.
"""

import numpy as np
from typing import Any


class Array:
    def __init__(self):
        self.array = []


class Stack(Array):
    def __init__(self):
        Array.__init__(self)
        self.top: Any = None
        self.size: int = 0

    def __repr__(self):
        array = self.array
        return ' -> '.join(str(item) for item in array)

    def push(self, data):
        " Appends an element on top."

        if self.top is not None:
            self.array.insert(0, data)
            self.top = data
        else:
            self.array.append(data)
            self.top = data

        self.size += 1

    def pop(self):
        """ Removes and returns the element on top. """
        if self.top is not None:
            self.array.pop(0)
        else:
            return "The stack is empty"

    def peek(self):
        "Get element on top."
        if self.top is not None:
            return self.top
        else:
            return "The stack is empty"

    def search(self, data):
        "Search for an element in the stack."
        if self.top is not None:
            # verify if data is in list
            if data in self.array:
                return True
            else:
                return False
        else:
            return "The stack is empty"

    def clear(self):
        self.top = None
        self.array.clear()
        self.size = 0


if __name__ == "__main__":
    food = Stack()
    food.push(1)
    food.push(2)
    food.push(3)
    print(food)
    print(food.peek())
    print(food.search(2))
    print(food.pop())
    print(food)

"""
Code used for the 'Crear un array' class.

Array type class
Methods:
    1. Length
    2. String representation
    3. Membership
    4. Index.
    5. Replacement
"""
from random import randint


class Array(object):
    "Represents an array."

    def __init__(self, capacity, fill_value=None):
        """
        Args:
            capacity (int): static size of the array.
            fill_value (any, optional): value at each position. Defaults to None.
        """
        self.items = list()
        for i in range(capacity):
            self.items.append(fill_value)

    def __len__(self):
        """Returns capacity of the array."""
        return len(self.items)

    def __str__(self):
        """Returns string representation of the array"""
        return str(self.items)

    def __iter__(self):
        """Supports traversal with a for loop."""
        return iter(self.items)

    def __getitem__(self, index):
        """Subscrit operator for access at index."""
        return self.items[index]

    def __setitem__(self, index, new_item):
        """Subscript operator for replacement at index."""
        self.items[index] = new_item

    def __randomnumbers__(self):
        for i in range(len(self.items)):
            self.items[i] = randint(0, 100)
            return self.items

    def __sum__(self):
        sum = 0
        for i in range(len(self.items)):
            sum += self.items[i]
        return sum


"""
Code used in the shell to create an array
instance and methods.
"""

if __name__ == "__main__":
    menu = Array(5)
    len(menu)
    print(menu)
    for i in range(len(menu)):
        menu[i] = i + 1
    print(menu[0])
    print(menu[2])
    for item in menu:
        print(menu)

    print(menu.__len__())
    print(menu.__str__())
    print(menu.__iter__())
    print(menu.__getitem__(2))
    print(menu.__setitem__(2, 100))
    print(menu.__getitem__(2))

    print(menu.__randomnumbers__())
    print(menu.__sum__())

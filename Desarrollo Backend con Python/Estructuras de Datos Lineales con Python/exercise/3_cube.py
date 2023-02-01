
import random


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


class Grid(object):
    """Represents a two-dimensional array."""

    def __init__(self, rows, columns, fill_value=None):
        self.data = Array(rows)
        for row in range(rows):
            self.data[row] = Array(columns, fill_value)

    def get_height(self):
        "Returns the number of rows."
        return len(self.data)

    def get_width(self):
        """Returns the number of columns."""
        return len(self.data[0])

    def __getitem__(self, index):
        """Supports two-dimensional indexing with [row][column]."""
        return self.data[index]

    def __str__(self):
        """Returns a string representation of the grid."""
        result = ""

        for row in range(self.get_height()):
            for col in range(self.get_width()):
                result += str(self.data[row][col]) + " "

            result += "\n"

        return str(result)


class array_3D():
    def __init__(self, rows, columns, depths, fill_value=None) -> None:
        self.data = Array(rows)
        for row in range(rows):
            self.data[row] = Array(columns)
            for column in range(columns):
                self.data[row][column] = Array(depths, fill_value)

    def __get_height__(self):
        return len(self.data)

    def __get_width__(self):
        return len(self.data[0])

    def __get_depth__(self):
        return len(self.data[0][0])

    def __str__(self) -> str:
        result = ""
        for row in range(self.__get_height__()):
            for col in range(self.__get_width__()):
                for depth in range(self.__get_depth__()):
                    result += str(self.data[row][col][depth]) + " "
                result += "\n"
        return str(result)

    def __random_numbers__(self):
        for row in range(self.__get_height__()):
            for col in range(self.__get_width__()):
                for depth in range(self.__get_depth__()):
                    self.data[row][col][depth] = random.randint(10, 20)


if __name__ == '__main__':
    matrix = array_3D(5, 5, 5)
    print(matrix.__get_height__())
    print(matrix.__get_width__())
    matrix.__random_numbers__()
    print(matrix.__str__())

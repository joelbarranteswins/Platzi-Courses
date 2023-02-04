from abc import abstractmethod


class Coordinate:

    def __init__(self, x, y):
        self.x = x
        self.y = y

    def move(self, length_x, length_y):
        return Coordinate(self.x + length_x, self.y + length_y)

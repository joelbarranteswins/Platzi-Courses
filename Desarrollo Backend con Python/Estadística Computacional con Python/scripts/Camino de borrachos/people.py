import random


class People:

    def __init__(self, name: str):
        self.name = name


class Drunker(People):

    def __init__(self, name):
        People.__init__(self, name)

    def walk(self):
        return random.choice([(0, 1), (0, -1), (1, 0), (-1, 0)])


class Addicted(People):

    def __init__(self, name):
        People.__init__(self, name)

    def walk(self):
        return (
            random.choice([
                (random.random(), random.random() * -1),
                (random.random() * -1, random.random()),
                (random.random() * -1, random.random() * -1),
                (random.random(), random.random()),
            ])
        )

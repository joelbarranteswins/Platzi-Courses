import time


class IterFibo():
    def __init__(self, max_number: int = None):
        # assert type(max_number) in  [int, float], "the input number has to be an integer or float"
        self.max_number = max_number

    def __iter__(self):
        self.number_1 = 0
        self.number_2 = 1
        self.contador = 0
        return self

    def __next__(self):
        if self.contador == 0:
            self.contador += 1
            return self.number_1

        elif self.contador == 1:
            self.contador += 1
            return self.number_2

        elif not self.max_number or self.number_2 < self.max_number:
            self.aux = self.number_1 + self.number_2
            self.number_1 = self.number_2
            self.number_2 = self.aux
            return self.aux

        else:
            raise StopIteration


if __name__ == '__main__':
    fibonacci = IterFibo(max_number=10000)
    for element in fibonacci:
        print(element)
        time.sleep(0.5)

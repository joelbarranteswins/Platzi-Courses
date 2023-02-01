class Queue:
    def __init__(self) -> None:
        self.inboud_stack = []
        self.outbound_stack = []

    def enqueue(self, data):
        self.inboud_stack.append(data)

    def dequeue(self):
        if not self.inboud_stack:
            return "Inbound stack is empty"

        if not self.outbound_stack:
            while self.inboud_stack:
                self.outbound_stack.append(self.inboud_stack.pop())

        return self.outbound_stack.pop()


if __name__ == "__main__":
    numbers = Queue()

    numbers.enqueue(5)
    numbers.enqueue(6)
    numbers.enqueue(7)

    print(numbers.inboud_stack)
    print(numbers.dequeue())

    print(numbers.inboud_stack)
    print(numbers.outbound_stack)

    print(numbers.dequeue())
    print(numbers.inboud_stack)
    print(numbers.outbound_stack)

    print(numbers.dequeue())
    print(numbers.outbound_stack)
    print(numbers.inboud_stack)

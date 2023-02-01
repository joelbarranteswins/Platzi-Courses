"""
Code used during the class 'Queues basadas en nodos'.
"""


class Node(object):
    def __init__(self, data=None, next=None, previous=None):
        self.data = data
        self.next = next
        self.previous = previous


class Queue:
    def __init__(self):
        self.head = None
        self.tail = None
        self.count = 0

    def enqueue(self, data):
        new_node = Node(data, None, None)

        if self.head is None:
            self.head = new_node
            self.tail = self.head
        else:
            new_node.previous = self.tail
            self.tail.next = new_node  # self.head
            self.tail = new_node

        self.count += 1

    def dequeue(self):
        current = self.head

        if self.count == 1:
            self.count -= 1
            self.head = None
            self.tail = None
        elif self.count > 1:
            self.head = self.head.next
            self.head.previous = None
            self.count -= 1

        return current


if __name__ == "__main__":
    x = Queue()

    x.enqueue('eggs')
    x.enqueue('ham')
    x.enqueue('spam')
    print(x)
    print(x.head.data)
    print(x.head.next.data)
    print(x.tail.data)
    print(x.tail.next)
    print(x.count)
    x.dequeue()
    print(x.head.data)

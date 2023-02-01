

class Node(object):
    def __init__(self, data=None, next=None, previous=None):
        self.data = data
        self.next = next
        self.previous = previous


class DoublyLinkedList(object):
    def __init__(self):
        self.head = None
        self.tail = None
        self.count = 0

    def __repr__(self):
        node = self.head
        nodes = []
        while node is not None:
            nodes.append(node.data)
            node = node.next
        nodes.append("None")
        return " -> ".join(nodes)

    def __iter__(self):
        current = self.head

        while current is not None:
            val = current.data
            current = current.next
            yield val

    def append(self, data):
        """ Append an item to the list. """
        new_node = Node(data, None, None)

        if self.head is None:
            self.head = new_node
            self.tail = self.head
        else:
            new_node.previous = self.tail
            self.tail.next = new_node
            self.tail = new_node
            self.count += 1

    def delete(self, data):
        current = self.head
        node_deleted = False

        if current is None:
            node_deleted = False
        elif current.data == data:
            self.head = current.next
            self.head.previous = None
            node_deleted = True
        elif self.tail.data == data:
            self.tail = self.tail.previous
            self.tail.next = None
            node_deleted = True
        else:
            while current:
                if current.data == data:
                    current.previous.next = current.next
                    current.next.previous = current.previous
                    node_deleted = True

                current = current.next

            if node_deleted:
                self.count -= 1

    def contain(self, data):
        for node_data in self.__iter__():
            if data == node_data:
                return True

        return False

    def clear(self):
        """ Clear the entire list. """
        self.tail = None
        self.head = None
        self.size = 0


if __name__ == "__main__":
    dll = DoublyLinkedList()
    dll.append("A")
    dll.append("B")
    dll.append("C")

    print(dll)
    print(dll.contain("B"))
    dll.delete("B")
    print(dll)

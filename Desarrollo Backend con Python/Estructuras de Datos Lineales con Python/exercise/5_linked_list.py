"""
Code used for the 'Singly linked list' class.
"""
# %%


class Node:
    "Represents a single linked node."

    def __init__(self, data, next=None):
        self.data = data
        self.next = None

    def __str__(self):
        "String representation of the node data."
        return str(self.data)

    def __repr__(self):
        "Simple representation of the node."
        return self.data

# %%


class SinglyLinkedList:
    "Represents a singly linked list made of several Node instances."

    def __init__(self):
        self.head = None
        self.__size: int = 0

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
        "Encapsulates the data in a Node class."
        node = Node(data)

        if self.head == None:
            self.head = node
        else:
            current = self.head

            while current.next is not None:
                current = current.next

            current.next = node

        self.__size += 1

    @property
    def size(self):
        "Returns the number of nodes in the list."
        return self.__size

    def replace(self, data, new_data):
        "replaces an element in the singly linked list."
        if self.head is None:
            raise Exception("Linked list is empty")

        current = self.head

        insertion = False
        while current is not None:
            if current.data == data:
                current.data = new_data
                insertion = True

            current = current.next

        if insertion == False:
            raise Exception("Node with data '%s' not found" % data)

    def delete(self, data):
        "Removes an element in the singly linked list."
        if self.head is None:
            raise Exception("Linked list is empty")

        current = self.head
        previous = self.head

        while current:
            if current.data == data:
                if current == self.head:
                    self.head = current.next
                else:
                    previous.next = current.next
                    self.__size -= 1
                    return current.data

            previous = current
            current = current.next

    def insert_first(self, data):
        "Inserts a new node at the beginning of the list."
        node = Node(data)

        if self.head is None:
            self.head = node
        else:
            node.next = self.head
            self.head = node

        self.__size += 1

    def insert_last(self, data):
        "Inserts a new node at the end of the list."
        node = Node(data)

        if self.head is None:
            self.head = node
        else:
            current = self.head

            while current.next is not None:
                current = current.next

            current.next = node

        self.__size += 1

    def search(self, data):
        "Looks for a specific element in the linked list."
        if self.head is None:
            raise Exception("Linked list is empty")

        search = False
        for node in self.__iter__():
            if data == node:
                return f"Data {data} found"

        if search == False:
            return f"Data {data} not found"

    def clear(self):
        "Clear the entire list."

        self.head = None
        #self.head = None
        self.__size = 0


# %%
"""
Ejemplo en shell de SinglyLinkedList con append
"""

if __name__ == "__main__":
    words = SinglyLinkedList()
    words.append('egg')
    words.append('ham')
    words.append('spam')

    print(words.head)
    print(words)
    print(words.size)
    print(words.replace('spam', 'cheese'))
    print(words)
    print(words.delete('cheese'))
    print(words)
    print(words.search('ham'))
    # print(words.clear())

    # while current:
    #     print(current.data)
    #     current = current.next

    # for word in words.iter():
    #     print(word)

    # words.search('eggs')

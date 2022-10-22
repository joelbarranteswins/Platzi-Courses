import unittest


def mayor_edad(edad):
    if edad >= 18:
        return True
    else:
        return False


class PruebaDeCristalTest(unittest.TestCase):

    def es_mayor(self):
        edad = 15
        result = mayor_edad(edad)

        self.assertEqual(result, True)

    def es_menor(self):
        edad = 100
        result = mayor_edad(edad)

        self.assertEqual(result, False)


if __name__ == '__main__':
    unittest.main()

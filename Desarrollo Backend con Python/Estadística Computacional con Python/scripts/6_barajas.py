import random
import collections

TIPOS = ['espada', 'corazon', 'rombo', 'trebol']
VALORES = ['as', '2', '3', '4', '5', '6', '7',
           '8', '9', '10', 'jota', 'reina', 'rey']


def crear_baraja() -> list[tuple[str, str]]:
    barajas: list = []
    for tipo in TIPOS:
        for valor in VALORES:
            barajas.append((tipo, valor))

    return barajas


def obtener_mano(
        barajas: list[tuple[str, str]],
        tamano_mano: int) -> list[tuple[str, str]]:
    mano = random.sample(barajas, tamano_mano)
    return mano


def main(tamano_mano: int, intentos: int):
    barajas = crear_baraja()

    manos: list[list[tuple[str, str]]] = []
    for _ in range(intentos):
        mano: list[tuple[str, str]] = obtener_mano(barajas, tamano_mano)
        manos.append(mano)
    print(manos)

    pares = 0
    for mano in manos:
        valores: list[str] = []
        for carta in mano:
            valores.append(carta[1])

        counter = dict(collections.Counter(valores))
        print(counter)
        for val in counter.values():
            if val == 2:
                pares += 1
                break

    probabilidad_par = pares / intentos
    print(
        f'La probabilidad de obtener un par en una mano de {tamano_mano} barajas es {probabilidad_par}')


if __name__ == '__main__':
    tamano_mano = 5
    intentos = 10000

    main(tamano_mano, intentos)

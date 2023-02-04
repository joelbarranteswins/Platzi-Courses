import random
import collections

TIPOS = ['espada', 'corazon', 'rombo', 'trebol']
VALORES = ['1', '2', '3', '4', '5', '6', '7',
           '8', '9', '10', '11', '12', '13']


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


def probabilidad_de_escalera(manos: list[list[tuple[str, str]]], intentos: int) -> float:
    cartas_consecutivas = 0
    for mano in manos:
        valores: list[int] = []
        for carta in mano:
            valores.append(int(carta[1]))

        valores.sort()

        for valor in set(valores):
            result = all(consecutivo in valores
                         for consecutivo in [valor+1, valor+2, valor+3, valor+4])

            if result is True:
                cartas_consecutivas += 1
                break

    probabilidad_corrida = cartas_consecutivas / intentos
    return probabilidad_corrida


def probabilidad_de_par(manos: list[list[tuple[str, str]]], intentos: int) -> float:
    pares = 0
    for mano in manos:
        valores: list[str] = []
        for carta in mano:
            valores.append(carta[1])

        counter = dict(collections.Counter(valores))
        for val in counter.values():
            if val == 2:
                pares += 1
                break

    probabilidad_par = pares / intentos
    return probabilidad_par


def probabilidad_de_doble_par(manos: list[list[tuple[str, str]]], intentos: int) -> float:
    dobles_pares = 0
    for mano in manos:
        valores: list[str] = []
        for carta in mano:
            valores.append(carta[1])

        counter = dict(collections.Counter(valores))
        values = counter.values()

        if list(values).count(2) == 2:
            dobles_pares += 1
            break

    probabilidad_doble_par = dobles_pares / intentos
    return probabilidad_doble_par


def probabilidad_de_trio(manos: list[list[tuple[str, str]]], intentos: int) -> float:
    trios = 0
    for mano in manos:
        valores: list[str] = []
        for carta in mano:
            valores.append(carta[1])

        counter = dict(collections.Counter(valores))
        values = counter.values()

        if list(values).count(3) == 1:
            trios += 1
            break

    probabilidad_trio = trios / intentos
    return probabilidad_trio


def probabilidad_de_poker(manos: list[list[tuple[str, str]]], intentos: int) -> float:
    poker = 0
    for mano in manos:
        valores: list[str] = []
        for carta in mano:
            valores.append(carta[1])

        counter = dict(collections.Counter(valores))
        values = counter.values()

        if list(values).count(4) == 1:
            poker += 1
            break

    probabilidad_poker = poker / intentos
    return probabilidad_poker


def probabilidad_de_fullhouse(manos: list[list[tuple[str, str]]], intentos: int) -> float:
    fullhouse = 0
    for mano in manos:
        valores: list[str] = []
        for carta in mano:
            valores.append(carta[1])

        counter = dict(collections.Counter(valores))
        values = counter.values()

        if list(values).count(3) == 1 and list(values).count(2) == 1:
            fullhouse += 1
            break

    probabilidad_fullhouse = fullhouse / intentos
    return probabilidad_fullhouse


def probabilidad_de_escalera_de_color(manos: list[list[tuple[str, str]]], intentos: int) -> float:
    escalera_de_color = 0

    for mano in manos:
        tipo_espada = []
        tipo_corazon = []
        tipo_rombo = []
        tipo_trebol = []
        for carta in mano:
            if carta[0] == 'espada':
                tipo_espada.append(carta)
            elif carta[0] == 'corazon':
                tipo_corazon.append(carta)
            elif carta[0] == 'rombo':
                tipo_rombo.append(carta)
            elif carta[0] == 'trebol':
                tipo_trebol.append(carta)
            else:
                raise ValueError('El tipo de carta no es válido')

        tipos = [
                [int(carta[1]) for carta in tipo_espada],
                [int(carta[1]) for carta in tipo_corazon],
                [int(carta[1]) for carta in tipo_rombo],
                [int(carta[1]) for carta in tipo_trebol]
        ]

        for tipo in tipos:
            for valor in set(tipo):
                result = all(consecutivo in tipo
                             for consecutivo in [valor+1, valor+2, valor+3, valor+4])

                if result is True:
                    escalera_de_color += 1
                    break

    probabilidad_escalera_de_color = escalera_de_color / intentos
    return probabilidad_escalera_de_color


def main(tamano_mano: int, intentos: int):
    assert tamano_mano > 0, 'El tamaño de la mano debe ser mayor a 0'
    assert tamano_mano <= 52, 'El tamaño de la mano debe ser menor a 52'
    assert intentos > 0, 'El número de intentos debe ser mayor a 0'

    manos: list[list[tuple[str, str]]] = [
        obtener_mano(crear_baraja(), tamano_mano) for _ in range(intentos)
    ]

    probabilidad_par = probabilidad_de_par(manos, intentos)
    probabilidad_doble_par = probabilidad_de_doble_par(manos, intentos)
    probabilidad_trio = probabilidad_de_trio(manos, intentos)
    probabilidad_corrida = probabilidad_de_escalera(manos, intentos)
    probabilidad_poker = probabilidad_de_poker(manos, intentos)
    probabilidad_fullhouse = probabilidad_de_fullhouse(manos, intentos)

    print(
        f""" la probabilidad de par (2 cartas de numero igual): {probabilidad_par}""")
    print(
        f""" la probabilidad de doble par (2 cartas de numero igual de 1 tipo y de otro tipo): {probabilidad_doble_par}""")
    print(
        f""" la probabilidad de trio (3 cartas de numero igual): {probabilidad_trio}""")
    print(
        f""" la probabilidad de poker (4 cartas de numero igual): {probabilidad_poker}""")
    print(
        f""" la probabilidad de fullhouse (3 cartas de numero igual y 2 cartas de numero igual): {probabilidad_fullhouse}""")
    print(
        f""" la probabilidad de escalera (5 cartas consecutivas): {probabilidad_corrida}""")


if __name__ == '__main__':
    tamano_mano = 5
    intentos = 10000

    main(tamano_mano, intentos)

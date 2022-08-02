import random
from fractions import Fraction


def numero_azar():
    return random.randint(0, 3 - 1)


def generate_doors():
    doors = ['Cabra' for i in range(3)]
    aleatorio = numero_azar()
    doors[aleatorio] = 'Winner'  
    return doors


def abrir_otra_puerta_mala(positions, chosen):
    aleatorio = numero_azar()

    while aleatorio == chosen or positions[aleatorio] == 'Winner':
        aleatorio = numero_azar()

    return aleatorio


def change_door(chosen, puerta_abierta):
    nuevo = numero_azar()

    while nuevo == chosen or nuevo == puerta_abierta:
        nuevo = numero_azar()
    return nuevo


def run():
    tries = int(input('Numero de repeticiones: '))    
    ganado = 0
    perdidos = 0

    for _ in range(tries):
        puertas = generate_doors()
        chosen = numero_azar()
        puerta_abierta = abrir_otra_puerta_mala(puertas, chosen)

        cambiar = change_door(chosen, puerta_abierta)

        print(puertas, chosen, puerta_abierta, cambiar, puertas[cambiar])

        if puertas[cambiar] == 'Winner':
            ganado += 1
        else:
            perdidos += 1

    print(f'Se ha ganado un {ganado} / {tries} y se ha perdido {perdidos} / {tries}')


if __name__ == '__main__':
    run()
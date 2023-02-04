import random

def tirar_dado(numero_de_tiros: int) -> list[int]:
    secuencia_de_tiros = []

    for _ in range(numero_de_tiros):
        tiro_1 = random.choice([1, 2, 3, 4, 5, 6])
        tiro_2 = random.choice([1, 2, 3, 4, 5, 6])
        secuencia_de_tiros.append(tiro_1 + tiro_2)

    return secuencia_de_tiros

def main(numero_de_tiros: int, numero_de_intentos: int):
    tiros: list[list[int]] = []
    for _ in range(numero_de_intentos):
        secuencia_de_tiros = tirar_dado(numero_de_tiros=numero_de_tiros)
        tiros.append(secuencia_de_tiros)

    tiros_con_12 = 0
    for tiro in tiros:
        print(tiro)
        if 12 in tiro:
            tiros_con_12 += 1
    print(tiros_con_12)
    probabilidad_tiros_con_12: float = tiros_con_12 / numero_de_intentos
    print(f'Probabilidad de obtener por lo menos un 12 en {numero_de_tiros} tiros = {probabilidad_tiros_con_12}')

    tiros_no_con_12 = 0
    for tiro in tiros:
        print(tiro)
        if 12 not in tiro:
            tiros_no_con_12 += 1
    print(tiros_no_con_12)

    probabilidad_no_tiros_con_12: float = tiros_no_con_12 / numero_de_intentos
    print(f'Probabilidad de NO obtener por lo menos un 12 en {numero_de_tiros} tiros = {probabilidad_no_tiros_con_12}')

if __name__ == '__main__':
    numero_de_tiros: int = 10
    numero_de_intentos: int = 10000

    main(numero_de_tiros, numero_de_intentos)
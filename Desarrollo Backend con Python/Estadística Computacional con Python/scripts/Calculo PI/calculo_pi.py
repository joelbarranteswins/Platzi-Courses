import random
import math
from estadisticas import desviacion_estandar, media


def aventar_agujas(numero_de_agujas: int) -> float:
    adentro_del_circulo = 0

    for _ in range(numero_de_agujas):
        x = random.random() * random.choice([-1, 1])
        y = random.random() * random.choice([-1, 1])
        distancia_desde_el_centro = math.sqrt(x**2 + y**2)

        if distancia_desde_el_centro <= 1:
            adentro_del_circulo += 1

    return (4 * adentro_del_circulo) / numero_de_agujas


def estimacion(numero_de_agujas, numero_de_intentos):
    estimados = []
    for _ in range(numero_de_intentos):
        estimacion_pi = aventar_agujas(numero_de_agujas)
        estimados.append(estimacion_pi)

    media_estimados = media(estimados)
    sigma = desviacion_estandar(estimados)
    print(f"""
          Est={round(media_estimados, 5)}, 
          sigma={round(sigma, 5)}, 
          agujas={numero_de_agujas}""")

    return (media_estimados, sigma)


def estimar_pi(precision, numero_de_intentos):
    numero_de_agujas = 1000
    sigma = precision

    media: float = 0.0
    while sigma >= precision / 1.96:  # 1.96 se basa en el interbalo de confianza del 95%
        media, sigma = estimacion(numero_de_agujas, numero_de_intentos)
        numero_de_agujas *= 2

    return media


if __name__ == '__main__':
    estimar_pi(0.01, 1000)

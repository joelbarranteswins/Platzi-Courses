'''Pomodoro es un sistema para que administres el tiempo mientras trabajas,
consiste en colocar un temporizador de 25 minutos y descansar 5 minutos,
repetir el ciclo 4 veces y posterior aumentar el tiempo de descanso o directamente parar'''  
import time 
import winsound

def contador(segundos):
    while segundos > 0:
        m,s = divmod(segundos, 60) #con divmod obtenemos el cociente y el residuo de la división de los valores ingresados, ambos lo guardamos en las variables m y s.
        formato_minuto_segundo = '{:02d}:{:02d}'.format(m,s)#''.format() es una función que usa como formato lo que este en las comillas y pone los valores de las variables ingresadas en el parentesis, lo que esta en las comillas en este caso es un mini lenguaje de python enfocado en los strings, aqui su documentación https://docs.python.org/2/library/string.html#formatspec
        print(formato_minuto_segundo)
        time.sleep(1)#(Segundos), le decimos al ciclo que duerma 1 segundo usando nuestro modulo time y la funcion sleep()
        segundos -= 1

 
def alarma():
    sonido = 0
    while True:#Comando para hacer un while infinito
        DURATION = 500  # Milisegundos
        FREQ = 450  # Hz
        winsound.Beep(FREQ, DURATION)
        sonido += 1
        if sonido < 15:
            continue
        else: 
            break

def run():
    menu = '''¿Vas a empezar tu tiempo de trabajo?
    Presiona 1 si quieres empezar tu cuenta pomodoro o enter si caiste por error y quieres cerrar el programa: '''
    menu = bool(input(menu))
    if menu:
        pomodoros =  0
        while True:
            contador(25*60)
            alarma()
            print('Descansa 5 minutos.')
            contador(5*60)
            alarma()
            print('Vuelve a trabajar')
            pomodoros += 1
            if pomodoros < 4:
                continue
            else:
                print('Tu ciclo pomodoro esta completo, toma un respiro ;)')
                break
    else:
        pass


if __name__ == '__main__':
    run()
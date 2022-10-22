def primera_letra(lista_de_palabras):
    primeras_letras = []

    for palabra in lista_de_palabras:
        assert type(palabra) == str, f'{palabra} no es str'
        assert len(palabra) > 0, 'no se permiten srt vacios'

        primeras_letras.append(palabra[0].capitalize())

    return primeras_letras


primera_letra(['hola', 'como', 'estas'])

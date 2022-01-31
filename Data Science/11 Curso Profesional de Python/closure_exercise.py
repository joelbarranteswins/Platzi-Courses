
def make_division_by(n: int) -> float:
    """
    this closure return a function that returns the division
    of an x number by n
    """
    assert n != 0, "n no debe ser cero"
    assert type(n) in [int, float], "debe es un numero entero o flotante"

    def division(number: int) -> float:
        assert type(number) in [int, float], "debe ser un numero entero o flotante"
        return number/n
    
    return division


# division_by_3 = make_division_by(3)
# print(division_by_3(18))

# division_by_5 = make_division_by(5)
# print(division_by_5(100))

# division_by_18 = make_division_by(18)
# print(division_by_18(54))
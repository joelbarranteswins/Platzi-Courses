def median(values: list) -> float:
    return sum(values) / len(values)

def get_pendent(x_values: list, y_values: list, x_median: float = None, y_median: float = None) -> float:

    if not x_median:
        x_median = median(x_values)
    if not y_median:
        y_median = median(y_values)

    aux_x = [x-x_median for x in x_values]
    aux_y = [y-y_median for y in y_values]

    numerator = sum(aux_x[i] * aux_y[i] for i in range(len(aux_x)))
    denominator = sum((x-x_median)**2 for x in x_values)

    return numerator / denominator


def get_constant(x_values: list = None, y_values: list = None, x_median: float = None, y_median: float = None, pendent: float = None):

    assert x_values or x_median, "Invalid Must have X Values or the median of X Values"
    assert y_values or y_median, "Invalid Must have Y Values or the median of Y Values"

    if not x_median:
        x_median = median(x_values)
    if not y_median:
        y_median = median(y_values)

    if not pendent:
        assert x_values and y_values, "Invalid if you don't send the pendent must send the X and Y Values"
        pendent = get_pendent(x_values, y_values,
                              x_median=x_median, y_median=y_median)

    return y_median - pendent * x_median

def get_lineal_regretion(x_values: list, y_values: list) -> dict:
    x_median = median(x_values)
    y_median = median(y_values)
    pendent = get_pendent(
        x_values=x_values,
        y_values=y_values,
        x_median=x_median,
        y_median=y_median
    )
    constant = get_constant(
        x_median=x_median,
        y_median=y_median,
        pendent=pendent
    )

    return {
        'equation': 'y= mx + b',
        'y': y_median,
        'x': x_median,
        'm': pendent,
        'b': constant
    }


if __name__ == '__main__':
    a = get_lineal_regretion(x_values=[1,2,4,5,8,9,7],y_values=[8,7,4,5,6,1,9])
    print(a)
import matplotlib.pyplot as plt


def generate_bar_chart(name, labels, values):
    fig, ax = plt.subplots()
    ax.bar(labels, values)
    plt.savefig(f'./imgs/{name}.png')
    plt.close()


def generate_pie_chart(labels, values):
    fig, ax = plt.subplots()
    ax.pie(values, labels=labels)
    ax.axis('equal')
    plt.savefig('chart_pie_final.png')
    plt.close()


if __name__ == '__main__':
    labels = ['a', 'b', 'c']
    values = [10, 40, 800]
    # generate_bar_chart(labels, values)
    generate_pie_chart(labels, values)

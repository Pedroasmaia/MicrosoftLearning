from time import sleep


def user_input():
    data_input = input('Entre com novo valor, ou "done" para encerrar: ')
    data = []
    while data_input.lower() != 'done':
        if user_input:
            data.append(data_input)
            print(data)
        data_input = input('Entre com novo valor, ou "done" para encerrar: ')

def number_count():
    countdown = [4, 3, 2, 1, 0]
    for number in countdown:
        print(number)
    print('Enviando🚀')
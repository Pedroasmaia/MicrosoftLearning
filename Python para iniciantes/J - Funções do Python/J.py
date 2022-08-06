def func():
    print("Pedro, Pereira, Pinto")


def save_var():
    return("Pedro, Pereira, Pinto")

output = save_var()
# print(output)
''' Output:

Pedro, Pereira, Pinto
'''
def func_arg(age):
    if age <= 17:
        print('Você não pode beber alcool')
    else:
        print('Qual bebida deseja?')

def calc_hour(distancia,velocidade):
    hour = distancia/velocidade
    return hour/24
# print(calc_hour(100,2.3))

def study_hours(hours=8):
    day = 365
    return f'Em um ano você estudou: {day * hours} horas'
# print(study_hours(1))
'''Output: 
Em um ano você estudou: 2920 horas
'''

def var_arg(*args):
    print(args)
# var_arg('Pedro','Jorge',10)
#Output :  'Pedro','Jorge',10


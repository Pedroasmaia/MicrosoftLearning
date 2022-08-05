def init():
    planets = ["Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"]

    print("The first planet is", planets[0])
    print("The second planet is", planets[1])
    print("The third planet is", planets[2])

    # Output
    # The first planet is Mercury
    # The second planet is Venus
    # The third planet is Earth

    planets[2] = "Water"
    print(planets)

    #Output:
    # ['Mercury', 'Venus', 'Water', 'Mars', 'Jupiter', 'Saturn', 'Uranus', 'Neptune']

def negative_index():
    fruit = ['orange','banana','kiwi']
    print(fruit[0])
    print(fruit[-1])
    # Output:
    # orange
    # kiwi

def learn_append():
    fruit = ['orange','kiwi']
    fruit.append('banana')
    print(fruit)
    #Output:
    # ['orange', 'kiwi', 'banana']

def learn_len():
    fruits = ['orange','kiwi']
    count_fruit = len(fruits)
    print(f'Total of fruits is {count_fruit}')
    #Output:
    # Total of fruits is 2


def learn_pop():
    fruits = ['orange','kiwi','Banana']
    fruits.pop()
    print(fruits)
    # output:
    # ['orange', 'kiwi']


def learn_index():
    fruits = ['orange','kiwi','Banana']
    index_kiwi = fruits.index('kiwi')
    print(f'O numero de indice do kiwi é {index_kiwi}')
    # output
    # O numero de indice do kiwi é 1

def learn_min_max():
    notas = [10,2,5,6,9,6]
    print(f'A menor nota foi {min(notas)} e a maior nota foi {max(notas)}')
    #Output
    #A menor nota foi 2 e a maior nota foi 10

def learn_sort():
    numeros = [10,11,9,8,5,3]
    numeros.sort()
    print(numeros)
    #Output:
    # [3, 5, 8, 9, 10, 11]

def fatiar_listas():
 notas = [10,2,5,6,9,6]
 sala_um = notas[0:3]
 sala_dois = notas[3:6]
 print(f'As notas da sala um foram {sala_um}')
 print(f'As notas da sala dois foram {sala_dois}')
 #Output
 #As notas da sala um foram [10, 2, 5]
#As notas da sala dois foram [6, 9, 6]

def unir_listas():
    notas_pedro = [5,6,9]
    notas_maria = [8,9,10]
    notas_casal = notas_maria + notas_pedro
    print(notas_casal)
    #Output
    #[8, 9, 10, 5, 6, 9]

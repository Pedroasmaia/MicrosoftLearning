igualdade = 'a' == 'b'
diferente = 'a' != 'b'
menor = 'a' < 'b'
menor_ou_igual = 'a' <= 'b'
maior = 'a' > 'b'
maior_ou_igual = 'a' >= 'b'

def expressão_teste():
    a = int(input('Coloque um número: '))
    b = int(input('Coloque um número: '))

    if a < b:
        print(f'{a} é menor que {b}')
    elif a == b:
        print('Os dois números tem o mesmo valor')
    else:
        print(f'{a} é maior que {b}')

def logica_aninhada():
    a = int(input('Coloque um número: '))
    b = int(input('Coloque um número: '))
    c = int(input('Coloque um número: '))

    if a > b:
        if b > c:
            print(f'{a} é maior que {b} e {b} é maior que {c}')
        else:
            print(f'{a} é maior que {b} e {b} é menor ou igual que {c}')

    elif a == b:
        print('Os dois números tem o mesmo valor')
    else:
        print(f'{a} é maior que {b}')

def expressão_and():
    Aluno1 = int(input('Qual foi a nota do Aluno 1:'))
    Aluno2 = int(input('Qual foi a nota do Aluno 2:'))
    if Aluno1 >= 60 and Aluno2 >=60:
        print('Os dois alunos foram aprovados')

def expressão_or():
    Aluno1 = int(input('Qual foi a nota do Aluno 1:'))
    Aluno2 = int(input('Qual foi a nota do Aluno 2:'))
    if Aluno1 >= 60 or Aluno2 >=60:
        print('Um dos 2 alunos foram aprovados')
expressão_or()
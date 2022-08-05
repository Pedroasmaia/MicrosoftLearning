planeta = {
    'nome' :'Terra',
    'luas' : 1
}

def learn_get():
    print(planeta.get('nome'))

#Output : Terra


def learn_otherget():
    print(planeta['nome'])
#Output : Terra


def learn_returnget():
    print(planeta.get('tamanho')) 
    #Output: None
    print(planeta['tamanho'])
    #Output: KeyError: 'tamanho'


def update_dict():
    planeta.update({'nome':'plutao'})
    print(planeta)
    #Output: {'nome': 'plutao', 'luas': 1}

def update_otherupdate():
    planeta['nome'] = 'Plutao'
    print(planeta)
    #Output: {'nome': 'plutao', 'luas': 1}

dados_complexos = {
    'planeta' : 'Jupiter',
    'propriedades' : {
        'luas' : 79,
        'diametros (km)' : {
            'polar' : 133709,
            'equatorial' : 142984
        }
    }
}

def learn_key():
    idades = {
    'Pedro': 4,
    'Maria': 3,
    'Jose': 2
    }
    for nomes in idades.keys():
        print(f'{nomes} tem {idades[nomes]} anos de idade')

learn_key()
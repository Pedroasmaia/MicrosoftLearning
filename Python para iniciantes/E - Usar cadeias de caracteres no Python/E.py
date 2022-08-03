import string


def varias_strings():
    fact = 'O Fato'
    two_facts = fact + ' é veridico'
    print(two_facts)


def alternar_aspas():
    string = "O simbolo # é conhecido como hashtag, já esse outro: ' se chama apóstrofo"
    print(string)



def varias_linhas():
    string = """Fatos sobre a lua:
    Nela não tem som
    Ela não contem atmosfera"""
    print(string)


def title_string():
    string = 'a seu tiTULO'
    print(string.title())

def split_string():
    temperaturas = """10° Betim
    15° BH
    12° Contagem"""
    print(temperaturas.split('\n'))

    nomes = 'Pedro,Jose,Faria,Rocha,Maia,Persófona'
    print(nomes.split(','))
split_string()
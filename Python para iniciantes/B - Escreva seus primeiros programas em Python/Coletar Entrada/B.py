# Textos

print("Welcome to the greeter program")
name = input("Enter your name ")
print("Greetings: " + name)

# Números

print("calculator program")
first_number = input("first number: ")
second_number = input("second number: ")
print(int(first_number) + int(second_number))

import sys

print(f'O primeiro argumento foi {sys.argv[1]}')
print(f'O segundo argumento foi {sys.argv[2]}')


#"Ao rodar no CLI python sys.py pedro maria o resultado será"
#"O primeiro argumento foi pedro"
#"O segundo argumento foi maria"
//Operadores mátematicos

int soma = 1 + 3;
int subtração = 5 -3;
int multiplicação = 7 * 5;
int divisão = 7/5;

Console.WriteLine("Soma: "+soma);
//Output: Soma:4
Console.WriteLine("Subtração: "+ subtração);
//Output: Subtração: 2
Console.WriteLine("Multiplicacao: " +multiplicação);
//Output: Multiplicacao: 35
Console.WriteLine("Divisão: " + divisão);
//Output: Divisão:1

//Reparem que o divisão esta errado pois passamos o tipo de dado errado nos dados, deveríamos ter usado decimal ao invés de int e passando o "m" apos o número decimal

decimal division = 7.0m/5;
Console.WriteLine("Divisão: " + division);

//Conversões temporárias
int first = 7;
int second = 2;
//Passando como eu quero que o compilador trate os dados entre parenteses
decimal result = (decimal)first / (decimal)second;
Console.WriteLine(result);
//output: 3.5

//Resto de divisão

//Para descobrir se um número é divisível pelo outro  basta usar o operador %, se o final for 0, significa que sim.
Console.WriteLine("Resto da divisão de 200 / 5 : " + (200 % 5));
Console.WriteLine("Resto da divisão de 7 / 5 : " + (7 % 5));

//Teste 
decimal numberOne = decimal.Parse(Console.ReadLine());
decimal numberTwo = decimal.Parse(Console.ReadLine());
Console.WriteLine(numberOne % numberTwo);


//Ordem das operações
//1° Parenteses
//2° Exponentes
//3° Multiplicação e Divisão (da esquerda pra direita)
//4° Adição e Subtração (da esquerda pra direita)
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
//Output: 23
Console.WriteLine(value2);
//Output: 35

//Apesar de não haver OPERADOR para exponentes você pode chamar a biblioteca Math assim:
int numero = 3;
Console.WriteLine(System.Math.Pow(numero,2));//Pow Potenciação
Console.WriteLine(System.Math.Sqrt(numero));//Sqrt Raiz

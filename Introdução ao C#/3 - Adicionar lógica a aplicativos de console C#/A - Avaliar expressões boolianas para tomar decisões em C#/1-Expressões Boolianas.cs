//! O que é uma expressão:
// Qualquer combinação de valores, operadores e métodos que retornem um único valor.
// Uma expressão booliana avalia os valores para retornar TRUE ou FALSE
//! Avaliando igualdade e desigualdade
// Um operador de igualdade (==) pode ser usado para avaliar a igualdade, se forem igual retornara TRUE, caso contrario retornara FALSE.
// Um operador de desigualdade (!=) pode comparar para ver se são diferentes
Console.WriteLine('a' == 'a');
Console.WriteLine('a' == 'A');
Console.WriteLine(1 == 2);
string myValue = "a";
Console.WriteLine(myValue == "a");
//! Melhora a verificação
string letraUm = "a";
string letraDois = "a ";

Console.WriteLine(letraUm == letraDois);
//Output = False
Console.WriteLine(letraUm == letraDois.Trim());
//Output = True
string letraTres = "A ";
Console.WriteLine(letraUm == letraTres.Trim().ToLower());
//Output = True
//! Usar o operador de desigualdade
Console.WriteLine("a" != "a");
//Output : False
Console.WriteLine("a" != "A");
//Output : True
Console.WriteLine(1 != 2);
//Output : True
myValue = "a";
Console.WriteLine(myValue != "a");
//Output : False
//! Operadores de comparações
// Maior que >
// Maior ou igual que >=
// Menor que <
// Menor ou igual que <=
Console.WriteLine(1>2);
//Output: False
Console.WriteLine(1>2);
//Output: True
Console.WriteLine(1>=1);
//Output: True
Console.WriteLine(1<=1);
//Output: True
//! Métodos Booliano que retorna valor
//São métodos de consulta, por exemplo o método Contains()
string fullName = "Jorge Aragão Ribeiro Lima";
Console.WriteLine(fullName.Contains("Ribeiro"));
//Output: True
Console.WriteLine(fullName.Contains("Souza"));
//Output: False

//! Negação Logica:
// É o operador "!", verifica se a expressão é falsa, abaixo as duas linhas vão fazer a mesma coisa:
Console.WriteLine(fullName.Contains("Pedro") == false);
//Output: True
Console.WriteLine(!fullName.Contains("Pedro"));
//Output: True
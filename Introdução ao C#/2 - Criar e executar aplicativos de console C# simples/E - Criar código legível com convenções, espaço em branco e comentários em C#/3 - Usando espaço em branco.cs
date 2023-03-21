//! Espaço em Branco

// Espaços em brancos são "espaços individuais" criados pela barra de espaço
// Tabulações produzidas pela tecla tab
// Novas linhas produzidas pela tecla enter

//O Espaço em branco é ignorado pelo Compilador de C# como podemos ver:

Console
.
WriteLine
(
   "Hello World!"
);
//Output: "Hello World!"
string firstWord="Hello";string lastWord="World";Console.WriteLine(firstWord+" "+lastWord+"!");
//Output: "Hello World!"

//Os dois exemplos mostram como o espaço em branco não é compilado, mas pode ser usado para facilitar a compreensão do código


//! Ilustrando como um espaço em branco pode ser util para compreender o código.
Random dice = new Random();
//                                    Espaço adicionado
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);
//                                    Espaço adicionado
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Rolagens do dado: {roll1} + {roll2} + {roll3} = {total}");
//                                    Espaço adicionado
if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))//Descendo abertura do Bloco
{
   if((roll1 == roll2) && (roll2 == roll3))//Descendo abertura do Bloco
   {
      Console.WriteLine("Você tirou 3 iguais! Mais 6 pontos no total");
      total += 6;
   }//Separando dois blocos diferentes
   else//Descendo abertura do Bloco
   {
      Console.WriteLine($"Você tirou 2 iguais! Mais 2 pontos no total");
      total += 2;
   }
   Console.WriteLine($"Seu total então é {total}");
}

// Notamos que não há espaço na vertical
// Os blocos de código {} são muito próximos, dificultando descobrir seu inicio/fim
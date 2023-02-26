// O if usa uma expressão booliana colocada entre parênteses.
//! Criar um jogo de números aleatórios usando instruções if
//Usaremos o método Random.Net() para simular a rodagem de 3 dados e vamos avaliar para calcular a pontuação, regras:

//Todo: Se quaisquer dois dados rolados resultarem no mesmo valor, o jogador deve receber dois pontos bônus.
//Todo: Se todos os três dados rolados resultarem no mesmo valor, o jogador deve receber seis pontos bônus.
//Todo: Se a soma dos 3 dados rolados, mais os pontos bonus, for igual ou maior que 15 o jogador vencerá o desafio, caso contrario perdera
Random dice = new Random(); //Uma instancia da classe Random

int diceRoll1 = dice.Next(1, 7);
int diceRoll2 = dice.Next(1, 7);
int diceRoll3 = dice.Next(1, 7);

int points = diceRoll1 + diceRoll2 + diceRoll3;

Console.WriteLine($"Dice roll: {diceRoll1} + {diceRoll2} + {diceRoll3} = {points}");

//Adicionando a instrução IF para exibir as mensagens
// () Expressão booliana
// {} Bloco de código definido por {}

if(points > 14){ 
   Console.WriteLine("You Win!!");
}
if(points < 15){
   Console.WriteLine("Sorry you lose!!");
}

//! O que é uma expressão booliana:
// Uma expressão booliana é qualquer código que retorne um valor booliano, true ou false. Um exemplo é o Método string.Contais() para avaliar se uma cadeia de caracteres contem outro:
string phrase = "O rato roeu a roupa do rei de Roma";
if(phrase.Contains("rei")){
   Console.WriteLine("A roupa do rei esta roida");
}
//Outras expressões boolianas podem ser criadas usando operadores:
//== igual a
//> maior que
//< menor que
//>= maior ou igual a 
//<= Menor ou igual a

//! O que é um bloco de código:
//é uma união de código organizada em {chaves}
//Blocos podem conter blocos de código

//! Implementando o Bonus

//Condição composta:
if((diceRoll1 == diceRoll2) || (diceRoll2 == diceRoll3)|| (diceRoll1 == diceRoll3))
//Usamos o operador lógico OU que são os "||"
{
   Console.WriteLine("Você rodou os dados com dois iguais! +2 Pontos pra você");
   points += 2;
   Console.WriteLine($"Sua pontuação total ficou: {points}");
}
//! Implementando o bônus por números triplicados
//Usamos o && que é o operador lógico AND
if ((diceRoll1 == diceRoll2) && (diceRoll2 == diceRoll3)){
   Console.WriteLine("Todos os dados tiveram o mesmo número! +6 Pontos pra você");
   points += 6;
   Console.WriteLine($"Sua pontuação total ficou: {points}");
}
if(points >= 15){ 
   Console.WriteLine("You Win!!");
}
if(points < 15){
   Console.WriteLine("Sorry you lose!!");
}
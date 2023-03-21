//! Usando IF e else if
Random dice = new Random();
int diceRoll1 = dice.Next(1, 7);
int diceRoll2 = dice.Next(1, 7);
int diceRoll3 = dice.Next(1, 7);
int points = diceRoll1 + diceRoll2 + diceRoll3;
Console.WriteLine($"Dice roll: {diceRoll1} + {diceRoll2} + {diceRoll3} = {points}");
if((diceRoll1 == diceRoll2) || (diceRoll2 == diceRoll3)|| (diceRoll1 == diceRoll3))
{
   if ((diceRoll1 == diceRoll2) && (diceRoll2 == diceRoll3)){
   Console.WriteLine("Todos os dados tiveram o mesmo número! +6 Pontos pra você");
   points += 6;
   Console.WriteLine($"Sua pontuação total ficou: {points}");}
else{
   Console.WriteLine("Você rodou os dados com dois iguais! +2 Pontos pra você");
   points += 2;
   Console.WriteLine($"Sua pontuação total ficou: {points}");
}}
if(points >= 16){ 
   Console.WriteLine("Parabéns você ganhou um Carro!");
}
else if(points >= 10){
   Console.WriteLine("Parabéns você ganhou um Laptop novo");
}
else if(points == 7)
{
 Console.WriteLine("Parabéns seu prêmio é uma viagem");
}
else{ //Todo else serve para todo resultado que não se encaixe na condição acima
   Console.WriteLine("Leve um gatinho de consolação!!");
}
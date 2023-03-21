//Todo 1: Começar com o código ilegível a seguir no Editor do .NET
string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
//Todo 2: Modificar o código para torná-lo mais legível
/*
A ideia desse código é transformar a frase em uma cadeia de caracteres, inverter sua ordem e mostrar quantas vezes aparece a letra o

*/
string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = str.ToCharArray();

Array.Reverse(message);

int letterCount = 0;
foreach (char letter in message) 
{ 
   if (letter == 'o')
   { 
      letterCount++; 
   } 
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
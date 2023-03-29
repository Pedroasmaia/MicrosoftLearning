//Todo Escrever código no Editor do .NET para exibir o resultado de um lançamento de moeda
/*
Use a classe Random para gerar um valor. Com base no valor, use o operador condicional para exibir heads ou tails.
As chances de que o resultado seja cara ou coroa devem ser de 50% cada.
Você deve ser capaz de realizar o resultado desejado em três linhas de código ou menos.
Se você não conseguir avançar e precisar ver a solução ou terminar com êxito, prossiga para ver uma solução para este desafio.
*/
Random coin = new Random();
int flip = coin.Next();
Console.WriteLine(flip % 2 == 0 ? "Cara" : "Coroa");
//Métodos que não retornam valores quando terminam são considerados MÉTODOS NULOS

//!Os métodos podem retornar qualquer tipo de dado, por exemplo o método:
Random.Next();
// Retorna um valor int gerado "aleatoriamente", mas pra isso precisamos salvar o valor dentro de uma variável
Random dice = new Random(); // Criando uma instancia com NEW
int number = dice.Next(1, 7); // Declarando a variável
Console.WriteLine(number); // Demonstrando na tela

//Parâmetros de entrada são para configurar como um método executa seu trabalho, podem ser um ou mais e são separados por vírgula.
//Na linha 7 desse código podemos ver o método Next(), onde neles foram passados os limites de inicio(1) e termino(7) dos números e na linha 8 no método WriteLine(), foi passado a informação(a variável number) que deveria ser mostrada no console;
//Os métodos esperam um tipo de dado padrão que deve ser recebido, não se pode passar uma string em um método que se recebe int e esperar que funcione.

//Uma Assinatura de Método é o número de entradas definidos para cada tipos de dados e parâmetro de entradas

//!Métodos sobrecarregados
//Métodos sobrecarregados  contem várias assinaturas de métodos, por exemplo, o Método Console.WriteLine(), possuiu 19 versões sobrecarregadas diferentes, e elas permitem enviar diferentes tipos de dados:
int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

// Em outros casos os métodos permitem enviar detalhes de configuração passadas para execução, o método Random.Next() tem 3 versões, que permitem definir restrições sobre o número gerado:
Random dice = new Random();
int numberOne = dice.Next();
int numberTwo = dice.Next(101);
int numberThree = dice.Next(50,101);

Console.WriteLine($"O primeiro resultado: {numberOne}"); //Não define limites, então pode ir até o número máximo que o INT suporta = 2,147,483,647
Console.WriteLine($"O segundo resultado: {numberTwo}");//Nesse caso define ó número máximo que ele pode alcançar, menos 1 = 100
Console.WriteLine($"O terceiro resultado: {numberThree}"); // Valor mínimo (50) e máximo (101-1)
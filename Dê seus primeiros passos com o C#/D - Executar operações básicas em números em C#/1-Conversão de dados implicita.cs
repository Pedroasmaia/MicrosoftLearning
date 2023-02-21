// Para adicionar dois números usaremos o simbolo +
int firstNumber = 10;
int secondNumber = 3;
Console.Write(firstNumber + secondNumber);
// Output = 13

// Se misturarmos dois tipos de dados em uma saida Console.Writeline(), o compliador entender que queremos concatenar
Console.Write("Eu tenho " + firstNumber + " anos de idade");
//Output = Eu tenho 10 anos de idade

//Caso eu queria realizar uma soma dentro da string posso passar um parentesse para deixar clara nossa intenção
int firstNumber = 10;
int secondNumber = 3;
Console.Write("Eu tenho " + (firstNumber + secondNumber) + " anos de idade");
//Output = Eu tenho 13 anos de idade

//Sem o parentese ficaria
Console.Write("Eu tenho " + firstNumber + secondNumber + " anos de idade");
//Output = Eu tenho 103 anos de idade

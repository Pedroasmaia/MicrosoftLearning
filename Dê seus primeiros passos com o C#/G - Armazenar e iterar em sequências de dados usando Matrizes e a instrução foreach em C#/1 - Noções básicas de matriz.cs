//! Declarar Matrizes
string[] OrderIDs = new string[3];
//Operador new cria uma instância
//Os colchetes "[]" informa ao compilador que se trata de uma matriz
// 3 Contém o número de elementos que a matriz conterá

//! Atribuir valores a elementos de uma matriz

OrderIDs[0] = "A123";
OrderIDs[1] = "B456";
OrderIDs[2] = "C789";

//Atribuindo valor, fora do limite da matriz apresentara o seguinte erro:

//fraudulentOrderIDs[3] = "D000";
//System.Reflection.TargetInvocationException: Exception has been thrown by the target of an invocation. ---> System.IndexOutOfRangeException: Index was outside the bounds of the array.

//!Recuperar valor de uma matriz

Console.WriteLine($"O 1° id:{OrderIDs[0]}");
Console.WriteLine($"O 2° id:{OrderIDs[1]}");
Console.WriteLine($"O 3° id:{OrderIDs[2]}");

//! Reatribuindo valor de uma matriz
OrderIDs[2] = "F00";
Console.WriteLine($"O 2° id agora é:{OrderIDs[2]}");

//! Inicializar uma matriz

string[] fradulentOrderID = {"A123","B456","C789","F000"};


Console.WriteLine($"O 1° id:{fradulentOrderID[0]}");
Console.WriteLine($"O 2° id:{fradulentOrderID[1]}");
Console.WriteLine($"O 3° id:{fradulentOrderID[2]}");


//!Obtendo o tamanho de uma matrix
Console.WriteLine($"Temos {fradulentOrderID.Length} IDs fraudulentos");



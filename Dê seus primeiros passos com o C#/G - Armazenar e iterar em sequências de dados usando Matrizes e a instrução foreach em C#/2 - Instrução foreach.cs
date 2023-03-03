//! Executando Loop em uma matriz usando o Foreach

// O Foreach realiza um loop em cada valor dentro de uma matriz, executando o código abaixo da declaração, salvando em uma variável:

string[] names = { "Pedro", "L1ef", "Grant" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

// 1 Inicializar uma matriz de int

int[] inventory = {100,450,900,600,500};
//! Criando uma variável para armazenar o número do compartimento atual
int bin = 0;
//! Criando variavel para soma total dos items
int sum =0;
// 2 Itere sobre a matriz
foreach (int items in inventory){
    sum += items;
    bin++;
    Console.WriteLine($"No compartimento {bin} temos {items} items, no total temos {sum}");
}
Console.WriteLine($"Nos temos {sum} items no inventario");


//Todo 1:  Declarar e inicializar uma nova matriz para conter IDs de pedidos falsas.
/*
B123
C234
A345
C15
B177
G3003
C235
B179 
*/
string[] ids = {"B123","C234","A345","C15","B177","G3003","C235","B179"};
//Todo 2: Iterar em cada elemento da matriz
foreach(string id in ids){
   if(id.StartsWith("B")){
   //Todo 3: Se a ID de Pedido falsa começar com "B", imprima-a na saída.
      Console.WriteLine(id);
   }
}
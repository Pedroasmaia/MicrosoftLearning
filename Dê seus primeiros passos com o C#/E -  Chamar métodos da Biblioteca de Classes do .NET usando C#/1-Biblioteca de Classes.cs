//Uma classe é um contêiner para métodos, que normalmente são agrupados por estarem relacionados, exemplo: Métodos que enviam ou recebem informações da linha de comando estão agrupadas em System.Console. Isso economiza tempo, pois pensa começar um aplicativo do 0 sempre que for começar um novo.

//Tipos de dados também são "classes", eles também tem métodos que podem ser chamados

//NAMESPACE são o sobrenome das classes, pois pode ser que 2 classes tenham o mesmo nome, portanto organizamos elas em Namespaces para verificar se elas não tem o mesmo "Nome completo"


// Console é a classe
// . é o operador de acesso ao membro
// WriteLine é o método
// Os () são a chamada do método
// O valor dentro é o parâmetro passado.
Console.WriteLine("Hello World!");

//Chamando diferentes tipos de métodos
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

//Métodos com estado vs. sem estado

string estado = "A condição do ambiente em execução em um momento específico do tempo, ou seja, o estado atual do aplicativo é a coleção de todos os valores armazenados na memória.";

// Métodos sem estado, não alteram o estado, porque funcionam sem referenciar ou alterar valores.

// Para chamar métodos com estado, deve 1° criar uma instancia da classe para que o método possa acessar o estado. Assim criando um Objeto e para fazer isso usamos o Operador new:

//Uma instancia da Classe Random co o objeto "dice":
Random dice = new Random();
//O operador "new" faz coisas importantes:
//1- Solicita um espaço na memoria grande o suficiente para armazenar um objeto.
//2- Cria um objeto e o armazena
//3- Ele retorna o endereço do objeto salvando na variável dice









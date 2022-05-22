//var meuArray = new int[5];
//int[] meuArray = new int[5];

//  Console.WriteLine(meuArray[0]);// Inteiro é um value tipes e inicia em 0

//  meuArray[0] = 12;

//  Console.WriteLine(meuArray[0]); // agora o array tem um valor atribuido a primeira posição

//var meuArray = new int[5]{1,2,3,4,5};

//-----------

//var meuArray = new Teste[1]{new Teste()};

// var meuArray = new Teste[2];
// meuArray[0] = new Teste();

// Console.WriteLine(meuArray[0].Id);

// struct Teste
// {
//     public int Id {get; set;};
// }

//------------

var meuArray = new int[2] {1,2};


// meuArray.Clone(); //refêrence types - Cria uma nova versão do array
// meuArray.CopyTo(); // copia o 

// for(var index = 0; index < meuArray.Length; index++)
// {
//     Console.WriteLine(meuArray[index]);
// }

// foreach (var item in meuArray)
// {
//     Console.WriteLine(item);
// }

// var funcionarios = new Funcionario[5];

// funcionarios[0] = new Funcionario() {Id = 2562, Nome = "Solano"};

// foreach ( var funcionario in funcionarios )
// {
//     Console.WriteLine(funcionario.Id);
//     Console.WriteLine(funcionario.Nome);
// }

// var arr = new int[2];
// var arrB = arr; // apontam pro mesmo lugar na memória

// arr[0] = 20;

// Console.WriteLine(arrB[0]);

var arr = new int[2];
var arrb = new int[2];


arr[0] = 20;

Console.WriteLine(arrb[0]);


struct Funcionario
{
    public int Id {get; set;}

    public string Nome {get; set;}
}

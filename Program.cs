// Arrays
string[] funcionarios = {"João", "Maria", "Cláudia", "Oscar"};

Console.WriteLine(funcionarios[1]);
int indice = Array.IndexOf(funcionarios, "Oscar");
Console.WriteLine($"Posição do Oscar: {indice}");

Array.Sort(funcionarios);
foreach(string nome in funcionarios) Console.WriteLine(nome);

Console.WriteLine("--------");
string[] novoArray = new string[5];
Array.Copy(funcionarios, novoArray, funcionarios.Length);
foreach(string nome in novoArray) Console.WriteLine(nome);
novoArray[4] = "Joana";

Console.WriteLine("--------");
foreach(string nome in novoArray) Console.WriteLine(nome);

// Ex 1
Console.WriteLine("--------");
Console.WriteLine($"Exercícios");
Console.WriteLine($"------------------------");
double[] doacoes = {103.54, 259.72, 82.16, 154.87, 364.45, 14.49 };  
double soma = 0;
foreach (double valor in doacoes)
{
    soma += valor;
}
Console.WriteLine($"Total de doações: {soma}");
Console.WriteLine($"------------------------");

// Ex 2
string[] nomes = { "Fernanda", "Eduardo", "Gustavo", "Carolina", "Alice", "Bruno", "Daniel" };  
nomes.Sort();
Console.WriteLine($"O terceiro nome da lista após ordenação é: {nomes[2]}");
Console.WriteLine($"------------------------");

// Ex 3
int[] numeros = { 5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9 };
int digito1 = Array.IndexOf(numeros, 19);
int digito2 = Array.IndexOf(numeros, 42);
int digito3 = Array.IndexOf(numeros, 7);
Console.WriteLine($"Combinação do cadeado: {digito1}-{digito2}-{digito3}");
Console.WriteLine($"------------------------");

// ----------------------------------------------------------------------------
// List
List<string> listaFuncionarios = new List<string>
{
    "João", "Maria", "Cláudia", "Oscar"
};
Console.WriteLine(listaFuncionarios[2]);
int indice2 = listaFuncionarios.IndexOf("Oscar");
Console.WriteLine($"Posição do Oscar: {indice2}");

//listaFuncionarios.Sort();
listaFuncionarios.Reverse();
foreach(string nome in listaFuncionarios)
{
    Console.WriteLine(nome);
}

Console.WriteLine("--------");
listaFuncionarios.Add("Iasmin");
listaFuncionarios.Remove("Oscar");

foreach(string nome in listaFuncionarios)
{
    Console.WriteLine(nome);
}
Console.WriteLine($"------------------------");

// HashSet
HashSet<string> setFuncionarios = new HashSet<string>();
setFuncionarios.Add("João");
setFuncionarios.Add("Maria");
setFuncionarios.Add("Cláudia");
setFuncionarios.Add("Oscar");

//Console.WriteLine(setFuncionarios[2]); --> não funciona no HashSet

setFuncionarios.Add("João"); // --> não insere valores repetidos 

foreach (var nome in setFuncionarios)
{
    Console.WriteLine(nome);
}

// Ex 1 
HashSet<int> scores = new HashSet<int>();
scores.Add(150);
scores.Add(90);
scores.Add(200);
scores.Add(120);
scores.Add(150);
scores.Add(80);
scores.Add(180);
scores.Add(200);

List<int> scoresOrdenados = new List<int>(scores);
scoresOrdenados.Sort();

Console.WriteLine("Scores únicos em ordem crescente:");
foreach (var score in scoresOrdenados)
{
    Console.WriteLine(score);
}
Console.WriteLine($"------------------------");

// Ex 2
List<char> caracteres = new List<char>()
{
    'o', 'd', 'n', 'u', 'm', ' ', 'á', 'l', 'o'
};

caracteres.Reverse();
foreach (var carac in caracteres)
{
    Console.WriteLine(carac);
}
Console.WriteLine($"------------------------");


// Ex 3
List<string> nomes2 = new List<string> { "Ana", "Carlos", "Mariana", "João", "Lúcia" };

Console.WriteLine("Lista original:");
Console.WriteLine(string.Join(", ", nomes2));

nomes2.Sort();
Console.WriteLine("\nApós Sort (ordem alfabética):");
Console.WriteLine(string.Join(", ", nomes2));

nomes2.Reverse();
Console.WriteLine("\nApós Reverse (ordem invertida):");
Console.WriteLine(string.Join(", ", nomes2));

var removido = nomes2[0];
nomes2.Remove(removido);
nomes2.Add(removido);
Console.WriteLine("\nApós remover o primeiro e adicioná-lo no fim:");
Console.WriteLine(string.Join(", ", nomes2));

Console.WriteLine($"\nA pessoa sorteada foi: {nomes[3]}");


using System;
using System.Text.RegularExpressions;
using System.Globalization;
using ExemploFundamentos.Common.Pessoa;
using System.Collections.ObjectModel;
using ExemploFundamentos.Common.Models;

// DECONSTRUCTOR AND TUPLES
Pessoa p1 = new Pessoa("Melissa", 8);
(string nome, int idade) = p1;

Console.WriteLine($"{nome} {idade}");





















/*
// TUPLES
// Melhor forma, cada variável tem um nome
(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Leonardo", "Buta", 1.80M);

// Outras formas
ValueTuple<int, string, string, decimal> outroExempLoTupla = (1, "Leonardo", "Buta", 1.80M);
var outroExemploTuplaCreate = Tuple. Create(1, "Leonardo", "Buta", 1.80M);

Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {outroExemploTuplaCreate.Item3}");
Console.WriteLine($"Altura: {outroExempLoTupla.Item4}");

string arquivo = "../Arquivos/arquivoLeitura.txt";
LeituraArquivo lerArquivo = new LeituraArquivo();
//(bool sucesso, string[] linhasArquivo, int qtdeLinhas) = lerArquivo.LerArquivo(arquivo);
var (sucesso, linhasArquivo, qtdeLinhas) = lerArquivo.LerArquivo(arquivo);

if (sucesso)
{
    foreach(string linha in linhasArquivo) {
        Console.WriteLine($"{linha}");
    }
}
Console.WriteLine("___________________________________");
Console.WriteLine($"Quantidade de linhas: {qtdeLinhas}");

arquivo = "../Arquivos/arquivo3DS.txt";
var (sucesso3ds, linhasArquivo3ds, _) = lerArquivo.LerArquivo(arquivo);

if (sucesso3ds)
{
    foreach(string linha in linhasArquivo3ds) {
        Console.WriteLine($"{linha}");
    }
}
*/



















/*
// DICTIONARY
Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "Sao Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("SC", "Santa Catarina");
estados.Add("RS", "Rio Grande do Sul");

foreach(KeyValuePair<string, string> item in estados) {
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
Console.WriteLine("_______________________________________");
estados.Remove("RJ");
estados["SP"] = "São Paulo";

foreach(var item in estados) {
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

if (estados.ContainsKey("SP")) {
    Console.WriteLine($"Existe o estado {estados["SP"]}");
}
*/











/*
// STACK
Stack<string> pilha = new Stack<string>();
pilha.Push("Primeiro item");
pilha.Push("Segundo item");
pilha.Push("Terceiro item");
pilha.Push("Quarto item");
pilha.Push("Quinto item");

foreach(string item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o item da pilha: {pilha.Pop()}");
Console.WriteLine($"Removendo o item da pilha: {pilha.Pop()}");
Console.WriteLine($"Removendo o item da pilha: {pilha.Pop()}");

pilha.Push("Sexto item");
pilha.Push("Sétimo item");

foreach(string item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o item da pilha: {pilha.Pop()}");

foreach(string item in pilha)
{
    Console.WriteLine(item);
}
*/




















/*
// QUEUE
Queue<int> fila = new Queue<int>();
fila.Enqueue(2);
fila.Enqueue(10);
fila.Enqueue(50);

foreach (int numero in fila) {
    Console.WriteLine(numero);
}

Console.WriteLine($"Removendo o item {fila.Dequeue()}");
Console.WriteLine($"Removendo o item {fila.Dequeue()}");

foreach (int numero in fila) {
    Console.WriteLine(numero);
}

fila.Enqueue(60);
fila.Enqueue(90);

Console.WriteLine($"Removendo o item {fila.Dequeue()}");

foreach (int numero in fila) {
    Console.WriteLine(numero);
}
*/























/*
// EXCEPTIONS
try {
    string[] linhas = File.ReadAllLines("../Arquivos/arquivoLeitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch(UnauthorizedAccessException ex) {
    Console.WriteLine($"Acesso ao arquivo não autorizado: {ex.Message}");
}
catch(FileNotFoundException ex) {
    Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
}
catch(DirectoryNotFoundException ex) {
    Console.WriteLine($"Diretório não encontrado: {ex.Message}");
}
catch(Exception ex) {
    Console.WriteLine($"Erro: {ex.Message}");
}
finally {
    Console.WriteLine("Fim do processo.");
}
*/















/*
// FORMATS
decimal preco = 6045.80M;
Console.WriteLine($"Preço: {preco:C}");

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

Console.WriteLine($"Preço: {preco:C}");

// Formata como currency no padrão português-Brasil
Console.WriteLine(preco.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

// Formata como currency com 1 casa decimal
Console.WriteLine(preco.ToString("C1"));

// Formata como número com 4 casas decimais
Console.WriteLine(preco.ToString("N4"));

double porcentagem = .3456781111;
// Formata em porcentagem com 4 decimais e padrão americano
Console.WriteLine($"Taxa de Juros anual: {porcentagem.ToString("P4", CultureInfo.CreateSpecificCulture("en-US"))}");

int telefone = 997472597;
Console.WriteLine($"Telefone: {telefone.ToString("#####-####")}");

int cep = 34401040;
Console.WriteLine($"CEP: {cep.ToString("00###-###")}");

string dataString = "04/14/2019 20:32";
DateTime data;
if (!DateTime.TryParseExact(dataString, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
{
    Console.WriteLine($"Data inválida: {dataString}. Será utilizada a data atual.");
    data = DateTime.Now;
}
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());
Console.WriteLine(data.ToLongDateString());
Console.WriteLine(data.ToLongTimeString());
*/











/*
// REGULAR EXPRESSIONS
string input = "ABC1234";
//string input = "ABC1D23";

// Padrões
string pattern1 = @"^[a-zA-Z]{3}\d{4}$$";  // 3 letras seguidas por 3 números
string pattern2 = @"^[a-zA-Z]{3}\d{1}[a-zA-Z]{1}\d{2}$";  // 2 números, 2 letras, 2 números

if (Regex.IsMatch(input, pattern1))
{
    Console.WriteLine("A string corresponde ao Padrão 1.");
}
else if (Regex.IsMatch(input, pattern2))
{
    Console.WriteLine("A string corresponde ao Padrão 2.");
}
else
{
    Console.WriteLine("A string não corresponde a nenhum dos padrões.");
}
*/


















/*
// ARRAYS
List<string> lista = new List<string>();

lista.Add("SP");
lista.Add("MG");
lista.Add("SC");
lista.Add("RS");

Console.WriteLine($"Itens: {lista.Count} / Capacidade: {lista.Capacity}");

lista.Add("MG");
lista.Add("RJ");

Console.WriteLine($"Itens: {lista.Count} / Capacidade: {lista.Capacity}");

lista.Remove("MG");

Console.WriteLine($"Itens: {lista.Count} / Capacidade: {lista.Capacity}");

string a = "15";
int b = 1;

int.TryParse(a, out b);

Console.WriteLine(b);
Console.WriteLine(int.TryParse(a, out b));

Console.WriteLine("Informe seu nome: ");
string meuNome = Console.ReadLine() ?? "";
Console.WriteLine("Informe sua idade: ");
int minhaIdade = 0;
int.TryParse(Console.ReadLine(), out minhaIdade);
Pessoa pessoa = new Pessoa(meuNome, minhaIdade);

pessoa.apresentar();
*/
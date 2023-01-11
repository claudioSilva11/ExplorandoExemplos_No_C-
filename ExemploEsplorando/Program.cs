using ExemploEsplorando.Models;
using System.Globalization;
using Newtonsoft.Json;


Pessoa p1 = new Pessoa(nome: "Cláudio" , sobrenome: "Silva");
Pessoa p2 = p1;

p2.Nome = "Tadeu";

Console.WriteLine($"Nome da p1: {p1.NomeCompleto}");
Console.WriteLine($"Nome da p2: {p2.NomeCompleto}");








// -----------------
// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);


// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElementoArray("Texto");

// Console.WriteLine(arrayString[0]);




// -----------------------------
// tipos dinamicos ACEITA diverços tipos diferentes
// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo de variável: {variavelDinamica.GetType()}, valor:{variavelDinamica}");

// variavelDinamica = "texto";

// Console.WriteLine($"Tipo de variável: {variavelDinamica.GetType()}, valor:{variavelDinamica}");





// Tipos anônimos em coleção
// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonima = listaVenda.Select(x => new {x.Produto, x.Preco});

// foreach(var venda in listaAnonima)
// {
// Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }







// Tipos anônimos 
// var tipoAnonimo = new { Nome = " Cláudio", Sobrenome = "Silva", Altura = 1.87};

// Console.WriteLine("Nome" + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);







// tipos NULOS no C#
// bool? deseaReceberEmail = false;

// if( deseaReceberEmail.HasValue && deseaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber e-mail");
// }
// else
// {
//     Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail");
// }






// Deserializar-------------------------------
// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto} " + 
//             $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}"+
//             $"{(venda.Desconto.HasValue ? $" Desconto de : {venda.Desconto}" : "")}");
// }








// int numero = 15;
// bool Par = false;

// // if ternario
// Par = numero.Ehpar();
// Console.WriteLine($"O número {numero} é " + (Par ? "par" : "inpar"));











// Pessoa p1 = new Pessoa("Cláudio", "Silva");

// (string nome, string sobrenome) = p1;
// Console.WriteLine($"{nome} {sobrenome}");







// Exemplo de leitura de arquivos ultilizando tupla
// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// // para descarte, ao não usar a variazel, basta Ultizar o _ no lugar da mesma


// if(sucesso)
// {
//     Console.WriteLine("Quantidade de linhas do arquivo: "+ quantidadeLinhas);
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }else{
//     Console.WriteLine("Não foi possivel ler o arquivo");

// }









// // melhor maneira de inicializar uma TUPLA
// (int Id , string Nome, string Sobrenome) tupla = (13, "Cláudio", "Silva");

// // Outra duas maneiras, porém menos eficientes, pois não dá para nomear as vareaveis.
// // ValueTuple<int, string, string>outroExemploTupla = (12, "Carla", "Silva");
// // var outroExemploTuplaCreate = Tuple.Create(122, "Tadeu" , "Costa");


// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");













// Dictionary<string,string> estados = new Dictionary<string,string>();

// estados.Add("SP","São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG","Minas Gerais");

// // encontra un estado
// Console.WriteLine(estado["MG"]);

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
// Console.WriteLine("-----------");
// estados.Remove("BA");
// estados["SP"] = "Sao Paulo - valor alterado"; //Como alterar o valor de um estado

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// strin chave = "BA";
// Console.WriteLine("Verificando o elemento"); //verificando se a chave digitada já existe

// if(estados.ContaInsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro a chave: {chave}");

// }





// trabalhando com pilha
// Stack<int> pilha = new Stack<int>(); 

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }






// Ultilizando FILA---------------
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }







// new ExemploExcecao().Metodo1();







// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//    Console.WriteLine($"Ocorreu uma exceção generica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }







// manipulando a impresão de datas
// string dataString = "2022-03-17 18:00";
// // Ultilizando tryParse
// // DateTime.TryParseExact(dataString,
// //                        "yyyy-MM-dd HH:mm",
// //                         CultureInfo.InvariantCulture,
// //                          DateTimeStyles.None, out DateTime data);

// bool sucesso = DateTime.TryParseExact(dataString,
//                        "yyyy-MM-dd HH:mm",
//                         CultureInfo.InvariantCulture,
//                         DateTimeStyles.None, out DateTime data);
   
// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucess! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data valida"); 
// }
// Console.WriteLine(data);

// Como passar uma data e hora sem ser a da maquina
// DateTime data = DateTime.Parse("17/04/2022 18:00");


// // DateTime data = DateTime.Now;

// // Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// // pegar somente a data 
// Console.WriteLine(data.ToShortDateString());

// // pegar somente a Hora
// Console.WriteLine(data.ToShortTimeString());









// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 82.40m;

// // Console.WriteLine(valorMonetario.ToString("c"), CultureInfo.CreateSpecificCulture("pt-BR"));

// // maneira de representar com mais casas decimais
// Console.WriteLine(valorMonetario.ToString("c4"));

// // formatar porcentagem
// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("p"));

// // formatar maneiras de representatividade

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));











// exemplo de soma 
// int numero1 = 10;
// int numero2 = 20;

// int resultado = numero1 + numero2;

// Console.WriteLine(resultado);







// Pessoa p1 = new Pessoa(nome:"Cláudio", sobrenome: "Silva");
// Pessoa p2 = new Pessoa(nome:"Carlos", sobrenome:"costa braga");

// Curso cursoDeIngles = new Curso();

// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();







// Ultilizado para o outro exemplo
// p1.Idade = 29;
// p1.Apresentar();
//Padrão Camel Case em variáveis
string mensagemDeBoasVindas = "\nBoas vindas ao Screen Sound";

//Criação de Lista
//List<string> listaDasBandas = new List<string> {"U2", "The Beatles", "Calipson"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int>{10,8,6});
bandasRegistradas.Add("The Beatles", new List<int>());


//Padrão Pascal Case em funções
void ExibirLogo()
{
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.WriteLine("\nDigite a sua opção: ");
    //Marcação ! para não retornar um valor nulo e sim uma string, nesse caso
    string opcaoEscolhida = Console.ReadLine()!;

    //Conversão de String para Inteiro
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);


    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case 4:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case -1:
            Console.WriteLine("Encerrando...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;

    }

}

void RegistrarBanda()
{
    //Console.Clear();
    ExibirTituloDaOpcao("Registrar nova banda");

    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda,new List<int>());
    //Interpolação de String
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso! ");
    //Função que espera em milisegundos
    Thread.Sleep(2000);
    //Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    //Console.Clear();
    ExibirTituloDaOpcao("Listagem de todas as bandas registradas");

//Para cada banda na lista de bandas, exiba
foreach(string banda in bandasRegistradas.Keys){
    Console.WriteLine($"Banda: {banda}");
}

    //Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    //Console.ReadKey();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo){
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras,'*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");

}

ExibirLogo();
ExibirOpcoesDoMenu();

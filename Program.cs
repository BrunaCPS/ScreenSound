//Padrão Camel Case em variáveis
string mensagemDeBoasVindas = "\nBoas vindas ao Screen Sound";

//Criação de Lista
List<string> listaDasBandas = new List<string> {"U2", "The Beatles", "Calipson"};

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
    Console.WriteLine("******************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("******************");

    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
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
    Console.WriteLine("***************************");
    Console.WriteLine("Lista de bandas registradas");
    Console.WriteLine("***************************");

//Para cada banda na lista de bandas, exiba
foreach(string banda in listaDasBandas){
    Console.WriteLine($"Banda: {banda}");
}

    //Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    //Console.ReadKey();
    ExibirOpcoesDoMenu();
}

ExibirLogo();
ExibirOpcoesDoMenu();

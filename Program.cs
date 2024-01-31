//Padrão Camel Case em variáveis
string mensagemDeBoasVindas = "\nBoas vindas ao Screen Sound";

//Classe Dictionary que recebe uma chave (nome da banda) e os valores em lista (avaliacao delas)
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
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
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMedia();
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
    Console.Clear();
    ExibirTituloDaOpcao("Registrar nova banda");

    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    //Interpolação de String
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso! ");
    //Função que espera em milisegundos
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Listagem de todas as bandas registradas");

    //Para cada banda na lista de bandas, exiba
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliação da banda");
    //Solicita a banda
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    //Verifica se a banda existe, se existir:
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        //Solicita a nota
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);

        //Atribui a nota à banda
        //Acessa a chave (banda) e adiciona a nota (valor)
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    //Se a banda não existir:
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada...");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média da banda");
    //Solicita a banda que quer avaliar
    Console.WriteLine("Qual o nome da banda a qual você deseja exibir a média de avaliações?");
    string nomeDaBanda = Console.ReadLine()!;

    //Verifica se a banda existe, se sim realiza o calculo
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        //método Average() para cálculo de média
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    //Caso não exista
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada...");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirLogo();
ExibirOpcoesDoMenu();

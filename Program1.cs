Dictionary<string, List<int>> listaDeBandas = new Dictionary<string, List<int>>();
listaDeBandas.Add("The Beatles", new List<int> { 8, 10, 9});
listaDeBandas.Add("Linkin Park", new List<int> { 10, 9, 8});


void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("\nBoas vindas ao Screen Sound\n");
}

void ExibirTituloOpcao(string titulo)
{
    Console.WriteLine(string.Empty.PadLeft(titulo.Length, '*'));
    Console.WriteLine(titulo);
    Console.WriteLine(string.Empty.PadLeft(titulo.Length, '*')+ "\n");
}

void ExibirOpcoesDoMenu()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("1. Registrar banda");
    Console.WriteLine("2. Listar bandas");
    Console.WriteLine("3. Avaliar banda");
    Console.WriteLine("4. Exibir média de uma banda");
    Console.WriteLine("5. Jogo de Adivinhacao");
    Console.WriteLine("-1. Sair");

    Console.Write("\nDigite a sua opçao: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);
    Console.Clear();

    switch (opcaoEscolhida)
    {
        case 1: RegistrarBanda();
            break;
        case 2: ListarBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: MediaBanda();
            break;
        case 5: JogoAdivinhacao();
            break;
        case -1: Console.WriteLine("Tchau!");
            break;
        default: Console.WriteLine("Opcao Inválida!");
            break;
    }
}

void RegistrarBanda()
{
    ExibirTituloOpcao("Registre uma Banda");
    Console.Write("Digite o nome da Banda: ");
    string banda = Console.ReadLine()!;
    listaDeBandas.Add(banda, new List<int>());
    Console.WriteLine($"Banda {banda} foi registrada com sucesso!");
    Console.ReadKey();
}

void ListarBandas()
{
    ExibirTituloOpcao("Listando todas as Bandas Registradas");

    foreach (var i in listaDeBandas.Keys)
    {
        Console.WriteLine($"Banda: {i}");
    }

    Console.ReadKey();
}

void AvaliarBanda()
{
    ExibirTituloOpcao("Avalie uma Banda");
    Console.Write("Banda que deseja Avaliar: ");
    string banda = Console.ReadLine()!;

    if (listaDeBandas.ContainsKey(banda))
    {
        Console.Write("Digite a nota da banda: ");
        int nota = int.Parse(Console.ReadLine()!);
        listaDeBandas[banda].Add(nota);
        Console.WriteLine($"Nota {nota} atribuida a Banda \"{banda}\" com sucesso!");
    }
    else
    {
        Console.WriteLine($"Banda \"{banda}\" nao foi encontrada!");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }

    Console.ReadKey();
}

void MediaBanda()
{
    ExibirTituloOpcao("Veja a média de uma Banda");
    Console.Write("Banda que você deseja verificar a média: ");
    string banda = Console.ReadLine()!;

    if (listaDeBandas.ContainsKey(banda))
    {
        double media = listaDeBandas[banda].Average();
        Console.WriteLine($"A Média da Banda {banda} é: {media}");
    }
    else
    {
        Console.WriteLine($"Banda \"{banda}\" nao foi encontrada!");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }
    
    Console.ReadKey();
}

void JogoAdivinhacao()
{
    Random random = new Random();
    int nmrRandom = random.Next(1, 101);
    int tentativas = 0;
    Console.WriteLine("Tente adivinhar o número entre 1 e 100\n");

    while (true)
    {
        Console.Write("Adivinhar: ");
        int escolhaUmNumero = int.Parse(Console.ReadLine()!);
        if (escolhaUmNumero > 0 && escolhaUmNumero < 101)
        {
            tentativas++;

            if (escolhaUmNumero > nmrRandom)
            {
                Console.WriteLine("Mais baixo!");
            }
            else if (escolhaUmNumero < nmrRandom)
            {
                Console.WriteLine("Mais alto!");
            }
            else
            {
                Console.WriteLine("Você ganhou!");
                Console.WriteLine($"Tentativas: {tentativas}");
                break;
            }
        }
        else
        {
            Console.WriteLine("Valor inválido, tente um número entre 1 e 100");
        }
    }
}


while (true)
{
    ExibirOpcoesDoMenu();
}
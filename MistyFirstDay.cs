string msgbv = @"
███╗░░░███╗██╗░██████╗████████╗██╗░░░██╗
████╗░████║██║██╔════╝╚══██╔══╝╚██╗░██╔╝
██╔████╔██║██║╚█████╗░░░░██║░░░░╚████╔╝░
██║╚██╔╝██║██║░╚═══██╗░░░██║░░░░░╚██╔╝░░
██║░╚═╝░██║██║██████╔╝░░░██║░░░░░░██║░░░
╚═╝░░░░░╚═╝╚═╝╚═════╝░░░░╚═╝░░░░░░╚═╝░░░
";

List<string> bandas = new List<string>();
void ExibirLogo()
{
    Console.WriteLine(msgbv);
}

//https://fsymbols.com

void ExibirOpMenu()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("Digite 1 para regristrar uma banda");
    Console.WriteLine("Digite 2 para Mostrar todas as bandas");
    Console.WriteLine("Digite 3 para Avaliar uma Banda");
    Console.WriteLine("Digite 4 para Exibir a media de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    string OpEsc = Console.ReadLine()!;
    int OpEscNum = int.Parse(OpEsc);


    switch (OpEscNum)
    {
        case 1:  
            registrarBanda(); 
            break;
        case 2:
            bandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção: " + OpEscNum);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção: " + OpEscNum);
            break;
        case 0:
            ExibirLogo();
            Console.WriteLine("\nVolte sempre!");
            break;
        default:
            Console.WriteLine("Opção invalida, insira uma opção válida");
            break;

    }

}

void registrarBanda()
{
    Console.Clear();
    Console.WriteLine(@"
█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█");
    Console.Write("\nDigite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(1);
    ExibirOpMenu();
}

void bandasRegistradas()
{
    Console.Clear();
    Console.WriteLine(@"
█▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀   █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ █▀▄ ▄▀█ █▀
█▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█   █▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ █▄▀ █▀█ ▄█" + ("\n");
    for(int i = 0; i < bandas.Count; i++)
    {
        Console.WriteLine($"{i+1}ª Banda: {bandas[i]}");
    }
    Console.WriteLine("\nAperte qualquer botão para voltar ao menu principal");
    Console.ReadKey();
    ExibirOpMenu();
}


ExibirOpMenu();
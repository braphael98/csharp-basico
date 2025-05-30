// Screen sound projeto do curso da alura de c#
// Variaveis camelCase, funções PascalCase
string welcomeMessage = "Boas vindas ao screen sound";
List<string> bandList = new List<string>();

void ShowLogo()
{
    Console.WriteLine(@"

█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
");
    //para adicionar titulos divertidos deve usar o @ (verbatinliteral).
    Console.WriteLine(welcomeMessage);

}

void MenuOptions()
{
    ShowLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    String optionChoice = Console.ReadLine()!;
    int optionChoiceNumber = int.Parse(optionChoice); //conversão de tipo de variavel.

    switch (optionChoiceNumber) // para menus é melhor usar switch case.
    {
        case 1:
            BandResgister();
            Console.WriteLine("Opção: " + optionChoiceNumber);
            break;
        case 2:
            BandShow();
            Console.WriteLine("Opção: " + optionChoiceNumber);
            break;
        case 3:
            Console.WriteLine("Opção: " + optionChoiceNumber);
            break;
        case 4:
            Console.WriteLine("Opção: " + optionChoiceNumber);
            break;
        case -1:
            Console.WriteLine("Fim da aplicação ");
            break;
        default:
            Console.WriteLine("OPÇÃO INVALIDA");
            break;
    }

}
void BandResgister()
{
    Console.Clear();

    Console.WriteLine("Registro de bandas");
    Console.Write("Digite a banda ou artista que queira registar: ");
    string bandName = Console.ReadLine()!;

    bandList.Add(bandName);

    Console.WriteLine($"Banda {bandName} registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    MenuOptions();
}

void BandShow()
{
    Console.Clear();
    for (int i = 0; i < bandList.Count; i++)
    {
        Console.WriteLine($"Banda: {bandList[i]}");
    }
    Console.Write("Digite B para voltar ao menu: ");
    string voltar = Console.ReadLine()!;
    if (voltar == "B")
    {
        MenuOptions();
    }
    
}
MenuOptions();



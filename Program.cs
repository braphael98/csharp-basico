// Screen sound projeto do curso da alura de c#
// Variaveis camelCase, funções PascalCase
string welcomeMessage = "Boas vindas ao screen sound";
//List<string> bandList = new List<string> { "Beatles", "Pink Floyd", "Yes" };

Dictionary<string, List<int>> allRegisteredBands = new Dictionary<string, List<int>>();
allRegisteredBands.Add("Linkin Park", new List<int> { 10, 9, 7, 5, 6 });
allRegisteredBands.Add("The Beatles", new List<int>());

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
            
            break;
        case 2:
            ShowBands();
            
            break;
        case 3:
            RateBand();
            
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
    OptionTittle("Registro das bandas");
    Console.Write("Digite a banda ou artista que queira registar: ");
    string bandName = Console.ReadLine()!;

    allRegisteredBands.Add(bandName, new List<int>()); //a nova lista é as notas

    Console.WriteLine($"Banda {bandName} registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    MenuOptions();
}

void ShowBands()
{
    Console.Clear();
    OptionTittle("Bandas Registradas !!!");
    foreach (string band in allRegisteredBands.Keys)
    {
        Console.WriteLine($"Banda: {band}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    MenuOptions();
}
void OptionTittle(string tittle)
{
    int letterCount = tittle.Length; //variavel para contar a quantidade de letras que eu passar no parametro.
    string asterisks = string.Empty.PadLeft(letterCount, '*');
    Console.WriteLine(asterisks);
    Console.WriteLine(tittle);
    Console.WriteLine(asterisks + "\n");
}
void RateBand()
{
    //digite qual banda deseja avaliar
    // se a banda existir no dicionario >> ai avaliar a nota !
    // se nao existir volta para o menu principal.

    Console.Clear();
    OptionTittle("Avaliar Banda !");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    String bandName = Console.ReadLine();
    if (allRegisteredBands.ContainsKey(bandName))
    {

    }
    else
    {
        Console.WriteLine($"\nA banda {bandName} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
        MenuOptions();
    }


}
MenuOptions();




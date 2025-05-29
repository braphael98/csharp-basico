// Screen sound projeto do curso da alura de c#
// Variaveis camelCase, funções PascalCase
string welcomeMessage = "Boas vindas ao screen sound";

void ShowMessage()
{
    Console.WriteLine(@"

█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
");
    //para adicionar titulos divertidos deve usar o @ (verbatinliteral).

    Console.WriteLine("***********************");
    Console.WriteLine(welcomeMessage);
    Console.WriteLine("***********************");
}

void MenuOptions()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("Digite -1 para sair");

}

ShowMessage();
MenuOptions();



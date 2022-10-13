internal class Program
{
    private static void Main(string[] args)
    {
        GameAccount Player1 = new GameAccount("Vasyl");
        GameAccount Player2 = new GameAccount("Ivan");
        Game num1 = new Game(1, Player1, Player2);
        Game num2 = new Game(2, Player1, Player2);
        Game num3 = new Game(3, Player1, Player2);
        Game num4 = new Game(4, Player1, Player2);
        Console.WriteLine("Статистика гравця Vasyl:");
        GameAccount.GetStatus(Player1.History);
        Console.WriteLine($"Кiлькiсть зiграних iгор:{Player1.GameCount}\tРейтинг:{Player1.CurrentRating}");

        Console.WriteLine("\nСтатистика гравця Ivan:");
        GameAccount.GetStatus(Player2.History);
        Console.WriteLine($"Кiлькiсть зiграних iгор:{Player2.GameCount}\tРейтинг:{Player2.CurrentRating}");
    }
}
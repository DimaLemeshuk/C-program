using System;

public class GameAccount
{
    public string UserName;
    public int CurrentRating;
    public int GameCount;
    public List<Info> History = new List<Info>();

    public GameAccount(string UserName, int CurrentRating, int GameCount)
    {
        this.UserName = UserName;
        this.CurrentRating = CurrentRating;
        this.GameCount = GameCount;
    }
    public GameAccount(string UserName)
    {
        this.UserName = UserName;
        CurrentRating = 1;  
        GameCount = 0;
    }

    public void WinGame(int IP, int rating, GameAccount opponent) 
    {
        CurrentRating += rating;
        GameCount++;
        Info info = new Info(IP, rating, opponent, "Перемога");
        History.Add(info);
    }
    public void LoseGame(int IP, int rating, GameAccount opponent)
    {
        if (CurrentRating - rating < 1){
            CurrentRating = 1;
        }
        else{
            CurrentRating -= rating;
        }
        GameCount++;
        Info info = new Info(IP, rating, opponent, "Поразка");
        History.Add(info);
    }

    public static void GetStatus(List<Info> History)
    {    
        foreach(var info in History)
        {          
            Console.WriteLine($"Iндекс гри: {info.IP} Противник: {info.opponent.UserName} Рейтинг:{info.Rating} Статус:{info.status}");
        }
    }
}

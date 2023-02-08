using static Seasons;

Seasons Season = new Seasons();


for (int i = 0; i < 5; i++)
{
    Season.allSesons((Season)i);

}
public class Seasons
{
    enum season
    {
        Summer
    }
    public enum Season
    {
        Winter = 0,
        Spring = 1,
        Summer = 2,
        Autumn = 3,
        WintSredTemp = -25,
        SprSredTemp = 10,
        SumSredTemp = 25,
        AutSredTemp = 5,
    }

    public void loveSeasons(Season season)
    {
        switch (season) 
        {
            case 0:
                Console.WriteLine("Я люблю зиму");
                break;
            case (Season)1:
                Console.WriteLine("Я люблю весну");
                break;
            case (Season)2:
                Console.WriteLine("Я люблю лето");
                break;
            case (Season)3:
                Console.WriteLine("Я люблю осень");
                break;

        }
    }

    public void SredTemp(Season temp)
    {
        switch (temp)
        {
            case (Season)(-25):
                Console.WriteLine("Зима");
                break;
            case (Season)10:
                Console.WriteLine("Весна");
                break;
            case (Season)25:
                Console.WriteLine("Лето");
                break;
            case (Season)5:
                Console.WriteLine("Осень");
                break;

        }
    }

    public string getDescription(Season seasons)
    {
        if (seasons == (Season.Summer))
            return "Теплое время года";

        else
            return "Холодное время года";
    }

    public void allSesons(Season season)
    {
        switch (season)
        {
            case 0:
                Console.WriteLine("Зима \n Средняя температура зимы - 25 градусов \n Cнежная и холодная, но очень красивая пора года, время метелей и вьюг, новогодних праздников и первого снега.");
                break;
            case (Season)1:
                Console.WriteLine("Весна \n Средняя температура весны 10 градусов \n Переходный сезон, когда заметно увеличение светового дня, повышается температура окружающей среды и активизируется природная деятельность живых существ и растений.");
                break;
            case (Season)2:
                Console.WriteLine("Лето \n Средняя температура лета 25 градусов \n Самое теплое время года, когда природа цветет и благоухает, радуется солнцу и освежается дождями.");
                break;
            case (Season)3:
                Console.WriteLine("Осень \n Средняя температура осенм 5 градусов \n  Переходный сезон, когда заметно уменьшение светового дня, и постепенно понижается температура окружающей среды.");
                break;

        }
    }
}
using _001_GameSales;
internal class Program
{
    private static void Main(string[] args)
    {
        GamerManager gamerManager = new GamerManager(new UserValidationManager());
        Gamer gamer1 = new Gamer{
            Id = 1,
            FirstName = "Erhan",
            LastName = "Balkan",
            BirthYear = 1999,
            IdentityNumber = 13063865844,
        };
        gamerManager.Add(gamer1);
    }
}
public class Menu
{
    static public string MainMenu()
    {
        string userSelection;
            
            System.Console.Clear();

            System.Console.WriteLine("Welcome to ...");
            System.Console.WriteLine("Type 1 for all songs");
            System.Console.WriteLine("Type 2 for add a song");
            System.Console.WriteLine("Type 3 favorite a song");
            System.Console.WriteLine("Type 4 to delete a song ");
            System.Console.WriteLine("Type 5 to exit the program");
            userSelection = Console.ReadLine();

            while (userSelection != "5")
            {
                RouteEm(userSelection);
                userSelection = MainMenu();
            }
            
            return userSelection;
    }
    static private void RouteEm(string userSelection)
    {
        switch (userSelection)
        {
            case "1":
            Song.WriteAllSongs();
            break;
            case "2":
            Song.AddNew();
            break;
            case "3":
            //Song.Favorite();
            break;
            case "4":
            break;
            default:
                Console.Clear();
                System.Console.WriteLine("Invalid Selection. Try again.");
                Console.ReadKey();
                MainMenu();
            break;
        }
    }
}
public class Menu
{   
    static public string MainMenu()
    {
        string userSelection;
            
            System.Console.Clear();

            System.Console.WriteLine("Welcome to Houndstoothify!" + "\n");
            System.Console.WriteLine("Enter 1 for all available songs");
            System.Console.WriteLine("Enter 2 for add a song");
            System.Console.WriteLine("Enter 3 favorite/unfavorite a song");
            System.Console.WriteLine("Enter 4 to delete/undelete a song ");
            System.Console.WriteLine("Enter 5 to exit the program\n");
            System.Console.Write("Selection here:");
            
            userSelection = Console.ReadLine();

            while (userSelection != "5")
            {
                RouteEm(userSelection);
                userSelection = MainMenu();
            }
            if (userSelection == "5")
            {
                Console.Clear();
                System.Console.WriteLine("Thank you for using Houndstoothify!");
            }
            return userSelection;
    }
    static private void RouteEm(string userSelection)
    {
        Console.Clear();

        switch (userSelection)
        {
            case "1":
            Song.WriteUndeletedSongs();
            System.Console.WriteLine("Press enter to continue.");
            Console.ReadKey();
            break;
            case "2":
            Song.AddNew();
            break;
            case "3":
            Song.Favorite();
            break;
            case "4":
            Song.Delete();
            break;
            default:
                System.Console.WriteLine("Invalid Selection. Try again.");
                Console.ReadKey();
                MainMenu();
            break;
        }
    }
}
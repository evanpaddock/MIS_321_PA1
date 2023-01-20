namespace MIS_321_PA1
{
    public class menu
    {
        public static string AskUserSelection()
        {
            string userSelection;

            do
            {
                System.Console.WriteLine("Write 1 for");
                System.Console.WriteLine("Write 1 for");
                System.Console.WriteLine("Write 1 for");
                System.Console.WriteLine("Write 1 for");
                System.Console.WriteLine("Write 1 for");
                userSelection = Console.ReadLine();
            }while(userSelection != "1");
            return userSelection;
        }
    }
}
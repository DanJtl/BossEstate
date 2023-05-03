namespace BossEstate.Services;

internal class MenuService
{
    public void MainMenu()
    {
        Console.Clear();
        Console.WriteLine("******** Boss Estate ********");
        Console.WriteLine("*****************************");
        Console.WriteLine(" [1] Create a New case.");
        Console.WriteLine(" [2] View all Cases.");
        Console.WriteLine(" [3] View a Specific case.");
        Console.WriteLine(" [4] View all Users.");
        Console.WriteLine(" [5] Update a specific case Status.");
        Console.Write(" \nChoose an option: (1-5)");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                break;

            case "2":
                break;

            case "3":
                break;

            case "4":
                break;

            case "5":
                break;

            default:
                Console.Clear();
                Console.Write("No valid option! Please try again.");
                break;
        }
        Console.ReadKey();
    }
}

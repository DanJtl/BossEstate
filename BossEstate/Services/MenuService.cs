using BossEstate.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BossEstate.Services;

internal class MenuService
{
    private readonly UserService _userService = new();
    private readonly CaseService _caseService = new();
    private readonly AddressService _addressService = new();


    public void MainMenu()
    {
        Console.Clear();
        Console.WriteLine("******** Boss Estate ********");
        Console.WriteLine("*****************************");
        Console.WriteLine(" [1] Show all data in local database");
        Console.Write(" \nChoose: ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                
                ShowAllData();
                break;

            default:
                Console.Clear();
                Console.Write("No valid option! Please try again.");
                break;
        }

        Console.ReadKey();
    }

    public void ShowAllData()
    {
        var users = _userService.GetAllAsync().Result;
        var addresses = _addressService.GetAllAsync().Result;
        var cases = _caseService.GetAllAsync().Result;

        Console.WriteLine("**** Users ****");
        foreach (var user in users)
        {
            Console.WriteLine($"Id: {user.Id}");
            Console.WriteLine($"First name: {user.FirstName}");
            Console.WriteLine($"Last name: {user.LastName}");
            Console.WriteLine($"Email: {user.Email}");
            Console.WriteLine($"Phone number: {user.PhoneNumber}");
            Console.WriteLine($"Address: {user.Address.StreetName}, {user.Address.PostalCode}, {user.Address.City}");
            Console.WriteLine();
        }

        Console.WriteLine("**** Addresses ****");
        foreach (var address in addresses)
        {
            Console.WriteLine($"Id: {address.Id}");
            Console.WriteLine($"Street name: {address.StreetName}");
            Console.WriteLine($"Postal code: {address.PostalCode}");
            Console.WriteLine($"City: {address.City}");
            Console.WriteLine();
        }

        Console.WriteLine("**** Cases ****");
        foreach (var caseEntity in cases)
        {
            Console.WriteLine($"Id: {caseEntity.Id}");
            Console.WriteLine($"Title: {caseEntity.Title}");
            Console.WriteLine($"Description: {caseEntity.Description}");
            Console.WriteLine($"Created: {caseEntity.Created}");
            Console.WriteLine($"Modified: {caseEntity.Modified}");
            Console.WriteLine($"User: {caseEntity.User.FirstName} {caseEntity.User.LastName}");
            Console.WriteLine($"Status: {caseEntity.StatusType.StatusName}");
            Console.WriteLine();
        }
    }
   
}

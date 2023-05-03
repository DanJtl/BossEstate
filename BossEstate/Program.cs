using BossEstate.Models.Entities;
using BossEstate.Services;

var _caseService = new CaseService();
var _datetime = DateTime.Now;

var _case = new CaseEntity
{
    Id = Guid.NewGuid(),
    Created = _datetime,
    Modified = _datetime,
    Title = "Trasig dörr",
    Description = "Hantaget sitter löst",
    StatusType = new StatusTypeEntity
    {
        StatusName = "Ej påbörjad"
    },
    User = new UserEntity
    {
        Id = Guid.NewGuid(),
        FirstName = "Bat",
        LastName = "Man",
        Email = "test@gmail.com",
        PhoneNumber = "1234567890",
        Address = new AddressEntity
        {
            StreetName = "Batgatan 6",
            PostalCode = "12355",
            City = "BatCity"
        }
    }
};

var result = await _caseService.SaveAsync(_case);

Console.ReadKey();

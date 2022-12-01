// See https://aka.ms/new-console-template for more information

using DAB_3_Solution_grp2.Models;using DAB_3_Solution_grp2.Services;

var reservationService = new ReservationService();
var userService = new ReservationService();
var itemService = new ReservationService();

while (true)
{
    var str = Console.ReadLine().ToUpper().Split(" ");
    switch (str[0])
    {
        case"1":
            var createReservation = CreateReservation();
            reservationService.CreateNewReservation(createReservation);
            Console.WriteLine("Reservation 1 created!");
            var createReservation2 = CreateReservation2();
            reservationService.CreateNewReservation(createReservation2);
            Console.WriteLine("Reservation 2 created!");
            break;
        case"2":
            var createUser = CreateUser();
            userService.CreateNewUser(createUser);
            Console.WriteLine("Users created!");
            break;
        case"3":
            var createItem = CreateItem();
            itemService.CreateNewItem(createItem);
            Console.WriteLine("Item 1 created!");
            var createItem2 = CreateItem2();
            itemService.CreateNewItem(createItem2);
            Console.WriteLine("Item 2 created!");
            break;
        case"4":
            
            break;
        default:
            Console.WriteLine("Command not known");
            break;
    }
}

static Reservation CreateReservation()
{
    return new Reservation
    {
        Id = 1,
        DateIn = DateTime.Now,
        DateOut = DateTime.Now,
        NumberOfPeople = 10,
        Note = "Note",
        Document = "Document",
        Facility = new List<Facilty>
        {
           new Facilty { FacilityKind = "b", ClosestAddress = "c", Information = "f", RulesOfUse = "d"}
        },
    };
}

static Reservation CreateReservation2()
{
    return new Reservation
    {
        Id = 2,
        DateIn = DateTime.Now,
        DateOut = DateTime.Now,
        NumberOfPeople = 22,
        Note = "Note about reservation 2.",
        Document = "Document about the 2nd reservation.",
        Facility = new List<Facilty>
        {
            new Facilty { FacilityKind = "Y", ClosestAddress = "U", Information = "I", RulesOfUse = "O"}
        },
    };
}

static User CreateUser()
{
    return new User
    {
        Id = 10,
        Name = "Anders",
        PhoneNumber = 12345678,
        Email = "anders@hotmail.com",
        Reservation = new int[] { 1 },
        Company = null,
    };
}

static Item CreateItem()
{
    return new Item
    {
        Id = 20,
        Facility = 1,
        Maintenance = new string[] {"1/11-2022: Rengjort", "10/11-2022: Rengjort igen", "1/12-2022: Rengjort igen igen"}
    };
}

static Item CreateItem2()
{
    return new Item
    {
        Id = 21,
        Facility = 1,
        Maintenance = new string[] {"1/12-2022 Skiftet en del..."}
    };
}
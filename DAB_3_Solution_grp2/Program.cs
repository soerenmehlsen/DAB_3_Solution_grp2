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
            Console.WriteLine("Reservations created!");
            break;
        case"2":
            var createUser = CreateUser();
            userService.CreateNewUser(createUser);
            Console.WriteLine("Users created!");
            break;
        case"3":
            var createItem = CreateItem();
            itemService.CreateNewItem(createItem);
            Console.WriteLine("Item created!");
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
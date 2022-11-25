// See https://aka.ms/new-console-template for more information

using DAB_3_Solution_grp2.Models;using DAB_3_Solution_grp2.Services;

var reservationService = new ReservationService();

while (true)
{
    var str = Console.ReadLine().ToUpper().Split(" ");
    switch (str[0])
    {
        case"1":
            var createReservation = CreateReservation();
            reservationService.CreateNewReservation(createReservation);
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
        DateIn = DateTime.Now,
        DateOut = DateTime.Now,
        NumberOfPeople = 10,
        Note = "Note",
        Document = "Document",
    };
}
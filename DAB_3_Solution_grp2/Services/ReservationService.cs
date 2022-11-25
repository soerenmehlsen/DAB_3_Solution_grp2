using DAB_3_Solution_grp2.Models;
using MongoDB.Driver;

namespace DAB_3_Solution_grp2.Services;

public class ReservationService
{
    private IMongoCollection<Reservation> _reservation;
    private readonly string conn = "mongodb://localhost:27017";
    private readonly string friluftslivaarhusDB = "friluftslivaarhusDB";
    private readonly string collection = "Reservation";

    public ReservationService() //Connection to the mongo database
    {
        var client = new MongoClient(conn);
        var database = client.GetDatabase(friluftslivaarhusDB);
        _reservation = database.GetCollection<Reservation>(collection);
    }

    public Reservation CreateNewReservation(Reservation reservation)
    {
        _reservation.InsertOne(reservation);
        return reservation;
    }
}
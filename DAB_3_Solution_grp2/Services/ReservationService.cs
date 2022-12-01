using DAB_3_Solution_grp2.Models;
using MongoDB.Driver;

namespace DAB_3_Solution_grp2.Services;

public class ReservationService
{
    private IMongoCollection<Reservation> _reservation;
    private IMongoCollection<User> _user;
    private IMongoCollection<Item> _item;
    private readonly string conn = "mongodb://localhost:27017";
    private readonly string friluftslivaarhusDB = "friluftslivaarhusDB";
    private readonly string collection = "Reservation";
    private readonly string userCollection = "User";
    private readonly string itemCollection = "Item";

    public ReservationService() //Connection to the mongo database
    {
        var client = new MongoClient(conn);
        var database = client.GetDatabase(friluftslivaarhusDB);
        _reservation = database.GetCollection<Reservation>(collection);
        _user = database.GetCollection<User>(userCollection);
        _item = database.GetCollection<Item>(itemCollection);
    }
    
    public Reservation CreateNewReservation(Reservation reservation)
    {
        _reservation.InsertOne(reservation);
        return reservation;
    }
    
    public User CreateNewUser(User user)
    {
        _user.InsertOne(user);
        return user;
    }
    
    public Item CreateNewItem(Item item)
    {
        _item.InsertOne(item);
        return item;
    }
}
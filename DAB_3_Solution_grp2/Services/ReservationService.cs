using DAB_3_Solution_grp2.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
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

    #region Create collections
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
    

    #endregion

    #region Queries

    public List<BsonDocument> GetQuery1()
    {
        var bson = _reservation
            .Find(new BsonDocument())
            .Project("{Facility: {Name:1, ClosestAddress:1}}")
            .ToList();
        return bson;
    }
    
    public List<BsonDocument> GetQuery2()
    {
        var bson = _reservation
            .Find(new BsonDocument()) // Finding all documents from the collection
            .Project("{Facility: {Name:1, ClosestAddress:1}}") //Projecting is selecting name and closestAddress from facility
            .Sort("{Facility.FacilityKind: -1}") //sorting after facility kind from a to z
            .ToList(); // adding to list
        return bson;
    }

    public List<BsonDocument> GetQuery3()
    {
        var bson = _user
            .Aggregate()
            .Lookup("Reservation", "Reservation", "_id", "Reservation")
            //.Project("{Facility: {Name:1}, DateIn: 1, DateOut: 1,}")
            .ToList();
        return bson;
    }

    #endregion
    
}
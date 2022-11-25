using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DAB_3_Solution_grp2.Models;

public class Reservation
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public DateTime DateIn { get; set; }
    public DateTime DateOut { get; set; }
    public int NumberOfPeople { get; set; }
    public string Note { get; set; }
    public string Document { get; set; }
}
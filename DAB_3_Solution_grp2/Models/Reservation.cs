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
    public List<Facilty> Facility { get; set; }
    public string[] Item { get; set; }
}

public class Facilty
{
    public string FacilityKind { get; set; }
    public string ClosestAddress { get; set; }
    public string Information { get; set; }
    public string RulesOfUse { get; set; }
}


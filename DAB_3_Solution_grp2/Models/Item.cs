using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DAB_3_Solution_grp2.Models;

public class Item
{
    public int Id { get; set; }
    public string ItemType { get; set; }
    public int FacilityId { get; set; }
    public string[] Maintenance { get; set; }
}
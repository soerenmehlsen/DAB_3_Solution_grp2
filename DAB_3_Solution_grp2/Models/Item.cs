using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DAB_3_Solution_grp2.Models;

public class Item
{
    public int Id { get; set; }
    public int Facility { get; set; }
    public string[] Maintenance { get; set; }
}
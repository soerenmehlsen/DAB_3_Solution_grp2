using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DAB_3_Solution_grp2.Models;

public class User
{
    public int Id { get; set; }

    public string Name { get; set; }
    public int PhoneNumber { get; set; }
    public string Email { get; set; }
    public int? CPRNumber { get; set; }
    public int[] Reservation { get; set; }
    public int[]? Company { get; set; }
}
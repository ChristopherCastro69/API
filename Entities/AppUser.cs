namespace API.Entities;

public class AppUser
{
    public int Id { get; set; } //primitive type -> default = 0
    public required string UserName { get; set;} //reference type -> default = null
       
}
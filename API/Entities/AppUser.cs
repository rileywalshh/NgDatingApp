using System;

namespace API.Entities;

public class AppUser
{
    public int Id { get; set; }   //get set is like read write
    public required string UserName { get; set; } //use required as each user will need a name
    public required byte[] PasswordHash {get; set;}
    public required byte[] PasswordSalt {get; set;}
}

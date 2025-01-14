using System;
using API.Extensions;
using Microsoft.AspNetCore.Identity;

namespace API.Entities;

public partial class AppUser
{
    public int Id { get; set; }   //get set is like read write
    public required string UserName { get; set; } //use required as each user will need a name
    public byte[] PasswordHash { get; set; } = [];
    public byte[] PasswordSalt { get; set; } = [];
    public DateOnly DateOfBirth { get; set; }
    public required string KnownAs { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime LastActive { get; set; } = DateTime.UtcNow;
    public string Gender { get; set; }
    public string? Introduction { get; set; }
    public string Interests { get; set; }
    public string LookingFor { get; set; }
    public required string City { get; set; }
    public required string Country { get; set; }
    public List<Photo> Photos { get; set; } = [];
    public int GetAge()
    {
        return DateOfBirth.CalculateAge();
    }
}

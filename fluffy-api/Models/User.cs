using System.ComponentModel.DataAnnotations;

namespace Models;

public class User
{
    public int Id { get; set; }

    [StringLength(32)]
    public required string Username { get; set; }

    [DataType(DataType.Password)]
    public required string Password { get; set; }

    [DataType(DataType.EmailAddress)]
    public required string Email { get; set; }
}
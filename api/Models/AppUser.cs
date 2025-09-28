using System.ComponentModel.DataAnnotations;

namespace api.Models;

public record AppUser(
    [EmailAddress] string Email,
    string Password
);
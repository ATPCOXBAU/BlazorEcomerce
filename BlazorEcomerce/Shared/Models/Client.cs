using System;
using System.Collections.Generic;

namespace BlazorEcomerce.Shared;

public partial class Clients
{
    public int ClientId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? PasswordHash { get; set; }

    public string? PhoneNumber { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public DateTime? LastLoginDate { get; set; }
}

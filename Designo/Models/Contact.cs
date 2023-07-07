using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Designo.Models;

public class Contact
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = default!;

    [Required]
    public string Phone { get; set; } = default!;

    [Required]
    [EmailAddress]
    [StringLength(60, MinimumLength = 2)]
    public string Email { get; set; } = default!;

    [Required]
    [StringLength(500, MinimumLength = 10)]
    public string Message { get; set; } = default!;
}

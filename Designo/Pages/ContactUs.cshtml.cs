using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Designo.Data;
using Designo.Models;
using System.Xml.Linq;

namespace Designo.Pages;

public class ContactUsModel : PageModel
{
    [BindProperty]
    [Required]
    public string Name { get; set; } = default!;

    [BindProperty]
    [Required]
    public string Phone { get; set; } = default!;

    [BindProperty]
    [Required]
    [EmailAddress]
    [StringLength(60, MinimumLength = 2)]
    public string Email { get; set; } = default!;

    [BindProperty]
    [Required]
    [StringLength(500, MinimumLength = 10)]
    public string Message { get; set; } = default!;

    public Dictionary<string, Dictionary<string, string>> Locations { get; set; } = new()
        {
            {
                "canada", new() {
                     {"image", "illustration-canada.svg"},
                     {"country", "canada"},
                     {"link", ""},
                }
            },
            {
                "australia", new() {
                     {"image", "illustration-australia.svg"},
                     {"country", "australia"},
                     {"link", ""},
                }
            },
            {
                "united", new() {
                     {"image", "illustration-united-kingdom.svg"},
                     {"country", "united Kingdom"},
                     {"link", ""},
                }
            }
    };

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page(); // Return the page with validation errors
        }

        using (DesignoContext db = new DesignoContext())
        {
            Contact contact = new Contact
            {
                Name = this.Name,
                Email = this.Email,
                Phone = this.Phone,
                Message = this.Message
            };

            db.Contact.Add(contact);
            db.SaveChanges();
        }

        // Example: Display a success message
        TempData["Message"] = "Thank you for contacting us! We will get back to you soon.";

        return RedirectToPage("/ContactUs"); // Redirect to the "Contact" page
    }

}
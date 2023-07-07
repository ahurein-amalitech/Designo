using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Designo.Pages;

public class AboutUsModel : PageModel
{
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
}

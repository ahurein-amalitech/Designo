using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Designo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public Dictionary<string, Dictionary<string, string>> Services { get; set; } = new()
        {
            {
                "web", new() {
                     {"name", "Web design"},
                     {"action", "View projects"},
                     {"image", "image-web-design.jpg"}
                }
            },
            {
                "app", new() {
                     {"name", "App design"},
                     {"action", "View projects"},
                     {"image", "image-app-design.jpg"}
                }
            },
            {
                "graphic", new() {
                     {"name", "Graphic design"},
                     {"action", "View projects"},
                     {"image", "image-graphic-design.jpg"}
                }
            }
        };

        public Dictionary<string, Dictionary<string, string>> WhyUs { get; set; } = new()
        {
            {
                "passionate", new() {
                     {"content", "Each project starts with an in-depth brand research to ensure we only create products that serve a purpose. We merge art, design, and technology into exciting new solutions."},
                     {"image", "illustration-passionate.svg"},
                     {"name", "passionate" }
                }
            },
            {
                "resourceful", new() {
                     {"content", "Everything that we do has a strategic purpose. We use an agile approach in all of our projects and value customer collaboration. It guarantees superior results that fulfill our clients’ needs."},
                     {"image", "illustration-resourceful.svg"},
                     {"name", "resourceful" }
                }
            },
            {
                "friendly", new() {
                     {"content", "We are a group of enthusiastic folks who know how to put people first. Our success depends on our customers, and we strive to give them the best experience a company can provide"},
                     {"image", "illustration-friendly.svg"},
                     {"name", "friendly" }
                }
            }
        };
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}                     
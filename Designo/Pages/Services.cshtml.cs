using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Designo.Pages
{
    public class ServicesModel : PageModel
    {
        public string? Id { get; set; } = "web";
        public Dictionary<string, string>[]? CurrentServiceDetails { get; set; }
        public Dictionary<string, Dictionary<string, string>[]> ServiceDetails { get; set; } = new()
        {
            {
                "Web design",
                new Dictionary<string, string>[]
                {
                    new()
                    {
                        {"image", "image-express.jpg" },
                        { "heading", "EXPRESS" },
                        { "content", "A multi-carrier shipping website for ecommerce businesses" }
                    },
                    new()
                    {
                        {"image", "image-transfer.jpg" },
                        { "heading", "TRANSFER" },
                        { "content", "Site for low-cost money transfers and sending money within seconds" }
                    },
                    new()
                    {
                        {"image", "image-photon.jpg" },
                        { "heading", "PHOTON" },
                        { "content", "A state-of-the-art music player with high-resolution audio and DSP effects" }
                    },
                    new()
                    {
                        {"image", "image-builder.jpg" },
                        { "heading", "BUILDER" },
                        { "content", "Connects users with local contractors based on their location" }
                    },
                    new()
                    {
                        {"image", "image-blogr.jpg" },
                        { "heading", "BLOGR" },
                        { "content", "Blogr is a platform for creating an online blog or publication" }
                    },
                    new()
                    {
                        {"image", "image-camp.jpg" },
                        { "heading", "CAMP" },
                        { "content", "Get expert training in coding, data, design, and digital marketing" }
                    }
                }
            },
            {
                "App design",
                new Dictionary<string, string>[]
                {
                    new()
                    {
                        {"image", "image-airfilter.jpg" },
                        { "heading", "AIRFILTER" },
                        { "content", "Solving the problem of poor indoor air quality by filtering the air" }
                    },
                    new()
                    {
                        {"image", "image-eyecam.jpg" },
                        { "heading", "EYECAM" },
                        { "content", "Product that lets you edit your favorite photos and videos at any time" }
                    },
                    new()
                    {
                        {"image", "image-faceit.jpg" },
                        { "heading", "FACEIT" },
                        { "content", "Get to meet your favorite internet superstar with the faceit app" }
                    },
                    new()
                    {
                        {"image", "image-todo.jpg" },
                        { "heading", "TODO" },
                        { "content", "A todo app that features cloud sync with light and dark mode" }
                    },
                    new()
                    {
                        {"image", "image-loopstudios.jpg" },
                        { "heading", "LOOPSTUDIOS" },
                        { "content", "A VR experience app made for Loopstudios" }
                    }
                }
            },
            {
                "Graphic design",
                new Dictionary<string, string>[]
                {
                    new()
                    {
                        {"image", "image-change.jpg" },
                        { "heading", "TIM BROWN" },
                        { "content", "A book cover designed for \r\nTim Brown’s new release, ‘Change’" }
                    },
                    new()
                    {
                        {"image", "image-boxed-water.jpg" },
                        { "heading", "BOXED WATER" },
                        { "content", "A simple packaging concept made for Boxed Water" }
                    },
                    new()
                    {
                        {"image", "image-science.jpg" },
                        { "heading", "SCIENCE!" },
                        { "content", "A poster made in collaboration with the Federal Art Project" }
                    }
                }
            }
        };

        public Dictionary<string, Dictionary<string, string>> Services { get; set; } = new()
        {
            {
                "web", new() {
                     {"name", "Web design"},
                     {"action", "View projects"},
                     {"image", "image-web-design.jpg"},
                     {"routeName", "web" }
                }
            },
            {
                "app", new() {
                     {"name", "App design"},
                     {"action", "View projects"},
                     {"image", "image-app-design.jpg"},
                     {"routeName", "app" }
                }
            },
            {
                "graphic", new() {
                     {"name", "Graphic design"},
                     {"action", "View projects"},
                     {"image", "image-graphic-design.jpg"},
                     {"routeName", "graphic" }
                }
            }
        };

        public Dictionary<string, Dictionary<string, string>> PageHeaderInfo { get; set; } = new()
        {
            {
                "web", new() {
                     {"title", "Web Design"},
                     {"subTitle", "We build websites that serve as powerful marketing tools and bring memorable brand experiences."}
                }
            },
            {
                "app", new() {
                     {"title", "App Design"},
                     {"subTitle", "Our mobile designs bring intuitive digital solutions to your customers right at their fingertips."}
                }
            },
            {
                "graphic", new() {
                     {"title", "Graphic Design"},
                     {"subTitle", "We deliver eye-catching branding materials that are tailored to meet your business objectives."}
                }
            }
        };

        public void OnGet(string id)
        {
            switch(id)
            {
                case "web":
                    CurrentServiceDetails = ServiceDetails["Web design"];
                    break;
                case "app":
                    CurrentServiceDetails = ServiceDetails["App design"]; 
                    break;
                case "graphic":
                    CurrentServiceDetails = ServiceDetails["Graphic design"]; 
                    break;
                default:
                    CurrentServiceDetails = ServiceDetails["Web design"];
                    break;
            }

            if(!string.IsNullOrEmpty(id))
            {
            Id = id;

            }
        }
    }
}

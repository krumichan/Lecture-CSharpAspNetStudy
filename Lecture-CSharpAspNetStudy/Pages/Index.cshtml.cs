using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lecture_CSharpAspNetStudy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lecture_CSharpAspNetStudy.Pages
{
    public class IndexModel : PageModel
    {
        // Model Binding 참가 암시.
        [BindProperty]
        public HelloMessage HelloMsg { get; set; }
        
        public string Noti { get; set; }

        public void OnGet()
        {
            this.HelloMsg = new HelloMessage()
            {
                Message = "Hello Razor Pages"
            };
        }

        public void OnPost()
        {
            this.Noti = "Message Changed";
        }
    }
}

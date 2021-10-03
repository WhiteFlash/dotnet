using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace dotnet.Pages
{
    public class StatModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public int count = 1;

        public StatModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["count"] = this.count++;
        }
    }
}
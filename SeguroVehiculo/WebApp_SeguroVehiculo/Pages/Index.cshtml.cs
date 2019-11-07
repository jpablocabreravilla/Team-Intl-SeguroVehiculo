using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace WebApp_SeguroVehiculo.Pages
{
    public class IndexModel : PageModel
    {
        public IConfiguration Configuration { get; set; }

        public IndexModel(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public void OnGet()
        {
        }
    }
}

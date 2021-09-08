using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesOne.Pages
{
    public class AmortizacionModel : PageModel
    {


        public double monto { get; set; }
        public int cantidad { get; set; }
        public int porcentaje { get; set; }



        public void OnGet()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesOne.Pages
{
    public class AmortizacionFrancesModel : PageModel
    { 
        //     Amortizacion  amortizacion  = new List<Amortizacion>()
        //        {

        //             new Amortizacion() { monto = 3000, cantidad = 32, porcentaje =5},
        //             new Amortizacion() { monto = 4000, cantidad = 2, porcentaje =4},
        //             new Amortizacion() { monto = 6700, cantidad = 12, porcentaje =3}




        //        };

        
        public List<AmortizacionModel> amortizacion { get; set; }


        public AmortizacionFrancesModel()
        {

            amortizacion = new List<AmortizacionModel>()
            {
                new AmortizacionModel (){ monto = 4000, cantidad = 32, porcentaje =3},
                new AmortizacionModel (){ monto = 6300, cantidad = 12, porcentaje =2},
                new AmortizacionModel (){ monto = 433000, cantidad = 322, porcentaje =1}


            };

        }


        public void OnGet( double Monto, int Cantidad, int Porcentaje)
        {

       

            this.amortizacion.Add(

                     new AmortizacionModel() { monto = Monto, cantidad = Cantidad, porcentaje = Porcentaje }



                );   


        }
    }
}

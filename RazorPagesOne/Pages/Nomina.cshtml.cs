using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesOne.Pages
{
    public class NominaModel : PageModel
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cargo { get; set; }
        public double sueldo { get; set; }
        public double descuentoAFP { get; set; }
        public double descuentoARS { get; set; }
        public double descuentoISR { get; set; }

        public double totalDescuento { get; set; }
        public double sueldoNeto { get; set; }

        public double  subsueldo { get; set; }




        public NominaModel nomina;


        // calcular el seguro familiar de salud

        public double calularSFS()
        {
            descuentoARS = this.sueldo * 0.0304;

            if (descuentoARS == 4098.53)
            {
                return 0; //maximo monto
            }

            return descuentoARS;

        }// fin metodo calcularSFS.


        public double calularAFP()
        {
            descuentoAFP = this.sueldo * 0.0287;

            if (descuentoAFP == 7738.67)
            {
                return 0; //maximo monto
            }

            return descuentoAFP;

        }// fin metodo calcularSFS.




        public double TotalDescuento()
        {
            return totalDescuento = calularISR() + calularSFS() + calularAFP();
        }








        public double calularISR()
        {
            subsueldo = sueldo - (descuentoAFP + descuentoARS);
            double excedente = 0;
            //Calcular escala del ISR para ver si aplica o no

            if (subsueldo >= 34686.00 && subsueldo < 52028.00)
            {
                excedente = (subsueldo * 12 - 416220.01);
                descuentoISR = (excedente * 0.15 / 12);
                //sueldo_neto = subsueldo - isr;
                return descuentoISR;

            }
            else if (subsueldo >= 52028.00 && subsueldo <= 72261.00)
            {
                excedente = (subsueldo * 12 - 624329.01);
                descuentoISR = (excedente * 0.2 / 12) + 31216.00;
                //sueldo_neto = subsueldo - isr;
                return descuentoISR;

            }
            else if (subsueldo >= 72261.00)
            {
                excedente = (subsueldo * 12 - 867123.00);
                descuentoISR = (excedente * 0.25 / 12) + 79776.00;
                //sueldo_neto = subsueldo - isr;
                return descuentoISR;

            }
            else
            {
             
                descuentoISR = 0;
                return descuentoISR;

            }


        }// fin metodo calcularSFS.



        public double calcularSueldoNeto()
        {

            return sueldoNeto = subsueldo - calularISR();


        }

        public void OnGet()
        {




        }
    }
}

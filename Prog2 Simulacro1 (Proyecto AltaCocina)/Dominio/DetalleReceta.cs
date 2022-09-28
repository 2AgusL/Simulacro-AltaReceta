using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Simulacro1__Proyecto_AltaCocina_.Dominio
{
    class DetalleReceta
    {
        public Ingrediente Ingrediente { get; set; }
        public decimal Cantidad { get; set; }

        public DetalleReceta()
        {
            Ingrediente = new Ingrediente();
            Cantidad = 0;
        }

        public DetalleReceta(Ingrediente ingrediente, decimal cantidad)
        {
            Ingrediente = new Ingrediente();
            Cantidad = cantidad;
        }
        

    }
}

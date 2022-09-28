using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Simulacro1__Proyecto_AltaCocina_.Dominio
{
    class Ingrediente
    {
        public int IdIngrediente { get; set; }
        public string NomIngrediente { get; set; }
        public string Unidad { get; set; }

        public Ingrediente()
        {
            IdIngrediente = 0;
            NomIngrediente = "";
            Unidad = "";
        }

        public Ingrediente(int idIngrediente, string nomIngrediente, string unidad)
        {
            IdIngrediente = idIngrediente;
            NomIngrediente = nomIngrediente;
            Unidad = unidad;
        }
    }
}

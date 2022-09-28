using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Simulacro1__Proyecto_AltaCocina_.Dominio
{
    class Receta
    {

        public int IdReceta { get; set; }
        public string NomReceta { get; set; }
        public string Chef { get; set; }
        public int TipoReceta { get; set; }
        public List<DetalleReceta> Detalles { get; set; }


        public Receta()
        {
            IdReceta = 0;
            NomReceta = "";
            Chef = "";
            TipoReceta = 0;
            Detalles = new List<DetalleReceta>();
        }

        public Receta(int idReceta, string nomReceta, string chef, int tipoReceta)
        {
            IdReceta = idReceta;
            NomReceta = nomReceta;
            Chef = chef;
            TipoReceta = tipoReceta;
            Detalles = new List<DetalleReceta>();
        }

        public void AgregarDetalle(DetalleReceta detalle) { Detalles.Add(detalle); }
        
        public void QuitarDetalle(int id) { Detalles.RemoveAt(id); }


    }
}

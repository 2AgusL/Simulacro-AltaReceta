using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Prog2_Simulacro1__Proyecto_AltaCocina_.Dominio;

namespace Prog2_Simulacro1__Proyecto_AltaCocina_.AccesoDatos
{
    class DBHelper
    {
        SqlConnection Conexion = new SqlConnection(Properties.Resources.ConexionCasa);
        SqlCommand Comando = new SqlCommand();

        private void AbrirConexion(string SP)
        {
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = SP;
        }
        private void CerrarConexion()
        {
            Conexion.Close();
        }

        public DataTable ConsultarDatos(string sp)
        {
            DataTable tabla = new DataTable();
            
            AbrirConexion(sp);
            tabla.Load(Comando.ExecuteReader());
            CerrarConexion();
            return tabla; 
        }

        public int ProximoID()
        {
            try
            {
                AbrirConexion("SP_PROXIMO_ID");
                Comando.Parameters.Clear();
                SqlParameter ID = new SqlParameter("@next", SqlDbType.Int);
                ID.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ID);
                Comando.ExecuteNonQuery();
                CerrarConexion();
                return Convert.ToInt32(ID.Value);
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public bool InsertarReceta(Receta receta)
        {
            bool ok = true;
            SqlTransaction transaction = null;

            try
            {
                AbrirConexion("SP_INSERTAR_RECETA");
                transaction = Conexion.BeginTransaction();
                Comando.Transaction = transaction;
                Comando.Parameters.Clear();

                Comando.Parameters.AddWithValue("@tipo_receta", receta.TipoReceta);
                Comando.Parameters.AddWithValue("@nombre", receta.NomReceta);
                Comando.Parameters.AddWithValue("@cheff", receta.Chef);
                SqlParameter ID = new SqlParameter("@id_receta", SqlDbType.Int);
                ID.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ID);

                Comando.ExecuteNonQuery();

                foreach (DetalleReceta detalle in receta.Detalles)
                {
                    SqlCommand CmmDetalle = new SqlCommand("SP_INSERTAR_DETALLES", Conexion);
                    CmmDetalle.CommandType = CommandType.StoredProcedure;
                    CmmDetalle.Transaction = transaction;
                    CmmDetalle.Parameters.Clear();

                    CmmDetalle.Parameters.AddWithValue("@id_receta", Convert.ToInt32(ID.Value));
                    CmmDetalle.Parameters.AddWithValue("@id_ingrediente", detalle.Ingrediente.IdIngrediente);
                    CmmDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    CmmDetalle.ExecuteNonQuery();
                }

                transaction.Commit();
                return ok;
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex+"");
                transaction.Rollback();
                return ok = false;
            }
            finally
            {
                CerrarConexion();
            }

        }
    }
}

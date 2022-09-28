using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prog2_Simulacro1__Proyecto_AltaCocina_.AccesoDatos;
using Prog2_Simulacro1__Proyecto_AltaCocina_.Dominio;

namespace Prog2_Simulacro1__Proyecto_AltaCocina_.Presentacion
{
    public partial class FrmAltaReceta : Form
    {
        DBHelper Helper;
        Receta Receta;
        int CantidadIngredientes;

        public FrmAltaReceta()
        {
            InitializeComponent();
            Helper = new DBHelper();
            Receta = new Receta();
            CantidadIngredientes = 0;
        }

        //METODOS
        private void FrmAltaReceta_Load(object sender, EventArgs e)
        {
            CargarDatos(cboIngrediente, "SP_CONSULTAR_INGREDIENTES",0,1);
            CargarDatos(cboTipoReceta, "SP_CONSULTAR_TIPOS_RECETAS",0,1);
            lblNroReceta.Text = Helper.ProximoID().ToString();
            btnAceptar.Enabled = false;
        }

        private void CargarDatos(ComboBox cbo, string sp, int value, int display)
        {
            cbo.DataSource = Helper.ConsultarDatos(sp);
            cbo.DisplayMember = Helper.ConsultarDatos(sp).Columns[display].ColumnName;
            cbo.ValueMember = Helper.ConsultarDatos(sp).Columns[value].ColumnName;
        }

        //BOTONES
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtNomReceta.Text == "")
            {
                MessageBox.Show("Falta el nombre de la receta","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if(txtChef.Text == "")
            {
                MessageBox.Show("Falta el nombre del chef","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if(txtCantidad.Text == "")
            {
                MessageBox.Show("Falta la cantidad del ingrediente","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            try { Convert.ToDecimal(txtCantidad.Text); }
            catch (Exception)
            {
                MessageBox.Show("Has escrito mal el valor de cantidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow row in dgvDetallesReceta.Rows)
            {
                if (row.Cells["ColumIngrediente"].Value.ToString().Equals(cboIngrediente.Text))
                {
                    MessageBox.Show("Este ingrediente ya esta puesto en la receta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            CantidadIngredientes++;
            lblCantidadIngredientes.Text = CantidadIngredientes.ToString();
            if (CantidadIngredientes < 3) btnAceptar.Enabled = false;
            else btnAceptar.Enabled = true;

            DataRowView item = (DataRowView)cboIngrediente.SelectedItem;
            int id = Convert.ToInt32(item.Row.ItemArray[0]);
            string nombre = item.Row.ItemArray[1].ToString();
            string unidad = item.Row.ItemArray[2].ToString();

            Ingrediente ingrediente = new Ingrediente(id,nombre,unidad);

            decimal cantidad = Convert.ToDecimal(txtCantidad.Text);
            DetalleReceta detalle = new DetalleReceta(ingrediente, cantidad);
            
            Receta.AgregarDetalle(detalle);

            dgvDetallesReceta.Rows.Add(new object[] {item.Row.ItemArray[0],item.Row.ItemArray[1], txtCantidad.Text});
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Receta.NomReceta = txtNomReceta.Text;
            Receta.Chef = txtChef.Text;
            Receta.TipoReceta = Convert.ToInt32(cboTipoReceta.SelectedValue);

            if (Helper.InsertarReceta(Receta))
            {
                MessageBox.Show("Se ha cargado correctamente la receta", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de que quieres cancelar?", "AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Question) 
                == DialogResult.Yes) this.Dispose();
        }

        private void dgvDetallesReceta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetallesReceta.CurrentCell.ColumnIndex == 3)
            {
                Receta.QuitarDetalle(dgvDetallesReceta.CurrentRow.Index);
                dgvDetallesReceta.Rows.Remove(dgvDetallesReceta.CurrentRow);

                CantidadIngredientes--;
                lblCantidadIngredientes.Text = CantidadIngredientes.ToString();

                if (CantidadIngredientes < 3) btnAceptar.Enabled = false;
                else btnAceptar.Enabled = true;
            }
        }
    }
}

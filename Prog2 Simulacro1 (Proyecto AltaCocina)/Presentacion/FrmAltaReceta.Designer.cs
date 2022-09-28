
namespace Prog2_Simulacro1__Proyecto_AltaCocina_.Presentacion
{
    partial class FrmAltaReceta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomReceta = new System.Windows.Forms.TextBox();
            this.lblReceta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChef = new System.Windows.Forms.TextBox();
            this.cboTipoReceta = new System.Windows.Forms.ComboBox();
            this.cboIngrediente = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgvDetallesReceta = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCantidadIngredientes = new System.Windows.Forms.Label();
            this.lblNroReceta = new System.Windows.Forms.Label();
            this.ColumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomReceta
            // 
            this.txtNomReceta.Location = new System.Drawing.Point(154, 53);
            this.txtNomReceta.Name = "txtNomReceta";
            this.txtNomReceta.Size = new System.Drawing.Size(361, 26);
            this.txtNomReceta.TabIndex = 0;
            // 
            // lblReceta
            // 
            this.lblReceta.AutoSize = true;
            this.lblReceta.Location = new System.Drawing.Point(150, 9);
            this.lblReceta.Name = "lblReceta";
            this.lblReceta.Size = new System.Drawing.Size(85, 20);
            this.lblReceta.TabIndex = 1;
            this.lblReceta.Text = "Receta N#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chef:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de receta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total de ingredientes:";
            // 
            // txtChef
            // 
            this.txtChef.Location = new System.Drawing.Point(154, 92);
            this.txtChef.Name = "txtChef";
            this.txtChef.Size = new System.Drawing.Size(361, 26);
            this.txtChef.TabIndex = 6;
            // 
            // cboTipoReceta
            // 
            this.cboTipoReceta.FormattingEnabled = true;
            this.cboTipoReceta.Location = new System.Drawing.Point(154, 135);
            this.cboTipoReceta.Name = "cboTipoReceta";
            this.cboTipoReceta.Size = new System.Drawing.Size(230, 28);
            this.cboTipoReceta.TabIndex = 7;
            // 
            // cboIngrediente
            // 
            this.cboIngrediente.FormattingEnabled = true;
            this.cboIngrediente.Location = new System.Drawing.Point(38, 204);
            this.cboIngrediente.Name = "cboIngrediente";
            this.cboIngrediente.Size = new System.Drawing.Size(230, 28);
            this.cboIngrediente.TabIndex = 8;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(274, 206);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(161, 26);
            this.txtCantidad.TabIndex = 9;
            // 
            // dgvDetallesReceta
            // 
            this.dgvDetallesReceta.AllowUserToAddRows = false;
            this.dgvDetallesReceta.AllowUserToDeleteRows = false;
            this.dgvDetallesReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumID,
            this.ColumIngrediente,
            this.ColumCantidad,
            this.ColumAcciones});
            this.dgvDetallesReceta.Location = new System.Drawing.Point(38, 238);
            this.dgvDetallesReceta.Name = "dgvDetallesReceta";
            this.dgvDetallesReceta.ReadOnly = true;
            this.dgvDetallesReceta.RowHeadersWidth = 62;
            this.dgvDetallesReceta.RowTemplate.Height = 28;
            this.dgvDetallesReceta.Size = new System.Drawing.Size(554, 150);
            this.dgvDetallesReceta.TabIndex = 10;
            this.dgvDetallesReceta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallesReceta_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(441, 195);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 37);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(149, 433);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(151, 41);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(306, 433);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(151, 41);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCantidadIngredientes
            // 
            this.lblCantidadIngredientes.AutoSize = true;
            this.lblCantidadIngredientes.Location = new System.Drawing.Point(535, 391);
            this.lblCantidadIngredientes.Name = "lblCantidadIngredientes";
            this.lblCantidadIngredientes.Size = new System.Drawing.Size(18, 20);
            this.lblCantidadIngredientes.TabIndex = 14;
            this.lblCantidadIngredientes.Text = "0";
            // 
            // lblNroReceta
            // 
            this.lblNroReceta.AutoSize = true;
            this.lblNroReceta.Location = new System.Drawing.Point(241, 9);
            this.lblNroReceta.Name = "lblNroReceta";
            this.lblNroReceta.Size = new System.Drawing.Size(18, 20);
            this.lblNroReceta.TabIndex = 15;
            this.lblNroReceta.Text = "0";
            // 
            // ColumID
            // 
            this.ColumID.HeaderText = "ID";
            this.ColumID.MinimumWidth = 8;
            this.ColumID.Name = "ColumID";
            this.ColumID.ReadOnly = true;
            this.ColumID.Visible = false;
            this.ColumID.Width = 150;
            // 
            // ColumIngrediente
            // 
            this.ColumIngrediente.HeaderText = "Ingrediente";
            this.ColumIngrediente.MinimumWidth = 8;
            this.ColumIngrediente.Name = "ColumIngrediente";
            this.ColumIngrediente.ReadOnly = true;
            this.ColumIngrediente.Width = 140;
            // 
            // ColumCantidad
            // 
            this.ColumCantidad.HeaderText = "Cantidad";
            this.ColumCantidad.MinimumWidth = 8;
            this.ColumCantidad.Name = "ColumCantidad";
            this.ColumCantidad.ReadOnly = true;
            this.ColumCantidad.Width = 70;
            // 
            // ColumAcciones
            // 
            this.ColumAcciones.HeaderText = "Acciones";
            this.ColumAcciones.MinimumWidth = 8;
            this.ColumAcciones.Name = "ColumAcciones";
            this.ColumAcciones.ReadOnly = true;
            this.ColumAcciones.Text = "Borrar";
            this.ColumAcciones.UseColumnTextForButtonValue = true;
            this.ColumAcciones.Width = 120;
            // 
            // FrmAltaReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 486);
            this.Controls.Add(this.lblNroReceta);
            this.Controls.Add(this.lblCantidadIngredientes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDetallesReceta);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cboIngrediente);
            this.Controls.Add(this.cboTipoReceta);
            this.Controls.Add(this.txtChef);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReceta);
            this.Controls.Add(this.txtNomReceta);
            this.Name = "FrmAltaReceta";
            this.Text = "Alta de receta";
            this.Load += new System.EventHandler(this.FrmAltaReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesReceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomReceta;
        private System.Windows.Forms.Label lblReceta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChef;
        private System.Windows.Forms.ComboBox cboTipoReceta;
        private System.Windows.Forms.ComboBox cboIngrediente;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvDetallesReceta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCantidadIngredientes;
        private System.Windows.Forms.Label lblNroReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn ColumAcciones;
    }
}
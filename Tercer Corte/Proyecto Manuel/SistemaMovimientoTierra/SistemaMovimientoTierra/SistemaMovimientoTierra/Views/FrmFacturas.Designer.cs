namespace SistemaMovimientoTierra.Views
{
    partial class FrmFacturas
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbDatosFactura = new System.Windows.Forms.GroupBox();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVerFactura = new System.Windows.Forms.Button();
            this.btnGuardarFactura = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCotizacion = new System.Windows.Forms.ComboBox();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.lblIdFactura = new System.Windows.Forms.Label();
            this.gbListaFacturas = new System.Windows.Forms.GroupBox();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminarFactura = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            this.gbDatosFactura.SuspendLayout();
            this.gbListaFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.pnlSuperior.Controls.Add(this.lblTitulo);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1144, 90);
            this.pnlSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1144, 90);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "FACTURAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbDatosFactura
            // 
            this.gbDatosFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbDatosFactura.Controls.Add(this.btnCambiarEstado);
            this.gbDatosFactura.Controls.Add(this.btnLimpiar);
            this.gbDatosFactura.Controls.Add(this.btnVerFactura);
            this.gbDatosFactura.Controls.Add(this.btnGuardarFactura);
            this.gbDatosFactura.Controls.Add(this.txtObservacion);
            this.gbDatosFactura.Controls.Add(this.lblObservacion);
            this.gbDatosFactura.Controls.Add(this.cmbEstado);
            this.gbDatosFactura.Controls.Add(this.lblEstado);
            this.gbDatosFactura.Controls.Add(this.txtCliente);
            this.gbDatosFactura.Controls.Add(this.lblCliente);
            this.gbDatosFactura.Controls.Add(this.cmbCotizacion);
            this.gbDatosFactura.Controls.Add(this.lblCotizacion);
            this.gbDatosFactura.Controls.Add(this.txtIdFactura);
            this.gbDatosFactura.Controls.Add(this.lblIdFactura);
            this.gbDatosFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosFactura.Location = new System.Drawing.Point(12, 115);
            this.gbDatosFactura.Name = "gbDatosFactura";
            this.gbDatosFactura.Size = new System.Drawing.Size(380, 513);
            this.gbDatosFactura.TabIndex = 1;
            this.gbDatosFactura.TabStop = false;
            this.gbDatosFactura.Text = "Datos de factura";
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCambiarEstado.FlatAppearance.BorderSize = 0;
            this.btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstado.ForeColor = System.Drawing.Color.White;
            this.btnCambiarEstado.Location = new System.Drawing.Point(107, 374);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(267, 52);
            this.btnCambiarEstado.TabIndex = 13;
            this.btnCambiarEstado.Text = "Cambiar estado";
            this.btnCambiarEstado.UseVisualStyleBackColor = false;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(107, 432);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(267, 52);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVerFactura
            // 
            this.btnVerFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnVerFactura.FlatAppearance.BorderSize = 0;
            this.btnVerFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerFactura.ForeColor = System.Drawing.Color.White;
            this.btnVerFactura.Location = new System.Drawing.Point(107, 316);
            this.btnVerFactura.Name = "btnVerFactura";
            this.btnVerFactura.Size = new System.Drawing.Size(267, 52);
            this.btnVerFactura.TabIndex = 11;
            this.btnVerFactura.Text = "Ver factura";
            this.btnVerFactura.UseVisualStyleBackColor = false;
            this.btnVerFactura.Click += new System.EventHandler(this.btnVerFactura_Click);
            // 
            // btnGuardarFactura
            // 
            this.btnGuardarFactura.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarFactura.FlatAppearance.BorderSize = 0;
            this.btnGuardarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarFactura.ForeColor = System.Drawing.Color.White;
            this.btnGuardarFactura.Location = new System.Drawing.Point(107, 258);
            this.btnGuardarFactura.Name = "btnGuardarFactura";
            this.btnGuardarFactura.Size = new System.Drawing.Size(267, 52);
            this.btnGuardarFactura.TabIndex = 10;
            this.btnGuardarFactura.Text = "Guardar factura";
            this.btnGuardarFactura.UseVisualStyleBackColor = false;
            this.btnGuardarFactura.Click += new System.EventHandler(this.btnGuardarFactura_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(107, 218);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(267, 34);
            this.txtObservacion.TabIndex = 9;
            // 
            // lblObservacion
            // 
            this.lblObservacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.Location = new System.Drawing.Point(6, 218);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(206, 34);
            this.lblObservacion.TabIndex = 8;
            this.lblObservacion.Text = "Observación:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(107, 176);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(267, 36);
            this.cmbEstado.TabIndex = 7;
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(39, 179);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(206, 34);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(107, 136);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(267, 34);
            this.txtCliente.TabIndex = 5;
            // 
            // lblCliente
            // 
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(39, 136);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(206, 34);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente:";
            // 
            // cmbCotizacion
            // 
            this.cmbCotizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCotizacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCotizacion.FormattingEnabled = true;
            this.cmbCotizacion.Location = new System.Drawing.Point(107, 94);
            this.cmbCotizacion.Name = "cmbCotizacion";
            this.cmbCotizacion.Size = new System.Drawing.Size(267, 36);
            this.cmbCotizacion.TabIndex = 3;
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizacion.Location = new System.Drawing.Point(18, 97);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(206, 34);
            this.lblCotizacion.TabIndex = 2;
            this.lblCotizacion.Text = "Cotización:";
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFactura.Location = new System.Drawing.Point(107, 52);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(267, 34);
            this.txtIdFactura.TabIndex = 1;
            // 
            // lblIdFactura
            // 
            this.lblIdFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdFactura.Location = new System.Drawing.Point(18, 52);
            this.lblIdFactura.Name = "lblIdFactura";
            this.lblIdFactura.Size = new System.Drawing.Size(206, 34);
            this.lblIdFactura.TabIndex = 0;
            this.lblIdFactura.Text = "ID Factura:";
            // 
            // gbListaFacturas
            // 
            this.gbListaFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbListaFacturas.Controls.Add(this.dgvFacturas);
            this.gbListaFacturas.Controls.Add(this.btnBuscar);
            this.gbListaFacturas.Controls.Add(this.txtBuscar);
            this.gbListaFacturas.Controls.Add(this.lblBuscar);
            this.gbListaFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbListaFacturas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListaFacturas.Location = new System.Drawing.Point(410, 115);
            this.gbListaFacturas.Name = "gbListaFacturas";
            this.gbListaFacturas.Size = new System.Drawing.Size(632, 459);
            this.gbListaFacturas.TabIndex = 2;
            this.gbListaFacturas.TabStop = false;
            this.gbListaFacturas.Text = "Lista de facturas";
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(15, 97);
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersVisible = false;
            this.dgvFacturas.RowHeadersWidth = 62;
            this.dgvFacturas.RowTemplate.Height = 28;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(599, 329);
            this.dgvFacturas.TabIndex = 21;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(409, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 31);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(101, 49);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(277, 34);
            this.txtBuscar.TabIndex = 19;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(23, 52);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(72, 28);
            this.lblBuscar.TabIndex = 18;
            this.lblBuscar.Text = "Buscar:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.DimGray;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(848, 580);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(185, 48);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminarFactura
            // 
            this.btnEliminarFactura.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarFactura.FlatAppearance.BorderSize = 0;
            this.btnEliminarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFactura.ForeColor = System.Drawing.Color.White;
            this.btnEliminarFactura.Location = new System.Drawing.Point(632, 580);
            this.btnEliminarFactura.Name = "btnEliminarFactura";
            this.btnEliminarFactura.Size = new System.Drawing.Size(185, 48);
            this.btnEliminarFactura.TabIndex = 24;
            this.btnEliminarFactura.Text = "Eliminar";
            this.btnEliminarFactura.UseVisualStyleBackColor = false;
            this.btnEliminarFactura.Click += new System.EventHandler(this.btnEliminarFactura_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Gray;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(410, 580);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(185, 48);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 713);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminarFactura);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gbListaFacturas);
            this.Controls.Add(this.gbDatosFactura);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FrmFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.FrmFacturas_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.gbDatosFactura.ResumeLayout(false);
            this.gbDatosFactura.PerformLayout();
            this.gbListaFacturas.ResumeLayout(false);
            this.gbListaFacturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbDatosFactura;
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.Label lblIdFactura;
        private System.Windows.Forms.ComboBox cmbCotizacion;
        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnGuardarFactura;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVerFactura;
        private System.Windows.Forms.GroupBox gbListaFacturas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminarFactura;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCambiarEstado;
    }
}
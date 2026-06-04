namespace SistemaMovimientoTierra.Views
{
    partial class FrmMateriales
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
            this.gbDatosMaterial = new System.Windows.Forms.GroupBox();
            this.lblIdMaterial = new System.Windows.Forms.Label();
            this.txtIdMaterial = new System.Windows.Forms.TextBox();
            this.txtNombreMaterial = new System.Windows.Forms.TextBox();
            this.lblNombreMaterial = new System.Windows.Forms.Label();
            this.lblTipoMaterial = new System.Windows.Forms.Label();
            this.cmbTipoMaterial = new System.Windows.Forms.ComboBox();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardarMaterial = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbListaMateriales = new System.Windows.Forms.GroupBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminarMaterial = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            this.gbDatosMaterial.SuspendLayout();
            this.gbListaMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.pnlSuperior.Controls.Add(this.lblTitulo);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1437, 90);
            this.pnlSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1437, 90);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GESTIÓN DE MATERIALES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbDatosMaterial
            // 
            this.gbDatosMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbDatosMaterial.Controls.Add(this.btnLimpiar);
            this.gbDatosMaterial.Controls.Add(this.btnGuardarMaterial);
            this.gbDatosMaterial.Controls.Add(this.txtDescripcion);
            this.gbDatosMaterial.Controls.Add(this.lblDescripcion);
            this.gbDatosMaterial.Controls.Add(this.cmbEstado);
            this.gbDatosMaterial.Controls.Add(this.lblEstado);
            this.gbDatosMaterial.Controls.Add(this.txtPrecioUnitario);
            this.gbDatosMaterial.Controls.Add(this.lblPrecioUnitario);
            this.gbDatosMaterial.Controls.Add(this.cmbUnidadMedida);
            this.gbDatosMaterial.Controls.Add(this.lblUnidadMedida);
            this.gbDatosMaterial.Controls.Add(this.cmbTipoMaterial);
            this.gbDatosMaterial.Controls.Add(this.lblTipoMaterial);
            this.gbDatosMaterial.Controls.Add(this.txtNombreMaterial);
            this.gbDatosMaterial.Controls.Add(this.lblNombreMaterial);
            this.gbDatosMaterial.Controls.Add(this.txtIdMaterial);
            this.gbDatosMaterial.Controls.Add(this.lblIdMaterial);
            this.gbDatosMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosMaterial.Location = new System.Drawing.Point(30, 120);
            this.gbDatosMaterial.Name = "gbDatosMaterial";
            this.gbDatosMaterial.Size = new System.Drawing.Size(380, 456);
            this.gbDatosMaterial.TabIndex = 1;
            this.gbDatosMaterial.TabStop = false;
            this.gbDatosMaterial.Text = "Datos del material";
            // 
            // lblIdMaterial
            // 
            this.lblIdMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMaterial.Location = new System.Drawing.Point(30, 45);
            this.lblIdMaterial.Name = "lblIdMaterial";
            this.lblIdMaterial.Size = new System.Drawing.Size(130, 25);
            this.lblIdMaterial.TabIndex = 0;
            this.lblIdMaterial.Text = "ID Material:";
            // 
            // txtIdMaterial
            // 
            this.txtIdMaterial.BackColor = System.Drawing.Color.White;
            this.txtIdMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMaterial.Location = new System.Drawing.Point(114, 42);
            this.txtIdMaterial.Name = "txtIdMaterial";
            this.txtIdMaterial.ReadOnly = true;
            this.txtIdMaterial.Size = new System.Drawing.Size(208, 34);
            this.txtIdMaterial.TabIndex = 1;
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.BackColor = System.Drawing.Color.White;
            this.txtNombreMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMaterial.Location = new System.Drawing.Point(114, 82);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.ReadOnly = true;
            this.txtNombreMaterial.Size = new System.Drawing.Size(208, 34);
            this.txtNombreMaterial.TabIndex = 3;
            this.txtNombreMaterial.TabStop = false;
            // 
            // lblNombreMaterial
            // 
            this.lblNombreMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMaterial.Location = new System.Drawing.Point(48, 85);
            this.lblNombreMaterial.Name = "lblNombreMaterial";
            this.lblNombreMaterial.Size = new System.Drawing.Size(130, 25);
            this.lblNombreMaterial.TabIndex = 2;
            this.lblNombreMaterial.Text = "Nombre:";
            // 
            // lblTipoMaterial
            // 
            this.lblTipoMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMaterial.Location = new System.Drawing.Point(19, 125);
            this.lblTipoMaterial.Name = "lblTipoMaterial";
            this.lblTipoMaterial.Size = new System.Drawing.Size(130, 25);
            this.lblTipoMaterial.TabIndex = 4;
            this.lblTipoMaterial.Text = "Tipo material:";
            // 
            // cmbTipoMaterial
            // 
            this.cmbTipoMaterial.BackColor = System.Drawing.Color.White;
            this.cmbTipoMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoMaterial.FormattingEnabled = true;
            this.cmbTipoMaterial.Items.AddRange(new object[] {
            "Agregado",
            "Tierra",
            "Escombro",
            "Relleno",
            "Transporte",
            "Otro"});
            this.cmbTipoMaterial.Location = new System.Drawing.Point(114, 122);
            this.cmbTipoMaterial.Name = "cmbTipoMaterial";
            this.cmbTipoMaterial.Size = new System.Drawing.Size(208, 36);
            this.cmbTipoMaterial.TabIndex = 5;
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.BackColor = System.Drawing.Color.White;
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Items.AddRange(new object[] {
            "m³",
            "Tonelada",
            "Viaje",
            "Unidad",
            "Kg"});
            this.cmbUnidadMedida.Location = new System.Drawing.Point(114, 164);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(208, 36);
            this.cmbUnidadMedida.TabIndex = 7;
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.Location = new System.Drawing.Point(57, 167);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(130, 25);
            this.lblUnidadMedida.TabIndex = 6;
            this.lblUnidadMedida.Text = "Unidad:";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.BackColor = System.Drawing.Color.White;
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(114, 206);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(208, 34);
            this.txtPrecioUnitario.TabIndex = 9;
            this.txtPrecioUnitario.TabStop = false;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(6, 209);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(130, 25);
            this.lblPrecioUnitario.TabIndex = 8;
            this.lblPrecioUnitario.Text = "Precio unitario:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.White;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(114, 246);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(208, 36);
            this.cmbEstado.TabIndex = 11;
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(57, 249);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(130, 25);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(30, 291);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(130, 25);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(114, 288);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(208, 34);
            this.txtDescripcion.TabIndex = 13;
            this.txtDescripcion.TabStop = false;
            // 
            // btnGuardarMaterial
            // 
            this.btnGuardarMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnGuardarMaterial.FlatAppearance.BorderSize = 0;
            this.btnGuardarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnGuardarMaterial.Location = new System.Drawing.Point(114, 328);
            this.btnGuardarMaterial.Name = "btnGuardarMaterial";
            this.btnGuardarMaterial.Size = new System.Drawing.Size(208, 39);
            this.btnGuardarMaterial.TabIndex = 14;
            this.btnGuardarMaterial.Text = "Guardar";
            this.btnGuardarMaterial.UseVisualStyleBackColor = false;
            this.btnGuardarMaterial.Click += new System.EventHandler(this.btnGuardarMaterial_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(114, 373);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(208, 39);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gbListaMateriales
            // 
            this.gbListaMateriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbListaMateriales.Controls.Add(this.btnCerrar);
            this.gbListaMateriales.Controls.Add(this.btnEliminarMaterial);
            this.gbListaMateriales.Controls.Add(this.btnActualizar);
            this.gbListaMateriales.Controls.Add(this.dgvMateriales);
            this.gbListaMateriales.Controls.Add(this.btnBuscar);
            this.gbListaMateriales.Controls.Add(this.txtBuscar);
            this.gbListaMateriales.Controls.Add(this.lblBuscar);
            this.gbListaMateriales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListaMateriales.Location = new System.Drawing.Point(440, 120);
            this.gbListaMateriales.Name = "gbListaMateriales";
            this.gbListaMateriales.Size = new System.Drawing.Size(620, 456);
            this.gbListaMateriales.TabIndex = 2;
            this.gbListaMateriales.TabStop = false;
            this.gbListaMateriales.Text = "Lista de materiales";
            // 
            // lblBuscar
            // 
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(49, 54);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(130, 25);
            this.lblBuscar.TabIndex = 16;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(108, 51);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.ReadOnly = true;
            this.txtBuscar.Size = new System.Drawing.Size(250, 34);
            this.txtBuscar.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(364, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(167, 25);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.AllowUserToAddRows = false;
            this.dgvMateriales.AllowUserToDeleteRows = false;
            this.dgvMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateriales.BackgroundColor = System.Drawing.Color.White;
            this.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMateriales.Location = new System.Drawing.Point(30, 109);
            this.dgvMateriales.MultiSelect = false;
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.ReadOnly = true;
            this.dgvMateriales.RowHeadersVisible = false;
            this.dgvMateriales.RowHeadersWidth = 62;
            this.dgvMateriales.RowTemplate.Height = 28;
            this.dgvMateriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriales.Size = new System.Drawing.Size(560, 270);
            this.dgvMateriales.TabIndex = 17;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Gray;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(30, 394);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(166, 39);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminarMaterial
            // 
            this.btnEliminarMaterial.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarMaterial.FlatAppearance.BorderSize = 0;
            this.btnEliminarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnEliminarMaterial.Location = new System.Drawing.Point(229, 394);
            this.btnEliminarMaterial.Name = "btnEliminarMaterial";
            this.btnEliminarMaterial.Size = new System.Drawing.Size(166, 39);
            this.btnEliminarMaterial.TabIndex = 18;
            this.btnEliminarMaterial.Text = "Eliminar";
            this.btnEliminarMaterial.UseVisualStyleBackColor = false;
            this.btnEliminarMaterial.Click += new System.EventHandler(this.btnEliminarMaterial_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Gray;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(424, 394);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(166, 39);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1437, 742);
            this.Controls.Add(this.gbListaMateriales);
            this.Controls.Add(this.gbDatosMaterial);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMateriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de materiales";
            this.Load += new System.EventHandler(this.FrmMateriales_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.gbDatosMaterial.ResumeLayout(false);
            this.gbDatosMaterial.PerformLayout();
            this.gbListaMateriales.ResumeLayout(false);
            this.gbListaMateriales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbDatosMaterial;
        private System.Windows.Forms.TextBox txtIdMaterial;
        private System.Windows.Forms.Label lblIdMaterial;
        private System.Windows.Forms.TextBox txtNombreMaterial;
        private System.Windows.Forms.Label lblNombreMaterial;
        private System.Windows.Forms.ComboBox cmbTipoMaterial;
        private System.Windows.Forms.Label lblTipoMaterial;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnGuardarMaterial;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gbListaMateriales;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminarMaterial;
    }
}
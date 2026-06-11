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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardarMaterial = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.cmbTipoMaterial = new System.Windows.Forms.ComboBox();
            this.lblTipoMaterial = new System.Windows.Forms.Label();
            this.txtNombreMaterial = new System.Windows.Forms.TextBox();
            this.lblNombreMaterial = new System.Windows.Forms.Label();
            this.txtIdMaterial = new System.Windows.Forms.TextBox();
            this.lblIdMaterial = new System.Windows.Forms.Label();
            this.gbListaMateriales = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminarMaterial = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlSuperior.SuspendLayout();
            this.gbDatosMaterial.SuspendLayout();
            this.gbListaMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.pnlSuperior.Controls.Add(this.lblTitulo);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1370, 90);
            this.pnlSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1370, 90);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GESTIÓN DE MATERIALES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbDatosMaterial
            // 
            this.gbDatosMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbDatosMaterial.Controls.Add(this.pictureBox2);
            this.gbDatosMaterial.Controls.Add(this.pictureBox1);
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
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(6, 291);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(102, 19);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripción:";
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
            this.cmbEstado.Size = new System.Drawing.Size(208, 25);
            this.cmbEstado.TabIndex = 11;
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(8, 249);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(89, 22);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado:";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.BackColor = System.Drawing.Color.White;
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(114, 206);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(208, 25);
            this.txtPrecioUnitario.TabIndex = 9;
            this.txtPrecioUnitario.TabStop = false;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(6, 209);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(112, 25);
            this.lblPrecioUnitario.TabIndex = 8;
            this.lblPrecioUnitario.Text = "Precio unitario:";
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
            this.cmbUnidadMedida.Size = new System.Drawing.Size(208, 25);
            this.cmbUnidadMedida.TabIndex = 7;
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.Location = new System.Drawing.Point(20, 164);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(88, 25);
            this.lblUnidadMedida.TabIndex = 6;
            this.lblUnidadMedida.Text = "Unidad:";
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
            this.cmbTipoMaterial.Size = new System.Drawing.Size(208, 25);
            this.cmbTipoMaterial.TabIndex = 5;
            // 
            // lblTipoMaterial
            // 
            this.lblTipoMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMaterial.Location = new System.Drawing.Point(19, 125);
            this.lblTipoMaterial.Name = "lblTipoMaterial";
            this.lblTipoMaterial.Size = new System.Drawing.Size(99, 22);
            this.lblTipoMaterial.TabIndex = 4;
            this.lblTipoMaterial.Text = "Tipo material:";
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.BackColor = System.Drawing.Color.White;
            this.txtNombreMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMaterial.Location = new System.Drawing.Point(114, 82);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.ReadOnly = true;
            this.txtNombreMaterial.Size = new System.Drawing.Size(208, 25);
            this.txtNombreMaterial.TabIndex = 3;
            this.txtNombreMaterial.TabStop = false;
            // 
            // lblNombreMaterial
            // 
            this.lblNombreMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMaterial.Location = new System.Drawing.Point(19, 85);
            this.lblNombreMaterial.Name = "lblNombreMaterial";
            this.lblNombreMaterial.Size = new System.Drawing.Size(78, 22);
            this.lblNombreMaterial.TabIndex = 2;
            this.lblNombreMaterial.Text = "Nombre:";
            // 
            // txtIdMaterial
            // 
            this.txtIdMaterial.BackColor = System.Drawing.Color.White;
            this.txtIdMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMaterial.Location = new System.Drawing.Point(114, 42);
            this.txtIdMaterial.Name = "txtIdMaterial";
            this.txtIdMaterial.ReadOnly = true;
            this.txtIdMaterial.Size = new System.Drawing.Size(208, 25);
            this.txtIdMaterial.TabIndex = 1;
            // 
            // lblIdMaterial
            // 
            this.lblIdMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMaterial.Location = new System.Drawing.Point(20, 42);
            this.lblIdMaterial.Name = "lblIdMaterial";
            this.lblIdMaterial.Size = new System.Drawing.Size(88, 25);
            this.lblIdMaterial.TabIndex = 0;
            this.lblIdMaterial.Text = "ID Material:";
            // 
            // gbListaMateriales
            // 
            this.gbListaMateriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbListaMateriales.BackgroundImage = global::SistemaMovimientoTierra.Properties.Resources.Imagen_del_login;
            this.gbListaMateriales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbListaMateriales.Controls.Add(this.pictureBox5);
            this.gbListaMateriales.Controls.Add(this.pictureBox4);
            this.gbListaMateriales.Controls.Add(this.pictureBox3);
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
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(108, 51);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.ReadOnly = true;
            this.txtBuscar.Size = new System.Drawing.Size(250, 25);
            this.txtBuscar.TabIndex = 16;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(49, 51);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(53, 25);
            this.lblBuscar.TabIndex = 16;
            this.lblBuscar.Text = "Buscar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.pictureBox1.Image = global::SistemaMovimientoTierra.Properties.Resources.guardar_datos;
            this.pictureBox1.Location = new System.Drawing.Point(114, 328);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.Image = global::SistemaMovimientoTierra.Properties.Resources.limpieza_de_datos;
            this.pictureBox2.Location = new System.Drawing.Point(114, 373);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gray;
            this.pictureBox3.Image = global::SistemaMovimientoTierra.Properties.Resources.Actualizar;
            this.pictureBox3.Location = new System.Drawing.Point(30, 394);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Firebrick;
            this.pictureBox4.Image = global::SistemaMovimientoTierra.Properties.Resources.eliminar;
            this.pictureBox4.Location = new System.Drawing.Point(229, 394);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Gray;
            this.pictureBox5.Image = global::SistemaMovimientoTierra.Properties.Resources.cerrar_sesion;
            this.pictureBox5.Location = new System.Drawing.Point(424, 394);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // FrmMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SistemaMovimientoTierra.Properties.Resources.fondo_proyecto;
            this.ClientSize = new System.Drawing.Size(1370, 742);
            this.Controls.Add(this.gbListaMateriales);
            this.Controls.Add(this.gbDatosMaterial);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
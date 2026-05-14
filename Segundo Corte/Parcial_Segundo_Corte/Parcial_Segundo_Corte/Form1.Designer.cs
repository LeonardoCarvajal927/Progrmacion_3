namespace Parcial_Segundo_Corte
{
    partial class FormPricipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTituloTechWord = new System.Windows.Forms.Label();
            this.picIconoTitulo = new System.Windows.Forms.PictureBox();
            this.tblPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.gbDatosEmpleados = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgEmpleados = new System.Windows.Forms.GroupBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dgvEmplados = new System.Windows.Forms.DataGridView();
            this.ClmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPrincipal.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoTitulo)).BeginInit();
            this.tblPrincipal.SuspendLayout();
            this.gbDatosEmpleados.SuspendLayout();
            this.dgEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmplados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlPrincipal.Controls.Add(this.pnlTitulo);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1157, 138);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitulo.Controls.Add(this.picIconoTitulo);
            this.pnlTitulo.Controls.Add(this.lblTituloTechWord);
            this.pnlTitulo.Location = new System.Drawing.Point(370, 21);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(390, 100);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTituloTechWord
            // 
            this.lblTituloTechWord.AutoSize = true;
            this.lblTituloTechWord.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTechWord.Location = new System.Drawing.Point(116, 14);
            this.lblTituloTechWord.Name = "lblTituloTechWord";
            this.lblTituloTechWord.Size = new System.Drawing.Size(269, 85);
            this.lblTituloTechWord.TabIndex = 0;
            this.lblTituloTechWord.Text = "TechWord";
            // 
            // picIconoTitulo
            // 
            this.picIconoTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIconoTitulo.Image = global::Parcial_Segundo_Corte.Properties.Resources.portafolio;
            this.picIconoTitulo.Location = new System.Drawing.Point(36, 14);
            this.picIconoTitulo.Name = "picIconoTitulo";
            this.picIconoTitulo.Size = new System.Drawing.Size(74, 71);
            this.picIconoTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconoTitulo.TabIndex = 1;
            this.picIconoTitulo.TabStop = false;
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.ColumnCount = 3;
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblPrincipal.Controls.Add(this.lblSubtitulo, 1, 0);
            this.tblPrincipal.Controls.Add(this.gbDatosEmpleados, 1, 1);
            this.tblPrincipal.Controls.Add(this.dgEmpleados, 1, 2);
            this.tblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrincipal.Location = new System.Drawing.Point(0, 138);
            this.tblPrincipal.Name = "tblPrincipal";
            this.tblPrincipal.RowCount = 3;
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblPrincipal.Size = new System.Drawing.Size(1157, 589);
            this.tblPrincipal.TabIndex = 1;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtitulo.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(60, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(1035, 44);
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "Sistema de registro y gestión de empleados";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbDatosEmpleados
            // 
            this.gbDatosEmpleados.Controls.Add(this.dtpFechaIngreso);
            this.gbDatosEmpleados.Controls.Add(this.btnLimpiar);
            this.gbDatosEmpleados.Controls.Add(this.btnEliminar);
            this.gbDatosEmpleados.Controls.Add(this.btnActualizar);
            this.gbDatosEmpleados.Controls.Add(this.btnGuardar);
            this.gbDatosEmpleados.Controls.Add(this.cmbEstado);
            this.gbDatosEmpleados.Controls.Add(this.txtSalario);
            this.gbDatosEmpleados.Controls.Add(this.cmbDepartamento);
            this.gbDatosEmpleados.Controls.Add(this.txtCargo);
            this.gbDatosEmpleados.Controls.Add(this.txtDocumento);
            this.gbDatosEmpleados.Controls.Add(this.txtApellido);
            this.gbDatosEmpleados.Controls.Add(this.txtNombre);
            this.gbDatosEmpleados.Controls.Add(this.txtID);
            this.gbDatosEmpleados.Controls.Add(this.lblEstado);
            this.gbDatosEmpleados.Controls.Add(this.lblSalario);
            this.gbDatosEmpleados.Controls.Add(this.lblDepartamento);
            this.gbDatosEmpleados.Controls.Add(this.lblCargo);
            this.gbDatosEmpleados.Controls.Add(this.lblFechaIngreso);
            this.gbDatosEmpleados.Controls.Add(this.lblDocumento);
            this.gbDatosEmpleados.Controls.Add(this.lblApellido);
            this.gbDatosEmpleados.Controls.Add(this.lblNombre);
            this.gbDatosEmpleados.Controls.Add(this.lblID);
            this.gbDatosEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDatosEmpleados.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosEmpleados.Location = new System.Drawing.Point(60, 50);
            this.gbDatosEmpleados.Name = "gbDatosEmpleados";
            this.gbDatosEmpleados.Size = new System.Drawing.Size(1035, 300);
            this.gbDatosEmpleados.TabIndex = 1;
            this.gbDatosEmpleados.TabStop = false;
            this.gbDatosEmpleados.Text = "Datos de Empreados";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(112, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(38, 36);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(58, 92);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 36);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(58, 138);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(93, 36);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(6, 182);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(150, 36);
            this.lblDocumento.TabIndex = 3;
            this.lblDocumento.Text = "N° Documento:";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(48, 225);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(103, 36);
            this.lblFechaIngreso.TabIndex = 4;
            this.lblFechaIngreso.Text = "F. Ingreso:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(527, 50);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(72, 36);
            this.lblCargo.TabIndex = 5;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(453, 90);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(146, 36);
            this.lblDepartamento.TabIndex = 6;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(520, 136);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(79, 36);
            this.lblSalario.TabIndex = 7;
            this.lblSalario.Text = "Salario:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(520, 184);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(78, 36);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(163, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(271, 38);
            this.txtID.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(271, 38);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(163, 137);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(271, 38);
            this.txtApellido.TabIndex = 11;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(163, 180);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(271, 38);
            this.txtDocumento.TabIndex = 12;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(605, 48);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(271, 38);
            this.txtCargo.TabIndex = 14;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Items.AddRange(new object[] {
            "Tecnologia",
            "Diseñador",
            "Analista",
            "Contabilidad"});
            this.cmbDepartamento.Location = new System.Drawing.Point(605, 91);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(271, 37);
            this.cmbDepartamento.TabIndex = 15;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(605, 136);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(271, 38);
            this.txtSalario.TabIndex = 16;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(605, 183);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(271, 37);
            this.cmbEstado.TabIndex = 17;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(490, 244);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 50);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Lime;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(617, 244);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(121, 50);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(744, 244);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 50);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(871, 244);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 50);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.Controls.Add(this.dgvEmplados);
            this.dgEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEmpleados.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgEmpleados.Location = new System.Drawing.Point(60, 356);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.Size = new System.Drawing.Size(1035, 230);
            this.dgEmpleados.TabIndex = 2;
            this.dgEmpleados.TabStop = false;
            this.dgEmpleados.Text = "Listas De Empleados";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(163, 225);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(271, 38);
            this.dtpFechaIngreso.TabIndex = 22;
            // 
            // dgvEmplados
            // 
            this.dgvEmplados.AllowUserToAddRows = false;
            this.dgvEmplados.AllowUserToDeleteRows = false;
            this.dgvEmplados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmplados.ColumnHeadersHeight = 34;
            this.dgvEmplados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmplados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmId,
            this.clmNombre,
            this.clmApellido,
            this.ClmDocumento,
            this.clmCargo,
            this.clmDepartamento,
            this.clmFecha,
            this.clmIngreso,
            this.clmSalario,
            this.clmEstado});
            this.dgvEmplados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmplados.Location = new System.Drawing.Point(3, 34);
            this.dgvEmplados.Name = "dgvEmplados";
            this.dgvEmplados.ReadOnly = true;
            this.dgvEmplados.RowHeadersVisible = false;
            this.dgvEmplados.RowHeadersWidth = 62;
            this.dgvEmplados.RowTemplate.Height = 28;
            this.dgvEmplados.Size = new System.Drawing.Size(1029, 193);
            this.dgvEmplados.TabIndex = 0;
            this.dgvEmplados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmplados_CellContentClick);
            // 
            // ClmId
            // 
            this.ClmId.HeaderText = "ID";
            this.ClmId.MinimumWidth = 8;
            this.ClmId.Name = "ClmId";
            this.ClmId.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.MinimumWidth = 8;
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmApellido
            // 
            this.clmApellido.HeaderText = "Apellido";
            this.clmApellido.MinimumWidth = 8;
            this.clmApellido.Name = "clmApellido";
            this.clmApellido.ReadOnly = true;
            // 
            // ClmDocumento
            // 
            this.ClmDocumento.HeaderText = "N° Documento";
            this.ClmDocumento.MinimumWidth = 8;
            this.ClmDocumento.Name = "ClmDocumento";
            this.ClmDocumento.ReadOnly = true;
            // 
            // clmCargo
            // 
            this.clmCargo.HeaderText = "Cargo";
            this.clmCargo.MinimumWidth = 8;
            this.clmCargo.Name = "clmCargo";
            this.clmCargo.ReadOnly = true;
            // 
            // clmDepartamento
            // 
            this.clmDepartamento.HeaderText = "Departamento";
            this.clmDepartamento.MinimumWidth = 8;
            this.clmDepartamento.Name = "clmDepartamento";
            this.clmDepartamento.ReadOnly = true;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "F. Ingreso";
            this.clmFecha.MinimumWidth = 8;
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            // 
            // clmIngreso
            // 
            this.clmIngreso.HeaderText = "Ingreso";
            this.clmIngreso.MinimumWidth = 8;
            this.clmIngreso.Name = "clmIngreso";
            this.clmIngreso.ReadOnly = true;
            // 
            // clmSalario
            // 
            this.clmSalario.HeaderText = "Salario";
            this.clmSalario.MinimumWidth = 8;
            this.clmSalario.Name = "clmSalario";
            this.clmSalario.ReadOnly = true;
            // 
            // clmEstado
            // 
            this.clmEstado.HeaderText = "Estado";
            this.clmEstado.MinimumWidth = 8;
            this.clmEstado.Name = "clmEstado";
            this.clmEstado.ReadOnly = true;
            // 
            // FormPricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1157, 727);
            this.Controls.Add(this.tblPrincipal);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "FormPricipal";
            this.Text = "Sisteam de Empreados ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoTitulo)).EndInit();
            this.tblPrincipal.ResumeLayout(false);
            this.gbDatosEmpleados.ResumeLayout(false);
            this.gbDatosEmpleados.PerformLayout();
            this.dgEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmplados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox picIconoTitulo;
        private System.Windows.Forms.Label lblTituloTechWord;
        private System.Windows.Forms.TableLayoutPanel tblPrincipal;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.GroupBox gbDatosEmpleados;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox dgEmpleados;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.DataGridView dgvEmplados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
    }
}


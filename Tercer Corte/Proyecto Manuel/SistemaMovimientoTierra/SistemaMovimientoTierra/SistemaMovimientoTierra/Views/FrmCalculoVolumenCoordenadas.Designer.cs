namespace SistemaMovimientoTierra.Views
{
    partial class FrmCalculoVolumenCoordenadas
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
            this.gbConfiguracion = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtH = new System.Windows.Forms.TextBox();
            this.lblH = new System.Windows.Forms.Label();
            this.txtDy = new System.Windows.Forms.TextBox();
            this.lblDy = new System.Windows.Forms.Label();
            this.txtDx = new System.Windows.Forms.TextBox();
            this.lblDx = new System.Windows.Forms.Label();
            this.txtCantidadPuntos = new System.Windows.Forms.TextBox();
            this.lblCantidadPuntos = new System.Windows.Forms.Label();
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.gbCoordenadas = new System.Windows.Forms.GroupBox();
            this.btnGenerarAleatorio = new System.Windows.Forms.Button();
            this.btnAgregarPunto = new System.Windows.Forms.Button();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.lblZ = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnGrafica3D = new System.Windows.Forms.Button();
            this.dgvCoordenadas = new System.Windows.Forms.DataGridView();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.lblMetodoResultado = new System.Windows.Forms.Label();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.lblTextoVolumen = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.btnGuardarCalculo = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            this.gbConfiguracion.SuspendLayout();
            this.gbCoordenadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordenadas)).BeginInit();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.pnlSuperior.Controls.Add(this.lblTitulo);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1501, 90);
            this.pnlSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1501, 90);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CÁLCULO DE VOLUMEN";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbConfiguracion
            // 
            this.gbConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbConfiguracion.Controls.Add(this.btnGuardarCalculo);
            this.gbConfiguracion.Controls.Add(this.txtPrecioUnitario);
            this.gbConfiguracion.Controls.Add(this.lblPrecioUnitario);
            this.gbConfiguracion.Controls.Add(this.cmbMaterial);
            this.gbConfiguracion.Controls.Add(this.lblMaterial);
            this.gbConfiguracion.Controls.Add(this.cmbCliente);
            this.gbConfiguracion.Controls.Add(this.lblCliente);
            this.gbConfiguracion.Controls.Add(this.btnCerrar);
            this.gbConfiguracion.Controls.Add(this.btnLimpiar);
            this.gbConfiguracion.Controls.Add(this.txtH);
            this.gbConfiguracion.Controls.Add(this.lblH);
            this.gbConfiguracion.Controls.Add(this.txtDy);
            this.gbConfiguracion.Controls.Add(this.lblDy);
            this.gbConfiguracion.Controls.Add(this.txtDx);
            this.gbConfiguracion.Controls.Add(this.lblDx);
            this.gbConfiguracion.Controls.Add(this.txtCantidadPuntos);
            this.gbConfiguracion.Controls.Add(this.lblCantidadPuntos);
            this.gbConfiguracion.Controls.Add(this.cmbMetodo);
            this.gbConfiguracion.Controls.Add(this.lblMetodo);
            this.gbConfiguracion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConfiguracion.Location = new System.Drawing.Point(13, 112);
            this.gbConfiguracion.Name = "gbConfiguracion";
            this.gbConfiguracion.Size = new System.Drawing.Size(424, 518);
            this.gbConfiguracion.TabIndex = 1;
            this.gbConfiguracion.TabStop = false;
            this.gbConfiguracion.Text = "Configuración del cálculo";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(121, 465);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(226, 46);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(121, 413);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(226, 46);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtH.Location = new System.Drawing.Point(121, 321);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(226, 34);
            this.txtH.TabIndex = 17;
            // 
            // lblH
            // 
            this.lblH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(65, 324);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(102, 28);
            this.lblH.TabIndex = 16;
            this.lblH.Text = "h corte:";
            // 
            // txtDy
            // 
            this.txtDy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDy.Location = new System.Drawing.Point(121, 281);
            this.txtDy.Name = "txtDy";
            this.txtDy.Size = new System.Drawing.Size(226, 34);
            this.txtDy.TabIndex = 15;
            // 
            // lblDy
            // 
            this.lblDy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDy.Location = new System.Drawing.Point(88, 284);
            this.lblDy.Name = "lblDy";
            this.lblDy.Size = new System.Drawing.Size(102, 28);
            this.lblDy.TabIndex = 14;
            this.lblDy.Text = "dy:";
            // 
            // txtDx
            // 
            this.txtDx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDx.Location = new System.Drawing.Point(121, 241);
            this.txtDx.Name = "txtDx";
            this.txtDx.Size = new System.Drawing.Size(226, 34);
            this.txtDx.TabIndex = 13;
            // 
            // lblDx
            // 
            this.lblDx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDx.Location = new System.Drawing.Point(88, 244);
            this.lblDx.Name = "lblDx";
            this.lblDx.Size = new System.Drawing.Size(102, 28);
            this.lblDx.TabIndex = 12;
            this.lblDx.Text = "dx:";
            // 
            // txtCantidadPuntos
            // 
            this.txtCantidadPuntos.Location = new System.Drawing.Point(121, 201);
            this.txtCantidadPuntos.Name = "txtCantidadPuntos";
            this.txtCantidadPuntos.Size = new System.Drawing.Size(226, 34);
            this.txtCantidadPuntos.TabIndex = 5;
            // 
            // lblCantidadPuntos
            // 
            this.lblCantidadPuntos.AutoSize = true;
            this.lblCantidadPuntos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPuntos.Location = new System.Drawing.Point(22, 204);
            this.lblCantidadPuntos.Name = "lblCantidadPuntos";
            this.lblCantidadPuntos.Size = new System.Drawing.Size(126, 28);
            this.lblCantidadPuntos.TabIndex = 4;
            this.lblCantidadPuntos.Text = "Cant. puntos:";
            // 
            // cmbMetodo
            // 
            this.cmbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMetodo.FormattingEnabled = true;
            this.cmbMetodo.Location = new System.Drawing.Point(121, 159);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(226, 36);
            this.cmbMetodo.TabIndex = 3;
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodo.Location = new System.Drawing.Point(51, 162);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(87, 28);
            this.lblMetodo.TabIndex = 2;
            this.lblMetodo.Text = "Método:";
            // 
            // gbCoordenadas
            // 
            this.gbCoordenadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbCoordenadas.Controls.Add(this.btnGenerarAleatorio);
            this.gbCoordenadas.Controls.Add(this.btnAgregarPunto);
            this.gbCoordenadas.Controls.Add(this.txtZ);
            this.gbCoordenadas.Controls.Add(this.lblZ);
            this.gbCoordenadas.Controls.Add(this.txtY);
            this.gbCoordenadas.Controls.Add(this.lblY);
            this.gbCoordenadas.Controls.Add(this.txtX);
            this.gbCoordenadas.Controls.Add(this.lblX);
            this.gbCoordenadas.Controls.Add(this.btnCalcular);
            this.gbCoordenadas.Controls.Add(this.btnGrafica3D);
            this.gbCoordenadas.Controls.Add(this.dgvCoordenadas);
            this.gbCoordenadas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCoordenadas.Location = new System.Drawing.Point(464, 112);
            this.gbCoordenadas.Name = "gbCoordenadas";
            this.gbCoordenadas.Size = new System.Drawing.Size(720, 518);
            this.gbCoordenadas.TabIndex = 3;
            this.gbCoordenadas.TabStop = false;
            this.gbCoordenadas.Text = "Registro de coordenadas";
            // 
            // btnGenerarAleatorio
            // 
            this.btnGenerarAleatorio.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGenerarAleatorio.FlatAppearance.BorderSize = 0;
            this.btnGenerarAleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarAleatorio.ForeColor = System.Drawing.Color.White;
            this.btnGenerarAleatorio.Location = new System.Drawing.Point(356, 96);
            this.btnGenerarAleatorio.Name = "btnGenerarAleatorio";
            this.btnGenerarAleatorio.Size = new System.Drawing.Size(226, 46);
            this.btnGenerarAleatorio.TabIndex = 23;
            this.btnGenerarAleatorio.Text = "Coor. aleatorias";
            this.btnGenerarAleatorio.UseVisualStyleBackColor = false;
            this.btnGenerarAleatorio.Click += new System.EventHandler(this.btnGenerarAleatorio_Click);
            // 
            // btnAgregarPunto
            // 
            this.btnAgregarPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnAgregarPunto.FlatAppearance.BorderSize = 0;
            this.btnAgregarPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPunto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPunto.Location = new System.Drawing.Point(91, 96);
            this.btnAgregarPunto.Name = "btnAgregarPunto";
            this.btnAgregarPunto.Size = new System.Drawing.Size(226, 46);
            this.btnAgregarPunto.TabIndex = 22;
            this.btnAgregarPunto.Text = "Agregar punto";
            this.btnAgregarPunto.UseVisualStyleBackColor = false;
            this.btnAgregarPunto.Click += new System.EventHandler(this.btnAgregarPunto_Click);
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(462, 48);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(120, 34);
            this.txtZ.TabIndex = 21;
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZ.Location = new System.Drawing.Point(428, 51);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(27, 28);
            this.lblZ.TabIndex = 20;
            this.lblZ.Text = "Z:";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(276, 48);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(120, 34);
            this.txtY.TabIndex = 19;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(242, 51);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(27, 28);
            this.lblY.TabIndex = 18;
            this.lblY.Text = "Y:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(91, 48);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(120, 34);
            this.txtX.TabIndex = 17;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(57, 51);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(28, 28);
            this.lblX.TabIndex = 16;
            this.lblX.Text = "X:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(91, 438);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(226, 46);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular volumen";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnGrafica3D
            // 
            this.btnGrafica3D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGrafica3D.FlatAppearance.BorderSize = 0;
            this.btnGrafica3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafica3D.ForeColor = System.Drawing.Color.White;
            this.btnGrafica3D.Location = new System.Drawing.Point(356, 438);
            this.btnGrafica3D.Name = "btnGrafica3D";
            this.btnGrafica3D.Size = new System.Drawing.Size(226, 46);
            this.btnGrafica3D.TabIndex = 14;
            this.btnGrafica3D.Text = "Ver gráfica 3D";
            this.btnGrafica3D.UseVisualStyleBackColor = false;
            this.btnGrafica3D.Click += new System.EventHandler(this.btnGrafica3D_Click);
            // 
            // dgvCoordenadas
            // 
            this.dgvCoordenadas.AllowUserToAddRows = false;
            this.dgvCoordenadas.AllowUserToDeleteRows = false;
            this.dgvCoordenadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCoordenadas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCoordenadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoordenadas.Location = new System.Drawing.Point(25, 162);
            this.dgvCoordenadas.Name = "dgvCoordenadas";
            this.dgvCoordenadas.RowHeadersVisible = false;
            this.dgvCoordenadas.RowHeadersWidth = 62;
            this.dgvCoordenadas.RowTemplate.Height = 28;
            this.dgvCoordenadas.Size = new System.Drawing.Size(670, 270);
            this.dgvCoordenadas.TabIndex = 0;
            // 
            // gbResultado
            // 
            this.gbResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbResultado.Controls.Add(this.lblMetodoResultado);
            this.gbResultado.Controls.Add(this.lblVolumen);
            this.gbResultado.Controls.Add(this.lblTextoVolumen);
            this.gbResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultado.Location = new System.Drawing.Point(13, 636);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(1171, 185);
            this.gbResultado.TabIndex = 4;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado del cálculo";
            // 
            // lblMetodoResultado
            // 
            this.lblMetodoResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoResultado.Location = new System.Drawing.Point(40, 58);
            this.lblMetodoResultado.Name = "lblMetodoResultado";
            this.lblMetodoResultado.Size = new System.Drawing.Size(444, 40);
            this.lblMetodoResultado.TabIndex = 2;
            this.lblMetodoResultado.Text = "Método utilizado: ---";
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumen.Location = new System.Drawing.Point(217, 30);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(78, 28);
            this.lblVolumen.TabIndex = 1;
            this.lblVolumen.Text = "0.00 m³";
            // 
            // lblTextoVolumen
            // 
            this.lblTextoVolumen.AutoSize = true;
            this.lblTextoVolumen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoVolumen.Location = new System.Drawing.Point(30, 30);
            this.lblTextoVolumen.Name = "lblTextoVolumen";
            this.lblTextoVolumen.Size = new System.Drawing.Size(181, 28);
            this.lblTextoVolumen.TabIndex = 0;
            this.lblTextoVolumen.Text = "Volumen calculado:";
            this.lblTextoVolumen.Click += new System.EventHandler(this.lblTextoVolumen_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(121, 35);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(226, 36);
            this.cmbCliente.TabIndex = 21;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(62, 38);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(76, 28);
            this.lblCliente.TabIndex = 20;
            this.lblCliente.Text = "Cliente:";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(121, 77);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(226, 36);
            this.cmbMaterial.TabIndex = 23;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(51, 80);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(88, 28);
            this.lblMaterial.TabIndex = 22;
            this.lblMaterial.Text = "Material:";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(121, 119);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(226, 34);
            this.txtPrecioUnitario.TabIndex = 25;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(15, 122);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(152, 28);
            this.lblPrecioUnitario.TabIndex = 24;
            this.lblPrecioUnitario.Text = "Precio unitario:";
            this.lblPrecioUnitario.Click += new System.EventHandler(this.lblPrecioUnitario_Click);
            // 
            // btnGuardarCalculo
            // 
            this.btnGuardarCalculo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarCalculo.FlatAppearance.BorderSize = 0;
            this.btnGuardarCalculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCalculo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCalculo.Location = new System.Drawing.Point(121, 361);
            this.btnGuardarCalculo.Name = "btnGuardarCalculo";
            this.btnGuardarCalculo.Size = new System.Drawing.Size(226, 46);
            this.btnGuardarCalculo.TabIndex = 26;
            this.btnGuardarCalculo.Text = "Guardar cálculo";
            this.btnGuardarCalculo.UseVisualStyleBackColor = false;
            this.btnGuardarCalculo.Click += new System.EventHandler(this.btnGuardarCalculo_Click);
            // 
            // FrmCalculoVolumenCoordenadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 930);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gbCoordenadas);
            this.Controls.Add(this.gbConfiguracion);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FrmCalculoVolumenCoordenadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de volumen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCalculoVolumenCoordenadas_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.gbConfiguracion.ResumeLayout(false);
            this.gbConfiguracion.PerformLayout();
            this.gbCoordenadas.ResumeLayout(false);
            this.gbCoordenadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordenadas)).EndInit();
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbConfiguracion;
        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Label lblCantidadPuntos;
        private System.Windows.Forms.TextBox txtCantidadPuntos;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.TextBox txtDy;
        private System.Windows.Forms.Label lblDy;
        private System.Windows.Forms.TextBox txtDx;
        private System.Windows.Forms.Label lblDx;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gbCoordenadas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnGrafica3D;
        private System.Windows.Forms.DataGridView dgvCoordenadas;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Button btnAgregarPunto;
        private System.Windows.Forms.Button btnGenerarAleatorio;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.Label lblMetodoResultado;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Label lblTextoVolumen;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Button btnGuardarCalculo;
    }
}
namespace BibliotecaApp
{
    partial class FormPrestamos
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
            this.pnlHeaderPrestamos = new System.Windows.Forms.Panel();
            this.pnlTituloPrestamos = new System.Windows.Forms.Panel();
            this.lblTituloPrestamos = new System.Windows.Forms.Label();
            this.picIconoPrestamos = new System.Windows.Forms.PictureBox();
            this.tblPrincipalPrestamos = new System.Windows.Forms.TableLayoutPanel();
            this.lblSubtituloPrestamos = new System.Windows.Forms.Label();
            this.splitPrestamos = new System.Windows.Forms.SplitContainer();
            this.gbRegistrarPrestamo = new System.Windows.Forms.GroupBox();
            this.btnRegistrarPrestamo = new System.Windows.Forms.Button();
            this.pnlInfoLibro = new System.Windows.Forms.Panel();
            this.lblDisponibles = new System.Windows.Forms.Label();
            this.lblLibroSeleccionado = new System.Windows.Forms.Label();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.cmbLibroPrestamo = new System.Windows.Forms.ComboBox();
            this.lblLibroPrestamo = new System.Windows.Forms.Label();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.txtIdPrestamo = new System.Windows.Forms.TextBox();
            this.lblIdPrestamo = new System.Windows.Forms.Label();
            this.gbPrestamosActivos = new System.Windows.Forms.GroupBox();
            this.btnActualizarPrestamos = new System.Windows.Forms.Button();
            this.pnlAlerta = new System.Windows.Forms.Panel();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPrestamos = new System.Windows.Forms.StatusStrip();
            this.lblEstadoPrestamos = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPrestamosActivos = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPrestamosVencidos = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlHeaderPrestamos.SuspendLayout();
            this.pnlTituloPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoPrestamos)).BeginInit();
            this.tblPrincipalPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPrestamos)).BeginInit();
            this.splitPrestamos.Panel1.SuspendLayout();
            this.splitPrestamos.Panel2.SuspendLayout();
            this.splitPrestamos.SuspendLayout();
            this.gbRegistrarPrestamo.SuspendLayout();
            this.pnlInfoLibro.SuspendLayout();
            this.gbPrestamosActivos.SuspendLayout();
            this.pnlAlerta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.statusPrestamos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderPrestamos
            // 
            this.pnlHeaderPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.pnlHeaderPrestamos.Controls.Add(this.pnlTituloPrestamos);
            this.pnlHeaderPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderPrestamos.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderPrestamos.Name = "pnlHeaderPrestamos";
            this.pnlHeaderPrestamos.Size = new System.Drawing.Size(1135, 140);
            this.pnlHeaderPrestamos.TabIndex = 0;
            // 
            // pnlTituloPrestamos
            // 
            this.pnlTituloPrestamos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTituloPrestamos.BackColor = System.Drawing.Color.Transparent;
            this.pnlTituloPrestamos.Controls.Add(this.lblTituloPrestamos);
            this.pnlTituloPrestamos.Controls.Add(this.picIconoPrestamos);
            this.pnlTituloPrestamos.Location = new System.Drawing.Point(329, 12);
            this.pnlTituloPrestamos.Name = "pnlTituloPrestamos";
            this.pnlTituloPrestamos.Size = new System.Drawing.Size(500, 100);
            this.pnlTituloPrestamos.TabIndex = 0;
            // 
            // lblTituloPrestamos
            // 
            this.lblTituloPrestamos.AutoSize = true;
            this.lblTituloPrestamos.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrestamos.ForeColor = System.Drawing.Color.White;
            this.lblTituloPrestamos.Location = new System.Drawing.Point(98, 15);
            this.lblTituloPrestamos.Name = "lblTituloPrestamos";
            this.lblTituloPrestamos.Size = new System.Drawing.Size(279, 67);
            this.lblTituloPrestamos.TabIndex = 1;
            this.lblTituloPrestamos.Text = "PRÉSTAMOS";
            // 
            // picIconoPrestamos
            // 
            this.picIconoPrestamos.Image = global::BibliotecaApp.Properties.Resources.clipboard_notes_list_tasks_icon_191193;
            this.picIconoPrestamos.Location = new System.Drawing.Point(27, 17);
            this.picIconoPrestamos.Name = "picIconoPrestamos";
            this.picIconoPrestamos.Size = new System.Drawing.Size(65, 65);
            this.picIconoPrestamos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconoPrestamos.TabIndex = 0;
            this.picIconoPrestamos.TabStop = false;
            // 
            // tblPrincipalPrestamos
            // 
            this.tblPrincipalPrestamos.ColumnCount = 3;
            this.tblPrincipalPrestamos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.04848F));
            this.tblPrincipalPrestamos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.94711F));
            this.tblPrincipalPrestamos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00441F));
            this.tblPrincipalPrestamos.Controls.Add(this.lblSubtituloPrestamos, 1, 0);
            this.tblPrincipalPrestamos.Controls.Add(this.splitPrestamos, 1, 1);
            this.tblPrincipalPrestamos.Controls.Add(this.statusPrestamos, 1, 2);
            this.tblPrincipalPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrincipalPrestamos.Location = new System.Drawing.Point(0, 140);
            this.tblPrincipalPrestamos.Name = "tblPrincipalPrestamos";
            this.tblPrincipalPrestamos.RowCount = 3;
            this.tblPrincipalPrestamos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblPrincipalPrestamos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tblPrincipalPrestamos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblPrincipalPrestamos.Size = new System.Drawing.Size(1135, 633);
            this.tblPrincipalPrestamos.TabIndex = 1;
            // 
            // lblSubtituloPrestamos
            // 
            this.lblSubtituloPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtituloPrestamos.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtituloPrestamos.Location = new System.Drawing.Point(117, 0);
            this.lblSubtituloPrestamos.Name = "lblSubtituloPrestamos";
            this.lblSubtituloPrestamos.Size = new System.Drawing.Size(901, 50);
            this.lblSubtituloPrestamos.TabIndex = 0;
            this.lblSubtituloPrestamos.Text = "Registro de libros prestados a estudiantes";
            this.lblSubtituloPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitPrestamos
            // 
            this.splitPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPrestamos.IsSplitterFixed = true;
            this.splitPrestamos.Location = new System.Drawing.Point(117, 53);
            this.splitPrestamos.Name = "splitPrestamos";
            // 
            // splitPrestamos.Panel1
            // 
            this.splitPrestamos.Panel1.Controls.Add(this.gbRegistrarPrestamo);
            // 
            // splitPrestamos.Panel2
            // 
            this.splitPrestamos.Panel2.Controls.Add(this.gbPrestamosActivos);
            this.splitPrestamos.Size = new System.Drawing.Size(901, 525);
            this.splitPrestamos.SplitterDistance = 240;
            this.splitPrestamos.TabIndex = 1;
            // 
            // gbRegistrarPrestamo
            // 
            this.gbRegistrarPrestamo.Controls.Add(this.btnRegistrarPrestamo);
            this.gbRegistrarPrestamo.Controls.Add(this.pnlInfoLibro);
            this.gbRegistrarPrestamo.Controls.Add(this.dtpFechaDevolucion);
            this.gbRegistrarPrestamo.Controls.Add(this.lblFechaDevolucion);
            this.gbRegistrarPrestamo.Controls.Add(this.txtEstudiante);
            this.gbRegistrarPrestamo.Controls.Add(this.lblEstudiante);
            this.gbRegistrarPrestamo.Controls.Add(this.cmbLibroPrestamo);
            this.gbRegistrarPrestamo.Controls.Add(this.lblLibroPrestamo);
            this.gbRegistrarPrestamo.Controls.Add(this.dtpFechaPrestamo);
            this.gbRegistrarPrestamo.Controls.Add(this.lblFechaPrestamo);
            this.gbRegistrarPrestamo.Controls.Add(this.txtIdPrestamo);
            this.gbRegistrarPrestamo.Controls.Add(this.lblIdPrestamo);
            this.gbRegistrarPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRegistrarPrestamo.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrarPrestamo.Location = new System.Drawing.Point(0, 0);
            this.gbRegistrarPrestamo.Name = "gbRegistrarPrestamo";
            this.gbRegistrarPrestamo.Size = new System.Drawing.Size(240, 525);
            this.gbRegistrarPrestamo.TabIndex = 0;
            this.gbRegistrarPrestamo.TabStop = false;
            this.gbRegistrarPrestamo.Text = "Registrar Préstamo";
            // 
            // btnRegistrarPrestamo
            // 
            this.btnRegistrarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnRegistrarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPrestamo.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPrestamo.Location = new System.Drawing.Point(7, 391);
            this.btnRegistrarPrestamo.Name = "btnRegistrarPrestamo";
            this.btnRegistrarPrestamo.Size = new System.Drawing.Size(367, 57);
            this.btnRegistrarPrestamo.TabIndex = 11;
            this.btnRegistrarPrestamo.Text = "Registrar Préstamo";
            this.btnRegistrarPrestamo.UseVisualStyleBackColor = false;
            this.btnRegistrarPrestamo.Click += new System.EventHandler(this.btnRegistrarPrestamo_Click);
            // 
            // pnlInfoLibro
            // 
            this.pnlInfoLibro.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlInfoLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoLibro.Controls.Add(this.lblDisponibles);
            this.pnlInfoLibro.Controls.Add(this.lblLibroSeleccionado);
            this.pnlInfoLibro.Location = new System.Drawing.Point(7, 293);
            this.pnlInfoLibro.Name = "pnlInfoLibro";
            this.pnlInfoLibro.Size = new System.Drawing.Size(367, 70);
            this.pnlInfoLibro.TabIndex = 10;
            // 
            // lblDisponibles
            // 
            this.lblDisponibles.Location = new System.Drawing.Point(19, 38);
            this.lblDisponibles.Name = "lblDisponibles";
            this.lblDisponibles.Size = new System.Drawing.Size(221, 30);
            this.lblDisponibles.TabIndex = 1;
            this.lblDisponibles.Text = "✅ Disponibles: 0 ejemplares";
            // 
            // lblLibroSeleccionado
            // 
            this.lblLibroSeleccionado.AutoSize = true;
            this.lblLibroSeleccionado.Location = new System.Drawing.Point(19, 4);
            this.lblLibroSeleccionado.Name = "lblLibroSeleccionado";
            this.lblLibroSeleccionado.Size = new System.Drawing.Size(225, 36);
            this.lblLibroSeleccionado.TabIndex = 0;
            this.lblLibroSeleccionado.Text = "📖 Libro seleccionado";
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(153, 242);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(203, 30);
            this.dtpFechaDevolucion.TabIndex = 9;
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDevolucion.Location = new System.Drawing.Point(10, 242);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(137, 25);
            this.lblFechaDevolucion.TabIndex = 8;
            this.lblFechaDevolucion.Text = "F. Devolución:";
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(153, 188);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(204, 46);
            this.txtEstudiante.TabIndex = 7;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.Location = new System.Drawing.Point(37, 192);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(110, 25);
            this.lblEstudiante.TabIndex = 6;
            this.lblEstudiante.Text = "Estudiante:";
            // 
            // cmbLibroPrestamo
            // 
            this.cmbLibroPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibroPrestamo.FormattingEnabled = true;
            this.cmbLibroPrestamo.Location = new System.Drawing.Point(154, 132);
            this.cmbLibroPrestamo.Name = "cmbLibroPrestamo";
            this.cmbLibroPrestamo.Size = new System.Drawing.Size(203, 44);
            this.cmbLibroPrestamo.TabIndex = 5;
            this.cmbLibroPrestamo.SelectedIndexChanged += new System.EventHandler(this.cmbLibroPrestamo_SelectedIndexChanged);
            // 
            // lblLibroPrestamo
            // 
            this.lblLibroPrestamo.AutoSize = true;
            this.lblLibroPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibroPrestamo.Location = new System.Drawing.Point(86, 140);
            this.lblLibroPrestamo.Name = "lblLibroPrestamo";
            this.lblLibroPrestamo.Size = new System.Drawing.Size(61, 25);
            this.lblLibroPrestamo.TabIndex = 4;
            this.lblLibroPrestamo.Text = "Libro:";
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(154, 96);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(203, 30);
            this.dtpFechaPrestamo.TabIndex = 3;
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPrestamo.Location = new System.Drawing.Point(74, 96);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(73, 25);
            this.lblFechaPrestamo.TabIndex = 2;
            this.lblFechaPrestamo.Text = "Fecha:";
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPrestamo.Location = new System.Drawing.Point(153, 54);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.Size = new System.Drawing.Size(204, 30);
            this.txtIdPrestamo.TabIndex = 1;
            this.txtIdPrestamo.Text = "001";
            // 
            // lblIdPrestamo
            // 
            this.lblIdPrestamo.AutoSize = true;
            this.lblIdPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPrestamo.Location = new System.Drawing.Point(22, 54);
            this.lblIdPrestamo.Name = "lblIdPrestamo";
            this.lblIdPrestamo.Size = new System.Drawing.Size(125, 25);
            this.lblIdPrestamo.TabIndex = 0;
            this.lblIdPrestamo.Text = "ID Préstamo:";
            this.lblIdPrestamo.Click += new System.EventHandler(this.lblIdPrestamo_Click);
            // 
            // gbPrestamosActivos
            // 
            this.gbPrestamosActivos.Controls.Add(this.btnActualizarPrestamos);
            this.gbPrestamosActivos.Controls.Add(this.pnlAlerta);
            this.gbPrestamosActivos.Controls.Add(this.dgvPrestamos);
            this.gbPrestamosActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPrestamosActivos.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrestamosActivos.Location = new System.Drawing.Point(0, 0);
            this.gbPrestamosActivos.Name = "gbPrestamosActivos";
            this.gbPrestamosActivos.Size = new System.Drawing.Size(657, 525);
            this.gbPrestamosActivos.TabIndex = 0;
            this.gbPrestamosActivos.TabStop = false;
            this.gbPrestamosActivos.Text = "Préstamos Activos";
            // 
            // btnActualizarPrestamos
            // 
            this.btnActualizarPrestamos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizarPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPrestamos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarPrestamos.Location = new System.Drawing.Point(6, 348);
            this.btnActualizarPrestamos.Name = "btnActualizarPrestamos";
            this.btnActualizarPrestamos.Size = new System.Drawing.Size(137, 59);
            this.btnActualizarPrestamos.TabIndex = 2;
            this.btnActualizarPrestamos.Text = "Actualizar";
            this.btnActualizarPrestamos.UseVisualStyleBackColor = false;
            // 
            // pnlAlerta
            // 
            this.pnlAlerta.BackColor = System.Drawing.Color.MistyRose;
            this.pnlAlerta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlerta.Controls.Add(this.lblAlerta);
            this.pnlAlerta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAlerta.Location = new System.Drawing.Point(3, 292);
            this.pnlAlerta.Name = "pnlAlerta";
            this.pnlAlerta.Size = new System.Drawing.Size(651, 50);
            this.pnlAlerta.TabIndex = 1;
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAlerta.Location = new System.Drawing.Point(348, 5);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(279, 39);
            this.lblAlerta.TabIndex = 0;
            this.lblAlerta.Text = "⚠️ 0 préstamos vencidos";
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colFecha,
            this.colLibro,
            this.colEstudiante,
            this.colFechaEsperada});
            this.dgvPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPrestamos.Location = new System.Drawing.Point(3, 42);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.RowHeadersWidth = 62;
            this.dgvPrestamos.RowTemplate.Height = 28;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(651, 250);
            this.dgvPrestamos.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 8;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "F. Préstamo";
            this.colFecha.MinimumWidth = 8;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colLibro
            // 
            this.colLibro.HeaderText = "Libro";
            this.colLibro.MinimumWidth = 8;
            this.colLibro.Name = "colLibro";
            this.colLibro.ReadOnly = true;
            // 
            // colEstudiante
            // 
            this.colEstudiante.HeaderText = "Estudiante";
            this.colEstudiante.MinimumWidth = 8;
            this.colEstudiante.Name = "colEstudiante";
            this.colEstudiante.ReadOnly = true;
            // 
            // colFechaEsperada
            // 
            this.colFechaEsperada.HeaderText = "F. Esperada";
            this.colFechaEsperada.MinimumWidth = 8;
            this.colFechaEsperada.Name = "colFechaEsperada";
            this.colFechaEsperada.ReadOnly = true;
            // 
            // statusPrestamos
            // 
            this.statusPrestamos.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusPrestamos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoPrestamos,
            this.lblPrestamosActivos,
            this.lblPrestamosVencidos});
            this.statusPrestamos.Location = new System.Drawing.Point(114, 590);
            this.statusPrestamos.Name = "statusPrestamos";
            this.statusPrestamos.Size = new System.Drawing.Size(907, 43);
            this.statusPrestamos.TabIndex = 2;
            this.statusPrestamos.Text = "statusStrip1";
            // 
            // lblEstadoPrestamos
            // 
            this.lblEstadoPrestamos.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoPrestamos.Name = "lblEstadoPrestamos";
            this.lblEstadoPrestamos.Size = new System.Drawing.Size(94, 36);
            this.lblEstadoPrestamos.Text = "✔ Listo";
            // 
            // lblPrestamosActivos
            // 
            this.lblPrestamosActivos.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamosActivos.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPrestamosActivos.Name = "lblPrestamosActivos";
            this.lblPrestamosActivos.Size = new System.Drawing.Size(108, 36);
            this.lblPrestamosActivos.Text = "Activos: 0";
            // 
            // lblPrestamosVencidos
            // 
            this.lblPrestamosVencidos.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamosVencidos.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPrestamosVencidos.Name = "lblPrestamosVencidos";
            this.lblPrestamosVencidos.Size = new System.Drawing.Size(123, 36);
            this.lblPrestamosVencidos.Text = "Vencidos: 0";
            // 
            // FormPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 773);
            this.Controls.Add(this.tblPrincipalPrestamos);
            this.Controls.Add(this.pnlHeaderPrestamos);
            this.Name = "FormPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Préstamos de Libros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeaderPrestamos.ResumeLayout(false);
            this.pnlTituloPrestamos.ResumeLayout(false);
            this.pnlTituloPrestamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoPrestamos)).EndInit();
            this.tblPrincipalPrestamos.ResumeLayout(false);
            this.tblPrincipalPrestamos.PerformLayout();
            this.splitPrestamos.Panel1.ResumeLayout(false);
            this.splitPrestamos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPrestamos)).EndInit();
            this.splitPrestamos.ResumeLayout(false);
            this.gbRegistrarPrestamo.ResumeLayout(false);
            this.gbRegistrarPrestamo.PerformLayout();
            this.pnlInfoLibro.ResumeLayout(false);
            this.pnlInfoLibro.PerformLayout();
            this.gbPrestamosActivos.ResumeLayout(false);
            this.pnlAlerta.ResumeLayout(false);
            this.pnlAlerta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.statusPrestamos.ResumeLayout(false);
            this.statusPrestamos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderPrestamos;
        private System.Windows.Forms.Panel pnlTituloPrestamos;
        private System.Windows.Forms.PictureBox picIconoPrestamos;
        private System.Windows.Forms.Label lblTituloPrestamos;
        private System.Windows.Forms.TableLayoutPanel tblPrincipalPrestamos;
        private System.Windows.Forms.Label lblSubtituloPrestamos;
        private System.Windows.Forms.SplitContainer splitPrestamos;
        private System.Windows.Forms.GroupBox gbRegistrarPrestamo;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.TextBox txtIdPrestamo;
        private System.Windows.Forms.Label lblIdPrestamo;
        private System.Windows.Forms.ComboBox cmbLibroPrestamo;
        private System.Windows.Forms.Label lblLibroPrestamo;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Panel pnlInfoLibro;
        private System.Windows.Forms.Label lblDisponibles;
        private System.Windows.Forms.Label lblLibroSeleccionado;
        private System.Windows.Forms.Button btnRegistrarPrestamo;
        private System.Windows.Forms.GroupBox gbPrestamosActivos;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEsperada;
        private System.Windows.Forms.Button btnActualizarPrestamos;
        private System.Windows.Forms.StatusStrip statusPrestamos;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoPrestamos;
        private System.Windows.Forms.ToolStripStatusLabel lblPrestamosActivos;
        private System.Windows.Forms.ToolStripStatusLabel lblPrestamosVencidos;
        private System.Windows.Forms.Panel pnlAlerta;
        private System.Windows.Forms.Label lblAlerta;
    }
}
namespace BibliotecaApp
{
    partial class FormDevoluciones
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
            this.pnlHeaderDevoluciones = new System.Windows.Forms.Panel();
            this.pnlTituloDevoluciones = new System.Windows.Forms.Panel();
            this.lblTituloDevoluciones = new System.Windows.Forms.Label();
            this.picIconoDevoluciones = new System.Windows.Forms.PictureBox();
            this.tblPrincipalDevoluciones = new System.Windows.Forms.TableLayoutPanel();
            this.splitDevoluciones = new System.Windows.Forms.SplitContainer();
            this.gbRegistrarDevolucion = new System.Windows.Forms.GroupBox();
            this.btnConfirmarDevolucion = new System.Windows.Forms.Button();
            this.pnlConMora = new System.Windows.Forms.Panel();
            this.lblConMora = new System.Windows.Forms.Label();
            this.pnlSinMora = new System.Windows.Forms.Panel();
            this.lblSinMora = new System.Windows.Forms.Label();
            this.pnlInfoPrestamo = new System.Windows.Forms.Panel();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.lblInfoFechaEsperada = new System.Windows.Forms.Label();
            this.lblInfoEstudiante = new System.Windows.Forms.Label();
            this.lblInfoLibro = new System.Windows.Forms.Label();
            this.lblInfoPrestamo = new System.Windows.Forms.Label();
            this.btnBuscarPrestamo = new System.Windows.Forms.Button();
            this.txtIdPrestamo = new System.Windows.Forms.TextBox();
            this.lblIdPrestamo = new System.Windows.Forms.Label();
            this.gbHistorialDevoluciones = new System.Windows.Forms.GroupBox();
            this.btnActualizarDevoluciones = new System.Windows.Forms.Button();
            this.dgvDevoluciones = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubtituloDevoluciones = new System.Windows.Forms.Label();
            this.pnlHeaderDevoluciones.SuspendLayout();
            this.pnlTituloDevoluciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoDevoluciones)).BeginInit();
            this.tblPrincipalDevoluciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDevoluciones)).BeginInit();
            this.splitDevoluciones.Panel1.SuspendLayout();
            this.splitDevoluciones.Panel2.SuspendLayout();
            this.splitDevoluciones.SuspendLayout();
            this.gbRegistrarDevolucion.SuspendLayout();
            this.pnlConMora.SuspendLayout();
            this.pnlSinMora.SuspendLayout();
            this.pnlInfoPrestamo.SuspendLayout();
            this.gbHistorialDevoluciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeaderDevoluciones
            // 
            this.pnlHeaderDevoluciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(255)))), ((int)(((byte)(176)))));
            this.pnlHeaderDevoluciones.Controls.Add(this.pnlTituloDevoluciones);
            this.pnlHeaderDevoluciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderDevoluciones.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderDevoluciones.Name = "pnlHeaderDevoluciones";
            this.pnlHeaderDevoluciones.Size = new System.Drawing.Size(1130, 140);
            this.pnlHeaderDevoluciones.TabIndex = 0;
            // 
            // pnlTituloDevoluciones
            // 
            this.pnlTituloDevoluciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTituloDevoluciones.BackColor = System.Drawing.Color.Transparent;
            this.pnlTituloDevoluciones.Controls.Add(this.lblTituloDevoluciones);
            this.pnlTituloDevoluciones.Controls.Add(this.picIconoDevoluciones);
            this.pnlTituloDevoluciones.Location = new System.Drawing.Point(259, 12);
            this.pnlTituloDevoluciones.Name = "pnlTituloDevoluciones";
            this.pnlTituloDevoluciones.Size = new System.Drawing.Size(600, 100);
            this.pnlTituloDevoluciones.TabIndex = 0;
            // 
            // lblTituloDevoluciones
            // 
            this.lblTituloDevoluciones.AutoSize = true;
            this.lblTituloDevoluciones.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDevoluciones.ForeColor = System.Drawing.Color.Black;
            this.lblTituloDevoluciones.Location = new System.Drawing.Point(151, 14);
            this.lblTituloDevoluciones.Name = "lblTituloDevoluciones";
            this.lblTituloDevoluciones.Size = new System.Drawing.Size(338, 67);
            this.lblTituloDevoluciones.TabIndex = 1;
            this.lblTituloDevoluciones.Text = "DEVOLUCIONES";
            // 
            // picIconoDevoluciones
            // 
            this.picIconoDevoluciones.Image = global::BibliotecaApp.Properties.Resources.left_arrow_curved_black_symbol_icon_icons_com_73000;
            this.picIconoDevoluciones.Location = new System.Drawing.Point(51, 14);
            this.picIconoDevoluciones.Name = "picIconoDevoluciones";
            this.picIconoDevoluciones.Size = new System.Drawing.Size(65, 65);
            this.picIconoDevoluciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconoDevoluciones.TabIndex = 0;
            this.picIconoDevoluciones.TabStop = false;
            // 
            // tblPrincipalDevoluciones
            // 
            this.tblPrincipalDevoluciones.ColumnCount = 3;
            this.tblPrincipalDevoluciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPrincipalDevoluciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblPrincipalDevoluciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPrincipalDevoluciones.Controls.Add(this.splitDevoluciones, 1, 1);
            this.tblPrincipalDevoluciones.Controls.Add(this.lblSubtituloDevoluciones, 1, 0);
            this.tblPrincipalDevoluciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrincipalDevoluciones.Location = new System.Drawing.Point(0, 140);
            this.tblPrincipalDevoluciones.Name = "tblPrincipalDevoluciones";
            this.tblPrincipalDevoluciones.RowCount = 3;
            this.tblPrincipalDevoluciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblPrincipalDevoluciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tblPrincipalDevoluciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblPrincipalDevoluciones.Size = new System.Drawing.Size(1130, 679);
            this.tblPrincipalDevoluciones.TabIndex = 1;
            // 
            // splitDevoluciones
            // 
            this.splitDevoluciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitDevoluciones.IsSplitterFixed = true;
            this.splitDevoluciones.Location = new System.Drawing.Point(116, 57);
            this.splitDevoluciones.Name = "splitDevoluciones";
            // 
            // splitDevoluciones.Panel1
            // 
            this.splitDevoluciones.Panel1.Controls.Add(this.gbRegistrarDevolucion);
            // 
            // splitDevoluciones.Panel2
            // 
            this.splitDevoluciones.Panel2.Controls.Add(this.gbHistorialDevoluciones);
            this.splitDevoluciones.Size = new System.Drawing.Size(898, 564);
            this.splitDevoluciones.SplitterDistance = 240;
            this.splitDevoluciones.TabIndex = 0;
            // 
            // gbRegistrarDevolucion
            // 
            this.gbRegistrarDevolucion.Controls.Add(this.btnConfirmarDevolucion);
            this.gbRegistrarDevolucion.Controls.Add(this.pnlConMora);
            this.gbRegistrarDevolucion.Controls.Add(this.pnlSinMora);
            this.gbRegistrarDevolucion.Controls.Add(this.pnlInfoPrestamo);
            this.gbRegistrarDevolucion.Controls.Add(this.btnBuscarPrestamo);
            this.gbRegistrarDevolucion.Controls.Add(this.txtIdPrestamo);
            this.gbRegistrarDevolucion.Controls.Add(this.lblIdPrestamo);
            this.gbRegistrarDevolucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRegistrarDevolucion.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrarDevolucion.Location = new System.Drawing.Point(0, 0);
            this.gbRegistrarDevolucion.Name = "gbRegistrarDevolucion";
            this.gbRegistrarDevolucion.Size = new System.Drawing.Size(240, 564);
            this.gbRegistrarDevolucion.TabIndex = 0;
            this.gbRegistrarDevolucion.TabStop = false;
            this.gbRegistrarDevolucion.Text = "Registrar Devolución";
            this.gbRegistrarDevolucion.Enter += new System.EventHandler(this.gbRegistrarDevolucion_Enter);
            // 
            // btnConfirmarDevolucion
            // 
            this.btnConfirmarDevolucion.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConfirmarDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarDevolucion.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarDevolucion.Location = new System.Drawing.Point(8, 510);
            this.btnConfirmarDevolucion.Name = "btnConfirmarDevolucion";
            this.btnConfirmarDevolucion.Size = new System.Drawing.Size(366, 48);
            this.btnConfirmarDevolucion.TabIndex = 6;
            this.btnConfirmarDevolucion.Text = "Confirmar Devolución";
            this.btnConfirmarDevolucion.UseVisualStyleBackColor = false;
            this.btnConfirmarDevolucion.Click += new System.EventHandler(this.btnConfirmarDevolucion_Click);
            // 
            // pnlConMora
            // 
            this.pnlConMora.BackColor = System.Drawing.Color.MistyRose;
            this.pnlConMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConMora.Controls.Add(this.lblConMora);
            this.pnlConMora.Location = new System.Drawing.Point(8, 431);
            this.pnlConMora.Name = "pnlConMora";
            this.pnlConMora.Size = new System.Drawing.Size(366, 63);
            this.pnlConMora.TabIndex = 5;
            // 
            // lblConMora
            // 
            this.lblConMora.AutoSize = true;
            this.lblConMora.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConMora.ForeColor = System.Drawing.Color.Firebrick;
            this.lblConMora.Location = new System.Drawing.Point(62, 13);
            this.lblConMora.Name = "lblConMora";
            this.lblConMora.Size = new System.Drawing.Size(214, 36);
            this.lblConMora.TabIndex = 0;
            this.lblConMora.Text = "⚠ Devuelto con mora";
            // 
            // pnlSinMora
            // 
            this.pnlSinMora.BackColor = System.Drawing.Color.Honeydew;
            this.pnlSinMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSinMora.Controls.Add(this.lblSinMora);
            this.pnlSinMora.Location = new System.Drawing.Point(8, 368);
            this.pnlSinMora.Name = "pnlSinMora";
            this.pnlSinMora.Size = new System.Drawing.Size(366, 56);
            this.pnlSinMora.TabIndex = 4;
            // 
            // lblSinMora
            // 
            this.lblSinMora.AutoSize = true;
            this.lblSinMora.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinMora.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSinMora.Location = new System.Drawing.Point(15, 9);
            this.lblSinMora.Name = "lblSinMora";
            this.lblSinMora.Size = new System.Drawing.Size(317, 36);
            this.lblSinMora.TabIndex = 0;
            this.lblSinMora.Text = "✅ Devuelto a tiempo — Sin mora";
            this.lblSinMora.Click += new System.EventHandler(this.lblSinMora_Click);
            // 
            // pnlInfoPrestamo
            // 
            this.pnlInfoPrestamo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInfoPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoPrestamo.Controls.Add(this.dtpFechaDevolucion);
            this.pnlInfoPrestamo.Controls.Add(this.lblFechaDevolucion);
            this.pnlInfoPrestamo.Controls.Add(this.lblInfoFechaEsperada);
            this.pnlInfoPrestamo.Controls.Add(this.lblInfoEstudiante);
            this.pnlInfoPrestamo.Controls.Add(this.lblInfoLibro);
            this.pnlInfoPrestamo.Controls.Add(this.lblInfoPrestamo);
            this.pnlInfoPrestamo.Location = new System.Drawing.Point(8, 92);
            this.pnlInfoPrestamo.Name = "pnlInfoPrestamo";
            this.pnlInfoPrestamo.Size = new System.Drawing.Size(366, 254);
            this.pnlInfoPrestamo.TabIndex = 3;
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(21, 177);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(206, 48);
            this.dtpFechaDevolucion.TabIndex = 5;
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDevolucion.Location = new System.Drawing.Point(15, 137);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(137, 36);
            this.lblFechaDevolucion.TabIndex = 4;
            this.lblFechaDevolucion.Text = "F. Devolución:";
            // 
            // lblInfoFechaEsperada
            // 
            this.lblInfoFechaEsperada.AutoSize = true;
            this.lblInfoFechaEsperada.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoFechaEsperada.Location = new System.Drawing.Point(15, 101);
            this.lblInfoFechaEsperada.Name = "lblInfoFechaEsperada";
            this.lblInfoFechaEsperada.Size = new System.Drawing.Size(117, 36);
            this.lblInfoFechaEsperada.TabIndex = 3;
            this.lblInfoFechaEsperada.Text = "F. Esperada:";
            // 
            // lblInfoEstudiante
            // 
            this.lblInfoEstudiante.AutoSize = true;
            this.lblInfoEstudiante.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEstudiante.Location = new System.Drawing.Point(15, 65);
            this.lblInfoEstudiante.Name = "lblInfoEstudiante";
            this.lblInfoEstudiante.Size = new System.Drawing.Size(110, 36);
            this.lblInfoEstudiante.TabIndex = 2;
            this.lblInfoEstudiante.Text = "Estudiante:";
            // 
            // lblInfoLibro
            // 
            this.lblInfoLibro.AutoSize = true;
            this.lblInfoLibro.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoLibro.Location = new System.Drawing.Point(15, 29);
            this.lblInfoLibro.Name = "lblInfoLibro";
            this.lblInfoLibro.Size = new System.Drawing.Size(64, 36);
            this.lblInfoLibro.TabIndex = 1;
            this.lblInfoLibro.Text = "Libro:";
            // 
            // lblInfoPrestamo
            // 
            this.lblInfoPrestamo.AutoSize = true;
            this.lblInfoPrestamo.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPrestamo.Location = new System.Drawing.Point(15, 3);
            this.lblInfoPrestamo.Name = "lblInfoPrestamo";
            this.lblInfoPrestamo.Size = new System.Drawing.Size(142, 36);
            this.lblInfoPrestamo.TabIndex = 0;
            this.lblInfoPrestamo.Text = "Préstamo: #---";
            // 
            // btnBuscarPrestamo
            // 
            this.btnBuscarPrestamo.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPrestamo.Location = new System.Drawing.Point(319, 40);
            this.btnBuscarPrestamo.Name = "btnBuscarPrestamo";
            this.btnBuscarPrestamo.Size = new System.Drawing.Size(75, 45);
            this.btnBuscarPrestamo.TabIndex = 2;
            this.btnBuscarPrestamo.Text = "🔍";
            this.btnBuscarPrestamo.UseVisualStyleBackColor = true;
            this.btnBuscarPrestamo.Click += new System.EventHandler(this.btnBuscarPrestamo_Click);
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPrestamo.Location = new System.Drawing.Point(143, 40);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.Size = new System.Drawing.Size(170, 45);
            this.txtIdPrestamo.TabIndex = 1;
            // 
            // lblIdPrestamo
            // 
            this.lblIdPrestamo.AutoSize = true;
            this.lblIdPrestamo.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPrestamo.Location = new System.Drawing.Point(12, 45);
            this.lblIdPrestamo.Name = "lblIdPrestamo";
            this.lblIdPrestamo.Size = new System.Drawing.Size(125, 36);
            this.lblIdPrestamo.TabIndex = 0;
            this.lblIdPrestamo.Text = "ID Préstamo:";
            // 
            // gbHistorialDevoluciones
            // 
            this.gbHistorialDevoluciones.Controls.Add(this.btnActualizarDevoluciones);
            this.gbHistorialDevoluciones.Controls.Add(this.dgvDevoluciones);
            this.gbHistorialDevoluciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHistorialDevoluciones.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHistorialDevoluciones.Location = new System.Drawing.Point(0, 0);
            this.gbHistorialDevoluciones.Name = "gbHistorialDevoluciones";
            this.gbHistorialDevoluciones.Size = new System.Drawing.Size(654, 564);
            this.gbHistorialDevoluciones.TabIndex = 0;
            this.gbHistorialDevoluciones.TabStop = false;
            this.gbHistorialDevoluciones.Text = "Historial de Devoluciones";
            // 
            // btnActualizarDevoluciones
            // 
            this.btnActualizarDevoluciones.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizarDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarDevoluciones.ForeColor = System.Drawing.Color.White;
            this.btnActualizarDevoluciones.Location = new System.Drawing.Point(6, 302);
            this.btnActualizarDevoluciones.Name = "btnActualizarDevoluciones";
            this.btnActualizarDevoluciones.Size = new System.Drawing.Size(142, 44);
            this.btnActualizarDevoluciones.TabIndex = 1;
            this.btnActualizarDevoluciones.Text = "Actualizar";
            this.btnActualizarDevoluciones.UseVisualStyleBackColor = false;
            this.btnActualizarDevoluciones.Click += new System.EventHandler(this.btnActualizarDevoluciones_Click);
            // 
            // dgvDevoluciones
            // 
            this.dgvDevoluciones.AllowUserToAddRows = false;
            this.dgvDevoluciones.AllowUserToDeleteRows = false;
            this.dgvDevoluciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevoluciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colLibro,
            this.colEstudiante,
            this.colFechaDevolucion,
            this.colMora});
            this.dgvDevoluciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDevoluciones.Location = new System.Drawing.Point(3, 45);
            this.dgvDevoluciones.Name = "dgvDevoluciones";
            this.dgvDevoluciones.ReadOnly = true;
            this.dgvDevoluciones.RowHeadersVisible = false;
            this.dgvDevoluciones.RowHeadersWidth = 62;
            this.dgvDevoluciones.RowTemplate.Height = 28;
            this.dgvDevoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevoluciones.Size = new System.Drawing.Size(648, 250);
            this.dgvDevoluciones.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 8;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
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
            // colFechaDevolucion
            // 
            this.colFechaDevolucion.HeaderText = "F. Devol.";
            this.colFechaDevolucion.MinimumWidth = 8;
            this.colFechaDevolucion.Name = "colFechaDevolucion";
            this.colFechaDevolucion.ReadOnly = true;
            // 
            // colMora
            // 
            this.colMora.HeaderText = "Mora";
            this.colMora.MinimumWidth = 8;
            this.colMora.Name = "colMora";
            this.colMora.ReadOnly = true;
            // 
            // lblSubtituloDevoluciones
            // 
            this.lblSubtituloDevoluciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtituloDevoluciones.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtituloDevoluciones.Location = new System.Drawing.Point(116, 0);
            this.lblSubtituloDevoluciones.Name = "lblSubtituloDevoluciones";
            this.lblSubtituloDevoluciones.Size = new System.Drawing.Size(898, 45);
            this.lblSubtituloDevoluciones.TabIndex = 1;
            this.lblSubtituloDevoluciones.Text = "Registro de libros devueltos";
            this.lblSubtituloDevoluciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 819);
            this.Controls.Add(this.tblPrincipalDevoluciones);
            this.Controls.Add(this.pnlHeaderDevoluciones);
            this.Name = "FormDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeaderDevoluciones.ResumeLayout(false);
            this.pnlTituloDevoluciones.ResumeLayout(false);
            this.pnlTituloDevoluciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoDevoluciones)).EndInit();
            this.tblPrincipalDevoluciones.ResumeLayout(false);
            this.splitDevoluciones.Panel1.ResumeLayout(false);
            this.splitDevoluciones.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitDevoluciones)).EndInit();
            this.splitDevoluciones.ResumeLayout(false);
            this.gbRegistrarDevolucion.ResumeLayout(false);
            this.gbRegistrarDevolucion.PerformLayout();
            this.pnlConMora.ResumeLayout(false);
            this.pnlConMora.PerformLayout();
            this.pnlSinMora.ResumeLayout(false);
            this.pnlSinMora.PerformLayout();
            this.pnlInfoPrestamo.ResumeLayout(false);
            this.pnlInfoPrestamo.PerformLayout();
            this.gbHistorialDevoluciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderDevoluciones;
        private System.Windows.Forms.Panel pnlTituloDevoluciones;
        private System.Windows.Forms.Label lblTituloDevoluciones;
        private System.Windows.Forms.PictureBox picIconoDevoluciones;
        private System.Windows.Forms.TableLayoutPanel tblPrincipalDevoluciones;
        private System.Windows.Forms.SplitContainer splitDevoluciones;
        private System.Windows.Forms.GroupBox gbRegistrarDevolucion;
        private System.Windows.Forms.Button btnBuscarPrestamo;
        private System.Windows.Forms.TextBox txtIdPrestamo;
        private System.Windows.Forms.Label lblIdPrestamo;
        private System.Windows.Forms.Label lblSubtituloDevoluciones;
        private System.Windows.Forms.Panel pnlInfoPrestamo;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.Label lblInfoFechaEsperada;
        private System.Windows.Forms.Label lblInfoEstudiante;
        private System.Windows.Forms.Label lblInfoLibro;
        private System.Windows.Forms.Label lblInfoPrestamo;
        private System.Windows.Forms.Panel pnlSinMora;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.Label lblSinMora;
        private System.Windows.Forms.Panel pnlConMora;
        private System.Windows.Forms.Label lblConMora;
        private System.Windows.Forms.Button btnConfirmarDevolucion;
        private System.Windows.Forms.GroupBox gbHistorialDevoluciones;
        private System.Windows.Forms.DataGridView dgvDevoluciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMora;
        private System.Windows.Forms.Button btnActualizarDevoluciones;
    }
}
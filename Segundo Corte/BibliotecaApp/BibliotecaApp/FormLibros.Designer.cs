namespace BibliotecaApp
{
    partial class FormLibros
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.splitLibros = new System.Windows.Forms.SplitContainer();
            this.gbRegistrarLibro = new System.Windows.Forms.GroupBox();
            this.btnLimpiarLibro = new System.Windows.Forms.Button();
            this.btnRegistrarLibro = new System.Windows.Forms.Button();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.lblTituloLibro = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.gbCatalogoLibros = new System.Windows.Forms.GroupBox();
            this.pnlBotonesCatalogo = new System.Windows.Forms.Panel();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.btnActualizarLibro = new System.Windows.Forms.Button();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubtituloLibros = new System.Windows.Forms.Label();
            this.tblPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.statusLibros = new System.Windows.Forms.StatusStrip();
            this.lblEstadoLibros = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalLibros = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAgotadosLibros = new System.Windows.Forms.ToolStripStatusLabel();
            this.picIcono = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLibros)).BeginInit();
            this.splitLibros.Panel1.SuspendLayout();
            this.splitLibros.Panel2.SuspendLayout();
            this.splitLibros.SuspendLayout();
            this.gbRegistrarLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.gbCatalogoLibros.SuspendLayout();
            this.pnlBotonesCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.tblPrincipal.SuspendLayout();
            this.statusLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.pnlHeader.Controls.Add(this.pnlCentro);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1190, 140);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlCentro
            // 
            this.pnlCentro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCentro.BackColor = System.Drawing.Color.Transparent;
            this.pnlCentro.Controls.Add(this.lblTitulo);
            this.pnlCentro.Controls.Add(this.picIcono);
            this.pnlCentro.Location = new System.Drawing.Point(331, 12);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(500, 100);
            this.pnlCentro.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(194, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(185, 67);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "LIBROS";
            // 
            // splitLibros
            // 
            this.splitLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLibros.Location = new System.Drawing.Point(122, 50);
            this.splitLibros.Name = "splitLibros";
            // 
            // splitLibros.Panel1
            // 
            this.splitLibros.Panel1.Controls.Add(this.gbRegistrarLibro);
            // 
            // splitLibros.Panel2
            // 
            this.splitLibros.Panel2.Controls.Add(this.gbCatalogoLibros);
            this.splitLibros.Size = new System.Drawing.Size(946, 490);
            this.splitLibros.SplitterDistance = 234;
            this.splitLibros.TabIndex = 1;
            // 
            // gbRegistrarLibro
            // 
            this.gbRegistrarLibro.Controls.Add(this.btnLimpiarLibro);
            this.gbRegistrarLibro.Controls.Add(this.btnRegistrarLibro);
            this.gbRegistrarLibro.Controls.Add(this.numCantidad);
            this.gbRegistrarLibro.Controls.Add(this.lblCantidad);
            this.gbRegistrarLibro.Controls.Add(this.cmbCategoria);
            this.gbRegistrarLibro.Controls.Add(this.lblCategoria);
            this.gbRegistrarLibro.Controls.Add(this.txtEditorial);
            this.gbRegistrarLibro.Controls.Add(this.lblEditorial);
            this.gbRegistrarLibro.Controls.Add(this.txtAutor);
            this.gbRegistrarLibro.Controls.Add(this.lblAutor);
            this.gbRegistrarLibro.Controls.Add(this.txtTituloLibro);
            this.gbRegistrarLibro.Controls.Add(this.lblTituloLibro);
            this.gbRegistrarLibro.Controls.Add(this.txtISBN);
            this.gbRegistrarLibro.Controls.Add(this.lblISBN);
            this.gbRegistrarLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRegistrarLibro.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrarLibro.Location = new System.Drawing.Point(0, 0);
            this.gbRegistrarLibro.Name = "gbRegistrarLibro";
            this.gbRegistrarLibro.Size = new System.Drawing.Size(234, 490);
            this.gbRegistrarLibro.TabIndex = 0;
            this.gbRegistrarLibro.TabStop = false;
            this.gbRegistrarLibro.Text = "Registrar Libro";
            // 
            // btnLimpiarLibro
            // 
            this.btnLimpiarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarLibro.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarLibro.Location = new System.Drawing.Point(18, 416);
            this.btnLimpiarLibro.Name = "btnLimpiarLibro";
            this.btnLimpiarLibro.Size = new System.Drawing.Size(292, 45);
            this.btnLimpiarLibro.TabIndex = 13;
            this.btnLimpiarLibro.Text = "Limpiar";
            this.btnLimpiarLibro.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarLibro
            // 
            this.btnRegistrarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.btnRegistrarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarLibro.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarLibro.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarLibro.Location = new System.Drawing.Point(18, 357);
            this.btnRegistrarLibro.Name = "btnRegistrarLibro";
            this.btnRegistrarLibro.Size = new System.Drawing.Size(292, 53);
            this.btnRegistrarLibro.TabIndex = 12;
            this.btnRegistrarLibro.Text = "Registrar Libro";
            this.btnRegistrarLibro.UseVisualStyleBackColor = false;
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCantidad.Location = new System.Drawing.Point(110, 297);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(200, 45);
            this.numCantidad.TabIndex = 11;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(6, 307);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(98, 36);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Literatura",
            "Tecnología",
            "Ciencia",
            "Historia",
            "Novela",
            "Académico"});
            this.cmbCategoria.Location = new System.Drawing.Point(110, 247);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(200, 44);
            this.cmbCategoria.TabIndex = 9;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(6, 255);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(104, 36);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorial.Location = new System.Drawing.Point(110, 195);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(200, 45);
            this.txtEditorial.TabIndex = 7;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.Location = new System.Drawing.Point(12, 205);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(92, 36);
            this.lblEditorial.TabIndex = 6;
            this.lblEditorial.Text = "Editorial:";
            this.lblEditorial.Click += new System.EventHandler(this.lblEditorial_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(110, 143);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(200, 45);
            this.txtAutor.TabIndex = 5;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(35, 153);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(69, 36);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "Autor:";
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloLibro.Location = new System.Drawing.Point(110, 91);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(200, 45);
            this.txtTituloLibro.TabIndex = 3;
            // 
            // lblTituloLibro
            // 
            this.lblTituloLibro.AutoSize = true;
            this.lblTituloLibro.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLibro.Location = new System.Drawing.Point(35, 101);
            this.lblTituloLibro.Name = "lblTituloLibro";
            this.lblTituloLibro.Size = new System.Drawing.Size(69, 36);
            this.lblTituloLibro.TabIndex = 2;
            this.lblTituloLibro.Text = "Título:";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(110, 39);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(200, 45);
            this.txtISBN.TabIndex = 1;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(43, 49);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(61, 36);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN:";
            // 
            // gbCatalogoLibros
            // 
            this.gbCatalogoLibros.Controls.Add(this.pnlBotonesCatalogo);
            this.gbCatalogoLibros.Controls.Add(this.dgvLibros);
            this.gbCatalogoLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCatalogoLibros.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCatalogoLibros.Location = new System.Drawing.Point(0, 0);
            this.gbCatalogoLibros.Name = "gbCatalogoLibros";
            this.gbCatalogoLibros.Size = new System.Drawing.Size(708, 490);
            this.gbCatalogoLibros.TabIndex = 0;
            this.gbCatalogoLibros.TabStop = false;
            this.gbCatalogoLibros.Text = "Catálogo de Libros";
            // 
            // pnlBotonesCatalogo
            // 
            this.pnlBotonesCatalogo.Controls.Add(this.btnEliminarLibro);
            this.pnlBotonesCatalogo.Controls.Add(this.btnActualizarLibro);
            this.pnlBotonesCatalogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonesCatalogo.Location = new System.Drawing.Point(3, 407);
            this.pnlBotonesCatalogo.Name = "pnlBotonesCatalogo";
            this.pnlBotonesCatalogo.Size = new System.Drawing.Size(702, 80);
            this.pnlBotonesCatalogo.TabIndex = 3;
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLibro.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarLibro.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEliminarLibro.Location = new System.Drawing.Point(550, 5);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(140, 53);
            this.btnEliminarLibro.TabIndex = 3;
            this.btnEliminarLibro.Text = "Eliminar";
            this.btnEliminarLibro.UseVisualStyleBackColor = true;
            // 
            // btnActualizarLibro
            // 
            this.btnActualizarLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.btnActualizarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarLibro.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarLibro.Location = new System.Drawing.Point(393, 5);
            this.btnActualizarLibro.Name = "btnActualizarLibro";
            this.btnActualizarLibro.Size = new System.Drawing.Size(140, 53);
            this.btnActualizarLibro.TabIndex = 2;
            this.btnActualizarLibro.Text = "Actualizar";
            this.btnActualizarLibro.UseVisualStyleBackColor = false;
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.White;
            this.dgvLibros.ColumnHeadersHeight = 60;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colISBN,
            this.colTitulo,
            this.colAutor,
            this.colTotal,
            this.colDisponibles});
            this.dgvLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLibros.Location = new System.Drawing.Point(3, 42);
            this.dgvLibros.MultiSelect = false;
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.RowHeadersWidth = 62;
            this.dgvLibros.RowTemplate.Height = 28;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(702, 300);
            this.dgvLibros.TabIndex = 0;
            // 
            // colISBN
            // 
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.MinimumWidth = 8;
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            // 
            // colTitulo
            // 
            this.colTitulo.HeaderText = "Título";
            this.colTitulo.MinimumWidth = 8;
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor";
            this.colAutor.MinimumWidth = 8;
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 8;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colDisponibles
            // 
            this.colDisponibles.HeaderText = "Disponibles";
            this.colDisponibles.MinimumWidth = 8;
            this.colDisponibles.Name = "colDisponibles";
            this.colDisponibles.ReadOnly = true;
            // 
            // lblSubtituloLibros
            // 
            this.lblSubtituloLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtituloLibros.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtituloLibros.Location = new System.Drawing.Point(122, 0);
            this.lblSubtituloLibros.Name = "lblSubtituloLibros";
            this.lblSubtituloLibros.Size = new System.Drawing.Size(946, 47);
            this.lblSubtituloLibros.TabIndex = 0;
            this.lblSubtituloLibros.Text = "Registro y consulta del catálogo";
            this.lblSubtituloLibros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubtituloLibros.Click += new System.EventHandler(this.lblSubtituloLibros_Click);
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.ColumnCount = 3;
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPrincipal.Controls.Add(this.lblSubtituloLibros, 1, 0);
            this.tblPrincipal.Controls.Add(this.splitLibros, 1, 1);
            this.tblPrincipal.Controls.Add(this.statusLibros, 1, 2);
            this.tblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrincipal.Location = new System.Drawing.Point(0, 140);
            this.tblPrincipal.Name = "tblPrincipal";
            this.tblPrincipal.RowCount = 3;
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblPrincipal.Size = new System.Drawing.Size(1190, 591);
            this.tblPrincipal.TabIndex = 1;
            // 
            // statusLibros
            // 
            this.statusLibros.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusLibros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoLibros,
            this.lblTotalLibros,
            this.lblAgotadosLibros});
            this.statusLibros.Location = new System.Drawing.Point(119, 548);
            this.statusLibros.Name = "statusLibros";
            this.statusLibros.Size = new System.Drawing.Size(952, 43);
            this.statusLibros.TabIndex = 2;
            this.statusLibros.Text = "statusStrip1";
            // 
            // lblEstadoLibros
            // 
            this.lblEstadoLibros.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoLibros.Name = "lblEstadoLibros";
            this.lblEstadoLibros.Size = new System.Drawing.Size(94, 36);
            this.lblEstadoLibros.Text = "✔ Listo";
            // 
            // lblTotalLibros
            // 
            this.lblTotalLibros.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLibros.Name = "lblTotalLibros";
            this.lblTotalLibros.Size = new System.Drawing.Size(198, 36);
            this.lblTotalLibros.Text = "0 libros registrados";
            // 
            // lblAgotadosLibros
            // 
            this.lblAgotadosLibros.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgotadosLibros.ForeColor = System.Drawing.Color.Red;
            this.lblAgotadosLibros.Name = "lblAgotadosLibros";
            this.lblAgotadosLibros.Size = new System.Drawing.Size(128, 36);
            this.lblAgotadosLibros.Text = "Agotados: 0";
            // 
            // picIcono
            // 
            this.picIcono.Image = global::BibliotecaApp.Properties.Resources.bookshelf_icon_icons_com_54414__3_;
            this.picIcono.Location = new System.Drawing.Point(128, 20);
            this.picIcono.Name = "picIcono";
            this.picIcono.Size = new System.Drawing.Size(60, 60);
            this.picIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcono.TabIndex = 0;
            this.picIcono.TabStop = false;
            // 
            // FormLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 731);
            this.Controls.Add(this.tblPrincipal);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FormLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Libros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            this.splitLibros.Panel1.ResumeLayout(false);
            this.splitLibros.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLibros)).EndInit();
            this.splitLibros.ResumeLayout(false);
            this.gbRegistrarLibro.ResumeLayout(false);
            this.gbRegistrarLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.gbCatalogoLibros.ResumeLayout(false);
            this.pnlBotonesCatalogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.tblPrincipal.ResumeLayout(false);
            this.tblPrincipal.PerformLayout();
            this.statusLibros.ResumeLayout(false);
            this.statusLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picIcono;
        private System.Windows.Forms.SplitContainer splitLibros;
        private System.Windows.Forms.GroupBox gbRegistrarLibro;
        private System.Windows.Forms.Button btnLimpiarLibro;
        private System.Windows.Forms.Button btnRegistrarLibro;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.Label lblTituloLibro;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.GroupBox gbCatalogoLibros;
        private System.Windows.Forms.Panel pnlBotonesCatalogo;
        private System.Windows.Forms.Button btnActualizarLibro;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisponibles;
        private System.Windows.Forms.Label lblSubtituloLibros;
        private System.Windows.Forms.TableLayoutPanel tblPrincipal;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.StatusStrip statusLibros;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoLibros;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalLibros;
        private System.Windows.Forms.ToolStripStatusLabel lblAgotadosLibros;
    }
}
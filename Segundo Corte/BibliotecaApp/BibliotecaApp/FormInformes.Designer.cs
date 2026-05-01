namespace BibliotecaApp
{
    partial class FormInformes
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
            this.pnlHeaderInformes = new System.Windows.Forms.Panel();
            this.pnlTituloInformes = new System.Windows.Forms.Panel();
            this.picIconoInformes = new System.Windows.Forms.PictureBox();
            this.lblTituloInformes = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEjemplaresDisponibles = new System.Windows.Forms.Panel();
            this.lblNumDisponibles = new System.Windows.Forms.Label();
            this.lblTextoDisponibles = new System.Windows.Forms.Label();
            this.pnlPrestamosActivos = new System.Windows.Forms.Panel();
            this.lblNumActivos = new System.Windows.Forms.Label();
            this.lblTextoActivos = new System.Windows.Forms.Label();
            this.pnlPrestamosVencidos = new System.Windows.Forms.Panel();
            this.lblNumVencidos = new System.Windows.Forms.Label();
            this.lblTextoVencidos = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.tblFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoriaFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.gbDisponibilidadLibro = new System.Windows.Forms.GroupBox();
            this.dgvDisponibilidad = new System.Windows.Forms.DataGridView();
            this.gbPrestamosVencidos = new System.Windows.Forms.GroupBox();
            this.dgvPrestamosVencidos = new System.Windows.Forms.DataGridView();
            this.colIDVencido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLibroVencido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstudianteVencido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaPrestamoVencido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEsperadaVencido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiasMora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstadoInformes = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalTitulos = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalVencidos = new System.Windows.Forms.ToolStripStatusLabel();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrestados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeaderInformes.SuspendLayout();
            this.pnlTituloInformes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoInformes)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlEjemplaresDisponibles.SuspendLayout();
            this.pnlPrestamosActivos.SuspendLayout();
            this.pnlPrestamosVencidos.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.tblFiltros.SuspendLayout();
            this.gbDisponibilidadLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibilidad)).BeginInit();
            this.gbPrestamosVencidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosVencidos)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderInformes
            // 
            this.pnlHeaderInformes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.pnlHeaderInformes.Controls.Add(this.pnlTituloInformes);
            this.pnlHeaderInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderInformes.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderInformes.Name = "pnlHeaderInformes";
            this.pnlHeaderInformes.Size = new System.Drawing.Size(1179, 140);
            this.pnlHeaderInformes.TabIndex = 0;
            // 
            // pnlTituloInformes
            // 
            this.pnlTituloInformes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTituloInformes.BackColor = System.Drawing.Color.Transparent;
            this.pnlTituloInformes.Controls.Add(this.lblTituloInformes);
            this.pnlTituloInformes.Controls.Add(this.picIconoInformes);
            this.pnlTituloInformes.Location = new System.Drawing.Point(295, 22);
            this.pnlTituloInformes.Name = "pnlTituloInformes";
            this.pnlTituloInformes.Size = new System.Drawing.Size(600, 100);
            this.pnlTituloInformes.TabIndex = 0;
            // 
            // picIconoInformes
            // 
            this.picIconoInformes.Image = global::BibliotecaApp.Properties.Resources.iconfinder_documents01_1622837_121952;
            this.picIconoInformes.Location = new System.Drawing.Point(100, 15);
            this.picIconoInformes.Name = "picIconoInformes";
            this.picIconoInformes.Size = new System.Drawing.Size(65, 65);
            this.picIconoInformes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconoInformes.TabIndex = 0;
            this.picIconoInformes.TabStop = false;
            // 
            // lblTituloInformes
            // 
            this.lblTituloInformes.AutoSize = true;
            this.lblTituloInformes.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInformes.Location = new System.Drawing.Point(171, 13);
            this.lblTituloInformes.Name = "lblTituloInformes";
            this.lblTituloInformes.Size = new System.Drawing.Size(239, 67);
            this.lblTituloInformes.TabIndex = 1;
            this.lblTituloInformes.Text = "INFORMES";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.pnlEjemplaresDisponibles, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlPrestamosActivos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlPrestamosVencidos, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 140);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1179, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnlEjemplaresDisponibles
            // 
            this.pnlEjemplaresDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEjemplaresDisponibles.Controls.Add(this.lblTextoDisponibles);
            this.pnlEjemplaresDisponibles.Controls.Add(this.lblNumDisponibles);
            this.pnlEjemplaresDisponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEjemplaresDisponibles.Location = new System.Drawing.Point(10, 10);
            this.pnlEjemplaresDisponibles.Margin = new System.Windows.Forms.Padding(10);
            this.pnlEjemplaresDisponibles.Name = "pnlEjemplaresDisponibles";
            this.pnlEjemplaresDisponibles.Size = new System.Drawing.Size(369, 80);
            this.pnlEjemplaresDisponibles.TabIndex = 0;
            // 
            // lblNumDisponibles
            // 
            this.lblNumDisponibles.AutoSize = true;
            this.lblNumDisponibles.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDisponibles.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblNumDisponibles.Location = new System.Drawing.Point(272, 0);
            this.lblNumDisponibles.Name = "lblNumDisponibles";
            this.lblNumDisponibles.Size = new System.Drawing.Size(48, 63);
            this.lblNumDisponibles.TabIndex = 0;
            this.lblNumDisponibles.Text = "0";
            this.lblNumDisponibles.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTextoDisponibles
            // 
            this.lblTextoDisponibles.AutoSize = true;
            this.lblTextoDisponibles.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoDisponibles.Location = new System.Drawing.Point(191, 43);
            this.lblTextoDisponibles.Name = "lblTextoDisponibles";
            this.lblTextoDisponibles.Size = new System.Drawing.Size(214, 36);
            this.lblTextoDisponibles.TabIndex = 1;
            this.lblTextoDisponibles.Text = "Ejemplares disponibles";
            this.lblTextoDisponibles.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTextoDisponibles.Click += new System.EventHandler(this.lblTextoDisponibles_Click);
            // 
            // pnlPrestamosActivos
            // 
            this.pnlPrestamosActivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrestamosActivos.Controls.Add(this.lblTextoActivos);
            this.pnlPrestamosActivos.Controls.Add(this.lblNumActivos);
            this.pnlPrestamosActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrestamosActivos.Location = new System.Drawing.Point(399, 10);
            this.pnlPrestamosActivos.Margin = new System.Windows.Forms.Padding(10);
            this.pnlPrestamosActivos.Name = "pnlPrestamosActivos";
            this.pnlPrestamosActivos.Size = new System.Drawing.Size(380, 80);
            this.pnlPrestamosActivos.TabIndex = 1;
            // 
            // lblNumActivos
            // 
            this.lblNumActivos.AutoSize = true;
            this.lblNumActivos.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumActivos.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblNumActivos.Location = new System.Drawing.Point(274, 0);
            this.lblNumActivos.Name = "lblNumActivos";
            this.lblNumActivos.Size = new System.Drawing.Size(48, 63);
            this.lblNumActivos.TabIndex = 0;
            this.lblNumActivos.Text = "0";
            // 
            // lblTextoActivos
            // 
            this.lblTextoActivos.AutoSize = true;
            this.lblTextoActivos.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoActivos.Location = new System.Drawing.Point(202, 42);
            this.lblTextoActivos.Name = "lblTextoActivos";
            this.lblTextoActivos.Size = new System.Drawing.Size(171, 36);
            this.lblTextoActivos.TabIndex = 1;
            this.lblTextoActivos.Text = "Préstamos activos";
            // 
            // pnlPrestamosVencidos
            // 
            this.pnlPrestamosVencidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrestamosVencidos.Controls.Add(this.lblTextoVencidos);
            this.pnlPrestamosVencidos.Controls.Add(this.lblNumVencidos);
            this.pnlPrestamosVencidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrestamosVencidos.Location = new System.Drawing.Point(799, 10);
            this.pnlPrestamosVencidos.Margin = new System.Windows.Forms.Padding(10);
            this.pnlPrestamosVencidos.Name = "pnlPrestamosVencidos";
            this.pnlPrestamosVencidos.Size = new System.Drawing.Size(370, 80);
            this.pnlPrestamosVencidos.TabIndex = 2;
            // 
            // lblNumVencidos
            // 
            this.lblNumVencidos.AutoSize = true;
            this.lblNumVencidos.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVencidos.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNumVencidos.Location = new System.Drawing.Point(248, 0);
            this.lblNumVencidos.Name = "lblNumVencidos";
            this.lblNumVencidos.Size = new System.Drawing.Size(48, 63);
            this.lblNumVencidos.TabIndex = 0;
            this.lblNumVencidos.Text = "0";
            // 
            // lblTextoVencidos
            // 
            this.lblTextoVencidos.AutoSize = true;
            this.lblTextoVencidos.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoVencidos.Location = new System.Drawing.Point(175, 42);
            this.lblTextoVencidos.Name = "lblTextoVencidos";
            this.lblTextoVencidos.Size = new System.Drawing.Size(187, 36);
            this.lblTextoVencidos.TabIndex = 1;
            this.lblTextoVencidos.Text = "Préstamos vencidos";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltros.Controls.Add(this.tblFiltros);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 240);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1179, 80);
            this.pnlFiltros.TabIndex = 2;
            // 
            // tblFiltros
            // 
            this.tblFiltros.ColumnCount = 6;
            this.tblFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblFiltros.Controls.Add(this.label1, 1, 0);
            this.tblFiltros.Controls.Add(this.cmbCategoriaFiltro, 1, 1);
            this.tblFiltros.Controls.Add(this.label2, 3, 0);
            this.tblFiltros.Controls.Add(this.cmbEstado, 3, 1);
            this.tblFiltros.Controls.Add(this.btnFiltrar, 4, 0);
            this.tblFiltros.Controls.Add(this.btnVerTodo, 5, 0);
            this.tblFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFiltros.Location = new System.Drawing.Point(0, 0);
            this.tblFiltros.Name = "tblFiltros";
            this.tblFiltros.RowCount = 2;
            this.tblFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblFiltros.Size = new System.Drawing.Size(1177, 78);
            this.tblFiltros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por categoría:";
            // 
            // cmbCategoriaFiltro
            // 
            this.cmbCategoriaFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaFiltro.FormattingEnabled = true;
            this.cmbCategoriaFiltro.Items.AddRange(new object[] {
            "— Todas —",
            "Literatura",
            "Clásicos",
            "Ciencia",
            "Historia",
            "Tecnología"});
            this.cmbCategoriaFiltro.Location = new System.Drawing.Point(3, 49);
            this.cmbCategoriaFiltro.Name = "cmbCategoriaFiltro";
            this.cmbCategoriaFiltro.Size = new System.Drawing.Size(191, 28);
            this.cmbCategoriaFiltro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            " Todos",
            " Disponibles",
            " Prestados",
            " Vencidos"});
            this.cmbEstado.Location = new System.Drawing.Point(203, 49);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(144, 28);
            this.cmbEstado.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnFiltrar.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrar.Location = new System.Drawing.Point(353, 3);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(114, 40);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "🔍 Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Location = new System.Drawing.Point(473, 3);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(116, 40);
            this.btnVerTodo.TabIndex = 5;
            this.btnVerTodo.Text = "Ver todo";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            // 
            // gbDisponibilidadLibro
            // 
            this.gbDisponibilidadLibro.Controls.Add(this.dgvDisponibilidad);
            this.gbDisponibilidadLibro.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDisponibilidadLibro.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDisponibilidadLibro.Location = new System.Drawing.Point(0, 320);
            this.gbDisponibilidadLibro.Name = "gbDisponibilidadLibro";
            this.gbDisponibilidadLibro.Size = new System.Drawing.Size(1179, 260);
            this.gbDisponibilidadLibro.TabIndex = 3;
            this.gbDisponibilidadLibro.TabStop = false;
            this.gbDisponibilidadLibro.Text = "Disponibilidad por Libro";
            // 
            // dgvDisponibilidad
            // 
            this.dgvDisponibilidad.AllowUserToAddRows = false;
            this.dgvDisponibilidad.AllowUserToDeleteRows = false;
            this.dgvDisponibilidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisponibilidad.BackgroundColor = System.Drawing.Color.White;
            this.dgvDisponibilidad.ColumnHeadersHeight = 45;
            this.dgvDisponibilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDisponibilidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colISBN,
            this.colTitulo,
            this.colTotal,
            this.colPrestados,
            this.colDisponibles,
            this.colCategoria});
            this.dgvDisponibilidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisponibilidad.EnableHeadersVisualStyles = false;
            this.dgvDisponibilidad.Location = new System.Drawing.Point(3, 42);
            this.dgvDisponibilidad.Name = "dgvDisponibilidad";
            this.dgvDisponibilidad.ReadOnly = true;
            this.dgvDisponibilidad.RowHeadersVisible = false;
            this.dgvDisponibilidad.RowHeadersWidth = 62;
            this.dgvDisponibilidad.RowTemplate.Height = 28;
            this.dgvDisponibilidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisponibilidad.Size = new System.Drawing.Size(1173, 215);
            this.dgvDisponibilidad.TabIndex = 0;
            // 
            // gbPrestamosVencidos
            // 
            this.gbPrestamosVencidos.Controls.Add(this.dgvPrestamosVencidos);
            this.gbPrestamosVencidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPrestamosVencidos.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrestamosVencidos.Location = new System.Drawing.Point(0, 580);
            this.gbPrestamosVencidos.Name = "gbPrestamosVencidos";
            this.gbPrestamosVencidos.Size = new System.Drawing.Size(1179, 180);
            this.gbPrestamosVencidos.TabIndex = 4;
            this.gbPrestamosVencidos.TabStop = false;
            this.gbPrestamosVencidos.Text = "ta";
            // 
            // dgvPrestamosVencidos
            // 
            this.dgvPrestamosVencidos.AllowUserToAddRows = false;
            this.dgvPrestamosVencidos.AllowUserToDeleteRows = false;
            this.dgvPrestamosVencidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamosVencidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrestamosVencidos.ColumnHeadersHeight = 45;
            this.dgvPrestamosVencidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrestamosVencidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDVencido,
            this.colLibroVencido,
            this.colEstudianteVencido,
            this.colFechaPrestamoVencido,
            this.colFechaEsperadaVencido,
            this.colDiasMora});
            this.dgvPrestamosVencidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrestamosVencidos.EnableHeadersVisualStyles = false;
            this.dgvPrestamosVencidos.Location = new System.Drawing.Point(3, 42);
            this.dgvPrestamosVencidos.Name = "dgvPrestamosVencidos";
            this.dgvPrestamosVencidos.ReadOnly = true;
            this.dgvPrestamosVencidos.RowHeadersVisible = false;
            this.dgvPrestamosVencidos.RowHeadersWidth = 62;
            this.dgvPrestamosVencidos.RowTemplate.Height = 28;
            this.dgvPrestamosVencidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamosVencidos.Size = new System.Drawing.Size(1173, 135);
            this.dgvPrestamosVencidos.TabIndex = 0;
            // 
            // colIDVencido
            // 
            this.colIDVencido.HeaderText = "ID";
            this.colIDVencido.MinimumWidth = 8;
            this.colIDVencido.Name = "colIDVencido";
            this.colIDVencido.ReadOnly = true;
            // 
            // colLibroVencido
            // 
            this.colLibroVencido.HeaderText = "Libro";
            this.colLibroVencido.MinimumWidth = 8;
            this.colLibroVencido.Name = "colLibroVencido";
            this.colLibroVencido.ReadOnly = true;
            // 
            // colEstudianteVencido
            // 
            this.colEstudianteVencido.HeaderText = "Estudiante";
            this.colEstudianteVencido.MinimumWidth = 8;
            this.colEstudianteVencido.Name = "colEstudianteVencido";
            this.colEstudianteVencido.ReadOnly = true;
            // 
            // colFechaPrestamoVencido
            // 
            this.colFechaPrestamoVencido.HeaderText = "F. Préstamo";
            this.colFechaPrestamoVencido.MinimumWidth = 8;
            this.colFechaPrestamoVencido.Name = "colFechaPrestamoVencido";
            this.colFechaPrestamoVencido.ReadOnly = true;
            // 
            // colFechaEsperadaVencido
            // 
            this.colFechaEsperadaVencido.HeaderText = "F. Esperada";
            this.colFechaEsperadaVencido.MinimumWidth = 8;
            this.colFechaEsperadaVencido.Name = "colFechaEsperadaVencido";
            this.colFechaEsperadaVencido.ReadOnly = true;
            // 
            // colDiasMora
            // 
            this.colDiasMora.HeaderText = "Días mora";
            this.colDiasMora.MinimumWidth = 8;
            this.colDiasMora.Name = "colDiasMora";
            this.colDiasMora.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoInformes,
            this.lblTotalTitulos,
            this.lblTotalVencidos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 822);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1179, 43);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstadoInformes
            // 
            this.lblEstadoInformes.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoInformes.Name = "lblEstadoInformes";
            this.lblEstadoInformes.Size = new System.Drawing.Size(228, 36);
            this.lblEstadoInformes.Text = "✔ Datos actualizados";
            // 
            // lblTotalTitulos
            // 
            this.lblTotalTitulos.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTitulos.Name = "lblTotalTitulos";
            this.lblTotalTitulos.Size = new System.Drawing.Size(94, 36);
            this.lblTotalTitulos.Text = "0 títulos";
            // 
            // lblTotalVencidos
            // 
            this.lblTotalVencidos.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVencidos.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTotalVencidos.Name = "lblTotalVencidos";
            this.lblTotalVencidos.Size = new System.Drawing.Size(116, 36);
            this.lblTotalVencidos.Text = "0 vencidos";
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
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 8;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colPrestados
            // 
            this.colPrestados.HeaderText = "Prestados";
            this.colPrestados.MinimumWidth = 8;
            this.colPrestados.Name = "colPrestados";
            this.colPrestados.ReadOnly = true;
            // 
            // colDisponibles
            // 
            this.colDisponibles.HeaderText = "Disponibles";
            this.colDisponibles.MinimumWidth = 8;
            this.colDisponibles.Name = "colDisponibles";
            this.colDisponibles.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.MinimumWidth = 8;
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // FormInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1179, 865);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbPrestamosVencidos);
            this.Controls.Add(this.gbDisponibilidadLibro);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlHeaderInformes);
            this.Name = "FormInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informes de Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeaderInformes.ResumeLayout(false);
            this.pnlTituloInformes.ResumeLayout(false);
            this.pnlTituloInformes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoInformes)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlEjemplaresDisponibles.ResumeLayout(false);
            this.pnlEjemplaresDisponibles.PerformLayout();
            this.pnlPrestamosActivos.ResumeLayout(false);
            this.pnlPrestamosActivos.PerformLayout();
            this.pnlPrestamosVencidos.ResumeLayout(false);
            this.pnlPrestamosVencidos.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.tblFiltros.ResumeLayout(false);
            this.tblFiltros.PerformLayout();
            this.gbDisponibilidadLibro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibilidad)).EndInit();
            this.gbPrestamosVencidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosVencidos)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderInformes;
        private System.Windows.Forms.Panel pnlTituloInformes;
        private System.Windows.Forms.PictureBox picIconoInformes;
        private System.Windows.Forms.Label lblTituloInformes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlEjemplaresDisponibles;
        private System.Windows.Forms.Label lblTextoDisponibles;
        private System.Windows.Forms.Label lblNumDisponibles;
        private System.Windows.Forms.Panel pnlPrestamosActivos;
        private System.Windows.Forms.Label lblTextoActivos;
        private System.Windows.Forms.Label lblNumActivos;
        private System.Windows.Forms.Panel pnlPrestamosVencidos;
        private System.Windows.Forms.Label lblNumVencidos;
        private System.Windows.Forms.Label lblTextoVencidos;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.TableLayoutPanel tblFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoriaFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.GroupBox gbDisponibilidadLibro;
        private System.Windows.Forms.DataGridView dgvDisponibilidad;
        private System.Windows.Forms.GroupBox gbPrestamosVencidos;
        private System.Windows.Forms.DataGridView dgvPrestamosVencidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDVencido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLibroVencido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstudianteVencido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaPrestamoVencido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEsperadaVencido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiasMora;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoInformes;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalTitulos;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalVencidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrestados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
    }
}
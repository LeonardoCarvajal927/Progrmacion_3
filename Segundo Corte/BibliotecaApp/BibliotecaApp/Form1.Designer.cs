namespace BibliotecaApp
{
    partial class FormPrincipal
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.tlpCentro = new System.Windows.Forms.TableLayoutPanel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnDevoluciones = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.tlpCentro.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.MaximumSize = new System.Drawing.Size(0, 110);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1232, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1232, 100);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BIBLIOTECA DIGITAL";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.tlpCentro);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 100);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1232, 369);
            this.panelContenido.TabIndex = 1;
            // 
            // tlpCentro
            // 
            this.tlpCentro.ColumnCount = 3;
            this.tlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpCentro.Controls.Add(this.panelBotones, 1, 1);
            this.tlpCentro.Controls.Add(this.lblSubtitulo, 1, 0);
            this.tlpCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCentro.Location = new System.Drawing.Point(0, 0);
            this.tlpCentro.Name = "tlpCentro";
            this.tlpCentro.RowCount = 3;
            this.tlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpCentro.Size = new System.Drawing.Size(1232, 369);
            this.tlpCentro.TabIndex = 0;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.tableLayoutPanel1);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotones.Location = new System.Drawing.Point(126, 39);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(979, 289);
            this.panelBotones.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnLibros, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrestamos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDevoluciones, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInformes, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 289);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnLibros
            // 
            this.btnLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibros.Font = new System.Drawing.Font("Myanmar Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros.Image = global::BibliotecaApp.Properties.Resources.bookshelf_icon_icons_com_54414__3_;
            this.btnLibros.Location = new System.Drawing.Point(3, 3);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(238, 283);
            this.btnLibros.TabIndex = 0;
            this.btnLibros.Text = "Libros";
            this.btnLibros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLibros.UseVisualStyleBackColor = true;
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.Font = new System.Drawing.Font("Myanmar Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.Image = global::BibliotecaApp.Properties.Resources.clipboard_notes_list_tasks_icon_191193;
            this.btnPrestamos.Location = new System.Drawing.Point(247, 3);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(238, 283);
            this.btnPrestamos.TabIndex = 1;
            this.btnPrestamos.Text = "Préstamos";
            this.btnPrestamos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrestamos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPrestamos.UseVisualStyleBackColor = true;
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevoluciones.Font = new System.Drawing.Font("Myanmar Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevoluciones.Image = global::BibliotecaApp.Properties.Resources.left_arrow_curved_black_symbol_icon_icons_com_73000;
            this.btnDevoluciones.Location = new System.Drawing.Point(491, 3);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Size = new System.Drawing.Size(238, 283);
            this.btnDevoluciones.TabIndex = 2;
            this.btnDevoluciones.Text = "Devoluciones";
            this.btnDevoluciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDevoluciones.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDevoluciones.UseVisualStyleBackColor = true;
            // 
            // btnInformes
            // 
            this.btnInformes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Myanmar Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.Image = global::BibliotecaApp.Properties.Resources.iconfinder_documents01_1622837_121952;
            this.btnInformes.Location = new System.Drawing.Point(735, 3);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(241, 283);
            this.btnInformes.TabIndex = 3;
            this.btnInformes.Text = "Informes";
            this.btnInformes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInformes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnInformes.UseVisualStyleBackColor = true;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtitulo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(126, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(979, 36);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Seleccione un módulo para empezar";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1232, 469);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormPrincipal";
            this.Text = "Sistema Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.tlpCentro.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.TableLayoutPanel tlpCentro;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnDevoluciones;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Label lblSubtitulo;
    }
}


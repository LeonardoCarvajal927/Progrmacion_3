namespace SistemaMovimientoTierra.Views
{
    partial class FrmCalculoVolumen
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
            this.lblMetodo = new System.Windows.Forms.Label();
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.lblFilas = new System.Windows.Forms.Label();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.lblColumnas = new System.Windows.Forms.Label();
            this.txtDx = new System.Windows.Forms.TextBox();
            this.lblDx = new System.Windows.Forms.Label();
            this.txtDy = new System.Windows.Forms.TextBox();
            this.lblDy = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.lblH = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbMatriz = new System.Windows.Forms.GroupBox();
            this.dgvAlturas = new System.Windows.Forms.DataGridView();
            this.btnGenerarMatriz = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.lblTextoVolumen = new System.Windows.Forms.Label();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.lblMetodoResultado = new System.Windows.Forms.Label();
            this.lblNotaGrafica = new System.Windows.Forms.Label();
            this.btnGrafica3D = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            this.gbConfiguracion.SuspendLayout();
            this.gbMatriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlturas)).BeginInit();
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
            this.pnlSuperior.Size = new System.Drawing.Size(1440, 90);
            this.pnlSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1440, 90);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CÁLCULO DE VOLUMEN";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbConfiguracion
            // 
            this.gbConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbConfiguracion.Controls.Add(this.btnCerrar);
            this.gbConfiguracion.Controls.Add(this.btnLimpiar);
            this.gbConfiguracion.Controls.Add(this.txtH);
            this.gbConfiguracion.Controls.Add(this.lblH);
            this.gbConfiguracion.Controls.Add(this.txtDy);
            this.gbConfiguracion.Controls.Add(this.lblDy);
            this.gbConfiguracion.Controls.Add(this.txtDx);
            this.gbConfiguracion.Controls.Add(this.lblDx);
            this.gbConfiguracion.Controls.Add(this.txtColumnas);
            this.gbConfiguracion.Controls.Add(this.lblColumnas);
            this.gbConfiguracion.Controls.Add(this.txtFilas);
            this.gbConfiguracion.Controls.Add(this.lblFilas);
            this.gbConfiguracion.Controls.Add(this.cmbMetodo);
            this.gbConfiguracion.Controls.Add(this.lblMetodo);
            this.gbConfiguracion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConfiguracion.Location = new System.Drawing.Point(30, 120);
            this.gbConfiguracion.Name = "gbConfiguracion";
            this.gbConfiguracion.Size = new System.Drawing.Size(360, 440);
            this.gbConfiguracion.TabIndex = 1;
            this.gbConfiguracion.TabStop = false;
            this.gbConfiguracion.Text = "Configuración del cálculo";
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodo.Location = new System.Drawing.Point(40, 58);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(87, 28);
            this.lblMetodo.TabIndex = 0;
            this.lblMetodo.Text = "Método:";
            // 
            // cmbMetodo
            // 
            this.cmbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMetodo.FormattingEnabled = true;
            this.cmbMetodo.Location = new System.Drawing.Point(110, 55);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(226, 36);
            this.cmbMetodo.TabIndex = 1;
            // 
            // lblFilas
            // 
            this.lblFilas.AutoSize = true;
            this.lblFilas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilas.Location = new System.Drawing.Point(63, 101);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(54, 28);
            this.lblFilas.TabIndex = 2;
            this.lblFilas.Text = "Filas:";
            // 
            // txtFilas
            // 
            this.txtFilas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilas.Location = new System.Drawing.Point(110, 98);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(226, 34);
            this.txtFilas.TabIndex = 3;
            // 
            // txtColumnas
            // 
            this.txtColumnas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnas.Location = new System.Drawing.Point(110, 138);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(226, 34);
            this.txtColumnas.TabIndex = 5;
            // 
            // lblColumnas
            // 
            this.lblColumnas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnas.Location = new System.Drawing.Point(30, 141);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.Size = new System.Drawing.Size(117, 28);
            this.lblColumnas.TabIndex = 4;
            this.lblColumnas.Text = "Columnas:";
            this.lblColumnas.Click += new System.EventHandler(this.txtColumnas_Click);
            // 
            // txtDx
            // 
            this.txtDx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDx.Location = new System.Drawing.Point(110, 178);
            this.txtDx.Name = "txtDx";
            this.txtDx.Size = new System.Drawing.Size(226, 34);
            this.txtDx.TabIndex = 7;
            // 
            // lblDx
            // 
            this.lblDx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDx.Location = new System.Drawing.Point(77, 181);
            this.lblDx.Name = "lblDx";
            this.lblDx.Size = new System.Drawing.Size(102, 28);
            this.lblDx.TabIndex = 6;
            this.lblDx.Text = "dx:";
            // 
            // txtDy
            // 
            this.txtDy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDy.Location = new System.Drawing.Point(110, 218);
            this.txtDy.Name = "txtDy";
            this.txtDy.Size = new System.Drawing.Size(226, 34);
            this.txtDy.TabIndex = 9;
            this.txtDy.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDy
            // 
            this.lblDy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDy.Location = new System.Drawing.Point(77, 221);
            this.lblDy.Name = "lblDy";
            this.lblDy.Size = new System.Drawing.Size(102, 28);
            this.lblDy.TabIndex = 8;
            this.lblDy.Text = "dy:";
            this.lblDy.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtH.Location = new System.Drawing.Point(110, 258);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(226, 34);
            this.txtH.TabIndex = 11;
            // 
            // lblH
            // 
            this.lblH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(54, 261);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(102, 28);
            this.lblH.TabIndex = 10;
            this.lblH.Text = "h corte:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(110, 299);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(226, 46);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(110, 351);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(226, 46);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbMatriz
            // 
            this.gbMatriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbMatriz.Controls.Add(this.btnCalcular);
            this.gbMatriz.Controls.Add(this.btnGenerarMatriz);
            this.gbMatriz.Controls.Add(this.dgvAlturas);
            this.gbMatriz.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMatriz.Location = new System.Drawing.Point(420, 120);
            this.gbMatriz.Name = "gbMatriz";
            this.gbMatriz.Size = new System.Drawing.Size(720, 440);
            this.gbMatriz.TabIndex = 2;
            this.gbMatriz.TabStop = false;
            this.gbMatriz.Text = "Matriz de alturas del terreno";
            // 
            // dgvAlturas
            // 
            this.dgvAlturas.AllowUserToAddRows = false;
            this.dgvAlturas.AllowUserToDeleteRows = false;
            this.dgvAlturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlturas.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlturas.Location = new System.Drawing.Point(25, 55);
            this.dgvAlturas.Name = "dgvAlturas";
            this.dgvAlturas.RowHeadersVisible = false;
            this.dgvAlturas.RowHeadersWidth = 62;
            this.dgvAlturas.RowTemplate.Height = 28;
            this.dgvAlturas.Size = new System.Drawing.Size(670, 270);
            this.dgvAlturas.TabIndex = 0;
            // 
            // btnGenerarMatriz
            // 
            this.btnGenerarMatriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnGenerarMatriz.FlatAppearance.BorderSize = 0;
            this.btnGenerarMatriz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarMatriz.ForeColor = System.Drawing.Color.White;
            this.btnGenerarMatriz.Location = new System.Drawing.Point(104, 331);
            this.btnGenerarMatriz.Name = "btnGenerarMatriz";
            this.btnGenerarMatriz.Size = new System.Drawing.Size(226, 46);
            this.btnGenerarMatriz.TabIndex = 14;
            this.btnGenerarMatriz.Text = "Generar matriz";
            this.btnGenerarMatriz.UseVisualStyleBackColor = false;
            this.btnGenerarMatriz.Click += new System.EventHandler(this.btnGenerarMatriz_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(361, 331);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(226, 46);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular volumen";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.btnGrafica3D);
            this.gbResultado.Controls.Add(this.lblNotaGrafica);
            this.gbResultado.Controls.Add(this.lblMetodoResultado);
            this.gbResultado.Controls.Add(this.lblVolumen);
            this.gbResultado.Controls.Add(this.lblTextoVolumen);
            this.gbResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultado.Location = new System.Drawing.Point(30, 566);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(1110, 185);
            this.gbResultado.TabIndex = 3;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado del cálculo";
            // 
            // lblTextoVolumen
            // 
            this.lblTextoVolumen.AutoSize = true;
            this.lblTextoVolumen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoVolumen.Location = new System.Drawing.Point(30, 49);
            this.lblTextoVolumen.Name = "lblTextoVolumen";
            this.lblTextoVolumen.Size = new System.Drawing.Size(181, 28);
            this.lblTextoVolumen.TabIndex = 0;
            this.lblTextoVolumen.Text = "Volumen calculado:";
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumen.Location = new System.Drawing.Point(211, 49);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(78, 28);
            this.lblVolumen.TabIndex = 1;
            this.lblVolumen.Text = "0.00 m³";
            // 
            // lblMetodoResultado
            // 
            this.lblMetodoResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoResultado.Location = new System.Drawing.Point(40, 86);
            this.lblMetodoResultado.Name = "lblMetodoResultado";
            this.lblMetodoResultado.Size = new System.Drawing.Size(444, 40);
            this.lblMetodoResultado.TabIndex = 2;
            this.lblMetodoResultado.Text = "Método utilizado: ---";
            // 
            // lblNotaGrafica
            // 
            this.lblNotaGrafica.AutoSize = true;
            this.lblNotaGrafica.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaGrafica.Location = new System.Drawing.Point(30, 126);
            this.lblNotaGrafica.Name = "lblNotaGrafica";
            this.lblNotaGrafica.Size = new System.Drawing.Size(310, 28);
            this.lblNotaGrafica.TabIndex = 3;
            this.lblNotaGrafica.Text = "Gráfica 3D pendiente por integrar.";
            // 
            // btnGrafica3D
            // 
            this.btnGrafica3D.BackColor = System.Drawing.Color.Gray;
            this.btnGrafica3D.FlatAppearance.BorderSize = 0;
            this.btnGrafica3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafica3D.ForeColor = System.Drawing.Color.White;
            this.btnGrafica3D.Location = new System.Drawing.Point(358, 117);
            this.btnGrafica3D.Name = "btnGrafica3D";
            this.btnGrafica3D.Size = new System.Drawing.Size(226, 46);
            this.btnGrafica3D.TabIndex = 16;
            this.btnGrafica3D.Text = "Ver gráfica 3D";
            this.btnGrafica3D.UseVisualStyleBackColor = false;
            this.btnGrafica3D.Click += new System.EventHandler(this.btnGrafica3D_Click);
            // 
            // FrmCalculoVolumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 930);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gbMatriz);
            this.Controls.Add(this.gbConfiguracion);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmCalculoVolumen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de volumen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCalculoVolumen_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.gbConfiguracion.ResumeLayout(false);
            this.gbConfiguracion.PerformLayout();
            this.gbMatriz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlturas)).EndInit();
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
        private System.Windows.Forms.Label lblFilas;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.TextBox txtDx;
        private System.Windows.Forms.Label lblDx;
        private System.Windows.Forms.TextBox txtDy;
        private System.Windows.Forms.Label lblDy;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gbMatriz;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnGenerarMatriz;
        private System.Windows.Forms.DataGridView dgvAlturas;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Label lblTextoVolumen;
        private System.Windows.Forms.Label lblNotaGrafica;
        private System.Windows.Forms.Label lblMetodoResultado;
        private System.Windows.Forms.Button btnGrafica3D;
    }
}
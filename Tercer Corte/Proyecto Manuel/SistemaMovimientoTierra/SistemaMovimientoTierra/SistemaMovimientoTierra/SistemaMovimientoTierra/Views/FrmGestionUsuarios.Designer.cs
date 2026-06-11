namespace SistemaMovimientoTierra
{
    partial class FrmGestionUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnCambiarRol = new System.Windows.Forms.Button();
            this.cmbRolUsuario = new System.Windows.Forms.ComboBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRestablecerPassword = new System.Windows.Forms.Button();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.txtUsuarioSeleccionado = new System.Windows.Forms.TextBox();
            this.lblUsuarioSeleccionado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.pnlSuperior.Controls.Add(this.lblTitulo);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1134, 75);
            this.pnlSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(320, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(498, 51);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GESTIÓN DE USUARIOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(30, 110);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(580, 390);
            this.dgvUsuarios.TabIndex = 1;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // gbAcciones
            // 
            this.gbAcciones.BackgroundImage = global::SistemaMovimientoTierra.Properties.Resources.Imagen_del_login;
            this.gbAcciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbAcciones.Controls.Add(this.pictureBox1);
            this.gbAcciones.Controls.Add(this.btnCambiarRol);
            this.gbAcciones.Controls.Add(this.cmbRolUsuario);
            this.gbAcciones.Controls.Add(this.lblRolUsuario);
            this.gbAcciones.Controls.Add(this.btnActualizar);
            this.gbAcciones.Controls.Add(this.btnRestablecerPassword);
            this.gbAcciones.Controls.Add(this.btnInactivar);
            this.gbAcciones.Controls.Add(this.btnActivar);
            this.gbAcciones.Controls.Add(this.txtUsuarioSeleccionado);
            this.gbAcciones.Controls.Add(this.lblUsuarioSeleccionado);
            this.gbAcciones.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAcciones.Location = new System.Drawing.Point(641, 110);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(441, 493);
            this.gbAcciones.TabIndex = 2;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones de usuario";
            // 
            // btnCambiarRol
            // 
            this.btnCambiarRol.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCambiarRol.FlatAppearance.BorderSize = 0;
            this.btnCambiarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarRol.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarRol.ForeColor = System.Drawing.Color.White;
            this.btnCambiarRol.Location = new System.Drawing.Point(107, 255);
            this.btnCambiarRol.Name = "btnCambiarRol";
            this.btnCambiarRol.Size = new System.Drawing.Size(247, 38);
            this.btnCambiarRol.TabIndex = 8;
            this.btnCambiarRol.Text = "Cambiar rol";
            this.btnCambiarRol.UseVisualStyleBackColor = false;
            this.btnCambiarRol.Click += new System.EventHandler(this.btnCambiarRol_Click);
            // 
            // cmbRolUsuario
            // 
            this.cmbRolUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRolUsuario.FormattingEnabled = true;
            this.cmbRolUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.cmbRolUsuario.Location = new System.Drawing.Point(105, 136);
            this.cmbRolUsuario.Name = "cmbRolUsuario";
            this.cmbRolUsuario.Size = new System.Drawing.Size(247, 25);
            this.cmbRolUsuario.TabIndex = 7;
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.Location = new System.Drawing.Point(101, 114);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(117, 19);
            this.lblRolUsuario.TabIndex = 6;
            this.lblRolUsuario.Text = "Rol del usuario:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Gray;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(105, 343);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(247, 38);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar lista";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnRestablecerPassword
            // 
            this.btnRestablecerPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnRestablecerPassword.FlatAppearance.BorderSize = 0;
            this.btnRestablecerPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecerPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecerPassword.ForeColor = System.Drawing.Color.White;
            this.btnRestablecerPassword.Location = new System.Drawing.Point(105, 299);
            this.btnRestablecerPassword.Name = "btnRestablecerPassword";
            this.btnRestablecerPassword.Size = new System.Drawing.Size(247, 38);
            this.btnRestablecerPassword.TabIndex = 4;
            this.btnRestablecerPassword.Text = "Restablecer contraseña";
            this.btnRestablecerPassword.UseVisualStyleBackColor = false;
            this.btnRestablecerPassword.Click += new System.EventHandler(this.btnRestablecerPassword_Click);
            // 
            // btnInactivar
            // 
            this.btnInactivar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnInactivar.FlatAppearance.BorderSize = 0;
            this.btnInactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInactivar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactivar.ForeColor = System.Drawing.Color.White;
            this.btnInactivar.Location = new System.Drawing.Point(107, 211);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(247, 38);
            this.btnInactivar.TabIndex = 3;
            this.btnInactivar.Text = "Inactivar usuario";
            this.btnInactivar.UseVisualStyleBackColor = false;
            this.btnInactivar.Click += new System.EventHandler(this.btnInactivar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActivar.FlatAppearance.BorderSize = 0;
            this.btnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivar.ForeColor = System.Drawing.Color.White;
            this.btnActivar.Location = new System.Drawing.Point(105, 167);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(247, 38);
            this.btnActivar.TabIndex = 2;
            this.btnActivar.Text = "Activar usuario";
            this.btnActivar.UseVisualStyleBackColor = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // txtUsuarioSeleccionado
            // 
            this.txtUsuarioSeleccionado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioSeleccionado.Location = new System.Drawing.Point(105, 72);
            this.txtUsuarioSeleccionado.Name = "txtUsuarioSeleccionado";
            this.txtUsuarioSeleccionado.ReadOnly = true;
            this.txtUsuarioSeleccionado.Size = new System.Drawing.Size(247, 25);
            this.txtUsuarioSeleccionado.TabIndex = 1;
            // 
            // lblUsuarioSeleccionado
            // 
            this.lblUsuarioSeleccionado.Location = new System.Drawing.Point(101, 22);
            this.lblUsuarioSeleccionado.Name = "lblUsuarioSeleccionado";
            this.lblUsuarioSeleccionado.Size = new System.Drawing.Size(253, 28);
            this.lblUsuarioSeleccionado.TabIndex = 0;
            this.lblUsuarioSeleccionado.Text = "Usuario seleccionado:";
            this.lblUsuarioSeleccionado.Click += new System.EventHandler(this.lblUsuarioSeleccionado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = global::SistemaMovimientoTierra.Properties.Resources._4092564_about_mobile_ui_profile_ui_user_website_114033;
            this.pictureBox1.Location = new System.Drawing.Point(105, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaMovimientoTierra.Properties.Resources.fondo_proyecto;
            this.ClientSize = new System.Drawing.Size(1134, 733);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmGestionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de usuarios";
            this.Load += new System.EventHandler(this.FrmGestionUsuarios_Load);
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbAcciones.ResumeLayout(false);
            this.gbAcciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Label lblUsuarioSeleccionado;
        private System.Windows.Forms.TextBox txtUsuarioSeleccionado;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnRestablecerPassword;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.ComboBox cmbRolUsuario;
        private System.Windows.Forms.Button btnCambiarRol;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
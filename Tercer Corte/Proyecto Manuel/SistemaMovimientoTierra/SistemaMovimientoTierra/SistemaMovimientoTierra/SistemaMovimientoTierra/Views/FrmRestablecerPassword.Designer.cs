namespace SistemaMovimientoTierra
{
    partial class FrmRestablecerPassword
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNuevaPassword = new System.Windows.Forms.TextBox();
            this.lblNuevaPassword = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblConfirmarPassword = new System.Windows.Forms.Label();
            this.txtConfirmarPassword = new System.Windows.Forms.TextBox();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.Transparent;
            this.pnlSuperior.Controls.Add(this.lblTitulo);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(633, 100);
            this.pnlSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(24, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(587, 51);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RESTABLECER CONTRASEÑA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(181, 122);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtNuevaPassword
            // 
            this.txtNuevaPassword.Location = new System.Drawing.Point(185, 223);
            this.txtNuevaPassword.Name = "txtNuevaPassword";
            this.txtNuevaPassword.Size = new System.Drawing.Size(246, 25);
            this.txtNuevaPassword.TabIndex = 2;
            this.txtNuevaPassword.UseSystemPasswordChar = true;
            // 
            // lblNuevaPassword
            // 
            this.lblNuevaPassword.AutoSize = true;
            this.lblNuevaPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaPassword.Location = new System.Drawing.Point(181, 200);
            this.lblNuevaPassword.Name = "lblNuevaPassword";
            this.lblNuevaPassword.Size = new System.Drawing.Size(139, 20);
            this.lblNuevaPassword.TabIndex = 3;
            this.lblNuevaPassword.Text = "Nueva contraseña:";
            this.lblNuevaPassword.Click += new System.EventHandler(this.lblNuevaPassword_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(185, 145);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(246, 25);
            this.txtUsuario.TabIndex = 4;
            // 
            // lblConfirmarPassword
            // 
            this.lblConfirmarPassword.AutoSize = true;
            this.lblConfirmarPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarPassword.Location = new System.Drawing.Point(181, 272);
            this.lblConfirmarPassword.Name = "lblConfirmarPassword";
            this.lblConfirmarPassword.Size = new System.Drawing.Size(165, 20);
            this.lblConfirmarPassword.TabIndex = 5;
            this.lblConfirmarPassword.Text = "Confirmar contraseña:";
            this.lblConfirmarPassword.Click += new System.EventHandler(this.lblConfirmarPassword_Click);
            // 
            // txtConfirmarPassword
            // 
            this.txtConfirmarPassword.Location = new System.Drawing.Point(185, 295);
            this.txtConfirmarPassword.Name = "txtConfirmarPassword";
            this.txtConfirmarPassword.Size = new System.Drawing.Size(246, 25);
            this.txtConfirmarPassword.TabIndex = 6;
            this.txtConfirmarPassword.UseSystemPasswordChar = true;
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnRestablecer.FlatAppearance.BorderSize = 0;
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.ForeColor = System.Drawing.Color.White;
            this.btnRestablecer.Location = new System.Drawing.Point(30, 361);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(246, 42);
            this.btnRestablecer.TabIndex = 7;
            this.btnRestablecer.Text = "Restablecer contraseña";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(341, 361);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(246, 42);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmRestablecerPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::SistemaMovimientoTierra.Properties.Resources.fondo_proyecto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 454);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.txtConfirmarPassword);
            this.Controls.Add(this.lblConfirmarPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblNuevaPassword);
            this.Controls.Add(this.txtNuevaPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pnlSuperior);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FrmRestablecerPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restablecer Contraseña";
            this.Load += new System.EventHandler(this.FrmRestablecerPassword_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtNuevaPassword;
        private System.Windows.Forms.Label lblNuevaPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblConfirmarPassword;
        private System.Windows.Forms.TextBox txtConfirmarPassword;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button btnCancelar;
    }
}
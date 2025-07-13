namespace Sistema_de_Reservas.Views
{
    partial class Usuarios
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(13, 241);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 29);
            this.txtEmail.TabIndex = 38;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(13, 123);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(315, 29);
            this.txtNombre.TabIndex = 37;
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.cmbRol.Location = new System.Drawing.Point(13, 179);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(315, 32);
            this.cmbRol.TabIndex = 36;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(13, 64);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(315, 29);
            this.txtId.TabIndex = 35;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(9, 273);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(57, 24);
            this.lblClave.TabIndex = 34;
            this.lblClave.Text = "Clave";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 214);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(9, 155);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(38, 24);
            this.lblRol.TabIndex = 32;
            this.lblRol.Text = "Rol";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 96);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(9, 42);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 24);
            this.lblId.TabIndex = 30;
            this.lblId.Text = "Id";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(127, 9);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(74, 24);
            this.lblUsuarios.TabIndex = 29;
            this.lblUsuarios.Text = "Usuario";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(13, 300);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(315, 29);
            this.txtClave.TabIndex = 39;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(13, 335);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 43);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(119, 335);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 43);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(228, 335);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 43);
            this.btnCerrar.TabIndex = 42;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 396);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblUsuarios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
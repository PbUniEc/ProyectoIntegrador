namespace Sistema_de_Reservas.Views
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transmetro";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 40);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(167, 24);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Coreo Electrónico:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(12, 104);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(111, 24);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Contraseña:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(303, 29);
            this.txtEmail.TabIndex = 3;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(16, 131);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(303, 29);
            this.txtClave.TabIndex = 4;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMensaje.Location = new System.Drawing.Point(0, 221);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(82, 24);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "Mensaje";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(16, 166);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(139, 33);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Inciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(172, 166);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(147, 33);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 245);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSalir;
    }
}
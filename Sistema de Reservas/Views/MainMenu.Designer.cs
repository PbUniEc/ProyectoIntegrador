namespace Sistema_de_Reservas.Views
{
    partial class Main_Menu
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AllowDrop = true;
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(118, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(136, 24);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menú Principal";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnBitacora);
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnReservas);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Location = new System.Drawing.Point(12, 48);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(352, 261);
            this.panelMenu.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(75, 204);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(209, 37);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnReservas
            // 
            this.btnReservas.Location = new System.Drawing.Point(75, 84);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(209, 37);
            this.btnReservas.TabIndex = 1;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(75, 20);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(209, 37);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnBitacora
            // 
            this.btnBitacora.Location = new System.Drawing.Point(75, 143);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(209, 37);
            this.btnBitacora.TabIndex = 4;
            this.btnBitacora.Text = "Bitacora";
            this.btnBitacora.UseVisualStyleBackColor = true;
            this.btnBitacora.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 321);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.lblMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main_Menu";
            this.Text = "Main_Menu";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnBitacora;
    }
}
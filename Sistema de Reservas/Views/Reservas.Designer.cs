namespace Sistema_de_Reservas.Views
{
    partial class Reservas
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
            this.lblRes = new System.Windows.Forms.Label();
            this.lblReserva = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(130, 9);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(88, 24);
            this.lblRes.TabIndex = 0;
            this.lblRes.Text = "Reservas";
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.Location = new System.Drawing.Point(12, 42);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(79, 24);
            this.lblReserva.TabIndex = 1;
            this.lblReserva.Text = "Reserva";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 96);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 24);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(12, 155);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(72, 24);
            this.lblHorario.TabIndex = 3;
            this.lblHorario.Text = "Horario";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(12, 212);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(70, 24);
            this.lblUnidad.TabIndex = 4;
            this.lblUnidad.Text = "Unidad";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 274);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 24);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 333);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(68, 24);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado";
            // 
            // txtReserva
            // 
            this.txtReserva.Location = new System.Drawing.Point(16, 64);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(315, 29);
            this.txtReserva.TabIndex = 7;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(16, 120);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(315, 32);
            this.cmbUsuario.TabIndex = 8;
            // 
            // cmbHorario
            // 
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(16, 182);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(315, 32);
            this.cmbHorario.TabIndex = 9;
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.Location = new System.Drawing.Point(16, 239);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(315, 32);
            this.cmbUnidad.TabIndex = 10;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(16, 301);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(315, 29);
            this.dtpFecha.TabIndex = 11;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Pendiente"});
            this.cmbEstado.Location = new System.Drawing.Point(16, 360);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(315, 32);
            this.cmbEstado.TabIndex = 12;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(231, 398);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 43);
            this.btnCerrar.TabIndex = 45;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(122, 398);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 43);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(16, 398);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 43);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 465);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbUnidad);
            this.Controls.Add(this.cmbHorario);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.txtReserva);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblReserva);
            this.Controls.Add(this.lblRes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Reservas";
            this.Text = "Reservas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtReserva;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.ComboBox cmbUnidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}
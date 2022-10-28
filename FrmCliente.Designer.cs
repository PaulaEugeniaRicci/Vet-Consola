namespace Vet
{
    partial class FrmCliente
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
            this.txtboxCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxDomicilio = new System.Windows.Forms.TextBox();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtboxDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxCliente
            // 
            this.txtboxCliente.Location = new System.Drawing.Point(131, 29);
            this.txtboxCliente.Name = "txtboxCliente";
            this.txtboxCliente.Size = new System.Drawing.Size(245, 20);
            this.txtboxCliente.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nombre y Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Domicilio:";
            // 
            // txtboxDomicilio
            // 
            this.txtboxDomicilio.Location = new System.Drawing.Point(131, 70);
            this.txtboxDomicilio.Name = "txtboxDomicilio";
            this.txtboxDomicilio.Size = new System.Drawing.Size(245, 20);
            this.txtboxDomicilio.TabIndex = 45;
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(558, 70);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(193, 20);
            this.txtboxEmail.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "e-Mail:";
            // 
            // txtboxTelefono
            // 
            this.txtboxTelefono.Location = new System.Drawing.Point(558, 29);
            this.txtboxTelefono.Name = "txtboxTelefono";
            this.txtboxTelefono.Size = new System.Drawing.Size(193, 20);
            this.txtboxTelefono.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Telefono:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(478, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 48);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Volver";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(202, 229);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 48);
            this.btnGuardar.TabIndex = 68;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtboxDNI
            // 
            this.txtboxDNI.Location = new System.Drawing.Point(131, 114);
            this.txtboxDNI.Name = "txtboxDNI";
            this.txtboxDNI.Size = new System.Drawing.Size(245, 20);
            this.txtboxDNI.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Documento:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(558, 114);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(193, 23);
            this.btnAgregar.TabIndex = 72;
            this.btnAgregar.Text = "Agregar Mascota";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 335);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtboxDNI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxDomicilio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxCliente);
            this.Controls.Add(this.label1);
            this.Name = "FrmCliente";
            this.Text = "Alta de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtboxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxDomicilio;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtboxDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
    }
}
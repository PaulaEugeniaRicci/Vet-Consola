namespace Vet
{
    partial class FrmEmpleado
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
            this.components = new System.ComponentModel.Container();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxDomicilio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(475, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 48);
            this.btnCancelar.TabIndex = 81;
            this.btnCancelar.Text = "Volver";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(199, 243);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 48);
            this.btnGuardar.TabIndex = 80;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(555, 84);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(193, 20);
            this.txtboxEmail.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "e-Mail:";
            // 
            // txtboxTelefono
            // 
            this.txtboxTelefono.Location = new System.Drawing.Point(555, 43);
            this.txtboxTelefono.Name = "txtboxTelefono";
            this.txtboxTelefono.Size = new System.Drawing.Size(193, 20);
            this.txtboxTelefono.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Telefono:";
            // 
            // txtboxDomicilio
            // 
            this.txtboxDomicilio.Location = new System.Drawing.Point(128, 84);
            this.txtboxDomicilio.Name = "txtboxDomicilio";
            this.txtboxDomicilio.Size = new System.Drawing.Size(245, 20);
            this.txtboxDomicilio.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Domicilio:";
            // 
            // txtboxEmpleado
            // 
            this.txtboxEmpleado.Location = new System.Drawing.Point(128, 43);
            this.txtboxEmpleado.Name = "txtboxEmpleado";
            this.txtboxEmpleado.Size = new System.Drawing.Size(245, 20);
            this.txtboxEmpleado.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Nombre y Apellido:";
            // 
            // txtboxDNI
            // 
            this.txtboxDNI.Location = new System.Drawing.Point(128, 129);
            this.txtboxDNI.Name = "txtboxDNI";
            this.txtboxDNI.Size = new System.Drawing.Size(245, 20);
            this.txtboxDNI.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Documento:";
            // 
            // datosBindingSource
            // 
            this.datosBindingSource.DataSource = typeof(Vet.Datos);
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 356);
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
            this.Controls.Add(this.txtboxEmpleado);
            this.Controls.Add(this.label1);
            this.Name = "FrmEmpleado";
            this.Text = "Alta de Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        //private System.Windows.Forms.ComboBox cmboxPacientes;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxDomicilio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource datosBindingSource;
    }
}
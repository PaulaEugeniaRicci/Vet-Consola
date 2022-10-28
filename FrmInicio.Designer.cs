namespace Vet
{
    partial class FrmInicio
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
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.AccessibleName = "Boton Alta Pacientes";
            this.btnAlta.Location = new System.Drawing.Point(113, 201);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(221, 108);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "3. Alta de Pacientes";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.AccessibleName = "Boton Consulta";
            this.btnConsulta.Location = new System.Drawing.Point(423, 201);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(221, 108);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "4. Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.AccessibleName = "Boton Alta Clientes";
            this.btnClientes.Location = new System.Drawing.Point(423, 56);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(221, 108);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "2. Alta de Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleName = "Boton Salir";
            this.btnSalir.Location = new System.Drawing.Point(268, 347);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(221, 45);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.AccessibleName = "Boton Alta Empleados";
            this.btnEmpleados.Location = new System.Drawing.Point(113, 56);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(221, 108);
            this.btnEmpleados.TabIndex = 4;
            this.btnEmpleados.Text = "1. Alta de Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // FrmInicio
            // 
            this.AccessibleName = "Inicio";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnAlta);
            this.Name = "FrmInicio";
            this.Text = "Sistema Veterinaria";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEmpleados;
    }
}


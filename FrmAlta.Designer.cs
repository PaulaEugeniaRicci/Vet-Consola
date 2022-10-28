namespace Vet
{
    partial class FrmAlta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmboxEspecie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmboxEmpleado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkboxActivo = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtboxEdad = new System.Windows.Forms.TextBox();
            this.txtboxPeso = new System.Windows.Forms.TextBox();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtboxDeceso = new System.Windows.Forms.TextBox();
            this.lblDeceso2 = new System.Windows.Forms.Label();
            this.txtboxOtros = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dateVisita = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.cmboxCliente = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmboxSexo = new System.Windows.Forms.ComboBox();
            this.txtboxRaza = new System.Windows.Forms.TextBox();
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.datosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente:";
            // 
            // txtboxPaciente
            // 
            this.txtboxPaciente.Location = new System.Drawing.Point(120, 26);
            this.txtboxPaciente.Name = "txtboxPaciente";
            this.txtboxPaciente.Size = new System.Drawing.Size(123, 20);
            this.txtboxPaciente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "F. Nacimiento:";
            // 
            // cmboxEspecie
            // 
            this.cmboxEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxEspecie.FormattingEnabled = true;
            this.cmboxEspecie.Location = new System.Drawing.Point(120, 112);
            this.cmboxEspecie.Name = "cmboxEspecie";
            this.cmboxEspecie.Size = new System.Drawing.Size(123, 21);
            this.cmboxEspecie.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Especie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Raza:";
            // 
            // txtboxColor
            // 
            this.txtboxColor.Location = new System.Drawing.Point(714, 113);
            this.txtboxColor.Name = "txtboxColor";
            this.txtboxColor.Size = new System.Drawing.Size(123, 20);
            this.txtboxColor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Color:";
            // 
            // cmboxEmpleado
            // 
            this.cmboxEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxEmpleado.FormattingEnabled = true;
            this.cmboxEmpleado.Location = new System.Drawing.Point(120, 257);
            this.cmboxEmpleado.Name = "cmboxEmpleado";
            this.cmboxEmpleado.Size = new System.Drawing.Size(123, 21);
            this.cmboxEmpleado.Sorted = true;
            this.cmboxEmpleado.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Atendido por:";
            // 
            // checkboxActivo
            // 
            this.checkboxActivo.AutoSize = true;
            this.checkboxActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkboxActivo.Checked = true;
            this.checkboxActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxActivo.Location = new System.Drawing.Point(544, 161);
            this.checkboxActivo.Name = "checkboxActivo";
            this.checkboxActivo.Size = new System.Drawing.Size(56, 17);
            this.checkboxActivo.TabIndex = 14;
            this.checkboxActivo.Text = "Activo";
            this.checkboxActivo.UseVisualStyleBackColor = true;
            this.checkboxActivo.CheckedChanged += new System.EventHandler(this.checkboxActivo_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(631, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Peso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Edad:";
            // 
            // txtboxEdad
            // 
            this.txtboxEdad.Location = new System.Drawing.Point(406, 68);
            this.txtboxEdad.Name = "txtboxEdad";
            this.txtboxEdad.Size = new System.Drawing.Size(47, 20);
            this.txtboxEdad.TabIndex = 23;
            // 
            // txtboxPeso
            // 
            this.txtboxPeso.Location = new System.Drawing.Point(714, 67);
            this.txtboxPeso.Name = "txtboxPeso";
            this.txtboxPeso.Size = new System.Drawing.Size(47, 20);
            this.txtboxPeso.TabIndex = 24;
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNacimiento.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateNacimiento.Location = new System.Drawing.Point(120, 68);
            this.dateNacimiento.Margin = new System.Windows.Forms.Padding(0);
            this.dateNacimiento.MaxDate = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.dateNacimiento.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(123, 20);
            this.dateNacimiento.TabIndex = 25;
            this.dateNacimiento.Value = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            // 
            // txtboxDeceso
            // 
            this.txtboxDeceso.Location = new System.Drawing.Point(714, 159);
            this.txtboxDeceso.Name = "txtboxDeceso";
            this.txtboxDeceso.Size = new System.Drawing.Size(123, 20);
            this.txtboxDeceso.TabIndex = 29;
            this.txtboxDeceso.Visible = false;
            // 
            // lblDeceso2
            // 
            this.lblDeceso2.AutoSize = true;
            this.lblDeceso2.Location = new System.Drawing.Point(628, 160);
            this.lblDeceso2.Name = "lblDeceso2";
            this.lblDeceso2.Size = new System.Drawing.Size(80, 13);
            this.lblDeceso2.TabIndex = 28;
            this.lblDeceso2.Text = "Causa Deceso:";
            this.lblDeceso2.Visible = false;
            // 
            // txtboxOtros
            // 
            this.txtboxOtros.Location = new System.Drawing.Point(434, 208);
            this.txtboxOtros.Multiline = true;
            this.txtboxOtros.Name = "txtboxOtros";
            this.txtboxOtros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxOtros.Size = new System.Drawing.Size(403, 135);
            this.txtboxOtros.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(351, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Otros Datos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(192, 403);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 48);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(468, 403);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 48);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Volver";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dateVisita
            // 
            this.dateVisita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVisita.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateVisita.Location = new System.Drawing.Point(120, 312);
            this.dateVisita.MaxDate = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.dateVisita.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.dateVisita.Name = "dateVisita";
            this.dateVisita.Size = new System.Drawing.Size(123, 20);
            this.dateVisita.TabIndex = 36;
            this.dateVisita.Value = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Próxima Visita:";
            // 
            // cmboxCliente
            // 
            this.cmboxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxCliente.FormattingEnabled = true;
            this.cmboxCliente.Location = new System.Drawing.Point(120, 208);
            this.cmboxCliente.Name = "cmboxCliente";
            this.cmboxCliente.Size = new System.Drawing.Size(123, 21);
            this.cmboxCliente.Sorted = true;
            this.cmboxCliente.TabIndex = 37;
            this.cmboxCliente.SelectedIndexChanged += new System.EventHandler(this.cmboxCliente_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(631, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Sexo:";
            // 
            // cmboxSexo
            // 
            this.cmboxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxSexo.FormattingEnabled = true;
            this.cmboxSexo.Location = new System.Drawing.Point(714, 26);
            this.cmboxSexo.Name = "cmboxSexo";
            this.cmboxSexo.Size = new System.Drawing.Size(47, 21);
            this.cmboxSexo.TabIndex = 40;
            // 
            // txtboxRaza
            // 
            this.txtboxRaza.Location = new System.Drawing.Point(406, 113);
            this.txtboxRaza.Name = "txtboxRaza";
            this.txtboxRaza.Size = new System.Drawing.Size(123, 20);
            this.txtboxRaza.TabIndex = 42;
            // 
            // txtboxID
            // 
            this.txtboxID.Location = new System.Drawing.Point(406, 25);
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.Size = new System.Drawing.Size(123, 20);
            this.txtboxID.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Identificación:";
            // 
            // datosBindingSource
            // 
            this.datosBindingSource.DataSource = typeof(Vet.Datos);
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 474);
            this.Controls.Add(this.txtboxID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtboxRaza);
            this.Controls.Add(this.cmboxSexo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmboxCliente);
            this.Controls.Add(this.dateVisita);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtboxOtros);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtboxDeceso);
            this.Controls.Add(this.lblDeceso2);
            this.Controls.Add(this.dateNacimiento);
            this.Controls.Add(this.txtboxPeso);
            this.Controls.Add(this.txtboxEdad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkboxActivo);
            this.Controls.Add(this.cmboxEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtboxColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmboxEspecie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxPaciente);
            this.Controls.Add(this.label1);
            this.Name = "FrmAlta";
            this.Text = "  Alta de Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmboxEspecie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmboxEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkboxActivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtboxEdad;
        private System.Windows.Forms.TextBox txtboxPeso;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.TextBox txtboxDeceso;
        private System.Windows.Forms.Label lblDeceso2;
        private System.Windows.Forms.TextBox txtboxOtros;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dateVisita;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmboxCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmboxSexo;
        private System.Windows.Forms.TextBox txtboxRaza;
        private System.Windows.Forms.TextBox txtboxID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource datosBindingSource;
    }
}
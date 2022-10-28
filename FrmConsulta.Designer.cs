namespace Vet
{
    partial class FrmConsulta
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmboxBuscar = new System.Windows.Forms.ComboBox();
            this.checkboxFiltrar = new System.Windows.Forms.CheckBox();
            this.cmboxFiltro = new System.Windows.Forms.ComboBox();
            this.txtboxFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtboxImpresion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(279, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 48);
            this.btnCancelar.TabIndex = 81;
            this.btnCancelar.Text = "Volver";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(51, 210);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(180, 48);
            this.btnConsultar.TabIndex = 80;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cmboxBuscar
            // 
            this.cmboxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxBuscar.FormattingEnabled = true;
            this.cmboxBuscar.Location = new System.Drawing.Point(50, 51);
            this.cmboxBuscar.Name = "cmboxBuscar";
            this.cmboxBuscar.Size = new System.Drawing.Size(409, 21);
            this.cmboxBuscar.TabIndex = 87;
            // 
            // checkboxFiltrar
            // 
            this.checkboxFiltrar.AutoSize = true;
            this.checkboxFiltrar.Location = new System.Drawing.Point(50, 78);
            this.checkboxFiltrar.Name = "checkboxFiltrar";
            this.checkboxFiltrar.Size = new System.Drawing.Size(51, 17);
            this.checkboxFiltrar.TabIndex = 88;
            this.checkboxFiltrar.Text = "Filtrar";
            this.checkboxFiltrar.UseVisualStyleBackColor = true;
            this.checkboxFiltrar.CheckedChanged += new System.EventHandler(this.checkboxFiltrar_CheckedChanged);
            // 
            // cmboxFiltro
            // 
            this.cmboxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxFiltro.FormattingEnabled = true;
            this.cmboxFiltro.Location = new System.Drawing.Point(107, 117);
            this.cmboxFiltro.Name = "cmboxFiltro";
            this.cmboxFiltro.Size = new System.Drawing.Size(163, 21);
            this.cmboxFiltro.TabIndex = 89;
            // 
            // txtboxFiltro
            // 
            this.txtboxFiltro.Location = new System.Drawing.Point(296, 118);
            this.txtboxFiltro.Name = "txtboxFiltro";
            this.txtboxFiltro.Size = new System.Drawing.Size(163, 20);
            this.txtboxFiltro.TabIndex = 90;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(48, 120);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(53, 13);
            this.lblFiltro.TabIndex = 91;
            this.lblFiltro.Text = "Filtrar por:";
            // 
            // txtboxImpresion
            // 
            this.txtboxImpresion.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxImpresion.Location = new System.Drawing.Point(524, 51);
            this.txtboxImpresion.Multiline = true;
            this.txtboxImpresion.Name = "txtboxImpresion";
            this.txtboxImpresion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxImpresion.Size = new System.Drawing.Size(397, 207);
            this.txtboxImpresion.TabIndex = 92;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 308);
            this.Controls.Add(this.txtboxImpresion);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtboxFiltro);
            this.Controls.Add(this.cmboxFiltro);
            this.Controls.Add(this.checkboxFiltrar);
            this.Controls.Add(this.cmboxBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConsultar);
            this.Name = "FrmConsulta";
            this.Text = "Consultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmboxBuscar;
        private System.Windows.Forms.CheckBox checkboxFiltrar;
        private System.Windows.Forms.ComboBox cmboxFiltro;
        private System.Windows.Forms.TextBox txtboxFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtboxImpresion;
    }
}
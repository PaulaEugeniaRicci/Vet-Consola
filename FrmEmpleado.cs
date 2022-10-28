using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;



namespace Vet
{
    public partial class FrmEmpleado : Form
    {
        private FrmInicio frmInicio;

        public FrmEmpleado(FrmInicio inicio)
        {
            InitializeComponent();
            frmInicio = inicio;
            Campos();
        }

        //Metodos para construir form

        private void Campos()
        {
            txtboxTelefono.MaxLength = 13;
            txtboxDNI.MaxLength = 9;
        }

        //Otros metodos
        public void Clear()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox) { control.Text = ""; }
            }
            this.txtboxEmpleado.Focus();
        }


        // Metodo para validaciones de campos 
        private Boolean Validacion()
        {   //Nombre
            if (!(txtboxEmpleado.Text.Length > 1) || !(Regex.IsMatch(txtboxEmpleado.Text, @"^[ a-zA-Zá-úÁ-Ú]+$")))
            {
                MessageBox.Show("Debe ingresar un nombre válido");
                txtboxEmpleado.Text = "";
                txtboxEmpleado.Focus();
                return false;
            }
            /*Telefono
            if (!(txtboxTelefono.Text.Length > 8) || !(Regex.IsMatch(txtboxTelefono.Text, @"^[0-9]+$")))
            {
                MessageBox.Show("Debe ingresar un número telefónico válido");
                txtboxTelefono.Text = "";
                txtboxTelefono.Focus();
                return false;
            }
            //Domicilio
            if (!(txtboxDomicilio.Text.Length > 4) || !(Regex.IsMatch(txtboxDomicilio.Text, @"^[ a-zA-Z0-9_]+$")))
            {
                MessageBox.Show("Debe ingresar una dirección válida");
                txtboxDomicilio.Text = "";
                txtboxDomicilio.Focus();
                return false;
            }
            //Email
            if (!(txtboxEmail.Text.Length > 5) || !(Regex.IsMatch(txtboxEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")))
            {
                MessageBox.Show("Debe ingresar un email válido");
                txtboxEmail.Text = "";
                txtboxEmail.Focus();
                return false;
                
            }
            //Documento*/
            if (!(txtboxDNI.Text.Length > 7) || !(Regex.IsMatch(txtboxDNI.Text, @"^[0-9]+$")))
            {
                MessageBox.Show("Debe ingresar un documento válido");
                txtboxDNI.Text = "";
                txtboxDNI.Focus();
                return false;
            }
            return true;

        }

        //Eventos     
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmInicio.Show();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (Validacion())
            {
                if (frmInicio.GetDatos().BuscarEmpleadoDNI(Int32.Parse(txtboxDNI.Text)))
                {
                    MessageBox.Show("Ya se encuentra registrado un empleado con ese documento.");
                    return;
                }
                else
                {
                    Empleado veterinario = new Empleado();
                    veterinario.SetNombre(txtboxEmpleado.Text);
                    //veterinario.SetNumero(Int32.Parse(txtboxTelefono.Text));
                    veterinario.SetEmail(txtboxEmail.Text);
                    veterinario.SetDomicilio(txtboxDomicilio.Text);
                    veterinario.SetDocumento(Int32.Parse(txtboxDNI.Text));

                    frmInicio.GetDatos().AddEmpleado(veterinario);
                    this.Clear();
                    MessageBox.Show("El Empleado ha sido registrado correctamente.");
                }
            }
        }
    }
}
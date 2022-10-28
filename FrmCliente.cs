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
using System.Data.SqlClient;

//cuando se da de alta el cliente desde inicio -> alta de cliente, 
//no debería haber un combobox para elegir mascota, solamente debería 
//estar la opción de "Agregar nueva"
//no va a existir una mascota para seleccionar en tiempo de alta de cliente, 
//que le pertenezca a ese cliente.

namespace Vet
{
    public partial class FrmCliente : Form
    {
        private FrmAlta frmAlta;
        private FrmInicio frmInicio;
        private Paciente mascota;
        private int flag;
        private int flagMascota = 0;

        public FrmCliente(FrmInicio inicio)
        {
            InitializeComponent();
            frmInicio = inicio;
            frmAlta = new FrmAlta(this, inicio);
            Campos();
            flag = 0;
        }
        public FrmCliente(FrmAlta alta, FrmInicio inicio)
        {
            InitializeComponent();
            frmAlta = alta;
            frmInicio = inicio;
            Campos();
            btnAgregar.Hide();
            flag = 1;
        }   
        
        //Metodos para construir form

        private void Campos()
        {
            txtboxTelefono.MaxLength = 13;
            txtboxDNI.MaxLength = 9;
        }

        //Otros metodos

        public void AsignarMascota (Paciente paciente)
        {
            mascota = paciente;
        }
        
        public void Clear()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox) { control.Text = ""; }
            }
            this.txtboxCliente.Focus();
            if (flag != 1)
            { btnAgregar.Enabled = true; } 
        }

        // Metodo para validaciones de campos 
        private Boolean Validacion()
        {   
            if (!(txtboxCliente.Text.Length > 1) || !(Regex.IsMatch(txtboxCliente.Text, @"^[ a-zA-Zá-úÁ-Ú]+$")))
            {
                MessageBox.Show("Debe ingresar un nombre válido");
                txtboxCliente.Text = "";
                txtboxCliente.Focus();
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

            if (flag == 0 & flagMascota == 0)
            {
                MessageBox.Show("Debe asignarle una Mascota al Cliente");
                return false;
                
            }
            return true;
            
        }

        //Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            if (flag == 0) { frmInicio.Show(); }
            if (flag == 1){ frmAlta.Show(); }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            flagMascota = 1;
            this.Hide();
            frmAlta = new FrmAlta(this, frmInicio);
            frmAlta.Show();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                if (frmInicio.GetDatos().BuscarClienteDNI(Int32.Parse(txtboxDNI.Text)))
                {
                    MessageBox.Show("Ya se encuentra registrado un cliente con ese documento.");
                    return;
                }
                else
                {
                    Cliente dueño = new Cliente();
                    dueño.SetNombre(txtboxCliente.Text);
                    //dueño.SetNumero(Int32.Parse(txtboxTelefono.Text));
                    dueño.SetEmail(txtboxEmail.Text);
                    dueño.SetDomicilio(txtboxDomicilio.Text);
                    dueño.SetDocumento(Int32.Parse(txtboxDNI.Text));
                    
                    if (flag == 0)
                    {
                        dueño.AddMascota(mascota);
                        frmInicio.GetDatos().ClienteMascota(mascota, dueño); 
                    }

                    frmInicio.GetDatos().AddDueño(dueño);
                    this.Clear();
                    MessageBox.Show("El Cliente ha sido registrado correctamente.");

                    if (flag == 1) 
                    {
                        this.Close();
                        frmAlta.Show();
                        frmAlta.SelectCliente(dueño);
                    }
                }                   
            }
        }       
    }
}


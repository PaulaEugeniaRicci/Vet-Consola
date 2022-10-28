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
using System.Drawing.Text;
using System.Reflection;

namespace Vet
{
    public partial class FrmAlta : Form
    {
        private FrmInicio frmInicio;
        private FrmCliente frmCliente;
        private int flag;

        public FrmAlta(FrmInicio inicio)
        {
            InitializeComponent();
            frmInicio = inicio;
            Campos();
            AddSexo();
            AddEspecie("Canino", "Felino", "Reptil", "Roedor", "Ave", "Otros");
            AddClientes();
            AddVeterinarios();
            flag = 0;
        }
        public FrmAlta(FrmCliente cliente, FrmInicio inicio)
        {
            InitializeComponent();
            frmCliente = cliente;
            frmInicio = inicio;
            Campos();
            AddSexo();
            AddEspecie("Canino", "Felino", "Reptil", "Roedor", "Ave", "Otros");
            AddVeterinarios();
            cmboxCliente.Hide();
            label7.Hide();
            flag = 1;
        }

        //Metodos para construir form
        private void Campos()
        {
            dateNacimiento.MaxDate = DateTime.Today;
            dateNacimiento.MinDate = new DateTime(1997, 01, 01);
            dateVisita.MaxDate = new DateTime(2021, 01, 01);
            dateVisita.MinDate = DateTime.Today.AddDays(1);
            txtboxOtros.MaxLength = 2000;
            txtboxDeceso.MaxLength = 25;
        }

        private void AddSexo()
        {
            cmboxSexo.Items.Add('M');
            cmboxSexo.Items.Add('H');
            cmboxSexo.SelectedIndex = 0;
        }

        private void AddEspecie(string can, string feli, string rep, string rod, string ave, string ot)
        {
            cmboxEspecie.Items.Add(can);
            cmboxEspecie.Items.Add(feli);
            cmboxEspecie.Items.Add(rep);
            cmboxEspecie.Items.Add(rod);
            cmboxEspecie.Items.Add(ave);
            cmboxEspecie.Items.Add(ot);
            cmboxEspecie.SelectedIndex = 0;
        }

        //Otros Metodos
        public void AddClientes()
        {
            cmboxCliente.Items.Clear();
            cmboxCliente.Items.Add("Agregar nuevo");
            cmboxCliente.Items.Add("");
            foreach (Cliente cliente in frmInicio.GetDatos().GetDueños())
            {
                cmboxCliente.Items.Add(cliente);
            }
        }
        public void SelectCliente(Cliente dueño)
        {
            AddClientes();
            if (cmboxCliente.Items.Count != 0)
            {
                cmboxCliente.SelectedItem = dueño;
                cmboxCliente.Enabled = false;
            }
        }
        public void AddVeterinarios()
        {
            cmboxEmpleado.Items.Add("");
            foreach (Empleado veterinario in frmInicio.GetDatos().GetEmpleados())
            {
                cmboxEmpleado.Items.Add(veterinario);
            }
        }
        public void Clear()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox) { control.Text = ""; }
            }
            this.txtboxPaciente.Focus();
            this.dateNacimiento.Value = DateTime.Today;
            if (flag == 0)
            {
                cmboxCliente.Enabled = true;
                cmboxCliente.SelectedIndex = 0;
            }
            cmboxEspecie.SelectedIndex = 0;
            cmboxEmpleado.SelectedIndex = 0;
        }


        // Metodo para validaciones de campos 
        private Boolean Validacion()
        {   
            if (!(txtboxPaciente.Text.Length > 1) || !(Regex.IsMatch(txtboxPaciente.Text, @"^[ a-zA-Zá-úÁ-Ú]+$")))
            {
                MessageBox.Show("Debe ingresar un nombre válido");
                txtboxPaciente.Text = "";
                txtboxPaciente.Focus();
                return false;
            }
            //Identificacion 
            if (!(txtboxID.Text.Length > 0) || !(Regex.IsMatch(txtboxID.Text, @"^[ a-zA-Zá-úÁ-Ú0-9]+$")))
            {
                MessageBox.Show("Debe ingresar algún código de identificación");
                txtboxPaciente.Focus();
                return false;
            }
            /*Edad
            if (!(txtboxEdad.Text.Length > 0) || !(Regex.IsMatch(txtboxEdad.Text, @"^[0-9]+$")))
            {
                MessageBox.Show("Debe ingresar una edad válida");
                txtboxEdad.Text = "";
                txtboxEdad.Focus();
                return false;
            }
            //Peso
            if (!(txtboxPeso.Text.Length > 0) || !(Regex.IsMatch(txtboxPeso.Text, @"^[0-9]+$")))
            {
                MessageBox.Show("Debe ingresar un peso válido");
                txtboxPeso.Text = "";
                txtboxPeso.Focus();
                return false;
            }
            //Color
            if (!(txtboxColor.Text.Length > 1) || !(Regex.IsMatch(txtboxColor.Text, @"^[a-zA-Z]+$")))
            {
                MessageBox.Show("Debe ingresar un color válido");
                txtboxColor.Text = "";
                txtboxColor.Focus();
                return false;
            }
            //Raza
            if (!(txtboxRaza.Text.Length > 1) || !(Regex.IsMatch(txtboxRaza.Text, @"^[a-zA-Z]+$")))
            {
                MessageBox.Show("Debe ingresar una raza válida");
                txtboxRaza.Text = "";
                txtboxRaza.Focus();
                return false;
            }
            //Deceso
            if (!(checkboxActivo.Checked))
            {
                if (!(txtboxDeceso.Text.Length > 1) || !(Regex.IsMatch(txtboxDeceso.Text, @"^[a-zA-Z]+$")))
                {
                    MessageBox.Show("Debe ingresar una causa de deceso");
                    txtboxDeceso.Text = "";
                    txtboxDeceso.Focus();
                    return false;
                }
            }
            Cliente*/
            if (cmboxEmpleado.SelectedItem == null || cmboxEmpleado.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Debe asignarle un Veterinario al Paciente");
                return false;
            }

            if (flag == 0)
            {
                if (cmboxCliente.SelectedItem == null || cmboxCliente.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Debe asignarle un Cliente al Paciente");
                    return false;
                }
            }
            return true;
        }


        // Eventos
        private void cmboxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((flag == 0) & (cmboxCliente.SelectedItem.ToString() == "Agregar nuevo"))
            {
                this.Hide();
                cmboxCliente.SelectedIndex = 0;
                frmCliente = new FrmCliente(this, frmInicio);
                frmCliente.Show();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            if (flag == 0) { frmInicio.Show(); }
            if (flag == 1) { frmCliente.Show(); }
        }
        private void checkboxActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (!(checkboxActivo.Checked))
            {
                lblDeceso2.Visible = true;
                txtboxDeceso.Visible = true;
            }
            if (checkboxActivo.Checked)
            {
                lblDeceso2.Visible = false;
                txtboxDeceso.Visible = false;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                if (frmInicio.GetDatos().BuscarPacienteID(txtboxID.Text))
                {
                    MessageBox.Show("Ya se encuentra registrada una mascota con esa identificación.");
                    return;
                }
                else
                {
                    Paciente mascota = new Paciente();

                    if (checkboxActivo.Checked)
                    {
                        mascota.SetActivo("Si");
                        mascota.SetCausaDeceso("No corresponde");
                    }
                    else
                    {
                        mascota.SetActivo("No");
                        mascota.SetCausaDeceso(txtboxDeceso.Text);
                    }

                    mascota.SetColor(txtboxColor.Text);
                    //mascota.SetEdad(Int32.Parse(txtboxEdad.Text));
                    mascota.SetEspecie(cmboxEspecie.Text);
                    mascota.SetID(txtboxID.Text);
                    mascota.SetNacimiento(dateNacimiento.Value);
                    mascota.SetNombre(txtboxPaciente.Text);
                    //mascota.SetPeso(Int32.Parse(txtboxPeso.Text));
                    mascota.SetRaza(txtboxRaza.Text);
                    mascota.SetSexo(char.Parse(cmboxSexo.Text));
                    mascota.AddVisitas(dateVisita.Value, DateTime.Today);
                    mascota.SetVeterinario((Empleado)cmboxEmpleado.SelectedItem);

                    if (flag == 0)
                    {
                        mascota.SetDueño((Cliente)cmboxCliente.SelectedItem);
                        frmInicio.GetDatos().MascotaCliente((Cliente)cmboxCliente.SelectedItem, mascota);
                    }

                    frmInicio.GetDatos().AddMascota(mascota);
                    frmInicio.GetDatos().MascotaVeterinario((Empleado)cmboxEmpleado.SelectedItem, mascota);

                    this.Clear();
                    MessageBox.Show("El Paciente ha sido registrado correctamente.");

                    if (flag == 1)
                    {
                        this.Close();
                        frmCliente.Show();
                        frmCliente.AsignarMascota(mascota);
                    }
                } 
            }
        }
    }
}
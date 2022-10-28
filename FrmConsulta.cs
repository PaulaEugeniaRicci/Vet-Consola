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
    public partial class FrmConsulta : Form
    {
        private FrmInicio frmInicio;
        private int flag = 0;

        public FrmConsulta(FrmInicio inicio)
        {
            InitializeComponent();
            frmInicio = inicio;
            Campos();
        }

        //Metodos
        private void Campos()
        {
            cmboxBuscar.Items.Add("Clientes");
            cmboxBuscar.Items.Add("Pacientes");
            cmboxBuscar.Items.Add("Veterinarios");
            cmboxBuscar.SelectedIndex = 0;

            cmboxFiltro.Items.Add("DNI/ID");
            cmboxFiltro.Items.Add("Nombre/Apellido");
            cmboxFiltro.Enabled = false;
            cmboxFiltro.Visible = false;

            lblFiltro.Visible = false;
            txtboxFiltro.Enabled = false;
            txtboxFiltro.Visible = false;
        }

        private void Limpiar()
        {
            txtboxImpresion.Text = "";
        }

        private void Filtro()
        {
            flag = 0;
            if (checkboxFiltrar.Checked)
            {
                if (cmboxFiltro.SelectedItem.ToString() == "DNI/ID") { flag = 1;}
                else if (cmboxFiltro.SelectedItem.ToString() == "Nombre/Apellido") { flag = 2; }
            }
        }

        //Validacion
        private bool Validacion()
        {
            if (checkboxFiltrar.Checked & txtboxFiltro.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar algún dato válido");
                txtboxFiltro.Focus();
                return false;
            }
           
            return true;
        }

        //Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInicio.Show();
        }

        private void checkboxFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxFiltrar.Checked)
            {
                cmboxFiltro.Enabled = true;
                cmboxFiltro.Visible = true;
                lblFiltro.Visible = true;
                txtboxFiltro.Enabled = true;
                txtboxFiltro.Visible = true;
            }
            else
            {
                cmboxFiltro.Enabled = false;
                cmboxFiltro.Visible = false;
                lblFiltro.Visible = false;
                txtboxFiltro.Enabled = false;
                txtboxFiltro.Visible = false;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Filtro();
            Limpiar();
            if (Validacion())
            {
                //CLIENTES
                //TODOS
                if (cmboxBuscar.SelectedItem.ToString() == "Clientes" & flag == 0)
                {
                    ImprimirTodosLosClientes();
                    return;
                }
                //DNI
                else if (cmboxBuscar.SelectedItem.ToString() == "Clientes" & flag == 1)
                {
                    if (frmInicio.GetDatos().ReturnClientDNI(Int32.Parse(txtboxFiltro.Text)) is null)
                    {
                        MessageBox.Show("No se encontraron clientes con ese documento.");
                        return;
                    }
                    else
                    {
                        ImprimirCliente(frmInicio.GetDatos().ReturnClientDNI(Int32.Parse(txtboxFiltro.Text)));
                        return;
                    }
                }

                //NOMBRE
                else if (cmboxBuscar.SelectedItem.ToString() == "Clientes" & flag == 2)
                {
                    if (!frmInicio.GetDatos().ReturnClientName(txtboxFiltro.Text).Any())
                    {
                        MessageBox.Show("No se encontraron clientes con ese nombre.");
                        return;
                    }
                    else
                    {
                        foreach (Cliente cliente in frmInicio.GetDatos().ReturnClientName(txtboxFiltro.Text))
                        {
                            ImprimirCliente(cliente);
                        }
                        return;
                    }
                }

                //PACIENTES
                //TODOS
                else if (cmboxBuscar.SelectedItem.ToString() == "Pacientes" & flag == 0)
                {
                    ImprimirTodosLosPacientes();
                    return;
                }

                //ID
                else if (cmboxBuscar.SelectedItem.ToString() == "Pacientes" & flag == 1)
                {
                    if (frmInicio.GetDatos().ReturnPacientID(txtboxFiltro.Text) is null)
                    {
                        MessageBox.Show("No se encontraron pacientes con esa identificación.");
                        return;
                    }
                    else
                    {
                        ImprimirPaciente(frmInicio.GetDatos().ReturnPacientID(txtboxFiltro.Text));
                        return;
                    }
                }
                //NOMBRE
                else if (cmboxBuscar.SelectedItem.ToString() == "Pacientes" & flag == 2)
                {
                    if (frmInicio.GetDatos().ReturnPacientID(txtboxFiltro.Text) is null)
                    {
                        MessageBox.Show("No se encontraron pacientes con ese nombre.");
                        return;
                    }
                    else ImprimirPaciente(frmInicio.GetDatos().ReturnPacientID(txtboxFiltro.Text));
                    return;
                }

                //EMPLEADOS
                //TODOS
                else if (cmboxBuscar.SelectedItem.ToString() == "Veterinarios" & flag == 0)
                {
                    ImprimirTodosLosVeterinarios();
                    return;
                }

                //DNI
                else if (cmboxBuscar.SelectedItem.ToString() == "Veterinarios" & flag == 1)
                {
                    if (frmInicio.GetDatos().ReturnEmployeeDNI(Int32.Parse(txtboxFiltro.Text)) is null)
                    {
                        MessageBox.Show("No se encontraron empleados con ese documento.");
                        return;
                    }
                    else ImprimirVeterinario(frmInicio.GetDatos().ReturnEmployeeDNI(Int32.Parse(txtboxFiltro.Text)));
                    return;
                }
                //NOMBRE
                else if (cmboxBuscar.SelectedItem.ToString() == "Veterinarios" & flag == 2)
                {
                    if (frmInicio.GetDatos().ReturnEmployeeDNI(Int32.Parse(txtboxFiltro.Text)) is null)
                    {
                        MessageBox.Show("No se encontraron empleados con ese nombre.");
                        return;
                    }
                    else ImprimirVeterinario(frmInicio.GetDatos().ReturnEmployeeDNI(Int32.Parse(txtboxFiltro.Text)));
                    return;
                }
            }
        }

        //Metodos de Impresion en TextBox Impresion
        // Todos
        private void ImprimirTodosLosClientes()
        {
            int cont = 1;
            foreach (Cliente dueño in frmInicio.GetDatos().GetDueños())
            {
                txtboxImpresion.AppendText(Environment.NewLine + "CLIENTE NÚMERO: " + cont);
                ImprimirCliente(dueño);
                cont += 1;
            }
        }
        private void ImprimirTodosLosPacientes()
        {
            int cont = 1;
            foreach (Paciente mascota in frmInicio.GetDatos().GetMascotas())
            {
                txtboxImpresion.AppendText(Environment.NewLine + "PACIENTE NÚMERO: " + cont);
                ImprimirPaciente(mascota);
                cont += 1;
            }
        }
        private void ImprimirTodosLosVeterinarios()
        {
            int cont = 1;
            foreach (Empleado veterinario in frmInicio.GetDatos().GetEmpleados())
            {
                txtboxImpresion.AppendText(Environment.NewLine + "EMPLEADO NÚMERO: " + cont);
                ImprimirVeterinario(veterinario);
                cont += 1;
            }
        }

        //Impresion a secas
        private void ImprimirCliente(Cliente cliente)
        {
            txtboxImpresion.AppendText(Environment.NewLine + "CLIENTE: " + cliente.GetNombre() + Environment.NewLine);
            txtboxImpresion.AppendText("DOCUMENTO: " + cliente.GetDocumento() + Environment.NewLine);
            txtboxImpresion.AppendText("TELEFONO: " + cliente.GetNumero() + Environment.NewLine);
            txtboxImpresion.AppendText("EMAIL: " + cliente.GetEmail() + Environment.NewLine);
            txtboxImpresion.AppendText("DOMICILIO: " + cliente.GetDomicilio() + Environment.NewLine);
            txtboxImpresion.AppendText("CANTIDAD DE MASCOTAS: " + cliente.GetMascotas().Count() + Environment.NewLine);
            foreach (Paciente mascota in cliente.GetMascotas())
            {
                txtboxImpresion.AppendText("NOMBRE DE MASCOTA: " + mascota.GetNombre() + Environment.NewLine);
                txtboxImpresion.AppendText("IDENTIFICACION: " + mascota.GetID() + Environment.NewLine);
            }
        }

        private void ImprimirVeterinario(Empleado veterinario)
        {
            txtboxImpresion.AppendText(Environment.NewLine + "EMPLEADO: " + veterinario.GetNombre() + Environment.NewLine);
            txtboxImpresion.AppendText("DOCUMENTO: " + veterinario.GetDocumento() + Environment.NewLine);
            txtboxImpresion.AppendText("TELEFONO: " + veterinario.GetNumero() + Environment.NewLine);
            txtboxImpresion.AppendText("EMAIL: " + veterinario.GetEmail() + Environment.NewLine);
            txtboxImpresion.AppendText("DOMICILIO: " + veterinario.GetDomicilio() + Environment.NewLine);
            txtboxImpresion.AppendText("CANTIDAD DE PACIENTES: " + veterinario.GetPacientes().Count() + Environment.NewLine);
            foreach (Paciente paciente in veterinario.GetPacientes())
            {
                txtboxImpresion.AppendText("NOMBRE DE PACIENTE: " + paciente.GetNombre() + Environment.NewLine);
                txtboxImpresion.AppendText("IDENTIFICACION: " + paciente.GetID() + Environment.NewLine);
            }
        }
            
        public void ImprimirPaciente(Paciente mascota)
        {
            txtboxImpresion.AppendText(Environment.NewLine + "IDENTIFICACION: " + mascota.GetID() + Environment.NewLine);
            txtboxImpresion.AppendText("NOMBRE: " + mascota.GetNombre() + Environment.NewLine);
            txtboxImpresion.AppendText("ESPECIE: " + mascota.GetEspecie() + Environment.NewLine);
            txtboxImpresion.AppendText("RAZA: " + mascota.GetRaza() + Environment.NewLine);
            txtboxImpresion.AppendText("COLOR: " + mascota.GetColor() + Environment.NewLine);
            txtboxImpresion.AppendText("PESO: " + mascota.GetPeso() + "KG" + Environment.NewLine);
            txtboxImpresion.AppendText("FECHA NACIMIENTO: " + mascota.GetNacimiento() + Environment.NewLine);
            txtboxImpresion.AppendText("EDAD: " + mascota.GetEdad() + Environment.NewLine);
            txtboxImpresion.AppendText("ACTIVO: " + mascota.GetActivo() + Environment.NewLine);
            txtboxImpresion.AppendText("CAUSA DECESO: " + mascota.GetCausaDeceso() + Environment.NewLine);
            txtboxImpresion.AppendText("DUEÑO: " + mascota.GetDueno() + Environment.NewLine);
            txtboxImpresion.AppendText("VETERINARIO A CARGO: " + mascota.GetVeterinario() + Environment.NewLine);
            txtboxImpresion.AppendText("VISITAS: " +  Environment.NewLine);
            foreach (DateTime fecha in mascota.GetVisitas())
            {
                txtboxImpresion.AppendText(fecha + Environment.NewLine);             
            }         
        }
    }       
}

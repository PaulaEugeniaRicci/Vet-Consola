using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vet
{
    [Serializable]
    public class Datos
    {
        private List<Cliente> Dueños { get; set; }
        private List<Empleado> Empleados { get; set; }        
        private List<Paciente> Pacientes { get; set; }      
        
        public Datos()
        {
            this.Dueños = new List<Cliente>();
            this.Empleados = new List<Empleado>();
            this.Pacientes = new List<Paciente>();           
        }

        //Setters
        public void SetDueños(List<Cliente> value) { this.Dueños = value; }
        public void SetEmpleados (List<Empleado> value) { this.Empleados = value; }
        public void SetMascotas(List<Paciente> value) { this.Pacientes = value; }

        //Getters
        public List<Cliente> GetDueños() { return Dueños; }
        public List<Empleado> GetEmpleados() { return Empleados; }
        public List<Paciente> GetMascotas() { return Pacientes; }

        //Metodos Add 
        public void AddDueño(Cliente dueño) {
            this.Dueños.Add(dueño);
        }
        public void AddEmpleado (Empleado veterinario)
        {
            this.Empleados.Add(veterinario);
        }
        public void AddMascota(Paciente mascota) {
            this.Pacientes.Add(mascota);
        }

        //Metodos para asociar 
        public void MascotaCliente(Cliente cliente, Paciente mascota)
        {
            foreach (Cliente dueño in Dueños)
            {
                if (dueño == cliente)
                {
                    dueño.AddMascota(mascota);
                }
            }
        }
        public void MascotaVeterinario(Empleado empleado, Paciente mascota)
        {
            foreach (Empleado veterinario in Empleados)
            {
                if (veterinario == empleado)
                {
                    veterinario.AddPacienteVeterinario(mascota);
                }
            }
        }

        public void ClienteMascota (Paciente paciente, Cliente dueño)
        {
            foreach (Paciente mascota in Pacientes)
            {
                if (paciente.GetID() == mascota.GetID())
                {
                    mascota.AddDueñoMascota(dueño);
                }
            }
        }

        //Metodos de Busqueda
        public Boolean BuscarPacienteID (string ID)
        {
            foreach (Paciente mascota in Pacientes)
            {
                if (mascota.GetID() == ID)
                {
                    return true;
                }
            }
            return false;
        }
        public Boolean BuscarClienteDNI(int DNI)
        {
            foreach (Cliente cliente in Dueños)
            {
                if (cliente.GetDocumento() == DNI)
                {
                    return true;
                }
            }
            return false;
        }
        public Boolean BuscarEmpleadoDNI(int DNI)
        {
            foreach (Empleado veterinario in Empleados)
            {
                if (veterinario.GetDocumento() == DNI)
                {
                    return true;
                }
            }
            return false;
        }

        //Metodos p/ Consulta
        public Cliente ReturnClientDNI(int DNI)
        {
            foreach (Cliente dueño in Dueños)
            {
                if (dueño.GetDocumento() == DNI)
                {
                    return dueño;
                }
            }
            Cliente clienteNoExiste = new Cliente();
            clienteNoExiste = null;
            return clienteNoExiste;
        }
        public Empleado ReturnEmployeeDNI(int DNI)
        {
            foreach (Empleado veterinario in Empleados)
            {
                if (veterinario.GetDocumento() == DNI)
                {
                    return veterinario;
                }
            }
            Empleado empleadoNoExiste = new Empleado();
            empleadoNoExiste = null;
            return empleadoNoExiste;
        }
        public Paciente ReturnPacientID(string ID)
        {
            foreach (Paciente mascota in Pacientes)
            {
                if (mascota.GetID() == ID)
                {
                    return mascota;
                }
            }
            Paciente pacienteNoExiste = new Paciente();
            pacienteNoExiste = null;
            return pacienteNoExiste;
        }
        //
        public List <Cliente> ReturnClientName(string nombre)
        {
            List<Cliente> listaClientes = new List<Cliente>();
            foreach (Cliente cliente in Dueños)
            {
                if (cliente.GetNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    listaClientes.Add(cliente);
                }
            }
            return listaClientes;
        }
    }
}


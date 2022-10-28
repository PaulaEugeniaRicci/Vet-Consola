using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet
{
    [Serializable]
    public class Empleado
    {
        private int documento { get; set; }
        private int numero { get; set; }
        private string domicilio { get; set; }
        private string email { get; set; }
        private string nombre { get; set; }
        private List<Paciente> pacientes { get; set; }

        public Empleado ()
        {
            this.pacientes = new List<Paciente>();
        }

        //Setters
        public void SetDocumento (int value) { this.documento = value; }
        public void SetNumero(int value) { this.numero = value; }
        public void SetDomicilio(string value) { this.domicilio = value; }
        public void SetEmail(string value) { this.email = value; }
        public void SetNombre(string value) { this.nombre = value; }
        public void SetPacientes(List<Paciente> value) { this.pacientes = value; }

        //Getters

        public int GetDocumento() { return documento; }
        public int GetNumero () { return numero; }
        public string GetDomicilio () { return domicilio; }
        public string GetEmail () { return email; }
        public string GetNombre() { return nombre; }
        public List<Paciente> GetPacientes() { return pacientes; }

       
        // Metodo para agregar Pacientes al Veterinario
        public void AddPacienteVeterinario(Paciente value)
        {
            this.pacientes.Add(value);
        }
        public override string ToString() //p/combobox
        {
            return String.Concat(nombre.ToString(), " - ", documento.ToString());
        }
    }

}


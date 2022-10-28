using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vet
{
    [Serializable]
    public class Paciente
    {
        private int edad { get; set; }
        private int peso { get; set; }
        private char sexo { get; set; }
        private string activo { get; set; }
        private string causadeceso { get; set; }
        private string color { get; set; }
        private string especie { get; set; }
        private string ID { get; set; }
        private string nombre { get; set; }
        private string raza { get; set; }
        private DateTime nacimiento { get; set; }
      

        private Cliente dueno { get; set; }
        private Empleado veterinario { get; set; }
        private List <DateTime> visitas { get; set; }


        public Paciente()
        {
            this.dueno = new Cliente();
            this.veterinario = new Empleado();
            this.visitas = new List<DateTime>();
        }

        //Setters   
        public void SetEdad(int value) { this.edad = value; }
        public void SetPeso(int value) { this.peso = value; }
        public void SetSexo(char value) { this.sexo = value; }
        public void SetActivo(string value) { this.activo = value; }
        public void SetCausaDeceso(string value) { this.causadeceso = value; }
        public void SetColor(string value) { this.color = value; }
        public void SetEspecie(string value) { this.especie = value; }
        public void SetNombre(string value) { this.nombre = value; }
        public void SetID(string value) { this.ID = value; }
        public void SetRaza(string value) { this.raza = value; }
        public void SetDueño(Cliente value) { this.dueno = value; }
        public void SetVeterinario(Empleado value) { this.veterinario = value; }
        public void SetNacimiento(DateTime value) { this.nacimiento = value; }  
        public void SetVisitas(List <DateTime> value) { this.visitas = value; }


        // Getters
        public int GetEdad() { return edad; }
        public int GetPeso() { return peso; }
        public string GetActivo() { return activo; }
        public string GetCausaDeceso() { return causadeceso; }
        public string GetColor() { return color; }
        public string GetEspecie() { return especie; }
        public string GetNombre() { return nombre; }
        public string GetID() { return ID; }
        public string GetRaza() { return raza; }
        public Cliente GetDueno() { return dueno; }
        public Empleado GetVeterinario() { return veterinario; }
        public DateTime GetNacimiento() { return nacimiento; }        
        public List <DateTime> GetVisitas() {return visitas; }

        //Metodos

        public void AddVisitas (DateTime date, DateTime today)
        {
            this.visitas.Add(date);
            this.visitas.Add(today);
        }
        // Metodos para agregar Dueño/Veterinario a la Mascota
        public void AddDueñoMascota(Cliente value)
        {
            this.dueno = value;
        }

        public void AddVeterinarioMascota (Empleado value)
        {
            this.veterinario = value;
        }

        public override string ToString() // p/combobox
        {
            return String.Concat(nombre.ToString(), " - ", ID.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Vet
{
    [Serializable]
    public class Cliente
    {
        private int Documento { get; set; }
        private int Numero { get; set; }       
        private string Domicilio { get; set; }
        private string Email { get; set; }
        private string Nombre { get; set; }
        private List<Paciente> Mascotas { get; set; }

   
        public Cliente ()
        {
            this.Mascotas = new List<Paciente>();
        }

        //Setters
        public void SetDocumento (int value) { this.Documento = value; }
        public void SetNumero(int value) { this.Numero = value; }
        public void SetDomicilio(string value) { this.Domicilio = value; }
        public void SetEmail(string value) { this.Email = value; }
        public void SetNombre (string value) { this.Nombre = value; }
        public void SetMascotas(List<Paciente> value) { this.Mascotas = value; }


        //Getters

        public int GetDocumento () { return Documento; }
        public int GetNumero () { return Numero; }
        public string GetDomicilio() { return Domicilio; }
        public string GetEmail () { return Email; }
        public string GetNombre() { return Nombre; }
        public List<Paciente> GetMascotas () { return Mascotas; }



        // Metodo para agregar Mascotas al Cliente
        public void AddMascota (Paciente value)
        {
            this.Mascotas.Add(value);
        }

        public override string ToString() //p/combobox 
        {
            return String.Concat(Nombre.ToString(), " - ", Documento.ToString());
        }
    }
}

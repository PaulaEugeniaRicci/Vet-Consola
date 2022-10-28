using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Vet
{
    static class Program
    {
        private static Datos datos;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Stream stream = File.OpenRead("datosVeterinaria.bin");
                BinaryFormatter deserializer = new BinaryFormatter();
                datos = (Datos)deserializer.Deserialize(stream);
                stream.Close();
            }
            catch (Exception)
            {
                datos = new Datos();
            }

            Application.ApplicationExit += new System.EventHandler(PersistirEnArchivo);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmInicio(datos));
        }

        public static void PersistirEnArchivo(object sender, EventArgs e)
        {
            Stream stream = File.Create("datosVeterinaria.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(stream, datos);
            stream.Close();
            MessageBox.Show("objeto serializado ok. terminando programa.");
        }
    }
}





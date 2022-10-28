using System;
using System.Windows.Forms;

namespace Vet
{
    public partial class FrmInicio : Form
    {
        private FrmAlta frmAlta;
        private FrmConsulta frmConsulta;
        private FrmCliente frmCliente;
        private FrmEmpleado frmEmpleado;
        private Datos Datos { get; set; }

        // Constructor
        public FrmInicio(Datos datos)
        {
            InitializeComponent();
            this.Datos = datos;
        }

        public void SetDatos(Datos value) { this.Datos = value; }

        public Datos GetDatos() { return Datos; }


        // Eventos
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAlta = new FrmAlta(this);
            frmAlta.Show();
            this.Hide();
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConsulta = new FrmConsulta(this);
            frmConsulta.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente = new FrmCliente(this);
            frmCliente.Show();
            this.Hide();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleado = new FrmEmpleado(this);
            frmEmpleado.Show();
            this.Hide();
        }
    }
}

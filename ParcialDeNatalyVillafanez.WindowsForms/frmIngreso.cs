using ParcialDeNatalyVillafanez.Entidades1;
using ParcialDeNatalyVillfanez.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialDeNatalyVillafanez.WindowsForms
{
    public partial class frmIngreso : Form
    {
        double semiejeMayor;
        double semiejeMenor;
        string cantidad;
        Elipse elipse;
        RepositorioDeElipses repo = new RepositorioDeElipses();
        public frmIngreso()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboTrazos();
        }
        
        private void CargarDatosComboTrazos()
        {
            TipoDeTrazoComboBox.DataSource = Enum.GetValues(typeof(TipoTrazo));
            TipoDeTrazoComboBox.SelectedIndex = 0;
            
            
        }

        internal Elipse GetElipse()
        {

            return elipse;
        }

        internal string GetCantidad()
        {
            return cantidad;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                elipse = new Elipse();
                elipse.SemiejeMayor = double.Parse(semiejeMayorTextBox.Text);
                elipse.SemiejeMenor = double.Parse(semiejeMenorTextBox.Text);

                DialogResult = DialogResult.OK;


            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (!double.TryParse(semiejeMayorTextBox.Text, out semiejeMayor))
            {
                valido = false;
                errorProvider1.SetError(semiejeMayorTextBox, "Error, ingrese un semieje valido");
            }
            else if (!double.TryParse(semiejeMenorTextBox.Text, out semiejeMenor))
            {
                valido = false;
                errorProvider1.SetError(semiejeMenorTextBox, "Error, ingrese un semieje valido");
            }
            else if (semiejeMayor <=0)
            {
                valido = false;
                errorProvider1.SetError(semiejeMayorTextBox, "El semieje debe ser positivo");
            }
            else if (semiejeMenor <= 0)
            {
                valido = false;
                errorProvider1.SetError(semiejeMayorTextBox, "El semieje debe ser positivo");
            }
            return valido;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
 
}

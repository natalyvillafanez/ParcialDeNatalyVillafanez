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
    public partial class frmElipses : Form
    {
        private List<Elipse> lista;
        private RepositorioDeElipses repo;
        public frmElipses()
        {
            InitializeComponent();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            frmIngreso frm = new frmIngreso();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                Elipse elipse = frm.GetElipse();

                repo.Agregar(elipse);
                var fila = ConstruirFila();
                SetearFila(fila, elipse);
                AgregarFila(fila);
                MostrarCantidad();
            }
        }

        private void MostrarCantidad()
        {
            
            CantidadTextBox.Text= repo.CantidadElipses().ToString();
        }

        private void AgregarFila(DataGridViewRow r)
        {
            ElipsesDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Elipse elipse)
        {
            r.Cells[colSemiejeMayor.Index].Value = elipse.SemiejeMayor;
            r.Cells[colSemiejeMenor.Index].Value = elipse.SemiejeMenor;
            r.Cells[colPerimetro.Index].Value = elipse.GetPerimetro();
            r.Cells[colArea.Index].Value = elipse.GetArea();
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(ElipsesDataGridView);
            return r;
        }

        private void frmElipses_Load(object sender, EventArgs e)
        {
            repo = new RepositorioDeElipses();

        }

        private void GuardadToolStripButton_Click(object sender, EventArgs e)
        {
            ManejadorDeArchivoSecuencial.GuardarEnArchivoSecuencia(repo.GetLista());
            MessageBox.Show("Registros Guardados");
        }
    }
}

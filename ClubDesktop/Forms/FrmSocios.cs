using ClubDesktop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDesktop.Forms
{
    public partial class FrmSocios : Form
    {
        public FrmSocios()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            ClubDesktopContext context = new ClubDesktopContext();
            if (txtBusqueda.Text.Length > 0)
            {
                dataGridSocios.DataSource = context.Socios.Where(s => s.ApellidoNombre.Contains(txtBusqueda.Text)).ToList();
            }
            else
            {
                dataGridSocios.DataSource = context.Socios.ToList();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idAEliminar =(int)dataGridSocios.CurrentRow.Cells[0].Value;
            string nombreSocioAEliminar = (string)dataGridSocios.CurrentRow.Cells[1].Value;
            var resultado=MessageBox.Show($"¿Está seguro que desea Eliminar al socio {nombreSocioAEliminar}?","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(resultado==DialogResult.Yes)
            {
                try
                {
                    var context = new ClubDesktopContext();
                    var socio = context.Socios.Find(idAEliminar);
                    context.Socios.Remove(socio);
                    context.SaveChanges();
                    CargarGrilla();
                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrio un problema al intentar borrar al socio {nombreSocioAEliminar}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
    }
}

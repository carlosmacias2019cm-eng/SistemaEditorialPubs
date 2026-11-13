using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaEditorialPubs
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            using (FrmAutores autores = new FrmAutores())
            {
                autores.ShowDialog();
            }
        }

        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            using (FrmEditoriales editoriales = new FrmEditoriales())
            {
                editoriales.ShowDialog();
            }
        }

        private void btnTitulos_Click(object sender, EventArgs e)
        {
            using (FrmTitulos titulos = new FrmTitulos())
            {
                titulos.ShowDialog();
            }
        }

        private void btnPuestos_Click(object sender, EventArgs e)
        {
            using (FrmPuestos puestos = new FrmPuestos())
            {
                puestos.ShowDialog();
            }
        }

        private void bntAutoresPorTitulo_Click(object sender, EventArgs e)
        {
            using (FrmAutoresPorTitulo formulario = new FrmAutoresPorTitulo())
            {
                formulario.ShowDialog();
            }
        }

        private void btnRegalias_Click(object sender, EventArgs e)
        {
            using (FrmRegalias formulario = new FrmRegalias())
            {
                formulario.ShowDialog();
            }
        }

        private void bntTiendas_Click(object sender, EventArgs e)
        {
            using (FrmTiendas formulario = new FrmTiendas())
            {
                formulario.ShowDialog();
            }
        }

        private void bntVentas_Click(object sender, EventArgs e)
        {
            using (FrmVentas formulario = new FrmVentas())
            {
                formulario.ShowDialog();
            }
        }

        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            using (FrmDescuentos formulario = new FrmDescuentos())
            {
                formulario.ShowDialog();
            }
        }

        private void btnInformacionEditorial_Click(object sender, EventArgs e)
        {
            using (FrmInfoEditorial info = new FrmInfoEditorial())
            {
                info.ShowDialog();
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            using (FrmEmpleados info = new FrmEmpleados())
            {
                info.ShowDialog();
            }
        }
    }
}

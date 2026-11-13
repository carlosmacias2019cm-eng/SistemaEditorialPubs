using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaEditorialPubs
{
    public partial class FrmInfoEditorial : Form
    {
        public FrmInfoEditorial()
        {
            InitializeComponent();
        }

        private void FrmInfoEditorial_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTests
{
    public partial class MenuDesplegable : Form
    {
        public MenuDesplegable()
        {
            InitializeComponent();
        }

        // VENTAS
        private void button5_Click(object sender, EventArgs e)
        {
            pnlCatalogos.Visible = false;
            pnlReportes.Visible = false;
        }

        // CATALOGOS
        private void button6_Click(object sender, EventArgs e)
        {
            pnlReportes.Visible = false;
            pnlCatalogos.Visible = true;
            pnlCatalogos.Show();
        }

        //REPORTES
        private void button7_Click(object sender, EventArgs e)
        {
            pnlCatalogos.Visible = false;
            pnlReportes.Visible = true;
            pnlReportes.Show();
        }

        private void MenuDesplegable_Load(object sender, EventArgs e)
        {
            pnlReportes.Visible = false;
            pnlCatalogos.Visible = false;
        }
    }
}

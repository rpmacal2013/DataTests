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
    public partial class DataSourceTest : Form
    {
        BindingSource bs = new BindingSource();

        public DataSourceTest()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DataTable dt = DataSourceTestN.Carga();

            dgvArticulos.DataSource = bs;
            bs.DataSource = dt;
            txtIdArticulo.DataBindings.Add(new Binding("Text", bs, "IdArticulo"));
            txtCodigoArticulo.DataBindings.Add(new Binding("Text", bs, "Codigo"));
            txtNombreArticulo.DataBindings.Add(new Binding("Text", bs, "NombreArticulo"));
            chkEsServicio.DataBindings.Add(new Binding("Checked", bs, "EsServicio"));
        }
    }
}

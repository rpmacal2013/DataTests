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
    public partial class VentasEncDet : Form
    {
        BindingSource bsEnc = new BindingSource();
        BindingSource bsDet = new BindingSource();
        DataTable dtEnc;
        DataTable dtDet;

        public VentasEncDet()
        {
            InitializeComponent();
        }

        private void VentasEncDet_Load(object sender, EventArgs e)
        {
            dgvVentasDetalle.DataSource = bsDet;
        }

        private void dgvVentasEncabezado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int numVenta = Convert.ToInt32(dgvVentasEncabezado.Rows[e.RowIndex].Cells[0].Value);
                dtDet = DataSourceTestN.CargaVentasDet(numVenta);
                bsDet.DataSource = dtDet;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dtEnc = DataSourceTestN.CargaVentasEnc();

            dgvVentasEncabezado.DataSource = bsEnc;
            bsEnc.DataSource = dtEnc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PdfUA pdf = new PdfUA();
            //pdf.ManipulatePdf();
            //pdf.ReporteVentas1();
            pdf.ReporteVentas2();
            label1.Text = "DONE!!!";
        }

        private void btnTotalMesArticulo_Click(object sender, EventArgs e)
        {
            PdfUA pdf = new PdfUA();
            DataTable dt = DataSourceTestN.TotalVentasMesArticulo();
            pdf.TotalVentasMesArticulo(dt);
            label1.Text = "DONE!!!";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

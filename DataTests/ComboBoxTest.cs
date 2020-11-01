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
    public partial class ComboBoxTest : Form
    {
        public ComboBoxTest()
        {
            InitializeComponent();
        }

        private void ComboBoxTest_Load(object sender, EventArgs e)
        {
            LlenaCB();
        }

        private void LlenaCB()
        {
            Dictionary<int, string> cbSrc = new Dictionary<int, string>();

            cbSrc.Add(1, "UNO");
            cbSrc.Add(2, "DOS");
            cbSrc.Add(3, "TRES");
            cbSrc.Add(4, "CUATRO");
            cbSrc.Add(5, "CINCO");
            cbSrc.Add(6, "SEIS");

            cbLista.DataSource = new BindingSource(cbSrc,null);
            cbLista.DisplayMember = "Value";
            cbLista.ValueMember = "Key";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int i = cbLista.FindString(txtBuscar.Text);
            cbLista.SelectedIndex = cbLista.FindString(txtBuscar.Text);
            //cbLista.SelectedItem = cbLista.Items[i].ToString();
        }
    }
}

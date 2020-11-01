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
    public partial class TextBoxTest : Form
    {
        bool copiados = false;
        bool primeraVez = true;

        public TextBoxTest()
        {
            InitializeComponent();
        }

        private void TextBoxTest_Load(object sender, EventArgs e)
        {

        }

        private void DetectaCambio(object sender, EventArgs e)
        {
            TextBox txtbox = sender as TextBox;

            label1.Text = "Text changed in: " + txtbox.Name + " nuevo texto: " + txtbox.Text;
        }

        // ASIGNAR VALORES
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "TEXTBOX1";
            textBox2.Text = "TEXTBOX2";
            textBox3.Text = "TEXTBOX3";
            textBox4.Text = "TEXTBOX4";

            comboBox1.Items.Add("UNO");
            comboBox1.Items.Add("DOS");
            comboBox1.Items.Add("TRES");
            comboBox1.Items.Add("CUATRO");

            CargaListaCB();

            copiados = true;
            primeraVez = true;
        }

        //private void textBox1_KeyDown(object sender, KeyEventArgs e)
        //{
            
        //}


        // SALIR
        private void button2_Click(object sender, EventArgs e)
        {
            if (copiados && !primeraVez)
            {
                // se modificaron campos despues de copiar datos
                label1.Text = "modificado por segunda vez";
                MessageBox.Show("Cambios sin guardar");
            }
            else
                this.Close();
        }

        //private void ChecaCambio(object sender, KeyEventArgs e)
        //{
        //    copiados = true;
        //    Type tipo = sender.GetType();
        //    label2.Text = "Cambio en el control: " + tipo.Name;
        //    //TextBox txtbox = sender as TextBox;
        //    //txtbox.ForeColor = Color.Red;
        //}

        //private void ChecaCambio(object sender, EventArgs e)
        //{
        //    CheckBox chkb = sender as CheckBox;
        //    label1.Text = "Cambio en checkbox:";
        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    label1.Text = "Cambio en combobox";
        //}

        private void CargaListaCB()
        {
            Dictionary<int, string> cbSrc = new Dictionary<int, string>();

            cbSrc.Add(1, "UNO");
            cbSrc.Add(2, "DOS");
            cbSrc.Add(3, "TRES");
            cbSrc.Add(4, "CUATRO");
            cbSrc.Add(5, "CINCO");
            cbSrc.Add(6, "SEIS");

            comboBox1.DataSource = new BindingSource(cbSrc, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            comboBox1.SelectedIndex = 0;
            
        }

        private void CheckKeys(object sender, KeyEventArgs e)
        {

            if (copiados && primeraVez)
            {
                primeraVez = false;
                //copiados = false;
                label1.Text = "modificado por primera vez";
            }

            if (copiados && !primeraVez)
            {
                // se modificaron campos despues de copiar datos
                label1.Text = "modificado por segunda vez";
            }

        }

        private void CheckValueChange(object sender, EventArgs e)
        {
            if (copiados && primeraVez)
            {
                primeraVez = false;
                //copiados = false;
                label1.Text = "modificado por primera vez";
            }

            if (copiados && !primeraVez)
            {
                // se modificaron campos despues de copiar datos
                label1.Text = "modificado por segunda vez";
            }

        }

        //private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        //{

        //}

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void dtp1_ValueChanged(object sender, EventArgs e)
        //{
        //    DateTimePicker dtp1 = sender as DateTimePicker;
        //    label2.Text = "VALUE CHANGED I CALENDAR";
        //}
    }
}

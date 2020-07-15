using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBuildGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            txtNumber.Text = "234242.344";
            txtFormat.Text = "{0:0.000}";
        }

        private void butTest_Click(object sender, EventArgs e)
        {
            try
            {
                decimal decNum = Convert.ToDecimal(txtNumber.Text);
                double doublNum = Convert.ToDouble(txtNumber.Text);

                txtOutput.Text = string.Format(txtFormat.Text, decNum);
                txtOutput.Text += Environment.NewLine + string.Format(txtFormat.Text, doublNum);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            


        }

        private void butFillData_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> lst = new List<Cliente>();
                lst.Add(new Cliente("nombre1"));
                lst.Add(new Cliente("nombre2"));

                // add las columnas
                grid.Columns.Add("codCliente", "Codigo");
                grid.Columns.Add("desCliente", "Nombre");

                foreach (var item in lst)
                {
                    this.grid.Rows.Add(new object[] { item.CodClienteN, item.Nombre });
                }
//                this.dgrData.Rows.Add(new object[] { "col1", "col2", "col3", 4.5, true });
            }
            catch (Exception ex)
            {

                MessageBox.Show (ex.Message);
            }
            
        }

        private void buttManual_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            Cliente cliente;

            bs.DataSource = typeof(Cliente);
            cliente = new Cliente("Cliente1");
            bs.Add(cliente);
            cliente = new Cliente("Cliente2");
            bs.Add(cliente);

            grid.DataSource = bs;
            grid.AutoGenerateColumns = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            airplaneBindingSource.Add(new Airplane("Boeing 747", 800));
            airplaneBindingSource.Add(new Airplane("Airbus A380", 1023));
            airplaneBindingSource.Add(new Airplane("Cessna 162", 67));
        }
    }
}

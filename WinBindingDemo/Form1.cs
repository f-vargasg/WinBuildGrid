using MisClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBindingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            airplaneBindingSource.Add(new Airplane("Boeing 747", 800));
            airplaneBindingSource.Add(new Airplane("Airbus A380", 1023));
            airplaneBindingSource.Add(new Airplane("Cessna 162", 67));
        }
    }
}

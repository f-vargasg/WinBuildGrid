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

namespace WinBindingDemo2
{
    public partial class Form1 : Form
    {
        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            bs.DataSource = typeof(Airplane);                                //**
            bs.Add(new Airplane("Boeing 747", 800));
            bs.Add(new Airplane("Airbus A380", 1023));
            bs.Add(new Airplane("Cessna 162", 67));
            */

            bs.Add(new Airplane("Boeing 747", 800));
            bs.DataSource = new Airplane("Airbus A380", 1023);
            bs.Add(new Airplane("Cessna 162", 67));

            grid.DataSource = bs;                                            //**
            grid.AutoGenerateColumns = true; // create columns automatically //**
            txtModel.DataBindings.Add("Text", bs, "Model");
        }
    }
}

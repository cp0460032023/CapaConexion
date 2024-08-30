using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Net;
using DatosLayer;
using Datoslayer;

namespace CapaConexion
{
    public partial class Form1 : Form
    {
        CustomerRepository customerRepository = new CustomerRepository();

        List<customers> Customers = new List<customers>();

        public Form1()
        {
            InitializeComponent();
        }

        private void cargarbtn_Click(object sender, EventArgs e)
        {
            var Customers = customerRepository.ObtenerTodos();
            dataGrid.DataSource = Customers;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //var filtro = Customers.FindAll(x => x.CompanyName.StartsWith(tbFiltro.Text));
            //dataGrid.DataSource = filtro;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
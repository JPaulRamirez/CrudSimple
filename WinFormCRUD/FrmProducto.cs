using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCRUD
{
    public partial class FrmProducto : Form
    {
        private Producto producto;

        public Producto Producto
        {
            get { return this.producto; }
        }
        public FrmProducto()
        {
            InitializeComponent();
        }
        public FrmProducto(Producto producto) : this()
        {
            this.producto = producto;
            
            //Muestra los valores
            this.txtCodigo.Text = producto.Codigo.ToString();
            this.txtNombre.Text = producto.Nombre;
            this.txtPrecio.Text = producto.Precio.ToString();


            this.txtCodigo.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Guardo los valores ingresados
            int codigo = int.Parse(this.txtCodigo.Text);
            string nombre = this.txtNombre.Text;
            double precio = double.Parse(this.txtPrecio.Text);

            this.producto = new Producto(codigo, nombre, precio);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //Close();
        }
    }
}

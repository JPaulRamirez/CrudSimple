using Entidades;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;


namespace WinFormCRUD
{
    public partial class FrmCRUD : Form
    {
        private List<Producto> productos;
        public FrmCRUD()
        {
            InitializeComponent();
            //Inializo el constructor 
            this.productos = new List<Producto>();

        }
        //PROBANDO GIT
        // Metodo serializar la lista de productos a XML
        private void SerializarXML()
        {
            string filePath = "./productos.xml";
            using (XmlTextWriter writer = new XmlTextWriter(filePath, Encoding.UTF8))
            {

                //Serializo los productos a formato XML
                XmlSerializer serializer = new XmlSerializer(typeof(List<Producto>));
                serializer.Serialize(writer, this.productos);
            }
        }
        // Metodo serializar la lista de productos a JSON
        private void SerializarJSON()
        {
            string filePath = "./productos.json";
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;
            // Escribo el contenido en el archivo utilizando StreamWriter
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                //Serializo los productos a formato JSON
                string odjJson = JsonSerializer.Serialize(this.productos, opciones);
                streamWriter.WriteLine(odjJson);
            }

        }
        // Metodo para deserializar la lista de productos desde XML
        private void DeserializarXML()
        {
            string filePath = "./productos.xml";

            using (XmlTextReader r = new XmlTextReader(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Producto>));
                this.productos = (List<Producto>)serializer.Deserialize(r);
            }

            ActualizarVisor();

        }
        // Metodo para deserializar la lista de productos desde JSON
        private void DeserializarJSON()
        {
            string filePath = "./productos.json";

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string jsonPersonas = streamReader.ReadToEnd();
                this.productos = JsonSerializer.Deserialize<List<Producto>>(jsonPersonas);

            }
            ActualizarVisor();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            #region 
            /*FrmProducto frmProducto = new FrmProducto();
            if (frmProducto.ShowDialog() == DialogResult.OK)
            {
                this.productos.Add(frmProducto.producto);

                this.ActualizarVisor();
            }*/
            #endregion

            // Codigo para agregar un nuevo producto a la lista
            // (asegúrate de obtener los datos del formulario FrmProducto)
            FrmProducto frmProducto = new FrmProducto();
            if (frmProducto.ShowDialog() == DialogResult.OK)
            {
                this.productos.Add(frmProducto.Producto);

                this.ActualizarVisor();
            }

            // Actualizar el ListBox
            ActualizarVisor();

            // Serializar la lista de productos a XML y JSON
            SerializarXML();
            SerializarJSON();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.lstVisor.SelectedIndex;
            if (indice != -1)
            {
                //Producto productoSeleccionado = this.listaProductos[indiceSeleccionado];
                //FrmProducto frmProducto = new FrmProducto(productoSeleccionado);
                FrmProducto frmProducto = new FrmProducto(this.productos[indice]);
                if (frmProducto.ShowDialog() == DialogResult.OK)
                {
                    this.productos.RemoveAt(indice);
                    this.ActualizarVisor();
                    // Serializar la lista de productos a XML y JSON
                    SerializarXML();
                    SerializarJSON();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = this.lstVisor.SelectedIndex;
            if (this.lstVisor.SelectedIndex >= 0)
            {
                //tipo clase(Producto)
                Producto productoSeleccionado = this.productos[indiceSeleccionado];
                FrmProducto frmProducto = new FrmProducto(productoSeleccionado);

                //frmModificar.ShowDialog() Debo aceptar OK o CANCEL para interactuar el otro frm
                if (frmProducto.ShowDialog() == DialogResult.OK)
                {
                    //Actualizo el producto
                    this.productos[indiceSeleccionado] = frmProducto.Producto;

                    this.ActualizarVisor();
                    // Serializar la lista de productos a XML y JSON
                    SerializarXML();
                    SerializarJSON();
                }
            }
        }
        private void ActualizarVisor()
        {
            //Limpio ListBox antes de agregar los productos
            this.lstVisor.Items.Clear();

            //Font font = new Font("Arial", 14);
            foreach (Producto producto in this.productos)
            {
                this.lstVisor.Items.Add(producto.Mostrar());
            }
            this.lstVisor.Font = new Font("Arial", 14);
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeserializarXML();
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeserializarJSON();
        }
    }
}
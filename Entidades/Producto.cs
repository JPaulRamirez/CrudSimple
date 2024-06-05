namespace Entidades
{
    public class Producto
    {
        private int codigo;
        private string nombre;
        private double precio;

        public int Codigo
        {
            get { return this.codigo; }
            set {this.codigo = value; }  
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        public Producto()
        {

        }
        public Producto(int codigo, string nombre, double precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
        }
        public string Mostrar()
        {  
            return $"{this.codigo} - {this.nombre} - {this.precio}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEntregable_1.Clases
{
    public class Producto
    {
        //Atributos y Propiedades
        public int Id { get; set; }
        public string descripcion { get; set; }
        public decimal costo { get; set; }
        public decimal precioVenta { get; set; }
        public int stock { get; set; }
        public int idUsusario { get; set; }

        //Constructores
        public Producto()
        {
            this.Id = 0;
            this.descripcion = "";
            this.costo = 0;
            this.precioVenta = 0;
            this.stock = 0;
            this.idUsusario = 0;
        }
        public Producto(int id, string descripcion, decimal costo, decimal precioVenta, int stock, int idUsusario)
        {
            this.Id = id;
            this.descripcion = descripcion;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUsusario = idUsusario;
        }
        public Producto(Producto p)
        {
            this.Id = p.Id;
            this.descripcion = p.descripcion;
            this.costo = p.costo;
            this.precioVenta = p.precioVenta;
            this.stock = p.stock;
            this.idUsusario = p.idUsusario;
        }
    }
}

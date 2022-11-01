using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEntregable_1.Clases
{
    public class ProductoVendido
    {
        //Atributos y Propiedades
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int Stock { get; set; }
        public int IdVenta { get; set; }

        //Constructores
        public ProductoVendido()
        {
            this.Id = 0;
            this.IdProducto = 0;
            this.Stock = 0;
            this.IdVenta = 0;
        }
        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            Id = id;
            IdProducto = idProducto;
            Stock = stock;
            IdVenta = idVenta;
        }
        public ProductoVendido(ProductoVendido pv)
        {
            this.Id = pv.Id;
            this.IdProducto = pv.IdProducto;
            this.Stock = pv.Stock;
            IdVenta = pv.IdVenta;
        }
    }
}

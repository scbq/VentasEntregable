using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEntregable_1.Clases
{
    public class Ventas
    {
        //Atributos y propiedades
        public int id { get; set; }
        public string comentarios { get; set; }

        //Constructores
        public Ventas()
        {
            this.id = 0;
            this.comentarios = "";
        }
        public Ventas(int id, string comentarios)
        {
            this.id = id;
            this.comentarios = comentarios;
        }
        public Ventas(Ventas v)
        {
            this.id = v.id;
            this.comentarios = v.comentarios;
        }
    }
}

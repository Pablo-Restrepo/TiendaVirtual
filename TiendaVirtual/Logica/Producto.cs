using AppGestionConsorcio.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVirtual.Logica
{
    class Producto
    {
        AccesoDatos dt = new AccesoDatos();
        public int crearProducto(int id, string nombre, int precio, string descripcion, string categoria)
        {
            int resultado;
            string consulta;
            consulta = "INSERT INTO PRODUCTO(PRO_ID , PRO_NOMBRE , PRO_PRECIO , PRO_DESCRIPCION , PRO_CATEGORIA , PRO_IMAGEN) VALUES(1234, 'Teclado', 200000, 'Teclado mecanico', 'Tecnologia', null)";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
    }
}

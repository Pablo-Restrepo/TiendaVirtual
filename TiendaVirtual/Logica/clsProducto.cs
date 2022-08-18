using AppGestionConsorcio.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVirtual.Logica
{
    class clsProducto
    {
        public long ProId;
        public string ProNombre;
        public float ProPrecio;
        public string ProCategoria;
        public string ProDescripcion;
        public byte[] prodFoto = new byte[0];

        AccesoDatos dt = new AccesoDatos();
        public List<clsProducto> consultarProductos()
        {
            List<clsProducto> datos = new List<clsProducto>();
            
            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT * FROM PRODUCTO";
            dataSet = dt.ejecutarSELECT(consulta);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                for (int j = 0; j < dataSet.Tables[0].Rows.Count; j++)
                {
                    clsProducto producto = new clsProducto();
                    producto.ProId = Int32.Parse(dataSet.Tables[0].Rows[j].ItemArray[0].ToString());
                    producto.ProNombre = dataSet.Tables[0].Rows[j].ItemArray[1].ToString();
                    producto.ProPrecio = float.Parse(dataSet.Tables[0].Rows[j].ItemArray[2].ToString());
                    producto.ProCategoria = dataSet.Tables[0].Rows[j].ItemArray[3].ToString();
                    producto.ProDescripcion = dataSet.Tables[0].Rows[j].ItemArray[4].ToString();
                    if (dataSet.Tables[0].Rows[j].ItemArray[5].ToString().Equals(""))
                    {
                        byte[] imagen = File.ReadAllBytes("..\\..\\Resources\\default.png");
                        producto.prodFoto = imagen;
                    }
                    else
                    {
                        producto.prodFoto = (byte[])dataSet.Tables[0].Rows[j].ItemArray[5];
                    }
                    datos.Add(producto);
                }
            }
            return datos;
        }
        public clsProducto consultarProducto(long idProducto)
        {
            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT * FROM PRODUCTO WHERE PRO_ID =" + idProducto;
            dataSet = dt.ejecutarSELECT(consulta);

            clsProducto producto = new clsProducto();
            producto.ProId = Int32.Parse(dataSet.Tables[0].Rows[0].ItemArray[0].ToString());
            producto.ProNombre = dataSet.Tables[0].Rows[0].ItemArray[1].ToString();
            producto.ProPrecio = float.Parse(dataSet.Tables[0].Rows[0].ItemArray[2].ToString());
            producto.ProCategoria = dataSet.Tables[0].Rows[0].ItemArray[3].ToString();
            producto.ProDescripcion = dataSet.Tables[0].Rows[0].ItemArray[4].ToString();
            if (dataSet.Tables[0].Rows[0].ItemArray[5].ToString().Equals(""))
            {
                byte[] imagen = File.ReadAllBytes("..\\..\\Resources\\default.png");
                producto.prodFoto = imagen;
            }
            else
            {
                producto.prodFoto = (byte[])dataSet.Tables[0].Rows[0].ItemArray[5];
            }
            return producto;
        }
        public int comprarProducto(long idProducto, float total, int cantidad)
        {
            int resultado;
            Random rand = new Random();
            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "INSERT INTO COMPRA(COM_ID , COM_TOTAL , COM_FECHA , COM_CANTIDAD , PRO_ID , USU_USERNAME) VALUES(" + rand.Next(0, 99999999) + "," + total + ",'" + DateTime.Now.ToString("dd-MM-yyyy") + "'," + cantidad + "," + idProducto + ",'" + Cache.User + "')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
    }
}

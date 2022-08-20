using AppGestionConsorcio.datos;
using System;
using System.Collections;
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
                    producto.ProNombre = dataSet.Tables[0].Rows[j].ItemArray[2].ToString();
                    producto.ProPrecio = float.Parse(dataSet.Tables[0].Rows[j].ItemArray[3].ToString());
                    producto.ProCategoria = dataSet.Tables[0].Rows[j].ItemArray[4].ToString();
                    producto.ProDescripcion = dataSet.Tables[0].Rows[j].ItemArray[5].ToString();
                    if (dataSet.Tables[0].Rows[j].ItemArray[6].ToString().Equals(""))
                    {
                        byte[] imagen = File.ReadAllBytes("..\\..\\Resources\\default.png");
                        producto.prodFoto = imagen;
                    }
                    else
                    {
                        producto.prodFoto = (byte[])dataSet.Tables[0].Rows[j].ItemArray[6];
                    }
                    datos.Add(producto);
                }
            }
            return datos;
        }
        public int comprarProducto(long idProducto, float total, int cantidad)
        {
            int resultado;
            Random rand = new Random();
            string consulta;
            consulta = "INSERT INTO COMPRA(COM_ID , COM_TOTAL , COM_FECHA , COM_CANTIDAD , PRO_ID , USU_USERNAME) VALUES(" + rand.Next(0, 99999999) + "," + total + ",'" + DateTime.Now.ToString("dd-MM-yyyy") + "'," + cantidad + "," + idProducto + ",'" + Cache.User + "')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
        public void guardarProducto(long idProducto)
        {
            string consulta;
            consulta = "INSERT INTO GUARDA(PRO_ID, USU_USERNAME) VALUES(" + idProducto + ",'" + Cache.User + "')";
            dt.ejecutarDML(consulta);
        }
        public void eliminarGuardarProducto(long idProducto)
        {
            string consulta;
            consulta = "DELETE FROM GUARDA WHERE USU_USERNAME ='" + Cache.User + "' AND PRO_ID =" + idProducto;
            dt.ejecutarDML(consulta);
        }
        public ArrayList consultarGuardados()
        {
            ArrayList datos = new ArrayList();
            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT PRO_ID FROM GUARDA WHERE USU_USERNAME ='" + Cache.User + "'";
            dataSet = dt.ejecutarSELECT(consulta);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                for (int j = 0; j < dataSet.Tables[0].Rows.Count; j++)
                {
                    datos.Add(Int32.Parse(dataSet.Tables[0].Rows[j].ItemArray[0].ToString()));
                }
            }

            return datos;
        }
        public List<clsProducto> consultarProductosGuardados()
        {
            List<clsProducto> datos = new List<clsProducto>();

            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT PRODUCTO.* FROM PRODUCTO INNER JOIN GUARDA ON PRODUCTO.PRO_ID = GUARDA.PRO_ID WHERE GUARDA.USU_USERNAME = '" + Cache.User + "'";
            dataSet = dt.ejecutarSELECT(consulta);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                for (int j = 0; j < dataSet.Tables[0].Rows.Count; j++)
                {
                    clsProducto producto = new clsProducto();
                    producto.ProId = Int32.Parse(dataSet.Tables[0].Rows[j].ItemArray[0].ToString());
                    producto.ProNombre = dataSet.Tables[0].Rows[j].ItemArray[2].ToString();
                    producto.ProPrecio = float.Parse(dataSet.Tables[0].Rows[j].ItemArray[3].ToString());
                    producto.ProCategoria = dataSet.Tables[0].Rows[j].ItemArray[4].ToString();
                    producto.ProDescripcion = dataSet.Tables[0].Rows[j].ItemArray[5].ToString();
                    if (dataSet.Tables[0].Rows[j].ItemArray[6].ToString().Equals(""))
                    {
                        byte[] imagen = File.ReadAllBytes("..\\..\\Resources\\default.png");
                        producto.prodFoto = imagen;
                    }
                    else
                    {
                        producto.prodFoto = (byte[])dataSet.Tables[0].Rows[j].ItemArray[6];
                    }
                    datos.Add(producto);
                }
            }
            return datos;
        }
        public int crearProducto(string nombre, float precio, string descrip, string categoria, byte[] imagen)
        {
            int resultado;
            Random rand = new Random();
            string consulta;
            consulta = "INSERT INTO PRODUCTO (PRO_ID, USU_USERNAME, PRO_NOMBRE, PRO_PRECIO, PRO_DESCRIPCION, PRO_CATEGORIA, PRO_IMAGEN) VALUES (" + rand.Next(0, 99999999) + ",'" + Cache.User + "','" + nombre + "'," + precio + ",'" + descrip + "','" + categoria + "'," + ":img)";
            resultado = dt.ejecutarDMLImagen(consulta, imagen);
            return resultado;
        }
    }
}

using AppGestionConsorcio.datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;

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
        private AccesoDatos dt = new AccesoDatos();

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
            crearNotifi(idProducto);
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
        public List<clsProducto> tusProductos()
        {
            List<clsProducto> datos = new List<clsProducto>();

            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT * FROM PRODUCTO WHERE USU_USERNAME = '" + Cache.User + "'";
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
        public List<clsProducto> consultarCategorias()
        {
            List<clsProducto> datos = new List<clsProducto>();

            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT DISTINCT PRO_CATEGORIA FROM PRODUCTO";
            dataSet = dt.ejecutarSELECT(consulta);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                for (int j = 0; j < dataSet.Tables[0].Rows.Count; j++)
                {
                    clsProducto producto = new clsProducto();
                    producto.ProCategoria = dataSet.Tables[0].Rows[j].ItemArray[0].ToString();
                    datos.Add(producto);
                }
            }
            return datos;
        }
        public List<clsProducto> consultarProductoDeXCategoria(string categoria)
        {
            List<clsProducto> datos = new List<clsProducto>();

            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT * FROM PRODUCTO WHERE PRO_CATEGORIA ='" + categoria + "'";
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
        private void crearNotifi(long idproducto)
        {
            DataSet dataSet = new DataSet();
            Random rand = new Random();
            string consulta;
            consulta = "SELECT USU_USERNAME FROM PRODUCTO WHERE PRO_ID =" + idproducto;
            dataSet = dt.ejecutarSELECT(consulta);
            consulta = "INSERT INTO notificacion(usu_username, noti_id, noti_nombre, noti_descripcion, noti_vista) VALUES('" + dataSet.Tables[0].Rows[0].ItemArray[0].ToString() + "'," + rand.Next(0, 99999999) + "," + "'Vendiste!', 'vendiste un producto. Revisa tus estadisticas.', 0)";
            dt.ejecutarDML(consulta);
        }
        public List<clsProducto> buscarProducto(string buscar)
        {
            List<clsProducto> datos = new List<clsProducto>();

            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT * FROM PRODUCTO WHERE UPPER(PRO_NOMBRE) LIKE UPPER('%" + buscar + "%')";
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
        public void eliminarProducto(long idproducto)
        {
            DataSet dataSet = new DataSet();
            Random rand = new Random();
            string consulta;
            consulta = "DELETE FROM PRODUCTO WHERE PRO_ID =" + idproducto;
            dt.ejecutarDML(consulta);
        }
        public List<clsProducto> hogarProducto()
        {
            List<clsProducto> datos = new List<clsProducto>();

            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT * FROM PRODUCTO WHERE PRO_CATEGORIA = 'Hogar'";
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
        public List<clsProducto> deporteProducto()
        {
            List<clsProducto> datos = new List<clsProducto>();

            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT * FROM PRODUCTO WHERE PRO_CATEGORIA = 'Deporte'";
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
        public List<clsProducto> tecnologiaProducto()
        {
            List<clsProducto> datos = new List<clsProducto>();

            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT * FROM PRODUCTO WHERE PRO_CATEGORIA = 'Tecnologia'";
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
        public List<clsProducto> masCompradoProducto()
        {
            List<clsProducto> datos = new List<clsProducto>();

            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT PRODUCTO.* FROM PRODUCTO INNER JOIN(SELECT PRO_ID FROM compra GROUP BY PRO_ID ORDER  BY SUM(COM_CANTIDAD) DESC FETCH FIRST 3 ROWS ONLY) T ON T.PRO_ID = PRODUCTO.PRO_ID";
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
        public List<clsProducto> masGuardosProducto()
        {
            List<clsProducto> datos = new List<clsProducto>();

            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT PRODUCTO.* FROM PRODUCTO INNER JOIN(SELECT PRO_ID FROM guarda GROUP BY PRO_ID ORDER  BY count(PRO_ID) DESC FETCH FIRST 3 ROWS ONLY) T ON T.PRO_ID = PRODUCTO.PRO_ID";
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
        public List<clsProducto> masBaratoProducto()
        {
            List<clsProducto> datos = new List<clsProducto>();

            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT * FROM PRODUCTO ORDER BY PRO_PRECIO FETCH FIRST 3 ROWS ONLY";
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
    }
}

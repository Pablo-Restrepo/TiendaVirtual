using AppGestionConsorcio.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace TiendaVirtual.Logica
{
    public class clsCompra
    {
        public long ComId;
        public string ComFecha;
        public float ComTotal;
        public int ComCantidad;
        public byte[] prodFoto = new byte[0];
        public string ProNombre;
        private AccesoDatos dt = new AccesoDatos();

        public List<clsCompra> consultarCompras()
        {
            List<clsCompra> datos = new List<clsCompra>();

            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT PRO_IMAGEN, PRO_NOMBRE, COM_FECHA, COM_CANTIDAD , COM_TOTAL FROM COMPRA INNER JOIN PRODUCTO ON COMPRA.PRO_ID =  PRODUCTO.PRO_ID WHERE COMPRA.USU_USERNAME = '" + Cache.User + "' ORDER BY COM_FECHA desc";
            dataSet = dt.ejecutarSELECT(consulta);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                for (int j = 0; j < dataSet.Tables[0].Rows.Count; j++)
                {
                    clsCompra compra = new clsCompra();
                    if (dataSet.Tables[0].Rows[j].ItemArray[0].ToString().Equals(""))
                    {
                        byte[] imagen = File.ReadAllBytes("..\\..\\Resources\\default.png");
                        compra.prodFoto = imagen;
                    }
                    else
                    {
                        compra.prodFoto = (byte[])dataSet.Tables[0].Rows[j].ItemArray[0];
                    }
                    compra.ProNombre = dataSet.Tables[0].Rows[j].ItemArray[1].ToString();
                    DateTime DateObject = Convert.ToDateTime(dataSet.Tables[0].Rows[j].ItemArray[2].ToString());
                    compra.ComFecha = DateObject.ToString("dd/MM/yyyy");
                    compra.ComCantidad = Int32.Parse(dataSet.Tables[0].Rows[j].ItemArray[3].ToString());
                    compra.ComTotal = float.Parse(dataSet.Tables[0].Rows[j].ItemArray[4].ToString());
                    datos.Add(compra);
                }
            }
            return datos;
        }
    }
}

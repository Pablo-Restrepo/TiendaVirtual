using AppGestionConsorcio.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace TiendaVirtual.Logica
{
    public class clsPromocional
    {
        public long PromId;
        public string PromNombre;
        public byte[] PromFoto = new byte[0];
        private AccesoDatos dt = new AccesoDatos();

        public int crearPromocional(string nombre, byte[] imagen)
        {
            int resultado;
            Random rand = new Random();
            string consulta;
            consulta = "INSERT INTO PROMOCIONAL (PROM_ID, USU_USERNAME, PROM_NOMBRE, PROM_IMAGEN) VALUES (" + rand.Next(0, 99999999) + ",'" + Cache.User + "','" + nombre + "'," + ":img)";
            resultado = dt.ejecutarDMLImagen(consulta, imagen);
            return resultado;
        }
        public List<clsPromocional> consultarPromocionales()
        {
            List<clsPromocional> datos = new List<clsPromocional>();

            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT PROM_IMAGEN FROM PROMOCIONAL";
            dt.ejecutarSELECT(consulta);
            dataSet = dt.ejecutarSELECT(consulta);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                for (int j = 0; j < dataSet.Tables[0].Rows.Count; j++)
                {
                    clsPromocional promocional = new clsPromocional();
                    if (dataSet.Tables[0].Rows[j].ItemArray[0].ToString().Equals(""))
                    {
                        byte[] imagen = File.ReadAllBytes("..\\..\\Resources\\default.png");
                        promocional.PromFoto = imagen;
                    }
                    else
                    {
                        promocional.PromFoto = (byte[])dataSet.Tables[0].Rows[j].ItemArray[0];
                    }
                    datos.Add(promocional);
                }
            }
            return datos;
        }
        public List<clsPromocional> tusPromocionales()
        {
            List<clsPromocional> datos = new List<clsPromocional>();

            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT PROM_IMAGEN FROM PROMOCIONAL WHERE USU_USERNAME ='" + Cache.User +"'";
            dt.ejecutarSELECT(consulta);
            dataSet = dt.ejecutarSELECT(consulta);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                for (int j = 0; j < dataSet.Tables[0].Rows.Count; j++)
                {
                    clsPromocional promocional = new clsPromocional();
                    if (dataSet.Tables[0].Rows[j].ItemArray[0].ToString().Equals(""))
                    {
                        byte[] imagen = File.ReadAllBytes("..\\..\\Resources\\default.png");
                        promocional.PromFoto = imagen;
                    }
                    else
                    {
                        promocional.PromFoto = (byte[])dataSet.Tables[0].Rows[j].ItemArray[0];
                    }
                    datos.Add(promocional);
                }
            }
            return datos;
        }
    }
}

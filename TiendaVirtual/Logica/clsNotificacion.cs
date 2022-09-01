using AppGestionConsorcio.datos;
using System;
using System.Collections.Generic;
using System.Data;

namespace TiendaVirtual.Logica
{
    public class clsNotificacion
    {
        public long NotiId;
        public string UsuUsername;
        public string NotiNombre;
        public string NotiDescripcion;
        public int NotiVista;
        private AccesoDatos dt = new AccesoDatos();
        
        public List<clsNotificacion> crearNoti()
        {
            List<clsNotificacion> datos = new List<clsNotificacion>();

            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT * FROM NOTIFICACION WHERE USU_USERNAME ='" + Cache.User + "'";
            dataSet = dt.ejecutarSELECT(consulta);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                for (int j = 0; j < dataSet.Tables[0].Rows.Count; j++)
                {
                    clsNotificacion notificacion = new clsNotificacion();
                    notificacion.NotiId = long.Parse(dataSet.Tables[0].Rows[j].ItemArray[0].ToString());
                    notificacion.UsuUsername = dataSet.Tables[0].Rows[j].ItemArray[1].ToString();
                    notificacion.NotiNombre = dataSet.Tables[0].Rows[j].ItemArray[2].ToString();
                    notificacion.NotiDescripcion = dataSet.Tables[0].Rows[j].ItemArray[3].ToString();
                    notificacion.NotiVista = Int32.Parse(dataSet.Tables[0].Rows[j].ItemArray[4].ToString());

                    datos.Add(notificacion);
                }
            }
            return datos;
        }
        public void notiVista()
        {
            string consulta;
            consulta = "UPDATE NOTIFICACION SET noti_vista = 1 WHERE USU_USERNAME ='" + Cache.User + "'";
            dt.ejecutarDML(consulta);
        }
    }
}

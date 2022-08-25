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
    class clsUsuario
    {
        public string UsuUsername;
        public string UsuNombre;
        public string UsuFechaNac;
        public byte[] UsuFoto = new byte[0];
        AccesoDatos dt = new AccesoDatos();

        public clsUsuario consultarDatosUser()
        {
            clsUsuario datos = new clsUsuario();

            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT * FROM USUARIO WHERE USU_USERNAME ='" + Cache.User + "'";
            dataSet = dt.ejecutarSELECT(consulta);

            datos.UsuUsername = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();
            datos.UsuNombre = dataSet.Tables[0].Rows[0].ItemArray[1].ToString();
            DateTime DateObject = Convert.ToDateTime(dataSet.Tables[0].Rows[0].ItemArray[3].ToString());
            datos.UsuFechaNac = DateObject.ToString("dd/MM/yyyy");
            if (dataSet.Tables[0].Rows[0].ItemArray[4].ToString().Equals(""))
            {
                byte[] imagen = File.ReadAllBytes("..\\..\\Resources\\default.png");
                datos.UsuFoto = imagen;
            }
            else
            {
                datos.UsuFoto = (byte[])dataSet.Tables[0].Rows[0].ItemArray[4];
            }
            return datos;
        }
        public int cambiarFoto(byte[] imagen)
        {
            int resultado;
            string consulta;
            consulta = "UPDATE USUARIO SET usu_foto =" + ":img" + " WHERE USU_USERNAME ='" + Cache.User + "'";
            resultado = dt.ejecutarDMLImagen(consulta, imagen);
            return resultado;
        }
        public int cambiarContrasenia(string contrasenia)
        {
            int resultado;
            string consulta;
            consulta = "UPDATE USUARIO SET usu_password ='" + contrasenia + "' WHERE USU_USERNAME ='" + Cache.User + "'";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
        public Boolean confirmarContrasenia(string contrasenia)
        {
            DataSet dataSet = new DataSet();
            string consulta;
            consulta = "SELECT usu_password FROM USUARIO WHERE USU_USERNAME ='" + Cache.User + "'";
            dataSet = dt.ejecutarSELECT(consulta);
            if (dataSet.Tables[0].Rows[0].ItemArray[0].ToString() == contrasenia)
            {
                return true;
            }
            return false;
        }
        public int cambiarNombre(string nombre)
        {
            int resultado;
            string consulta;
            consulta = "UPDATE USUARIO SET usu_nombre ='" + nombre + "' WHERE USU_USERNAME ='" + Cache.User + "'";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
        public int cambiarFechaNaci(string fecha)
        {
            int resultado;
            string consulta;
            consulta = "UPDATE USUARIO SET usu_fechanacimiento ='" + fecha + "' WHERE USU_USERNAME ='" + Cache.User + "'";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
    }
}

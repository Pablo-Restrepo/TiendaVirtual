using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVirtual.Logica
{
    public interface IForm
    {
        void Ejecutar(object formHija);
        void actualizar();
    }
}

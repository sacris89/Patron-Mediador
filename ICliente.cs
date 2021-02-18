using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador
{
   public interface ICliente
    {

          void recibirMensaje(Mensaje m);
        void EnviarMensaje(String m);



    }
}
